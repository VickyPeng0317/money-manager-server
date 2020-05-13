using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using money_manager_server.Entities;

namespace money_manager_server.Controllers
{
  [ApiController]
  [Route("api/[controller]/[action]")]
  public class TestController : ControllerBase
  {

    [HttpGet]
    public string Test()
    {
      return "hello";
    }

  }
}
