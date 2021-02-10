#include <iostream>

const int arrLen = 7;

void Remove(int* arr, int len, int idx)
{
    for (int i = idx; i < len; i++)
        arr[i] = arr[i + 1];
    arr[len -1] = 0;
}

int main()
{
    // входные данные
    int arr[arrLen] = {4, 7, -2, 5, 1, -3, 2};
    int a = 2, b = 6;
    
    // результат
    int sum = 0, idx = 0;

    // ищем сумму и минимальный элемент
    bool sumStart = false;
    int minNum = arr[0];
    for (int i = 0; i < arrLen; i++) 
    {
        if (abs(arr[i]) < minNum)
        {
            minNum = abs(arr[i]);
            idx = i;
        }

        if (sumStart)
            sum += abs(arr[i]);

        if (arr[i] < 0)
            sumStart = true;
    }

    // сжатие массива
    for (int i = 0; i < arrLen; i++)
        if (arr[i] >= a && arr[i] <= b)
            Remove (arr, arrLen, i);

    // вывод
    setlocale(LC_ALL, "RUS");
    std::cout << "Номер минимального по модулю элемента массива: " << idx << std::endl;
    std::cout << "Сумма модулей элементов массива, расположенных после первого отрицательного элемента: " << sum << std::endl;
    for (int i = 0; i < arrLen; i++)
        std::cout << arr[i] << " ";
    std::cout << std::endl;
}
