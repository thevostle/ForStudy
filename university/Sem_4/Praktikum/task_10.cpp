// Выполнить упражнения из раздела «Одномерные массивы», оформив каждый
// пункт задания в виде шаблона функции. Все необходимые данные для функций
// должны передаваться им в качестве параметров. Использование глобальных переменных 
// в функциях не допускается. Привести примеры программ, 
// использующих эти шаблоны для типов int, float и double.

#include <iostream>

template<typename Type>
void Remove(Type* arr, int len, int idx)
{
    for (int i = idx; i < len; i++)
        arr[i] = arr[i + 1];
    arr[len - 1] = 0;
}

template<typename type>
void Sum(type* arr, int len)
{
    bool sumStart = false;
    type sum = 0;
    for (int i = 0; i < len; i++)
    {
        if (sumStart)
            sum += abs(arr[i]);

        if (arr[i] < 0)
            sumStart = true;
    }
    std::cout << "Сумма модулей элементов массива, расположенных после первого отрицательного элемента: " << sum << std::endl;
}

template<typename type>
void MinIdx(type* arr, int len)
{
    type minNum = arr[0];
    type idx = 0;
    for (int i = 0; i < len; i++)
    {
        if (abs(arr[i]) < minNum)
        {
            minNum = abs(arr[i]);
            idx = i;
        }
    }
    std::cout << "Номер минимального по модулю элемента массива: " << idx << std::endl;
}

int main()
{
    const int arrLen = 7;

    // входные данные
    int arr[arrLen] = { 4, 7, -2, 5, 1, -3, 2 };
    float arr2[arrLen] = { 4.0, 7.3, -2.3, 25, 10.1, -3.2, 2.0 };
    double arr3[arrLen] = { 4.023, 7.321, -2.32, 5.945, 1.17, -3.23, 2.01 };
    int a = 2, b = 6;


    // сжатие массива
    for (int i = 0; i < arrLen; i++)
        if (arr[i] >= a && arr[i] <= b)
            Remove(arr, arrLen, i);
    for (int i = 0; i < arrLen; i++)
        if (arr2[i] >= a && arr2[i] <= b)
            Remove(arr2, arrLen, i);
    for (int i = 0; i < arrLen; i++)
        if (arr3[i] >= a && arr3[i] <= b)
            Remove(arr3, arrLen, i);

    // вывод
    setlocale(LC_ALL, "RUS");

    MinIdx(arr, arrLen);
    MinIdx(arr2, arrLen);
    MinIdx(arr3, arrLen);
    Sum(arr, arrLen);
    Sum(arr2, arrLen);
    Sum(arr3, arrLen);

    for (int i = 0; i < arrLen; i++)
        std::cout << arr[i] << " ";
    std::cout << std::endl;
    for (int i = 0; i < arrLen; i++)
        std::cout << arr2[i] << " ";
    std::cout << std::endl;
    for (int i = 0; i < arrLen; i++)
        std::cout << arr3[i] << " ";
    std::cout << std::endl;
}
