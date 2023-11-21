using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RegistryController : ControllerBase
{
    private readonly RegistryManager _registryManager;

    public RegistryController(RegistryManager registryManager)
    {
        _registryManager = registryManager;
    }

    [HttpPost]
    [Route("addMdFileType")]
    public IActionResult AddMDFileType()
    {
        _registryManager.AddMDFileType();
        return Ok("'.md' file type added successfully to the context menu.");
    }
}
