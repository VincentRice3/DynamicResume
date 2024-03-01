using DynamicResume.Models;
using DynamicResume.Utilities;

namespace DynamicResume.ViewModels
{
    public class EducationViewModel : IStringConverter
    {
        public List<Education> Educations { get; set; }

        public EducationViewModel(List<Education> educations) {
            Educations = educations;
        }

        public List<string> ConvertStringToList(string stringValue)
        {
            if(stringValue != null)
            {
                char delimiter = ',';
                return stringValue.Split(delimiter).ToList();
            }
            else
            {
                return new();
            }

        }
    }
}
