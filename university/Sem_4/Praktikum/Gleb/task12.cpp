// Вариант 15
// Анкета для опроса населения содержит две группы вопросов.
// Первая группа содержит сведения о респонденте :
//   • возраст;
//   • пол;
//   • образование(начальное, среднее, высшее).
// Вторая группа содержит собственно вопрос анкеты, ответ на который либо ДА, либо НЕТ.
// Составить программу, которая:
//   • обеспечивает начальный ввод анкет и формирует из них линейный список;
//   • на основе анализа анкет выдает ответы на следующие вопросы : 
//        а) сколько мужчин старше 40 лет, имеющих высшее образование, ответили ДА на вопрос анкеты;
//        б) сколько женщин моложе 30 лет, имеющих среднее образование, ответили НЕТ на вопрос анкеты; 
//        в) сколько мужчин моложе 25 лет, имеющих начальное образование, ответили ДА на вопрос анкеты;
//   • производит вывод всех анкет и ответов на вопросы.
// Программа должна обеспечивать диалог с помощью меню и контроль ошибок при вводе.


#include <iostream>
#include <list>
#include <string>

struct Note
{
    int age;
    int gender; // 0 - М, 1 - Ж
    int education; // 0-2
    int answer; // 0 - НЕТ, 1 - ДА
};

int main()
{
    setlocale(LC_ALL, "RUS");

    std::list<Note> notes;
    
    int countOfNotes = 0;
    std::cout << "Введите кол-во анкет: ";
    std::cin >> countOfNotes;
    
    for (int i = 0; i < countOfNotes; i++) {
        Note newNote;
        std::cout << std::endl << std::endl << "Введите возраст: ";
        std::cin >> newNote.age;
        while (std::cin.fail())
            std::cin >> newNote.age;

        std::cout << std::endl << "Введите пол (0-М/1-Ж): ";
        std::cin >> newNote.gender;
        while (std::cin.fail() || (newNote.gender != 0 && newNote.gender != 1))
        {
            std::cout << newNote.gender;
            std::cin >> newNote.gender;
        }

        std::cout << std::endl << "Введите образование (0 - начальное, 1 - среднее, 2 - высшее): ";
        std::cin >> newNote.education;
        while (std::cin.fail() || !(newNote.education >= 0 && newNote.education <= 2))
            std::cin >> newNote.education;

        std::cout << std::endl << "Введите ответ (0-НЕТ/1-ДА): ";
        std::cin >> newNote.answer;
        while (std::cin.fail() || (newNote.answer != 0 && newNote.answer != 1))
            std::cin >> newNote.answer;

        notes.push_back(newNote);
    }

    std::cout << std::endl << "Пол" << "\t" << "Возраст" << "\t" << "Образование" << "\t" << "Ответ";

    // анализ и вывод анкет
    int ans1 = 0, ans2 = 0, ans3 = 0;
    for (Note n : notes)
    {
        if (n.gender == 0 && n.age > 40 && n.education == 2 && n.answer == 1)
            ans1++;
        if (n.gender == 1 && n.age < 30 && n.education == 1 && n.answer == 0)
            ans2++;
        if (n.gender == 0 && n.age < 25 && n.education == 0 && n.answer == 1)
            ans3++;
        std::cout << std::endl << n.gender << "\t" << n.age << "\t" << n.education << "\t\t" << n.answer;
    }

    std::cout << std::endl << "Анализ анкет: " << ans1 << " " << ans2 << " " << ans3;

    return 0;
}
