namespace tiplessCashJar.repositories
{
  public abstract class RepositoryBase
  {
    protected TiplessCashJarContext Db { get; set; }

    protected RepositoryBase(TiplessCashJarContext db)
    {
      Db = db;
    }
  }
}