using MaoNaMassa.ContentContext.Enums;

namespace MaoNaMassa.ContentContext
{
    public class Course(string title, string url, string tag, int durationInMinutes, EContentLevel level)
        : Content(title, url)
    {
        public string Tag { get; set; } = tag;
        public IList<Module> Modules { get; set; } = new List<Module>();

        public int DurationInMinutes { get; set; } = durationInMinutes;

        public EContentLevel Level { get; set; } = level;
    }
}