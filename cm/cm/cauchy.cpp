#include <iostream>
using namespace std;

/* ������� ������� ������� */
double func1p(double x) {
	return sin(x) + exp(-sin(x)) - 1;
}
/* ������ ���� */
double func(double x, double y) {
	return 1.0 / 2 * sin(x * 2) - y*cos(x);
}
/* ����� ������ */
double Euler(double x, double y, double h) {
	return y + h*func(x, y);
}
/* ����� ������ � ���������� */
double EulerRecount(double x, double y, double x1, double h) { 
	return y + h / 2 * (func(x, y) + func(x1, y + h*func(x, y)));
}
/* ���������������� ����� ������ */
double EulerModified(double x, double y, double h) {
	return y + h*func(x + h / 2, y + h/2*func(x, y));
}
/* ����� �����-����� */
double RungeKutta(double x, double y, double h) {
	double k0 = func(x, y);
	double k1 = func(x + h / 2, y + h*k0 / 2);
	double k2 = func(x + h / 2, y + h*k1 / 2);
	double k3 = func(x + h, y + h*k2);
	return y + h*(k0 + 2 * k1 + 2 * k2 + k3) / 6;
}

int main(int argc, char** argv) {
	cout.precision(4);
	/* �������� �������� */
	double x0 = 0, xn = 1, y0 = 0, h = 0.1;
	double xi = x0, yi;
	/* �������� ������� */
	double yiEuler = y0, yiEulerRecount = y0, yiEulerModified = y0, yiRungeKutta = y0;
	cout << "x\tEuler\tEulerRecount\tEulerModified\tRungeKutta\ty" << endl;
	for (int i = 0; xi <= xn; i++) {
		// ������� �������� �� ������ ������
		yiEuler = Euler(xi, yiEuler, h);
		// ������� �������� �� ������ ������ � ����������
		yiEulerRecount = EulerRecount(xi, yiEulerRecount, xi + h, h);
		// ������� �������� �� ����������������� ������ ������
		yiEulerModified = EulerModified(xi, yiEulerModified, h);
		// ������� �������� �� ����������������� ������ �����-�����
		yiRungeKutta = RungeKutta(xi, yiRungeKutta, h);
		
		xi += h;
		// ������� ������ ��������
		yi = func1p(xi);
		cout << fixed << xi << "\t" << yiEuler << "\t" << yiEulerRecount << "\t\t" << yiEulerModified << "\t\t" << yiRungeKutta << "\t\t" <<  yi << endl; // �����
	}
	return 0;
}