namespace DynamicResume.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string User { get; set; }


        public string Title { get; set; }

        public string Establishment { get; set; }

        public string Attended { get; set; }

        public string? AwardedGrade { get; set; }

        public string? RelevantCourses { get; set; }

        public string? EduInfo { get; set; }

        public Education(string user, string title, string establishment, string attended, string? awardedGrade, string? relevantCourses, string? eduInfo)
        {
            User = user;
            Title = title;
            Establishment = establishment;
            Attended = attended;
            AwardedGrade = awardedGrade;
            RelevantCourses = relevantCourses;
            EduInfo = eduInfo;
        }

    }




}

