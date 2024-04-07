using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class StudentService(DapperContext dapperContext) : Interface<Student>
{
    public async Task AddValueAsync(Student value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Student(email,password,fname,iname,dob,phone,mobile,parentId,dateOfJoin,status,lastLoginDate,lastLoginIp)values(@email,@password,@fname,@iname,@dob,@phone,@mobile,@parentId,@dateOfJoin,@status,@lastLoginDate,@lastLoginIp)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Student where Id = @id", new {Id = id});
    }

    public async Task<List<Student>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Student>("select * from Student");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Student value)
    {
        await dapperContext.Connection().ExecuteAsync("update Student set email = @email,password = @password,fname = @fname,iname = @iname,dob = @dob,phone = @phone,mobile = @mobile,parentId = @parentId,dateOfJoin = @dateOfJoin,status = @status,lastLoginDate = @lastLoginDate,lastLoginIp = @lastLoginIp where Id = @id",value);
    }
}
