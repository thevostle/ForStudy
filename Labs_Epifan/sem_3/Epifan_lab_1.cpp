#include <iostream>
#include <fstream>
#include <string>

int main()
{
    std::string line;
    std::string line_old;

    bool equalStrings = false;

    std::ifstream in("D:\\text.txt");
    if (in.is_open())
    {
        while (getline(in, line))
        {
            if (line == line_old)
            {
                std::cout << "The text contains the same lines" << std::endl;
                equalStrings = true;
                break;
            }

            line_old = line;
        }
    }
    in.close();

    if (!equalStrings)
        std::cout << "There are no identical lines in the text" << std::endl;

    return 0;
}
