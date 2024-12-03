#include<iostream>
#include "Point.cpp"
#include "Line.cpp"
using namespace std;
int main(){
    Point begin(1, 1);
    begin.setX(0);
    begin.setY(0);
	Point end(2, 2);
    end.setX(0);
    end.setY(4);
	Line line1(begin, end);
	cout << line1.getLength() << endl;

	Line line2(0, 0, 2, 2);
	cout << line2.getLength() << endl;
    return 0;
}