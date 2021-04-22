// Выполнить задания из раздела «Одномерные массивы» с
// использованием контейнерных классов и алгоритмов библиотеки.

#include <iostream>
#include <algorithm>
#include <vector>

int main()
{
    std::vector<int> arr = { 2, -6, 3, 1, -6, 3, 9, 4, -8 };
    int C = 2;

    int count = 0, idx = 0;
    double maxAbs = arr[0];
    for (int i = 0; i < arr.size(); i++)
    {
        if (abs(arr[i]) > maxAbs)
        {
            maxAbs = abs(arr[i]);
            idx = i;
        }
        if (arr[i] > C)
            count++;
    }

    double mult = 1;
    for (int i = idx + 1; i < arr.size(); i++)
        mult *= arr[i];

    std::partition(std::begin(arr), std::end(arr), [](const int x) { return x < 0; });

    setlocale(LC_ALL, "RUS");
    std::cout << count << std::endl;
    std::cout << mult << std::endl;
    for (int i = 0; i < arr.size(); i++)
        std::cout << arr[i] << " ";
    std::cout << std::endl;
}
