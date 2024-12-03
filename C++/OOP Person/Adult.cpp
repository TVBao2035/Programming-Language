#include<iostream>
#include "Person.cpp"
using namespace std;
class Adult : public Person{
    public:
        Adult(){}
        Adult(string name, int age, string add, vector<Book> vb):Person(name, age, add, vb){}
        long moneyPay(){
            return Person::getVB().size()*10000;
        }
        void display(){
            cout<<"Adult!"<<endl;
            Person::display();
        }
};