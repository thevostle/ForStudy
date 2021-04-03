// задача 9 с использованием string, то есть можно сдать и как 15

#include <string>
#include <fstream>
#include <vector>
#include <windows.h>
#include <iostream>

using namespace std;

void SetColor(int text)
{
    HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hStdOut, (WORD)text);
}

int main(int argc, char* argv[])
{
    string str;
    fstream fin("input.dat");
    vector<string>text;
    SetColor(15);

    // вывод текста
    while (getline(fin, str))
        text.push_back(str);
    for (int i = 0; i < text.size(); i++)
        cout << text[i] << endl;

    system("pause");
    system("cls");

    string lastString = text[text.size() - 1];

    // ищем последнее слово
    int idx = lastString.length(); // индекс первой буквы последнего слова
    for (int i = idx-2; i > 0; i--)
    {
        if (lastString[i] == ' ' && lastString[i + 1] != ' ')
        {
            idx = i+1;
            break;
        }
    }

    // сколько 'а' в последнем слове?
    vector<int> coordsA;
    for (int i = idx; i < lastString.length(); i++)
        if (lastString[i] == 'a')
            coordsA.push_back(i);

    cout << "Count of A: " << coordsA.size() << endl;
    system("pause");
    system("cls");

    // выводим текст до последней строки
    for (int i = 0; i < text.size()-1; i++)
        cout << text[i] << endl;
    
    // выводим последнюю строку до последнего слова
    for (int i = 0; i < idx; i++)
        cout << lastString[i];

    // выделяем и выводим последнее слово
    SetColor(14);
    for (int i = idx; i < lastString.length(); i++)
        cout << lastString[i];
    cout << endl;
    SetColor(15);

    // выделяем все 'а'
    for (int iter = 0; iter < coordsA.size(); iter++)
    {
        system("pause");
        system("cls");

        // выводим текст до последней строки
        for (int i = 0; i < text.size() - 1; i++)
            cout << text[i] << endl;

        // выводим последнюю строку до последнего слова
        int i = 0;
        for (i; i < idx-1; i++)
            cout << lastString[i];

        // выводим слово с выделенной буквой
        for (i; i < coordsA[iter]; i++)
            cout << lastString[i];
        SetColor(14);
        cout << lastString[i];
        SetColor(15);
        i++;
        for (i; i < lastString.length(); i++)
            cout << lastString[i];
        cout << endl;
    }

    system("pause");
    return 0;
}
