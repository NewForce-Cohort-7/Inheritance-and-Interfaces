public class Cohort 
{
    public string Name {get;set;} 
    public string StartDate {get;set;}
    public string EndDate {get;set;}
    public List<Student> Students {get;set;} = new List<Student>();
}