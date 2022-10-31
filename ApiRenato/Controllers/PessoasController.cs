using ApiRenato.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;

namespace ApiRenato.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PessoasController : ControllerBase
    {
        public IPessoasRepository _pessoasRepository;

        public PessoasController(IPessoasRepository pessoasRepository)
        {
            _pessoasRepository = pessoasRepository;
        }

        [HttpGet]
        public IActionResult Get() {
            try
            {
                return Ok("retorno ok get pessoas");
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,"Falha no Banco de dados");
            }
            
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de dados");
            }

        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de dados");
            }

        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de dados");
            }

        }
        [HttpDelete("{Id}")]
        public IActionResult Delet(int Id)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de dados");
            }

        }
    }
}
