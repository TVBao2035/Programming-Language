using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_13
{
    public class Time
    {
        public int Hour{
            get; set;
        }

        public int Minute{
            get; set;
        }
        public int Second{
            get; set;
        }

        public Time(int hour, int minute, int second){
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void setTime(int hour, int minute, int second){
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void nextSecond(){
            if(Second == 59 && Minute == 59 && Hour == 23){
                Hour = 0;
                Minute = 0;
                Second = 0;
            }else if(Second == 59 && Minute == 59){
                Hour++;
                Minute = 0;
                Second = 0;
            }else if(Second == 59){
                Minute++;
                Second = 0;
            }
        }

        public void previousSecond(){
            if(Second == 0 && Minute == 0 && Hour == 0){
                Hour = 23;
                Minute = 59;
                Second = 59;
            }else if(Second == 0 && Minute == 0){
                Hour--;
                Minute = 59;
                Second = 59;
            }else if(Second == 0){
                Minute--;
                Second = 59;
            }
        }

        public void display(){
            string time = "";
            if(Hour < 10){
                time += '0';
            }
            time += Hour.ToString() + ':';
            if(Minute < 10){
                time += '0';
            }
            time += Minute.ToString() + ':';
            if(Second < 10){
                time += '0';
            }
            time += Second.ToString();

            Console.WriteLine(time);
        }
    }
}