using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
using Domain.Models;
namespace Infrastructure.Services;

public class GradeService(DapperContext dapperContext) : Interface<Grade>
{
    public async Task AddValueAsync(Grade value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Grade(name,descs)values(@name,@descs)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Grade where Id = @id", new {Id = id});
    }

    public async Task<List<Grade>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Grade>("select * from Grade");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Grade value)
    {
        await dapperContext.Connection().ExecuteAsync("update Grade set name = @name, descs = @descs where Id = @id",value);
    }
}
