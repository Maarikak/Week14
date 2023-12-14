
using System.Net.Security;

Dog goodboy = new Dog("Good Boy");
Console.WriteLine($"Name: {goodboy.Name}; Level of happinness : {goodboy.LevelOfHappinness}");

while(goodboy.LevelOfHappinness < 5)
{
    goodboy.Bark();
}

goodboy.Wag();

//goodboy.Bark();
//Console.WriteLine($"Name: {goodboy.Name}; Level of happinness : {goodboy.LevelOfHappinness}");
//goodboy.Wag();


class Dog
{
    public string Name;
    public int LevelOfHappinness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappinness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappinness++;
        Console.WriteLine("Woof-woof!");
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} starts wagging its tail.");
        Console.WriteLine("Whoosh-woosh");
    }



}
