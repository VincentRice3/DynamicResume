using DynamicResume.Models;
using DynamicResume.Utilities;

namespace DynamicResume.ViewModels
{
    public class ResumeViewModel : IStringConverter
    {

        public ResumeData Resume {  get; set; }

        public ResumeViewModel(ResumeData data)
        {
            if (data != null)
            {
                Resume =data;
            }
            else
            {
                throw new ArgumentNullException();
            }

        }


        public string[] GetSocialLinks(string links)
        {

            if (links.Contains("github"))
            {
                return ["Github", links];
            }
            else if (links.Contains("linkedin"))
            {
                return ["LinkedIn", links];
            }
            else if (links.Contains("mail"))
            {
                return ["Email Address", links];
            }
            else
            {
                return [];
            }

        }
        public List<string> ConvertStringToList(string stringValue)
        {
            char delimiter = stringValue.Contains("ASP") ? '/' : ',';
            return stringValue.Split(delimiter).ToList();
        }
    }
}
