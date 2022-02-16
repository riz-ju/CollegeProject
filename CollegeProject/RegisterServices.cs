

using CollegeProjectRepository.Interface;
using CollegeProjectRepository.Repository;
using CollegeProjectServices.Interface;
using CollegeProjectServices.Service;

namespace CollegeProjectAPI
{
    public static class SeriveRegisterExtention
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {

            services.AddSingleton<IStudentService, StudentService>();
            services.AddSingleton<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
