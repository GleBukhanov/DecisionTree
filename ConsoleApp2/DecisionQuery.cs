using System.Reflection.Metadata;

namespace MyApp;

public class DecisionQuery : Decision
{
    public string Title { get; set; }
    public Decision Positive {get;set;}
    public Decision Negative {get;set;}
    //public Func<Employee, bool> Test { get; set; }
    public override void Evaluate(IEntity entity)
    {
        if (entity.getAnswer(Title))
        {
            Positive.Evaluate(entity);
        }
        else
        {
            Negative.Evaluate(entity);
        }
    }
}