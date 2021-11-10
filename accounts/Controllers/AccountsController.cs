using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using accounts.Data;
using Microsoft.AspNetCore.Http;
using accounts.Model;
using accounts.Entity;

namespace accounts.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase 
    {
        private readonly ILogger<AccountsController> _logger;

        private readonly ApplacationDbcontext _context;

        public AccountsController(ILogger<AccountsController> logger, ApplacationDbcontext context) 
        { 
            _logger = logger;
            _context = context;

        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateUser([FromBody]NewUser newUser)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("user are not valid");
            }

            var user = new User(
                firstname: newUser.Firstname,
                lastname: newUser.Lastname,
                middlename: newUser.Middlename,
                phone: newUser.Phone,
                email: newUser.Email,
                password: newUser.password
            ); 

            try
            {
                  await _context.Users.AddAsync(user);
                  await _context.SaveChangesAsync();
                  return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, new {errorMessage = e.Message});
            }


        }
    }
}