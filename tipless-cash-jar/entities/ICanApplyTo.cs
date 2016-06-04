namespace tiplessCashJar.entities
{
  public interface ICanApplyTo<T>
  {
    T ApplyTo(T target);
  }
}