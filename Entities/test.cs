using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace money_manager_server.Entities
{
  [Table("test")]
  public class Test
  {
    [Column("id")]
    public int id { get; set; }

    [Column("name")]
    public string name { get; set; }

    [Column("phone")]
    public string phone { get; set; }

    [Column("remark")]
    public string remark { get; set; }
  }

  public class TestService
  {
    public DBContext _context;

    public TestService(DBContext context)
    {
      _context = context;
    }

    public IEnumerable<Test> GetTests() {
      return _context.test.ToList();
    }
  }
}