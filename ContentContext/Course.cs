using MaoNaMassa.ContentContext.Enums;

namespace MaoNaMassa.ContentContext
{
    public class Course(string title, string url)
        : Content(title, url)
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; } = new List<Module>();

        public int DurationInMinutes { get; set; } 

        public EContentLevel Level { get; set; } 
    }
}