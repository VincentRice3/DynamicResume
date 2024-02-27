using DynamicResume.Models;
using DynamicResume.Utilities;
using Microsoft.IdentityModel.Tokens;

namespace DynamicResume.ViewModels
{
    public class EmploymentHistoryViewModel(List<EmploymentHistory> employments)
    {
        public List<EmploymentHistory> ListOfEmployments { get; set; } = employments;

        public List<string> ConvertStringToList(string stringValue)
        {
            char delimiter = '/';
            return stringValue.Split(delimiter).ToList();
        }
    }
}

