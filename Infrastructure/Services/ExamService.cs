using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class ExamService(DapperContext dapperContext) : Interface<Exam>
{
    public async Task AddValueAsync(Exam value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Exam(examTypeId)values(@examTypeId)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Exam where Id = @id", new {Id = id});
    }

    public async Task<List<Exam>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Exam>("select * from Exam");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Exam value)
    {
        await dapperContext.Connection().ExecuteAsync("update Exam set examTypeId = @examTypeId where Id = @id",value);
    }
}
