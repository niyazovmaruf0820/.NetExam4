using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]

[Route("[controller]")]
public class StudentController(Interface<Student> studentservice)
{
    [HttpGet("get-Students")]
    public async Task<List<Student>> GetStudentsAsync()
    {
        return await studentservice.GetValuesAsync();
    }
    [HttpPost("add-Student")]
    public async Task AddStudentAsync(Student student)
    {
        await studentservice.AddValueAsync(student);
    }
    [HttpPut("update-Student")]
    public async Task UpdateTeacheAsync(Student student)
    {
        await studentservice.UpdateValueAsync(student);
    }
    [HttpDelete("delete-Student")]
    public async Task DeleteStudentAsync(int id)
    {
        await studentservice.DeleteValueAsync(id);
    }
}
