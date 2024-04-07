using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Data;
using Dapper;
namespace Infrastructure.Services;

public class TeacherService(DapperContext dapperContext) : Interface<Teacher>
{
    public async Task AddValueAsync(Teacher value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Teacher(email,password,fname,iname,dob,phone,mobile,status,lastLoginDate,lastLoginIp)values(@email,@password,@fname,@iname,@dob,@phone,@mobile,@status,@lastLoginDate,@lastLoginIp)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Teacher where Id = @id", new {Id = id});
    }

    public async Task<List<Teacher>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Teacher>("select * from Teacher");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Teacher value)
    {
        await dapperContext.Connection().ExecuteAsync("update Teacher set email = @email,password = @password,fname = @fname,iname = @iname,dob = @dob,phone = @phone,mobile = @mobile,status = @status,lastLoginDate = @lastLoginDate,lastLoginIp = @lastLoginIp where Id = @id",value);
    }

}
