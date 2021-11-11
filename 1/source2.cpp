#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <opencv2/imgproc/imgproc.hpp> // подключены все необходимые библиотеки
using namespace cv;
using namespace std;  // подключены необходимые пространства имён
int main()
{
	int height = 600; // высота окна
	int width = 900; // ширина окна
	Mat img(height, width, CV_8UC3); // создание окна с заданными ранее параметрами
	Point textOrg(50, img.rows / 2); // изменение положения текста, первый параметр отвечает за отступ от левого края окна, а второй это это положение по вертикали
	int fontFace = FONT_HERSHEY_TRIPLEX; // шрифт
	double fontScale = 6; // размер шрифта
	Scalar color(249, 10, 10); // цвет текста
	putText(img, "AMOGUS", textOrg, fontFace, fontScale, color); // создание самого текста
	namedWindow("Hello World", 0);
	imshow("Hello World", img);
	waitKey(0);
	return 0;
}