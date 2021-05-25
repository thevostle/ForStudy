// C++ с использованием технологии OpenMP
// находит минимальный элемент и его “координаты” в матрице M × N чисел типа double;

#include<stdio.h>
#include<omp.h>
#include <iostream>
#include <cstdlib>
#include <ctime>

const int N = 20000000;
int NUM_PROC;

// генератор double чисел
double fRand(double fMin, double fMax)
{
    double f = (double)rand() / RAND_MAX;
    return fMin + f * (fMax - fMin);
}

double* MatrixMin(double** array, int sizeX, int sizeY)
{
    double coords[3] = {0, 0, array[0][0]};
    double minNum = array[0][0];
    for (int y = 0; y < sizeY; y++) {
        for (int x = 0; x < sizeX; x++) {
            if (array[x][y] < minNum) {
                coords[0] = (double)x;
                coords[1] = (double)y;
                minNum = array[x][y];
            }
        }
    }
    return coords;
}

double* MatrixMinP(double** array, int sizeX, int sizeY)
{
    double coords[3] = { 0, 0, array[0][0] };
    double minNum = array[0][0];
    double* linearMatrix = new double [sizeX * sizeY];

    for (int y = 0; y < sizeY; y++)
        for (int x = 0; x < sizeX; x++)
            linearMatrix[(y * sizeY) + x] = array[x][y];

    /*#pragma omp for reduction(min:min)
    for (int i = 0; i < N; i++)
        if (linearMatrix[i] < min)
            min = linearMatrix[i];*/

    // TODO тут срабатывает ошибка
    #pragma omp parallel
    {
    #pragma omp for
        for (ptrdiff_t i = 0; i < sizeX * sizeY; i++)
            if (linearMatrix[i] < minNum) {
                coords[0] = (double)(i%(sizeY));         // ошибка
                //coords[1] = (double)((i-coords[0])/sizeY); // ошибка
                minNum = linearMatrix[i];
            }
    }

    return coords;
}

using namespace std;
int main(int argN, char** args)
{
    srand(time(0));
    double time_1, time_2, S = 0;
    int m, n;

    m = 10;
    n = 11;

    double** arr = new double* [m]; // создание динамического двумерного массива на m строк
    for (int i(0); i < m; i++) // создание каждого одномерного массива в динамическом двумерном массиве, или иначе - создание столбцов размерность n
        arr[i] = new double[n];
    
    //заполнение массива от -100 до 100
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i][j] = fRand(-100, 100);
        }
    }

    // вывод матрицы
    cout << "Array: " << endl;
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }

    NUM_PROC = omp_get_num_procs();
    printf_s("Procs = %d  _OPENMP=%d\n", NUM_PROC, _OPENMP);

    time_1 = omp_get_wtime();
    double *coords;
    coords = MatrixMin(arr, m, n);
    cout << (int)coords[0] << ' ' << (int)coords[1];
    time_2 = omp_get_wtime();
    printf_s("Time_s = %18.15f;  Ss=%g (exact)\n", (time_2 - time_1)*1000, S);

    time_1 = omp_get_wtime();
    coords = MatrixMinP(arr, m, n);
    cout << (int)coords[0] << ' ' << (int)coords[1];
    time_2 = omp_get_wtime();
    printf_s("Time_p = %18.15f;  Sp=%g\n", time_2 - time_1, S);

    for (int i(0); i < m; i++) // освобождение памяти каждого одномерного массива в двумерном массиве - удаление столбцов
        delete arr[i];
    delete arr; // освобождение памяти двумерного массива

    return 0;
}
