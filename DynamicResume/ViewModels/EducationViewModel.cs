using DynamicResume.Models;

namespace DynamicResume.ViewModels
{
    public class EducationViewModel
    {
        public List<Education> Educations { get; set; }

        public EducationViewModel(List<Education> educations) {
            Educations = educations;
        }
    }
}
