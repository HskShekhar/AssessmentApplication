namespace AssessmentApplication.Models
{
    public class Project : BaseModel
    {
        public string Title { get; set; }

        public double Duration { get; set; }

        public double Cost { get; set; }
    }
}
