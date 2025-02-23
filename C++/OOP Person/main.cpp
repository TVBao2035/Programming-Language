#include<iostream>
#include<vector>
#include "Person.cpp"
#include "Children.cpp"
#include "Book.cpp"
#include "Adult.cpp"
using namespace std;


int main()
{
	Book a("Pride and Prejudice", "Jane Austen", 100);
	Book b("Crime and Punishment", "Fyodor Dostoyevsky", 1000);
	vector<Book> all;
	all.push_back(a);
	all.push_back(b);
	vector<Book> vb, v;
	v.push_back(b);
	v.push_back(a);
	vb.push_back(a);
	Person* x[4];
	x[0] = new Children("a", 20, "HN", vb);
	x[1] = new Adult("b", 20, "NM", vb);
	x[2] = new Children("c", 8, "HN", v);
	x[3] = new Children("d", 20, "NB", v);
	vector<Person*> p;
	p.push_back(x[0]);
	p.push_back(x[1]);
	p.push_back(x[2]);
	p.push_back(x[3]);
	for (int i = 0; i < p.size(); i++)
	{
		p[i]->display();
	}
	Person::sortPersonAge(p);
	
	vector<int> str(Person::getListAge(p));
    // for(int i=0;i<str.size();i++){
    //     cout<<str[i]<<endl;
    // }
	vector<Book> res(Person::getMaxBookBorrowed(p, all));
    
	return 0;
}