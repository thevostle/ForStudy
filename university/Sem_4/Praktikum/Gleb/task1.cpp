#include <iostream>

void f(double a, double b, double c, double Xs, double Xe, double Xd);

int main()
{
    double a, b, c, Xs, Xe, Xd;;
    std::cin >> a >> b >> c >> Xs >> Xe >> Xd;

    std::cout << std::endl;
    std::cout << "X" << '\t' << "Result" << std::endl;
    if (~((int)a ^ (int)b ^ (int)c))
        f((int)a, (int)b, (int)c, Xs, Xe, Xd);
    else
        f(a, b, c, Xs, Xe, Xd);
}

void f(double a, double b, double c, double Xs, double Xe, double Xd)
{
    double X = Xs;
    while (X < Xe) {
        double result = 0;
        if (X < 0 && b != 0)
        {
            result = -a * X * X + b;
        }

        if (X > 0 && b == 0)
        {
            result = (X / (X - c)) + 5.5;
        }

        else
        {
            result = X/(c*-1);
        }

        std::cout << X << '\t' << result << std::endl;
        X += Xd;
    }
}
