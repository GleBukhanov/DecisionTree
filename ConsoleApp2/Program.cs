using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainDecisionTree().Evaluate(new Employee());


        }
        public static Decision MainDecisionTree()
        {
            var deny = new DecisionResult("Deny");
            var firstDay = new DecisionQuery()
            {
                Title = "Has he gone on the first day?",
                Negative = deny,
                Positive = new DecisionResult("Accept")
            };
            var requiredDocumets = new DecisionQuery()
            {
                Title = "Does he have required documents?",
                Negative = deny,
                Positive = firstDay
            };
            var successInterview = new DecisionQuery()
            {
                Title = "Do you have a success interview?",
                Negative = deny,
                Positive = requiredDocumets
            };
            var goToInterview = new DecisionQuery()
            {
                Title = "Is he go to interview?",
                Negative = deny,
                Positive = successInterview
            };
            var goodCV = new DecisionQuery()
            {
                Title = "Does he have a good CV?",
                Negative = deny,
                Positive = goToInterview
            };
            
            var call = new DecisionQuery()
            {
                Title = "Employee answered to the Call?",
                Negative = deny,
                Positive = goodCV
            };
            return call;
        }
    }
}