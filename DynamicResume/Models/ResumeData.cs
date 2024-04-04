namespace DynamicResume.Models
{
    public class ResumeData
    {
        public int Id { get; set; }
        public string User { get; set; }
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
    }
}


