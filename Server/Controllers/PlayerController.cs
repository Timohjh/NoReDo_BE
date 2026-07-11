using Microsoft.AspNetCore.Mvc;
using Server.Services;
using SharedLibrary;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayerController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpGet]
    public DataObject GetQuery([FromQuery] int id)
    {
        var data = new DataObject() {  Id = id};
        return data;
    }

    [HttpGet("{id}")]
    public DataObject Get([FromRoute] int id)
    {
        var data = new DataObject() { Id = id };
        _playerService.DoSomething();
        return data;
    }

    [HttpPost]
    public DataObject Post(DataObject dataObject)
    {
        return dataObject;
    }
}