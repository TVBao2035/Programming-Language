#include<iostream>
#include "Person.cpp"
using namespace std;
class Children : public Person {
public:
    Children() {

   }
    Children(string name, int age, string add) : Person(name, age, add) {

    }
};
int main()
{
    Children a("Bao", 20, "tien giang");
    return 0;
}