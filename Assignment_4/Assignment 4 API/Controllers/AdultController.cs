using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignnment_4_API.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Assignnment_4_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private ICloudService _cloudService;

        public AdultController(ICloudService cloudService) {
            this._cloudService = cloudService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetTodos() {
            try {
                IList<Adult> todos = await _cloudService.GetAdultAsync();
                return Ok(todos);
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteTodo([FromRoute] int id) {
            try {
                await _cloudService.RemoveAdultAsync(id);
                return Ok();
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddTodo([FromBody] Adult adult) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try {
                Adult added = await _cloudService.AddAdultAsync(adult);
                return Created($"/{added.Id}",added); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> UpdateTodo([FromBody] Adult adult) {
            try {
                await _cloudService.UpdateAdultAsync(adult);
                return Ok(); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> GetAdultByIdAsync([FromRoute] int id) {
            try {
                Adult adult = await _cloudService.GetAdultByIdAsync(id);
                return Ok(adult);
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}