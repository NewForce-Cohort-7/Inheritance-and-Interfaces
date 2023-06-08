public class Person {


    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Address {get;set;}
    public string Email {get;set;}
    public string Birthday {get;set;}
    public string Phone {get; set;}

    public virtual void CallOutSick() 
    {
            Console.WriteLine($"{FirstName} {LastName} is out sick today.");
    }

}