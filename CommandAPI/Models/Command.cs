namespace CommandAPI.Models
{
    public class Command
    {
        //Comment set after pulling azure-pipelines.yaml

        public int Id { get; set; }
        public string HowTo { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string CommandLine { get; set; } = string.Empty;
    }
}

