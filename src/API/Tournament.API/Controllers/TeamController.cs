using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;

namespace Tournament.API.Controllers
{
    [ApiController]
    [Route("v1/team")]
    public class TeamController : Controller
    {
        private readonly IApplicationTeamService _applicationTeamService;

        public TeamController(IApplicationTeamService applicationTeamService)
        {
            _applicationTeamService = applicationTeamService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<TeamCommand>> GetAll()
        {
            return Ok(_applicationTeamService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<TeamCommand> Get(Guid id)
        {
            return Ok(_applicationTeamService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] TeamCommand teamCommand)
        {
            try
            {
                if (teamCommand == null)
                    return NotFound();

                _applicationTeamService.Add(teamCommand);
                return Ok("Time criado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(
            Guid id,
            [FromBody] TeamCommand teamCommand
            )
        {
            try
            {
                if (teamCommand == null || id != teamCommand.Id)
                    return NotFound();

                _applicationTeamService.Update(teamCommand);
                return Ok("Time atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(
            Guid id,
            [FromBody] TeamCommand teamCommand
            )
        {
            try
            {
                if (teamCommand == null || id != teamCommand.Id)
                    return NotFound();

                _applicationTeamService.Remove(teamCommand);
                return Ok("Time deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}