using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;

namespace Tournament.API.Controllers
{
    [ApiController]
    [Route("v1/game")]
    public class GameController : Controller
    {
        private readonly IApplicationGameService _applicationGameService;

        public GameController(IApplicationGameService applicationGameService)
        {
            _applicationGameService = applicationGameService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<GameCommand>> GetAll()
        {
            return Ok(_applicationGameService.GetAll());
        }
        
        [HttpGet("GetUnfinishedGames")]
        public ActionResult<IEnumerable<GameCommand>> GetUnfinishedGames()
        {
            return Ok(_applicationGameService.GetAll().Where(x=> x.GameEnd == null));
        }
        
        [HttpGet("{id}")]
        public ActionResult<GameCommand> Get(Guid id)
        {
            return Ok(_applicationGameService.GetById(id));
        }
        
        [HttpPost]
        public ActionResult Post([FromBody] GameCommand gameCommand)
        {
            try
            {
                if (gameCommand == null)
                    return NotFound();

                _applicationGameService.Add(gameCommand);
                return Ok("Partida criada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpPut("{id}")]
        public ActionResult Put(
            Guid id,
            [FromBody] GameCommand gameCommand
            )
        {
            try
            {
                if (gameCommand == null || id != gameCommand.Id)
                    return NotFound();

                _applicationGameService.Update(gameCommand);
                return Ok("Partida atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(
            Guid id,
            [FromBody] GameCommand gameCommand
            )
        {try
            {
                if (gameCommand == null || id != gameCommand.Id)
                    return NotFound();

                _applicationGameService.Remove(gameCommand);
                return Ok("Partida deletada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}