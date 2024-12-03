#include<iostream>
#include<string>

using namespace std;

class Date {
private:
	int day;
	int month;
	int year;
public:
	int stt[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };

	Date() {}

	Date(int day, int month, int year) {
		setDay(day); setMonth(month); setYear(year);
	}
	Date(int month, int year) {
		setMonth(month); setYear(year);
	}
	void setDay(int day) {  
		if (day > 30 || day <= 0) this->day = 1;
		else this->day = day;
	}
	void setMonth(int month) { 
		if (month > 12 || month <= 0) this->month = 1;
		else this->month = month;
	}
	void setYear(int year) {
		if (year <= 0) this->year = 1000;
		else this->year = year;
	}
	int getDay() {
		return day;
	}
	int getMonth() {
		return month;
	}
	int getYear() {
		return year;
	}

	string String_Day( int a) {
		string s = to_string(a);
		if (s.length() == 1) return "0" + s; 
		return s;
		}

	string String_Month(int a) { 
		string s = to_string(a);
		if (s.length() == 1) return "0" + s; 
		return s;
	}

	string String_Year(int a) { 
		string s = to_string(a);
		if (s.length() == 1) return "000" + s;
		if (s.length() == 2) return "00" + s;
		if (s.length() == 3) return "0" + s;
		return s;
	}
	int so_ngay(int month, int year, int stt[]) {
		if (month == 2) {
			if (year % 4 == 0 && year % 100 != 0) return 29;
			return stt[month - 1];
		}
		else {
			return stt[month - 1];
		}
	}
	
	virtual void display() {  
		cout << endl << String_Day(getDay()) << "/" << String_Month(getMonth()) << "/" << String_Year(getYear()) << endl;
		cout << "\nTháng " << String_Month(getMonth()) << " Năm " << String_Year(getYear()) << " co " << so_ngay(getMonth(), getYear(), stt) << " Ngày";
	}
};

class Time{
private:
	int hour;
	int minutes;
	int second;
public:
	Time(){}

	Time(int second, int minutes, int hour) {
		setSecond(second); setMinutes(minutes); setHour(hour);
	}
	void setHour(int hour) {
		if (hour > 24 || hour <= 0) this->hour = 0;
		else this->hour = hour;
	}
	void setMinutes(int minutes) {

		if (minutes > 60 || minutes < 0) this->minutes = 0;
		else {
			this->minutes = minutes;
		}
	}
	void setSecond(int second) {
		if (second > 60 || second < 0) this->second = 0;
		else this->second = second;
	}
	int getHour() {
		return hour;
	}
	int getMinutes() {
		return minutes;
	}
	int getSecond() {
		return second;
	}
	string String_Hour(int hour) { 
		string s = to_string(hour);
		if (s.length() == 1) return "0" + s;
		return s;
	}
	string String_Minutes(int minutes) {
		string s = to_string(minutes);
		if (s.length() == 1) return "0" + s;
		return s;
	}
	string String_Second(int second) {
		string s = to_string(second);
		if (s.length() == 1) return "0" + s;
		return s;
	}
	
	void display() {
		if (getHour() == 24 && (getMinutes() != 0 || getSecond() != 0)) setHour(0);

		cout << endl << endl << String_Hour(getHour()) << ":" << String_Minutes(getMinutes()) << ":" << String_Second(getSecond()) << endl;
	}
};
class DateTime :public Date , public Time  {
public:
	DateTime(int day, int month, int year, int second, int minutes, int hour) : Date(day, month, year), Time(second, minutes, hour) {
	};
	void display() { 
		Date::display();
		Time::display();
		if (getYear() % 4 == 0 && getYear() % 100 != 0) stt[1] = 29;

		int giayConLai = stt[getMonth() - 1] * 3600 * 24 - ((getDay() * 24 * 3600) + (getHour() * 3600) + (getMinutes() * 60) + getSecond());

		cout << "\nGiay Con Lai: " << giayConLai << endl;
	}
};
int main()
{
	int day, month, year, hour, minutes, second;

	cout << "\nEnter Day:"; cin >> day; 
	cout << "\nEnter Month:"; cin >> month;
	cout << "\nEnter Year:";cin >> year;
	
	int x;
	cout << "\n\nDo You Want To Enter The Time:\n";
	cout << "\n[1].YES\n[2].NO\n\nNhap Lenh:"; cin >> x;
	do {
		if (x == 1) {
			cout << "\nEnter Second:"; cin >> second;
			cout << "\nEnter Minutes:"; cin >> minutes;
			cout << "\nEnter Hour:"; cin >> hour;
		}
		else if(x == 2) {
			second = minutes = hour = 0;
		}
		else {
			cout << "\nNhap sai lenh!";
		}
	} while (x < 1 || x > 2);

	
	DateTime b(day,month, year, second,minutes, hour);
	b.display();

	return 0;

}
