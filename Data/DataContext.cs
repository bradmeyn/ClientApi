using ClientApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientApi.Data;

public class DataContext: DbContext {


     public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }


    public DbSet<Client> Clients {get; set;}
     public DbSet<Models.Task> Tasks {get; set;}
}