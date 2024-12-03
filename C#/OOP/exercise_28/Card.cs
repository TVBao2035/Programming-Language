using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_28
{
    public class Card
    {
        public string NameBook{
            get; set;
        }

        public string NameAuthor{
            get; set;
        }

        public int NumberBook{
            get; set;
        }

        public Card(){}
        public Card(string nameBook, string nameAuthor, int numberBook){
            NameBook = nameBook;
            NameAuthor = nameAuthor;
            NumberBook = numberBook;
        }

        public void display(){
            Console.WriteLine("Name Book: " + NameBook);
            Console.WriteLine("Name Author: " + NameAuthor);
            Console.WriteLine("Number Book: " + NumberBook);
        }

        public static void sortCards(List<Card> listCards){
            for(int i=0; i < listCards.Count - 1; i++){
                if(listCards[i].NumberBook > listCards[i + 1].NumberBook){
                    Card temp = listCards[i];
                    listCards[i] = listCards[i + 1];
                    listCards[i + 1] = temp;
                }
            }
        }
    }
}