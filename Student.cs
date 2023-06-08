public class Student : Person
{
    public string Cohort {get;set;}         

    public DateTime GraduationDate {get;set;}   

    public string CurrentMentor {get;set;}

    public override void CallOutSick()
    {
        Console.WriteLine($"{FirstName} {LastName} is out sick today. Sucks for them, hope the feel better tomorrow.");
    }
}