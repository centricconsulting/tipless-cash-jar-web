using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiplessCashJar.repositories
{
  public class TiplessCashJarContext : DbContext
  {
    public TiplessCashJarContext() : base("tipless-cash-jar-connection-string")
    {
    }
  }
}
