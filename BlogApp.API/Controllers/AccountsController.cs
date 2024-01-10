using BlogApp.Business.DTOs.AccountDTOs;
using BlogApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ICategoryService _service;
        public AccountsController(ICategoryService service)
        {
            _service = service;
        }
        [HttpPost("[action]")]
        public  async Task<IActionResult> Register([FromForm] RegisterDto registerDtos)
        {
            await _service.Register(registerDtos);
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromForm] LoginDto loginDto)
        {
            var result = await _service.LoginAsync(loginDto);
            return Ok(result);
        }

    }
}
