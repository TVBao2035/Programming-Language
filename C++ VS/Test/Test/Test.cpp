#include<iostream>
#include<sstream>

using namespace std;

class Person {
private:
	string name;
	int age;
	string sex;
	float height;
	float weight;
public:
	void setName(string name) {
		stringstream part_name(name);
		string store_name = "";
		string coppy_part_name;
		while (part_name >> coppy_part_name) {
			store_name += toupper(coppy_part_name[0]);
			for (int i = 1; i < coppy_part_name.length(); i++) {
				store_name += tolower(coppy_part_name[i]);
			}
			store_name += " ";
		}
		store_name.erase(store_name.length() - 1);
		this->name = store_name;
	}

	string getName() {
		cout << endl << "Name is " << name << " " << endl;
		return name;
	}

	void setAge(int age) {
		if (age <= 0) {
			age = 1;
			this->age = age;
		}
		else {
			this->age = age;
		}
	}

	int getAge() {
		cout << endl << "Age is " << age << endl;
		return age;
	}

	void setSex() {
		int x;
		cout << "\nChoose Sex: \n  [1]:BOY \n  [2]:GIRL\nEnter Number: "; cin >> x; cin.ignore();
		cout << endl;
		switch (x) {
		case 1:
			this->sex = "Boy";
			break;
		case 2:
			this->sex = "Girl";
			break;
		default:
			this->sex = "Gender";
			break;
		}
	}

	string getSex() {
		cout << endl << "Sex is " << sex << endl;
		return sex;
	}

	void setWeight(float weight) {
		if (weight <= 0) this->weight = 1;
		else this->weight = weight;
	}

	float getWeight() {
		cout << endl << "Weight is " << weight << "Kg" << endl;
		return weight;
	}

	void setHeight(float height) {
		if (weight <= 0) this->height = 1;
		else this->height = height;
	}

	float getHeight() {
		cout << endl << "Height is " << height << "m" << endl;
		return height;
	}

	void enter() {
		cout << endl << "Enter Name: "; fflush(stdin); getline(cin, name);
		cout << endl << "Enter Age: ";  cin >> age;
		setSex();
		cout << endl << "Enter Weight: "; cin >> weight;
		cout << endl << "Enter Height: "; cin >> height;
		cin.ignore();
		setName(name);
		setAge(age);
		setWeight(weight);
		setHeight(height);
	}

	void display() {
		getName();
		getAge();
		getSex();
		getWeight();
		getHeight();
	}
	
	virtual void enterInfor(Person per[],int quantity) {
		for (int i = 0; i < quantity; i++) per[i].enter();
	}

	virtual void displayInfor(Person per[], int quantity) {
		for (int i = 0; i < quantity; i++) per[i].display();
	}
};

class Student : public Person {
private:
	int level;
	float score_1;
	float score_2;
	float score_3;
public:

	void setLevel(int level) {
		if (level <= 0 || level > 12) this->level = 1;
		else this->level = level;
	}

	int getLevel() {
		cout << endl << "Level is " << level << endl;
		return level;
	}

	void setScore_1(float score_1) {
		if (score_1 < 0 || score_2 > 10) this->score_1 = 0;
		else this->score_1 = score_1;
	}

	float getScore_1() {
		cout << endl << "Score 1 is " << score_1 << endl;
		return score_1;
	}

	void setScore_2(float score_2) {
		if (score_2 < 0 || score_2 > 10) this->score_2 = 0;
		else this->score_2 = score_2;
	}

	float getScore_2() {
		cout << endl << "Score 2 is " << score_2 << endl;
		return score_2;
	}

	void setScore_3(float score_3) {
		if (score_3 < 0 || score_3 > 10) this->score_3 = 0;
		else this->score_3 = score_3;
	}

	float getScore_3() {
		cout << endl << "Score 3 is " << score_3 << endl;
		return score_3;
	}

	void enter() {
		Person::enter();
		cout << endl << "Enter Level: "; cin >> level;
		cout << endl << "Enter Score 1: "; cin >> score_1;
		cout << endl << "Enter Score 2: "; cin >> score_2;
		cout << endl << "Enter Score 3: "; cin >> score_3;
		cin.ignore();
		setLevel(level);
		setScore_1(score_1);
		setScore_2(score_2);
		setScore_3(score_3);
	}

	void display() {
		Person::display();
		getLevel();
		getScore_1();
		getScore_2();
		getScore_3();
	}

	void enterInfor(Student student[], int quantity) {
		for (int i = 0; i < quantity; i++) student[i].enter();
	}

	void displayInfor(Student student[], int quantity) {
		for (int i = 0; i < quantity; i++) student[i].display();
	}

};

class Teacher : public Person {
private:
	int salary;
public:
	void setSalary(int salary) {
		this->salary = salary;
	}

	int getSalary() {
		cout << endl << "Salary is " << salary << ".000 USD" << endl;
		return salary;
	}

	void enter() {
		Person::enter();
		cout << endl << "Enter Salary:"; cin >> salary;
		setSalary(salary);
	}

	void display() {
		Person::display();
		getSalary();
	}

	void enterInfor(Teacher teacher[], int quantity) {
		for (int i = 0; i < quantity; i++) teacher[i].enter();
	}

	void displayInfor(Teacher teacher[], int quantity) {
		for (int i = 0; i < quantity; i++) teacher[i].display();
	}

};

int main()
{
	int number_Of_Student = 1;
	int number_Of_Person = 1;
	int number_Of_Teacher = 1;
	/*cout << "Enter Number of Student : ";
	cin >> number_Of_Student;
	cin.ignore();*/
	Teacher* teacher = new Teacher[number_Of_Teacher];
	Student* student = new Student[number_Of_Student];
	Person* person = new Person[number_Of_Person];

	cout << endl << "Enter Teacher: " << endl << endl;
	teacher->enterInfor(teacher, number_Of_Teacher);
	cout << endl << "Display Teacher: " << endl << endl;
	teacher->displayInfor(teacher, number_Of_Teacher);
	cout << endl << "Enter Person: " << endl << endl;
	person->enterInfor(person, number_Of_Person);
	cout << endl << "Enter Student: " << endl << endl;
	student->enterInfor(student, number_Of_Student);
	cout << endl << "Display Person: " << endl << endl;
	person->displayInfor(person, number_Of_Person);
	cout << endl << "Display Student: " << endl << endl;
	student->displayInfor(student, number_Of_Student);
	return 0;
}