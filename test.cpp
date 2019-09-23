#include <iostream>
#include <Windows.h>
#include <cmath>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	float x1, x2, x3, y1, y2, y3;
	cout << "введите координаты точки 1: ";
	cin>>x1>>y1;
	cout << "введите координаты точки 2: ";
	cin >> x2 >> y2;
	cout << "введите координаты точки 3: ";
	cin >> x3 >> y3;

	float a, b, c;
	a = sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
	b = sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
	c = sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));

	float p = (a + b + c) / 2;
	float s = sqrt(p * (p - a) * (p - b) * (p - c));
	cout << endl << "\nПлощадь треугольника: " << s;

	float AB, AC, BC;

	BC = (b * b + c * c - a * a) / (2 * b * c);
	BC = acos(BC);
	AB = (a * a + b * b - c * c) / (2 * a * b);
	AB = acos(AB);
	AC = (a * a + c * c - b * b) / (2 * a * c);
	AC = acos(AC);

	cout << endl << "Угол между сторонами AB = " << AB << endl << "Угол между сторонами BC = " << BC << endl<< "Угол между сторонами AC = " << AC << endl;

	system("pause");
	return 0;
}
