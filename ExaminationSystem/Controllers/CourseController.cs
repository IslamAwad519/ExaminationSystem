using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ExaminationSystem.Controllers;


[Route("api/[controller]")]
[ApiController]
////[ApiExplorerSettings(IgnoreApi = true)]
//[Authorize]
public class CourseController : ControllerBase
{
    private readonly IBaseRepository<Course> _courseRepository;
    private readonly ICourseService _courseService;
    private readonly IMapper _mapper;

    public CourseController(IBaseRepository<Course> courseRepository, IMapper mapper, ICourseService courseService)
    {
        _courseRepository = courseRepository;
        _mapper = mapper;
        _courseService = courseService;
    }
    
    // Get-Instructor_Course
    [HttpGet("get-instructor-courses")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(CourseResponse), StatusCodes.Status200OK)]
    [Authorize(Roles = DefaultRoles.Instructor)]
    public async Task<ActionResult<CourseResponse>> GetCourse()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if(userId is null) 
            return Unauthorized();
        var courses = await _courseService.GetCourseForInstructor(userId!);

        return courses is null
            ? NotFound()
            : Ok(_mapper.Map<IEnumerable<CourseResponse>>(courses));
    }
    
    //Enroll-Student
    [HttpPost("enroll")]
    public async Task<IActionResult> EnrollStudentInCourses([FromBody] EnrollmentRequest request)
    {
        try
        {
            await _courseService.EnrollStudentInCourse(request.StudentId, request.CourseIds);
            return Ok(new { message = "Student enrolled in courses successfully" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost]
    [ProducesResponseType(typeof(CourseResponse), StatusCodes.Status201Created)]
    [Authorize(Roles = DefaultRoles.Instructor)]
    public async Task<ActionResult>  AddCourse([FromBody]CourseRequest request)
    {
        var newCourse = await _courseRepository.AddAsync(_mapper.Map<Course>(request));
        var course = await _courseRepository.GetAsync(newCourse.Id);
        var courseResponse = _mapper.Map<CourseResponse>(course);
        return CreatedAtAction(nameof(GetCourse),new {id = newCourse.Id }, courseResponse);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateCourse([FromRoute] int id, [FromBody] CourseRequest request)
    {
        var isUpdated = await _courseRepository.UpdateAsync(id, _mapper.Map<Course>(request));
        var course = await _courseRepository.GetAsync(id);
        return !isUpdated
            ? NotFound()
            : NoContent();
    }
    
    //Delete-Course
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCourse([FromRoute] int id)
    {
        var isDeleted = await _courseRepository.RemoveAsync(id);
        return !isDeleted
            ? NotFound()
            : NoContent();
    }
}
