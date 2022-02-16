using AutoMapper;
using CollegeProjectData;
using CollegeProjectModels.Models;

namespace CollegeProjectAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, Students>().ReverseMap()
                .ForMember(x => x.id, y => y.MapFrom(y => y.Sid))
                .ForMember(x => x.name, y => y.MapFrom(y => y.Sname))
                .ForMember(x => x.department, y => y.MapFrom(y => y.Sdepartment))
                .ForMember(x => x.age, y => y.MapFrom(y => y.Sage))
                .ForMember(x => x.joiningDate, y => y.MapFrom(y => y.SjoiningDate));



          /*      id { get; set; }
        public string name { get; set; }

        public string department { get; set; }
        public int age { get; set; }

        public DateTime joiningDate*/
        }

    }
}
