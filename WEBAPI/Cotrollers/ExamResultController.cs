using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ExamResultController(Interface<ExamResult> examResultservice)
{
    [HttpGet("get-ExamResults")]
    public async Task<List<ExamResult>> GetExamResultsAsync()
    {
        return await examResultservice.GetValuesAsync();
    }
    [HttpPost("add-ExamResult")]
    public async Task AddExamResultAsync(ExamResult examResult)
    {
        await examResultservice.AddValueAsync(examResult);
    }
    [HttpPut("update-ExamResult")]
    public async Task UpdateTeacheAsync(ExamResult examResult)
    {
        await examResultservice.UpdateValueAsync(examResult);
    }
    [HttpDelete("delete-ExamResult")]
    public async Task DeleteExamResultAsync(int id)
    {
        await examResultservice.DeleteValueAsync(id);
    }
}
