#include<iostream>
#include "Person.cpp"
using namespace std;
class Children : public Person {
private:
    int level;
public:
    Children() {
        cout << "SFS" << endl;
    }
    Children(string name, int age,float heigth, float weight,int level ,string address) : Person(name, age,heigth,weight,address) {
        this->level = level;
    }
    int getLevel() {
        return level;
    }
    void display() {
        Person::display();
        cout << "Level: " << getLevel() << endl;
    }
};
int main()
{
    Person b("Liem", 19, 1.6, 50, "tien giang");
    Children a("Bao", 20, 1.6, 52, 12, "tien giang");
    Children c;
    a.display();
    b.display();
    
    return 0;
}