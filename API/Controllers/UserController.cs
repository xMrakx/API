using API.DTO.Profile;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route( "api/user" )]
    public class UserController : ControllerBase
    {
        [HttpPost( "auth" )]
        public IActionResult LogIn( [FromBody] LoginRequestDto requset )
        {
            if (true)
            {
                return Ok(new LoginResponseDto()
                {
                    Success = true,
                    Data = "K7safn9asdf5FS"
                });
            }

            if (false)
            {
                return BadRequest(false);
            }
        }

        [HttpGet( "profile" )]
        public IActionResult GetUserData( [FromQuery] string accessToken)  
        {
            if (true)
            {
                return Ok( new UserDataResponseDto()
                {
                    Success = true,
                    Data = new UserDataDto() 
                    {
                        UserId = 1,
                        LastName = "Иванов",
                        Name = "Иван",
                        Patronymic = "Иванович",
                        UserRole = 0,
                        Email = "test@mail.ru"
                    }
                });
            }

            if (false)
            {
                return NotFound(false);
            }
        }
    }
}
