namespace ClientApi.Models;

public class Task {

    public Guid Id {get; set;}

    public string Detail {get; set;} = string.Empty;

    public Guid ClientId {get; set;}
   
    public required Client Client {get; set;} 
}