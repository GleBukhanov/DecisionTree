namespace MyApp;

public class DecisionResult : Decision
{
    private string res;

    public DecisionResult(string res)
    {
        this.res = res;
    }
    public override void Evaluate(IEntity entity)
    {
        Console.WriteLine(res);
    }
}