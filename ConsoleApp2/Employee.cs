namespace MyApp;

public class Employee :IEntity
{

    public bool getAnswer(string title)
    {
        Console.WriteLine("Enter 1 if true and 0 if false");
        Console.WriteLine(title);
        var result=int.Parse(Console.ReadLine());
        if (result == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}