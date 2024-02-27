using DynamicResume.Utilities;
using Microsoft.IdentityModel.Tokens;

namespace DynamicResume.Models
{
    public class EmploymentHistory
    {
        public int Id { get; set; }

        public string User { get; set; }

        public string JobTitle { get; set; }

        public string Company { get; set; }

        public string EmploymentDuration { get; set; }

        public string Responsibilities { get; set; }

        public string? ManagerName { get; set; }

        public string? ManagerEmail { get; set; }

        public EmploymentHistory(string user, string jobTitle, string company, string employmentDuration, string responsibilities, string managerName, string managerEmail)
        {
            User = user;
            JobTitle = jobTitle;
            Company = company;
            EmploymentDuration = employmentDuration;
            Responsibilities = responsibilities;
            ManagerName = managerName;
            ManagerEmail = CheckFieldIsEmpty(managerEmail);
        }

        private string? CheckFieldIsEmpty(string? managerName)
        {
            string? managerDetails = managerName.IsNullOrEmpty() ? "Please get in touch for reference information" : managerName;

            return managerDetails;

        }


    }
}
