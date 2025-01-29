using Batch_Data_Processing_API_With_Odata.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Batch_Data_Processing_API_With_Odata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ODataController
    {
        private UsersDbContext _dbContext;
        public UserController(UsersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetUsers")]
        [EnableQuery]
        public ActionResult GetUsers()
        {
            var result = _dbContext.USERS.Include(u => u.Orders).AsQueryable();
            return Ok(result);
        }
    }
}
