namespace ArmWrestlingApp.Models
{
    public class WorkoutEntry
    {
        public int Id { get; set; }
        public string Exercise { get; set; } = string.Empty;
        public int Reps { get; set; }
        public float Weight { get; set; }
    }
}

