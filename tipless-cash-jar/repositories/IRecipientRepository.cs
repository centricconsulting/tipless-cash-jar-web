using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public interface IRecipientRepository
  {
    Task<RecipientEntity> GetByBeaconName(string name);
  }
}