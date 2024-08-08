namespace ZTMdotNetTutorial;

public class A
{
    public string name;
    public A(string name)
    {
        this.name = name;
    }

    public virtual void GetName()
    {
        name = "Arbab";
        Console.WriteLine("Name before overriding: " + name);
    }
}