namespace DynamicResume.Models
{
    public class DevelopmentProjects
    {
        public int Id { get; set; }

        public string User {  get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DevelopmentProjects(string user, string title, string description) {
            User = user;
            Title = title;
            Description = description;

        }

    }

}
