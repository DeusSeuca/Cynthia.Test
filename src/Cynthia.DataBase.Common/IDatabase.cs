using System.Collections.Generic;

namespace Cynthia.DataBase.Common
{
    public interface IDatabase : IEnumerable<IRepository>
    {
        string Name { get; }
        IRepository GetRepository(string name);
        IRepository<TModel> GetRepository<TModel>(string name) where TModel : ModelBase;
        IRepository<TModel> GetRepository<TModel>() where TModel : ModelBase;
    }
}