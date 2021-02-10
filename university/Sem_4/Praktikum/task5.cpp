#include <iostream>
#include <string>

struct MARSH {
    std::string pathStart;
    std::string pathEnd;
    int pathIndex;
};

const int pathsCount = 3;

int main()
{
    setlocale(LC_ALL, "RUS");

    MARSH paths[pathsCount];
    std::cout << "Введите начальный и конечный пункт" << std::endl;
    for (int i = 0; i < pathsCount; i++)
    {
        std::cout << i+1 << ") ";
        std::cin >> paths[i].pathStart >> paths[i].pathEnd;
        std::cout << std::endl;
        paths[i].pathIndex = i;
    }

    while (true) {
        std::string pathName;
        std::cout << "Введите название пункта: ";
        std::cin >> pathName;

        for (int i = 0; i < pathsCount; i++)
        {
            if (paths[i].pathStart == pathName || paths[i].pathEnd == pathName)
            {
                std::cout << "Индекс маршрута: " << paths[i].pathIndex << std::endl;
                std::cout << "Старт маршрута: " << paths[i].pathStart << std::endl;
                std::cout << "Конец маршрута: " << paths[i].pathEnd << std::endl << std::endl;
            }
        }
    }
}
