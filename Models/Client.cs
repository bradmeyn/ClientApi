namespace ClientApi.Models;

public class Client {

   public Guid Id {get; set;}

   public string Name {get; set;} = string.Empty;

   public string Email {get; set;} = string.Empty;


   public ICollection<Task> tasks = new List<Task>();
}