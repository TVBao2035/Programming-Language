#include<iostream>
#include<cmath>

using namespace std;


struct Point{
    int x, y;

    void input(){
        cout<<endl<<"enter x: ";
        cin>>x;
        cout<<"enter y: ";
        cin>>y;
    }

};

void enterPoint(Point p[], int n){
    for(int i = 0; i < n; i++){
        cout<<endl<<"enter Point ["<<i<<"]:";
        p[i].input();
    }
}

double distance(Point a, Point b)
{
    return sqrt(pow((b.x - a.x), 2) + pow((b.y - a.y), 2));
}


void displayMinMaxDistance(Point p[], int n)
{
    double min = distance(p[0], p[1]);
    double max = distance(p[0], p[1]);

    for(int i = 0; i < n - 1; i++)
    {
        double temp = distance(p[i], p[i +1]);
        min = min < temp ? min : temp;
        max = max < temp ? temp : max;
    }

    cout<<endl<<"the longest distance: "<<max;
    cout<<endl<<"the shortest distance: "<<min;
}

double perimeter(Point p[], int n)
{
    double result = 0;
    for(int i = 0; i < n - 1; i++)
    {
        result += distance(p[i], p[i + 1]);
    }

    return result;
}


int main()
{
    int n = 3;
    Point points[n];
    enterPoint(points, n);
    displayMinMaxDistance(points, n);
    cout<<endl<<"Perimeter: "<< perimeter(points, n);
    return 0;
}