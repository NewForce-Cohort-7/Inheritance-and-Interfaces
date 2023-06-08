// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Instructor Jordan = new Instructor(){
    FirstName = "Jordan",
    LastName = "Castelloe",
    Address = "Somwhere outehre",
    Phone = "1243432123",
    Birthday = "08/31/2000",
    Email = "GoodCop@generationwv.org"
    
};

Jordan.CallOutSick();



List<IEmployee> GWVEmployees = new List<IEmployee>()
{
    new GenerationEmployee(){
        FirstName = "Candice"
    },
    new GenerationEmployee(){
        FirstName = "Olivia"
    }
};

GWVEmployees.Add(
    new GenerationEmployee(){
        FirstName = "Alex"
    }); 

    GWVEmployees.Add(Jordan);

 
