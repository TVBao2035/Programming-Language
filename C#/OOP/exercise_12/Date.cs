using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_12
{
    public class Date
    {
        public int Day{
            get; set;
        }
        public int Month{
            get; set;
        }
        public int Year{
            get; set;
        }

        public Date(int day, int month, int year){
            Day = day;
            Month = month;
            Year = year;
        }
        public void setDate(int day, int month, int year){
            Day = day;
            Month = month;
            Year = year;
        }

        public void display(){
            string date = "";
            if(Day < 10){
                date += '0';
            }
            date += Day.ToString() + '/';
            if(Month < 10){
                date += '0';
            }
            date += Month.ToString() + '/' + Year.ToString();
            Console.WriteLine(date);
        }
    }
}