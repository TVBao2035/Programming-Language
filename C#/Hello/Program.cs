namespace Hello
{
    class Person{
        private string name;
        private int age;

    
        public string Name {
            get{
                return name;
            }
            set{
                if(value == "") value = "Known";
                name = value;
            }
        }
        public int Age {
            get{
                return age;
            }

            set{
                if(value <= 0) value = 1;
                age = value;
            }
        }
        public void display(){
            Console.WriteLine(Name + " " + Age);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "";
            p.Age = 0;
            p.display();
        }
    }

}