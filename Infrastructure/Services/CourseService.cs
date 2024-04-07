using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class CourseService(DapperContext dapperContext) : Interface<Course>
{
    public async Task AddValueAsync(Course value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Course(name,description,gradeId)values(@name,@description,@gradeId)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Course where Id = @id", new {Id = id});
    }

    public async Task<List<Course>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Course>("select * from Course");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Course value)
    {
        await dapperContext.Connection().ExecuteAsync("update Course set name = @name,description = @description,gradeId = @gradeId where Id = @id",value);
    }
}
