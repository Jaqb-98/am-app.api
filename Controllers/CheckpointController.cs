using Api.Model;
using Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class CheckpointController : ControllerBase
{

private readonly ICheckpointRepository _repository;
    public CheckpointController(ICheckpointRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    public async Task<ActionResult<Checkpoint>> Get()
    {
        var checkpoint = await _repository.GetRandomCheckpoint();
        return checkpoint != null ? Ok(checkpoint) : NotFound();
    }
    [HttpGet]
    [RouteAttribute("Create")]
    public async Task<ActionResult<Checkpoint>> Get(double lat, double lng)
    {
        var checkpoint = await _repository.CreateRandomCheckpoint(lat, lng);
        return checkpoint != null ? Ok(checkpoint) : NotFound();
    }
}
