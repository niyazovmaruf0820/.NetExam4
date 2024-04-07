using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ParentController(Interface<Parent> parentservice)
{
    [HttpGet("get-Parents")]
    public async Task<List<Parent>> GetParentsAsync()
    {
        return await parentservice.GetValuesAsync();
    }
    [HttpPost("add-Parent")]
    public async Task AddParentAsync(Parent parent)
    {
        await parentservice.AddValueAsync(parent);
    }
    [HttpPut("update-Parent")]
    public async Task UpdateTeacheAsync(Parent parent)
    {
        await parentservice.UpdateValueAsync(parent);
    }
    [HttpDelete("delete-Parent")]
    public async Task DeleteParentAsync(int id)
    {
        await parentservice.DeleteValueAsync(id);
    }
}
