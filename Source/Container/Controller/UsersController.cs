namespace Frapi.Source.Container.Controller;
[ApiController]
[Route("api/")]
public class UsersController(IUserRepository repository) : ControllerBase
{
    
}
