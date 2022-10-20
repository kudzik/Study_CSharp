
// Klasa worker zawiera to co Person dodatkowo dodaje nową własność

Worker worker = new() { Age = 30 };


class Person
{
    string? Name { get; set; }
    public int Age { get; set; }

    public virtual void SayHello()
    {
        System.Console.WriteLine("Hello I'm Person");
    }

    public int WorkPrefix => 0; // Równoważne z 
    public int WorkPrefix { get { return 0; } }

}

class Worker : Person
{
    public int WorkerID { get; set; }

    // Przesłonięta metoda z klasy bazowej
    public override void SayHello()
    {
        System.Console.WriteLine("Hello I'm Worker");
        //base.SayHello() // Wywołanie metody z klasy bazowej

    }
}

