#include <iostream>
using namespace std;

/* Функция точного решения */
double func1p(double x) {
	return sin(x) + exp(-sin(x)) - 1;
}
/* Задача Коши */
double func(double x, double y) {
	return 1.0 / 2 * sin(x * 2) - y*cos(x);
}
/* Метод Эйлера */
double Euler(double x, double y, double h) {
	return y + h*func(x, y);
}
/* Метод Эйлера с пересчетом */
double EulerRecount(double x, double y, double x1, double h) { 
	return y + h / 2 * (func(x, y) + func(x1, y + h*func(x, y)));
}
/* Модифицированный метод Эйлера */
double EulerModified(double x, double y, double h) {
	return y + h*func(x + h / 2, y + h/2*func(x, y));
}
/* Метод Рунге-Кутта */
double RungeKutta(double x, double y, double h) {
	double k0 = func(x, y);
	double k1 = func(x + h / 2, y + h*k0 / 2);
	double k2 = func(x + h / 2, y + h*k1 / 2);
	double k3 = func(x + h, y + h*k2);
	return y + h*(k0 + 2 * k1 + 2 * k2 + k3) / 6;
}

int main(int argc, char** argv) {
	cout.precision(4);
	/* Исходные значения */
	double x0 = 0, xn = 1, y0 = 0, h = 0.1;
	double xi = x0, yi;
	/* Значения функций */
	double yiEuler = y0, yiEulerRecount = y0, yiEulerModified = y0, yiRungeKutta = y0;
	cout << "x\tEuler\tEulerRecount\tEulerModified\tRungeKutta\ty" << endl;
	for (int i = 0; xi <= xn; i++) {
		// Находим значение по методу Эйлера
		yiEuler = Euler(xi, yiEuler, h);
		// Находим значение по методу Эйлера с пересчетом
		yiEulerRecount = EulerRecount(xi, yiEulerRecount, xi + h, h);
		// Находим значение по модифицированному методу Эйлера
		yiEulerModified = EulerModified(xi, yiEulerModified, h);
		// Находим значение по модифицированному методу Рунге-Кутта
		yiRungeKutta = RungeKutta(xi, yiRungeKutta, h);
		
		xi += h;
		// Находим точное значение
		yi = func1p(xi);
		cout << fixed << xi << "\t" << yiEuler << "\t" << yiEulerRecount << "\t\t" << yiEulerModified << "\t\t" << yiRungeKutta << "\t\t" <<  yi << endl; // Вывод
	}
	return 0;
}