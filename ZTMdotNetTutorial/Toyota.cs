namespace ZTMdotNetTutorial;

public class Toyota : ICar
{
    public string Make()
    {
        return "Toyota";
    }

    public string Model()
    {
        return "Camry";
    }

    public string Variant()
    {
        return "Grande";
    }
}