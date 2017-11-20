
namespace Bot_1

{
    using System;
using Microsoft.Bot.Builder.FormFlow;

[Serializable]
public class PolicyQuery
{
   // [Numeric(0,100)]
    [Prompt("Please enter your {&}")]
    public string EntryAge { get; set; }


   // [Numeric(100,int.MaxValue)]
    [Prompt("What is the {&} you want to start with ?")]
    public string MinimumPremium { get; set; }

   // [Numeric(1, int.MaxValue)]
    [Prompt(" What is the {&} that you expect?")]
    public string MinimumSumAssured { get; set; }
}
}