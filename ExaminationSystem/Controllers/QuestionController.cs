using ExaminationSystem.DTOs.Questions;
using ExaminationSystem.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ExaminationSystem.Controllers;



[ApiController]
[Route("api/[controller]")]
////[ApiExplorerSettings(IgnoreApi = true)]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionService _questionService;
    private readonly IBaseRepository<Question> _questionRepository;
    private readonly IMapper _mapper;
    public QuestionsController(IQuestionService questionService, IBaseRepository<Question> questionRepository, IMapper mapper)
    {
        _questionService = questionService;
        _questionRepository = questionRepository;
        _mapper = mapper;
    }


    //Add-Question
    [HttpPost]
    [Authorize(Roles = DefaultRoles.Instructor)]
    public async Task<IActionResult> AddQuestion([FromBody] CreateQuestionDto createQuestionDto)
    {
        if (createQuestionDto == null)
            return BadRequest(ModelState);
        

        var newQuestion = await _questionService.AddQuestionAsync(createQuestionDto);
        //string[] includes = new string[] { "QuestionLevel" };
        var question = await _questionRepository.GetAsync(newQuestion.Id);
        var questionReposnse = _mapper.Map<QuestionDto>(question);
        return CreatedAtAction(nameof(GetQuestionById), new { id = newQuestion.Id }, questionReposnse);
    }
    
    //Get-Question-add-with-instructor
    [HttpGet]
    [Authorize(Roles = DefaultRoles.Instructor)]
    public async Task<IActionResult> GetQuestionById(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var questions = await _questionService.GetQuestionsForInstructor(userId!);
        //var question = await _questionRepository.GetAsync(id);

        return questions is null
              ? NotFound()
             : Ok(_mapper.Map<IEnumerable<QuestionDto>>(questions));
    }

    //Delete-Question
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.Instructor)]
    public async Task<IActionResult> DeleteQuestion([FromRoute] int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var isDeleted = await _questionService.DeleteQuestionsForSpecificInstructor(id,userId!);
        return !isDeleted
            ? NotFound()
            : NoContent();
    }
}