using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api.Models;
using web_api.Service.FuncionarioService;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;

        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _funcionarioInterface.GetFuncionarios());

        }
    }
}
