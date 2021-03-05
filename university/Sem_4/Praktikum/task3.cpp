// Коэффициенты системы линейных уравнений заданы в виде прямоугольной матрицы.
// С помощью допустимых преобразований привести систему к треугольному виду.
// Найти количество строк, среднее арифметическое элементов которых меньше заданной величины.

#include <iostream>

const int size = 3;

int main()
{
    int matrix[size][size];
    double coef;
    
    int value, count;

    std::cout << "Input matrix:" << std::endl;
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            std::cin >> matrix[i][j];

    std::cout << std::endl << "Input value: ";
    std::cin >> value;

    // количество строк
    count = 0;
    for (int i = 0; i < size; i++)
    {
        int sum = 0;
        for (int j = 0; j < size; j++)
            sum += matrix[i][j];
        if (sum / size < value)
            count++;
    }

    // треугольный вид
    for (int k = 0; k < size; k++)
    {
        for (int i = k + 1; i < size; i++)
        {
            coef = (double)matrix[i][k] / matrix[k][k];
            for (int j = 0; j < size; j++)
                matrix[i][j] -= matrix[k][j] * coef;
        }
    }

    std::cout << std::endl << "Triangulazed matrix:" << std::endl;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            std::cout << matrix[i][j] << "\t";
        std::cout << std::endl;
    }

    std::cout << std::endl << "Count of rows: " << count;

    return 0;
}
