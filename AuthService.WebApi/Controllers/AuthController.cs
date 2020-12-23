using Microsoft.AspNetCore.Mvc;

namespace AuthService.WebApi.Controllers
{
   [ApiController]
   public class AuthController : ControllerBase
   {
      [HttpPost]
      [Route("login")]
      public IActionResult Post()
      {
         var tokenResult = "{ \"access_token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c\" }";

         return Ok(tokenResult);
      }
   }
}