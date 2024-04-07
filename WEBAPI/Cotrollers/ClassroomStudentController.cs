using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ClassroomStudentController(Interface<ClassroomStudent> classroomStudentservice)
{
    [HttpGet("get-ClassroomStudents")]
    public async Task<List<ClassroomStudent>> GetClassroomStudentsAsync()
    {
        return await classroomStudentservice.GetValuesAsync();
    }
    [HttpPost("add-ClassroomStudent")]
    public async Task AddClassroomStudentAsync(ClassroomStudent classroomStudent)
    {
        await classroomStudentservice.AddValueAsync(classroomStudent);
    }
    [HttpPut("update-ClassroomStudent")]
    public async Task UpdateTeacheAsync(ClassroomStudent classroomStudent)
    {
        await classroomStudentservice.UpdateValueAsync(classroomStudent);
    }
    [HttpDelete("delete-ClassroomStudent")]
    public async Task DeleteClassroomStudentAsync(int id)
    {
        await classroomStudentservice.DeleteValueAsync(id);
    }
}
