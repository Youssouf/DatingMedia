using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public UsersController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Getusers()
        {
        return await _dbContext.AppUsers.ToListAsync();
        
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> Getuser(int id)
        {
        return await _dbContext.AppUsers.FindAsync(id);
       
        }
         
    }
}