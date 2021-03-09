using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Extensions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

 
        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            TcknoSet run = new TcknoSet();
            var singleId=run.SetSingId();
            user.SingleID = singleId;
            user.Birthday = user.Birthday;
            user.CreationDate = DateTime.Now;
            user.LastModified = DateTime.Now;
            var result = _userService.AddUser(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put([FromBody] User user)
        {
            var result= _userService.UpdateUser(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        // DELETE api/<UserController>/5
        [HttpDelete()]
        public IActionResult Delete(string SingleId)
        {
            var result=_userService.DeleteUser(SingleId);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }



        [HttpGet("getbysingleid")]
        public IActionResult GetById(string singleId)
        {

            var result = _userService.GetBySingleId(singleId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
