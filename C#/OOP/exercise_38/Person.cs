using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_38
{
    public class Person
    {
        public string Name{
            get; set;
        }

        public int Age{
            get; set;
        }

        public string Address{
            get; set;
        }

        public List<Book> ListBook{
            get; set;
        }

        public Person(){}

        public Person(string name, int age, string address, List<Book> list)
        {
            Name = name;
            Age = age;
            Address = address;
            ListBook = list;
        }

        public virtual long moneyPay(){
            return 0;
        }

        public virtual void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("List of Books: ");
            foreach(var e in ListBook){
                e.display();
            }
            Console.WriteLine("Money Pay: " + moneyPay());
        }

        public static void sortPersonAge(List<Person> PList){
            for(int i = 0; i < PList.Count - 1; i++){
                for(int j = i + 1; j < PList.Count; j++){
                    if(PList[i].Age > PList[j].Age){
                        Person temp = PList[i];
                        PList[i] = PList[j];
                        PList[j] = temp;
                    }
                }
            }
        }


        public static List<int> getListAge(List<Person> PList){
            List<int> listAge = new List<int>();

            Person.sortPersonAge(PList);

            foreach(var e in PList) if(listAge.Count == 0 || !listAge.Contains(e.Age)) listAge.Add(e.Age);

            return listAge;

        }

        public static List<Book> getMaxBookBorrowed(List<Person> PList, List<Book> BList)
        {
            List<Book> result = new List<Book>();

            List<int> count = new List<int>(BList.Count);
            int max = 0, temp;

            for(int i = 0; i < BList.Count; i++){
                temp = 0;
                for(int j = 0; j < PList.Count; j++){
                    for(int k = 0; k < PList[j].ListBook.Count; k++){
                        if(PList[j].ListBook[k].NameBook == BList[i].NameBook)   temp++;                        
                    }
                }
                count.Add(temp);
                max = max < temp ? temp:max;
            }

            for(int i = 0; i < BList.Count; i++) if(max == count[i])   result.Add(BList[i]);

            return result;
        }
    }
}