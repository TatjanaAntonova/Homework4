namespace Homework4.Domain.Common
{
    public interface IRepository<T>: ICrudMethods<T>, IPaging, ISorting, IFiltering
    {
    }
}