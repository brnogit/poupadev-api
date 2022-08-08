using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoupaDev.API.Models;

namespace PoupaDev.API.Controllers
{
    [ApiController]
    [Route("api/objetivos-financeiros")]
    public class ObjetivosFinanceirosController : ControllerBase
    {
        // GET api/objetivos-financeiros
        [HttpGet]
        public IActionResult GetTodos() {
            return Ok();
        }

        // GET api/objetivos-financeiros/1
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id) {
            // se não achar, retornar NotFound();
            return Ok();
        }

        // POST api/objetivos-financeiros
        [HttpPost]
        public IActionResult Post(ObjetivoFinanceiroInputModel model) {
            // Se dados de entrada estiverem invalidos, retornar BadRequest();
            return Ok();        
        }

        // POST api/objetivos-financeiros/1/operacoes
        [HttpPost("{id}/operacoes")]
        public IActionResult PostOperacao(int id, OperacaoInputModel model) {
            return NoContent();
        }
    }
}