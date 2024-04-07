using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ExamController(Interface<Exam> examservice)
{
    [HttpGet("get-Exams")]
    public async Task<List<Exam>> GetExamsAsync()
    {
        return await examservice.GetValuesAsync();
    }
    [HttpPost("add-Exam")]
    public async Task AddExamAsync(Exam exam)
    {
        await examservice.AddValueAsync(exam);
    }
    [HttpPut("update-Exam")]
    public async Task UpdateTeacheAsync(Exam exam)
    {
        await examservice.UpdateValueAsync(exam);
    }
    [HttpDelete("delete-Exam")]
    public async Task DeleteExamAsync(int id)
    {
        await examservice.DeleteValueAsync(id);
    }
}
