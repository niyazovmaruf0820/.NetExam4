using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
using Domain.Models;
namespace Infrastructure.Services;

public class AttendanceService(DapperContext dapperContext) : Interface<Attendance>
{
    public async Task AddValueAsync(Attendance value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Attendance(attendanceDate,studentId,status,remark)values(@attendanceDate,@studentId,@status,@remark)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Attendance where Id = @id", new {Id = id});
    }

    public async Task<List<Attendance>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Attendance>("select * from Attendance");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Attendance value)
    {
        await dapperContext.Connection().ExecuteAsync("update Attendance set attendanceDate = @attendanceDate,studentId = @studentId,status = @status, remark = @remark where Id = @id",value);
    }
}
