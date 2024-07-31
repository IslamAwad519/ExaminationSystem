using ExaminationSystem.DTOs.Choices;
using ExaminationSystem.DTOs.Questions;
using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Core.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //Course
        CreateMap<Course, CourseResponse>();
        CreateMap<CourseRequest, Course>();


        //from database to front
        CreateMap<Question, QuestionDto>()
             .ForMember(dest => dest.QuestionLevel, opt => opt.MapFrom(src => src.QuestionLevel.ToString())); // Map enum to string

        //from front to database
        CreateMap<QuestionDto, Question>()
            .ForMember(dest => dest.QuestionLevel, opt => opt.MapFrom(src => Enum.Parse<QuestionLevel>(src.QuestionLevel))); // Map string to enum

        CreateMap<Choice,ChoiceDto>().ReverseMap();
    }
}
