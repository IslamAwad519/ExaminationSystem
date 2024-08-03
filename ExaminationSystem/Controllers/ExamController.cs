using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Services.Exams;
using Microsoft.AspNetCore.Authorization;

namespace ExaminationSystem.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExamController : ControllerBase
{
    private readonly IExamService _examService;

    public ExamController(IExamService examService)
    {
        _examService = examService;
    }

    // Generate-Exam
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ExamResponse), StatusCodes.Status200OK)]
    [Authorize(Roles = DefaultRoles.Instructor)]
    [HttpPost("generate")]
    public async Task<IActionResult> GenerateExam([FromBody]ExamParams examParams)
    {
        try
        {
            var isCreated = await _examService.GenerateExamAsync(examParams);
            return isCreated
                ? Ok("Exam Created Successfully")
                : BadRequest("There is Final Exam Exists");
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}
