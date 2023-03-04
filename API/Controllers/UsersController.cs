using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Database;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Retrieving all data
        [HttpGet] //No route?
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(){
            var users = await _appDbContext.Users.ToListAsync();
            return  users == null ? NotFound() : users;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id){
            var user = await _appDbContext.Users.FindAsync(id);
            return user == null ? NotFound() : user;
        }
         

    }
}