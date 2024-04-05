using HomeWork6;

Console.WriteLine("Дайте кличку коту а потом собаки");

string nameCat = Console.ReadLine();
string nameDog = Console.ReadLine();    

var cat = new Cat(nameCat);
var dog = new Dog(nameDog);

cat.Voice();
dog.Voice();

cat.Eat();
dog.Eat();  

Console.ReadLine(); 
