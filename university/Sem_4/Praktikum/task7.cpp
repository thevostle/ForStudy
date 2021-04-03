// Коэффициенты системы линейных уравнений заданы в виде прямоугольной матрицы.
// С помощью допустимых преобразований привести систему к треугольному виду.
// Найти количество строк, среднее арифметическое элементов которых меньше заданной величины.

// Выполнить упражнения из раздела «Двумерные массивы», оформив каждый
// пункт задания в виде функции.Все необходимые данные для функций должны
// передаваться им в качестве параметров.Использование глобальных переменных
// в функциях не допускается.

#include <iostream>

void Triangulaze(int(*matrix)[3], int rowsCount);
void GetLinesCount(int(*matrix)[3], int rowsCount, int value);
void PrintResult(int(*matrix)[3], int rowsCount, bool isTriangulazed);

int main() 
{
    const int size = 3;

    int matrix[size][size];

    int value;

    std::cout << "Input matrix:" << std::endl;
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            std::cin >> matrix[i][j];

    std::cout << std::endl << "Input value: ";
    std::cin >> value;

    PrintResult(matrix, size, false);
    GetLinesCount(matrix, size, value);
    Triangulaze(matrix, size);
    PrintResult(matrix, size, true);
}

void PrintResult(int(*matrix)[3], int rowsCount, bool isTriangulazed)
{
    // количество столбцов или элементов в каждом подмассиве
    int columnsCount = sizeof(*matrix) / sizeof(*matrix[0]);
    if (isTriangulazed)
        std::cout << std::endl << "Triangulazed matrix:" << std::endl;
    else
        std::cout << std::endl << "Origin matrix:" << std::endl;

    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
            std::cout << matrix[i][j] << "\t";
        std::cout << std::endl;
    }
}

void GetLinesCount(int(*matrix)[3], int rowsCount, int value)
{
    int columnsCount = sizeof(*matrix) / sizeof(*matrix[0]);
    int count = 0;
    for (int i = 0; i < rowsCount; i++)
    {
        int sum = 0;
        for (int j = 0; j < columnsCount; j++)
            sum += matrix[i][j];
        if (sum / columnsCount < value)
            count++;
    }
    std::cout << std::endl << std::endl << "Count of rows: " << count << std::endl;
}

void Triangulaze(int(*matrix)[3], int rowsCount)
{
    int columnsCount = sizeof(*matrix) / sizeof(*matrix[0]);
    double coef;
    for (int k = 0; k < columnsCount; k++)
    {
        for (int i = k + 1; i < rowsCount; i++)
        {
            coef = (double)matrix[i][k] / matrix[k][k];
            for (int j = 0; j < columnsCount; j++)
                matrix[i][j] -= matrix[k][j] * coef;
        }
    }
}
