namespace exercise_19;

class Program{
    static void Main()
    {
        Animal[] animal = new Animal[4];
        animal[0] = new Animal();
        animal[1] = new Duck();
        animal[2] = new Dog();
        animal[3] = new Cat();

        for(int i=0; i<4; i++){
            animal[i].sound();
        }
    }
}