using Sistem;
class Person
{
    private string name;
    const int c = 3;
    public Person (string nm)
    {
        name = nm;
    }
    public string GetName()
    {
        return name;
    }
    public int Dochod(int a)
    {
        return a * c;
    }
    static void Main (string[], args)
    {
        Person p = new Person("David");
        Console.WriteLine(p.GetName);
        Person x = new Person (Convert.ToInt32("34000"));
        Console.WriteLine(x.Dochod);
    }
}