public class Instructor : Person, IEmployee
{
  public int CohortsTaught {get; set;}

 public string CurrentMentee {get; set;}

 public bool FormerStudent {get; set;}
 public double PayRate {get;set;}

 public string StartDate {get; set;}

 public bool isGoodCop {get; set;}

 public int LecturesTaught {get;set;}

 public int EmployeeId {get; set;}

public override void CallOutSick()
{
    Console.WriteLine($"The Instructor {FirstName} {LastName} is out sick today. Someone else needs to cover their lecture and their meeting with {CurrentMentee}.");
}


}