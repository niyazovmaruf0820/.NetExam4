using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
using Domain.Models;
namespace Infrastructure.Services;

public class ClassroomStudentService(DapperContext dapperContext) : Interface<ClassroomStudent>
{
    public async Task AddValueAsync(ClassroomStudent value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into ClassroomStudent(classroomId,studentId)values(@classroomId,@studentId)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from ClassroomStudent where Id = @id", new {Id = id});
    }

    public async Task<List<ClassroomStudent>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<ClassroomStudent>("select * from ClassroomStudent");
        return list.ToList();
    }

    public async Task UpdateValueAsync(ClassroomStudent value)
    {
        await dapperContext.Connection().ExecuteAsync("update ClassroomStudent set classroomId = @classroomId, studentId = @studentId where Id = @id",value);
    }
}
