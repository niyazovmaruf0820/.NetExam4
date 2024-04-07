using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class ExamResultService(DapperContext dapperContext) : Interface<ExamResult>
{
    public async Task AddValueAsync(ExamResult value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into ExamResult(studentId,courseId,marks)values(@studentId,@courseId,@marks)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from ExamResult where Id = @id", new {Id = id});
    }

    public async Task<List<ExamResult>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<ExamResult>("select * from ExamResult");
        return list.ToList();
    }

    public async Task UpdateValueAsync(ExamResult value)
    {
        await dapperContext.Connection().ExecuteAsync("update ExamResult set studentId = @studentId,courseId = @courseId, marks = @marks where Id = @id",value);
    }
}
