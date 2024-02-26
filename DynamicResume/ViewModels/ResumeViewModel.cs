using DynamicResume.Models;
using DynamicResume.Utilities;

namespace DynamicResume.ViewModels
{
    public class ResumeViewModel : IStringConverter
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public string MobileNum { get; set; }

        public string SocialLinks { get; set; }

        public string PersonalStatement { get; set; }

        public List<Education> Education { get; set; }

        public string KeySkills { get; set; }

        public List<DevelopmentProjects> DevelopmentProjects { get; set; }

        public List<EmploymentHistory> EmploymentHistory { get; set; }

        public string Hobbies { get; set; }


        public ResumeViewModel(ResumeData data)
        {
            if (data != null)
            {
                Name = data.Name;
                Title = data.Title;
                Address = data.Address;
                MobileNum = data.MobileNum;
                SocialLinks = data.SocialLinks;
                PersonalStatement = data.PersonalStatement;
                Education = data.Education;
                KeySkills = data.KeySkills;
                DevelopmentProjects = data.DevelopmentProjects;
                EmploymentHistory = data.EmploymentHistory;
                Hobbies = data.Hobbies;
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
