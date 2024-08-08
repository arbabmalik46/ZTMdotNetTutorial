namespace ZTMdotNetTutorial;

public class Student
{
    public static string Member = "Toyota";
    public static void Name()
    {
        Console.WriteLine("My name is abdul");
    }

    public void Gender()
    {
        Console.WriteLine("I am a man");
    }

    public ICar car;

    public ICar getCarModel()
    {
        if (Member == "Mercedes")
        {
            return car = new Mercedes();
        }
        else
        {
            return car = new Toyota();
        }
    }

    public string getspeed()
    {
            string makemodelvaritant = car.Make()+" " + car.Model()+ " " + car.Variant();
            return makemodelvaritant;
    }
}