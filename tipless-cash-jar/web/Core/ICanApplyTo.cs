namespace web.Core
{
  public interface ICanApplyTo<T>
  {
    T ApplyTo(T target);
  }
}