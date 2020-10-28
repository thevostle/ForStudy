// Вариант 16

#include <iostream>

int main()
{
    setlocale(LC_ALL, "RUS");

    struct complex
    {
        double Re;
        double Im;
    };

    complex a, b, c;

    std::cout << "Введите числа a, b, c:\n" << std::endl;

    // консольный ввод
    std::cout << "a = ... + ... i" << std::endl;
    std::cin >> a.Re >> a.Im;
    std::cout << "b = ... + ... i" << std::endl;
    std::cin >> b.Re >> b.Im;
    std::cout << "b = ... + ... i" << std::endl;
    std::cin >> c.Re >> c.Im;

    complex part_1, part_2, part_3, part_4, answer;

    // a - b - c
    part_1.Re = a.Re - b.Re - c.Re;
    part_1.Im = a.Im - b.Im - c.Im;

    // b + c
    part_2.Re = b.Re + c.Re;
    part_2.Im = b.Im + c.Im;

    // b - c
    part_3.Re = b.Re - c.Re;
    part_3.Im = b.Im - c.Im;

    // (b + c) / (b - c)
    part_4.Re = (part_2.Re * part_3.Re + part_2.Im * part_3.Im) / (part_3.Re * part_3.Re + part_3.Im * part_3.Im);
    part_4.Im = (part_3.Re * part_2.Im - part_2.Re * part_3.Im) / (part_3.Re * part_3.Re + part_3.Im * part_3.Im);

    // ... * ...
    answer.Re = part_1.Re * part_4.Re - part_1.Im * part_4.Im;
    answer.Im = part_1.Re * part_4.Im + part_1.Im * part_4.Re;

    std::cout << "d = " << answer.Re << " + " << answer.Im << " i" << std::endl;

    return 0;
}
