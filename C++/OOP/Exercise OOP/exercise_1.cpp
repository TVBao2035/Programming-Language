#include<iostream>
#include<string>
class Student{
    private:
        std::string name;
        int age;
        std::string address;
    public:
        Student(std::string name, int age){
            this->name = name;
            this->age = age;
        }
        Student(){}
       void getInformation(){
            getline(std::cin,name);
            std::cin>>age;
       }
       
       void display(){
            std::cout<<std::endl<<"Name: "<<name;
            std::cout<<std::endl<<"Age: "<<age;
       }
};

class Circle{
    private:
        double radius;
    public:
        Circle(double radius){
            this->radius = radius;
        }

        double getArea(){
            return radius*radius*3.14;
        }

        double getPerimeter(){
            return radius*2*3.14;
        }

        void display(){
            std::cout<<std::endl<<"Area: "<<getArea();
            std::cout<<std::endl<<"Perimeter: "<<getPerimeter();
        }
};

class Rectangle {
    private:
        double length;
        double width;
    public:
        Rectangle(double length, double width){
            this->length = length;
            this->width = width;
        }

        Rectangle(){}
        void getInformation(){
            std::cin>>length;
            std::cin>>width;
        }

        double getArea(){
            return length * width;

        }

        double getPerimeter(){
            return (width + length)*2;
        }
        void display(){
            std::cout<<std::endl<<"Area: "<<getArea();
            std::cout<<std::endl<<"Perimeter: "<<getPerimeter();
        }
};
int main(){

    Student student("Bao", 22);
    student.display();
    Rectangle rectangle(3, 6);
    Student s1("", 20);
    s1.display();
    rectangle.display();
    Circle circle(5.7);
    circle.display();
    std::cout<<"Hello world";
    return 1;
}