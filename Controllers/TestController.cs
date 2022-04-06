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
    private DBContext _context;

    // public TestController(DBContext context)
    // {
    //   _context = context;
    // }

    [HttpGet]
    public List<Test> GetList()
    {
      List<Test> testList = _context.test.ToList();
      return testList;
    }

    [HttpGet]
    public string hello()
    {
      return "hellotest";
    }

    [HttpPost]
    public string Add(Test item)
    {
      _context.test.Add(item);
      _context.SaveChanges();
      return "success";
    }
  }
}
