using DynamicResume.Models;

namespace DynamicResume.ViewModels
{
    public class DevelopmentProjectsViewModel(List<DevelopmentProjects> projects)
    {
        public List<DevelopmentProjects> DevelopmentProjects { get; set; } = projects;
    }
}
