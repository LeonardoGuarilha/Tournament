using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;

namespace Tournament.API.Controllers
{
    [ApiController]
    [Route("v1/player")]
    public class PlayerController : Controller
    {
        private readonly IApplicationPlayerService _applicationPlayerService;

        public PlayerController(IApplicationPlayerService applicationPlayerService)
        {
            _applicationPlayerService = applicationPlayerService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<PlayerCommand>> GetAll()
        {
            return Ok(_applicationPlayerService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<PlayerCommand> Get(Guid id)
        {
            return Ok(_applicationPlayerService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PlayerCommand playerCommand)
        {
            try
            {
                if (playerCommand == null)
                    return NotFound();

                _applicationPlayerService.Add(playerCommand);
                return Ok("Jogador criado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(
            Guid id,
            [FromBody] PlayerCommand playerCommand
            )
        {
            try
            {
                if (playerCommand == null || id != playerCommand.Id)
                    return NotFound();

                _applicationPlayerService.Update(playerCommand);
                return Ok("Jogador atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(
            Guid id,
            [FromBody] PlayerCommand playerCommand
            )
        {
            try
            {
                if (playerCommand == null || id != playerCommand.Id)
                    return NotFound();

                _applicationPlayerService.Remove(playerCommand);
                return Ok("Jogador deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}