using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class TeacherController(Interface<Teacher> teacherservice)
{
    [HttpGet("get-teachers")]
    public async Task<List<Teacher>> GetTeachersAsync()
    {
        return await teacherservice.GetValuesAsync();
    }
    [HttpPost("add-teacher")]
    public async Task AddTeacherAsync(Teacher teacher)
    {
        await teacherservice.AddValueAsync(teacher);
    }
    [HttpPut("update-teacher")]
    public async Task UpdateTeacheAsync(Teacher teacher)
    {
        await teacherservice.UpdateValueAsync(teacher);
    }
    [HttpDelete("delete-teacher")]
    public async Task DeleteTeacherAsync(int id)
    {
        await teacherservice.DeleteValueAsync(id);
    }
}
