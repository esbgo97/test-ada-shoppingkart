using ADA.ShoppingKart.Business.Interfaces;
using ADA.ShoppingKart.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADA.ShoppingKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBusiness _business;
        public UsersController(IUserBusiness business)
        {
            _business = business;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _business.GetAll(new User { });
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
