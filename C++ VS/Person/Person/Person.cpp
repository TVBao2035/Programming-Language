#include<iostream>
#pragma once
using namespace std;
class Person {
private:
    string name;
    int age;
    float height;
    float weight;
    string address;
    
public:
    Person() {
        cout << "XIn chao" << endl;
    }
    Person(string name, int age,float height, float weight, string address)
    {
        this->name = name;
        this->age = age;
        this->height = height;
        this->weight = weight;
        this->address = address;
    }
    string getName() {
        return name;
    }
    int getAge() {
        return age;
    }
    string getAddress() {
        return address;
    }
    float getHeight() {
        return height;
    }
    float getWeight() {
        return weight;
    }
    virtual void display() {
        cout << "Name: " << getName() << endl;
        cout << "Age: " << getAge() << endl;
        cout << "Height: " << getHeight() << " m" << endl;
        cout << "Weight: " << getWeight() << " Kg " << endl;
        cout << "Add: " << getAddress() << endl;
    }
};
