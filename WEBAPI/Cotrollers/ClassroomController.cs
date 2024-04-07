using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ClassroomController(Interface<Classroom> classroomservice)
{
    [HttpGet("get-Classrooms")]
    public async Task<List<Classroom>> GetClassroomsAsync()
    {
        return await classroomservice.GetValuesAsync();
    }
    [HttpPost("add-Classroom")]
    public async Task AddClassroomAsync(Classroom classroom)
    {
        await classroomservice.AddValueAsync(classroom);
    }
    [HttpPut("update-Classroom")]
    public async Task UpdateTeacheAsync(Classroom classroom)
    {
        await classroomservice.UpdateValueAsync(classroom);
    }
    [HttpDelete("delete-Classroom")]
    public async Task DeleteClassroomAsync(int id)
    {
        await classroomservice.DeleteValueAsync(id);
    }
}
