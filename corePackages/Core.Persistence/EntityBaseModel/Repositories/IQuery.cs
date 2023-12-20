namespace Core.Persistence.EntityBaseModel.Repositories;

internal interface IQuery<T>
{
    IQueryable<T> Query();
}
