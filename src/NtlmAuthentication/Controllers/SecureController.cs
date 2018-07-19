using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NtlmAuthentication.Controllers {

    [Route("api/[controller]/[action]")]
    public class SecureController {

        [HttpGet]
        [Authorize]
        public dynamic SayHello() {
            return new {
                Hello = "World"
            };
        }

    }
}