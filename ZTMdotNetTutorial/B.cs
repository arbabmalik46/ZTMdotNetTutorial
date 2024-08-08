namespace ZTMdotNetTutorial;

public class B : A
{
    public B(string name) : base("Ayesha")
    {
        this.name = name;
            
    }

    public Asset assets;

    private decimal _value;

    public decimal Value
    {
        get
        {
            return assets switch
            {
                Asset.Car when (_value>0)  => Math.Round(_value,1),
                Asset.Gold => _value,
            };
        }
            
    }
    public enum Asset
    {
        Car,
        House,
        Land,
        Money,
        Gold,

    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override void GetName()
    {
        base.GetName();
        name = "Hamza";
        Console.WriteLine("Name after override: " + name);
    }
}