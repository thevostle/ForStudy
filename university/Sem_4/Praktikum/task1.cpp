#include <iostream>

void f(double a, double b, double c, double Xs, double Xe, double Xd);

int main()
{
    double a, b, c, Xs, Xe, Xd;;
    std::cin >> a >> b >> c >> Xs >> Xe >> Xd;

    std::cout << std::endl;
    if (((((int)a && (int)b) ^ (int)c) & 1) == 0)
        f((int)a, (int)b, (int)c, Xs, Xe, Xd);
    else
        f(a, b, c, Xs, Xe, Xd);
}

void f(double a, double b, double c, double Xs, double Xe, double Xd)
{
    double X = Xs;
    while (X < Xe) {
        double result = 0;
        if (X < 1 && c != 0)
        {
            result = a * X * X + (b / c);
        }

        if (X > 1.5 && c == 0)
        {
            result = (X - a) / pow(X - c, 2);
        }

        else
        {
            result = pow(X, 2) / pow(c, 2);
        }

        std::cout << X << '\t' << result << std::endl;
        X += Xd;
    }
}
