// Дана целочисленная прямоугольная матрица.Определить номер первого из
// столбцов, содержащих хотя бы один нулевой элемент.
// Характеристикой строки целочисленной матрицы назовем сумму ее отрицательных четных элементов.
// Переставляя строки заданной матрицы, расположить их в соответствии с убыванием характеристик.

#include <iostream>

const int sizeY = 3;
const int sizeX = 3;

static int GetRowCharacteristic(int(*m)[3], int row)
{
    int sum = 0;
    for (int i = 0; i < sizeX; i++)
        if (m[row][i] < 0 && m[row][i] % 2 == 0)
            sum += m[row][i];
    return sum;
}

static void SwapRows(int(*m)[3], int row1, int row2)
{
    for (int i = 0; i < sizeX; i++) {
        int tmp = m[row1][i];
        m[row1][i] = m[row2][i];
        m[row2][i] = tmp;
    }
}

static void OrderRows(int(*m)[3])
{
    for (int i = 0; i < sizeY; i++)
        for (int j = i + 1; j < sizeY; j++)
            if (GetRowCharacteristic(m, i) < GetRowCharacteristic(m, j))
                SwapRows(m, i, j);
}

int main()
{
    int matrix[sizeY][sizeX];

    std::cout << "Input matrix:" << std::endl;
    for (int i = 0; i < sizeY; i++)
        for (int j = 0; j < sizeX; j++)
            std::cin >> matrix[i][j];


    // первый столбец с отриц. элементом
    bool finded = false;
    for (int k = 0; k < sizeX; k++)
    {
        for (int i = k + 1; i < sizeY; i++)
        {
            if (matrix[i][k] < 0)
            {
                std::cout << k;
                finded = true;
                break;
            }
        }
        if (finded)
            break;
    }

    OrderRows(matrix);

    std::cout << std::endl << "Sorted:" << std::endl;
    for (int i = 0; i < sizeY; i++)
    {
        for (int j = 0; j < sizeX; j++)
            std::cout << matrix[i][j] << "\t";
        std::cout << std::endl;
    }

    return 0;
}
