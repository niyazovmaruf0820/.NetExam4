using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Dapper;
namespace Infrastructure.Services;

public class ParentService(DapperContext dapperContext) : Interface<Parent>
{
    public async Task AddValueAsync(Parent value)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Parent(email,password,fname,iname,dob,phone,mobile,status,lastLoginDate,lastLoginIp)values(@email,@password,@fname,@iname,@dob,@phone,@mobile,@status,@lastLoginDate,@lastLoginIp)",value);
    }

    public async Task DeleteValueAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Parent where Id = @id", new {Id = id});
    }

    public async Task<List<Parent>> GetValuesAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Parent>("select * from Parent");
        return list.ToList();
    }

    public async Task UpdateValueAsync(Parent value)
    {
        await dapperContext.Connection().ExecuteAsync("update Parent set email = @email,password = @password,fname = @fname,iname = @iname,dob = @dob,phone = @phone,mobile = @mobile,status = @status,lastLoginDate = @lastLoginDate,lastLoginIp = @lastLoginIp where Id = @id",value);
    }
}
