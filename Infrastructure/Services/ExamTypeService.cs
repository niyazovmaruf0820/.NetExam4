using Infrastructure.Data;
using Dapper;
using Infrastructure.Interfaces;
using Domain.Models;
namespace Infrastructure.Services;

public class ExamTypeService(DapperContext dapperContext) : Interface<ExamType>
{
    public async Task AddValueAsync(ExamType value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into ExamType(name,descs)values(@name,@descs)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from ExamType where Id = @id", new {Id = id});
    }

    public async Task<List<ExamType>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<ExamType>("select * from ExamType");
        return list.ToList();
    }

    public async Task UpdateValueAsync(ExamType value)
    {
        await dapperContext.Connection().ExecuteAsync("update ExamType set name = @name,descs = @descs where Id = @id",value);
    }
}
