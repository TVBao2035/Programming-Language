class Person{
    constructor(name, yearOfBirth, gender, width, height, address){
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.gender = gender;
        this.width = width;
        this.height = height;
        this.address = address;
    }

    set setName(name){
        this.name = name;
    }
    get getName(){
        return this.name;
    }

    set setYearOfBirth(yearOfBirth){
        this.yearOfBirth = yearOfBirth;
    }
    get getYearOfBirth(){
        return this.yearOfBirth;
    }

    set setGender(gender){
        this.gender = gender;
    }
    get getGender(){
        return this.gender;
    }

    set setWidth(width){
        this.width = width;
    }
    get getWidth(){
        return this.width;
    }

    set setHeight(height){
        this.height = height;
    }
    get getHeight(){
        return this.height;
    }

    set setAddress(address){
        this.address = address;
    }
    get getAddress(){
        return this.address;
    }
    talk(){
        console.log("Hahahah");
    }
    display(){
        console.log("Name: " , this.getName);
        console.log("Year Of Birth: ", this.getYearOfBirth);
        console.log("Gender: ", this.getGender);
        console.log("Width: ", this.getWidth);
        console.log("Height: ", this.getHeight);
        console.log("Address: ", this.getAddress);
    }
}

class Student extends Person{
    constructor(name, yearOfBirth, gender, width, height, address, id){
        super(name, yearOfBirth, gender, width, height, address);
        this.id = id;
    }
    set setId(id){
        this.id = id;
    }
    get getId(){
        return this.id;
    }
    talk(){
        super.talk();
        console.log("heheheh")
    }
    display(){
        super.display();
        console.log("id: ", this.id);
    }
}
var person = new Person("truong van bao", 2003, "Nam", 50, 1.6,"Tien Giang");
person.display();
var student = new Student("Bao", 2000, "Boy", 51, 1.65, "TG", 2424);
student.display();

