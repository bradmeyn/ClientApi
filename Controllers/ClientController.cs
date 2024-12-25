using ClientApi.Data;
using Microsoft.AspNetCore.Mvc;


namespace ClientApi.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientController: ControllerBase 
{

    private readonly ILogger<ClientController> _logger;
    private readonly DataContext _context;

    // Constructor
    public ClientController(ILogger<ClientController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

}