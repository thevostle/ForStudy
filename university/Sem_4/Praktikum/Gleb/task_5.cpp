#include <iostream>
#include <string>

struct ZNAK {
    std::string name;
    std::string surname;
    std::string znak;
    int date[3];
};

const int notes = 3;

int main()
{
    setlocale(LC_ALL, "RUS");

    ZNAK people[notes];
    std::cout << "Введите имя, фамилию, знак и дату рождения" << std::endl;
    for (int i = 0; i < notes; i++)
    {
        std::cout << i + 1 << ") ";
        std::cin >> people[i].name >> people[i].surname >> people[i].znak;
        std::cin >> people[i].date[0] >> people[i].date[1] >> people[i].date[2];
        std::cout << std::endl;
    }

    while (true) {
        std::string sn;
        std::cout << "Введите фамилию: " << std::endl;
        std::cin >> sn;

        for (int i = 0; i < notes; i++)
        {
            if (people[i].surname == sn)
            {
                std::cout << "Имя: " << people[i].name << std::endl;
                std::cout << "Фамилия: " << people[i].surname << std::endl;
                std::cout << "Знак зодиака: " << people[i].znak << std::endl;
                std::cout << "Дата рождения: " << people[i].date[0] << "/" << people[i].date[1] << "/" << people[i].date[2] << std::endl << std::endl;
            }
        }
    }
}
