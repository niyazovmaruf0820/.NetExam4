using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
using Domain.Models;
namespace Infrastructure.Services;

public class ClassroomService(DapperContext dapperContext) : Interface<Classroom>
{
    public async Task AddValueAsync(Classroom value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Classroom(year,gradeId,section,status,remarks,teacherId)values(@year,@gradeId,@section,@status,@remarks,@teacherId)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Classroom where Id = @id", new {Id = id});
    }

    public async Task<List<Classroom>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Classroom>("select * from Classroom");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Classroom value)
    {
        await dapperContext.Connection().ExecuteAsync("update Classroom set year = @year,gradeId = @gradeId,section = @section,status = @status,remarks = @remarks,teacherId = @teacherId where Id = @id",value);
    }
}
