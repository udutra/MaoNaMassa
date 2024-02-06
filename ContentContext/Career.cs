namespace MaoNaMassa.ContentContext
{
    public class Career(string title, string url) : Content(title, url)
    {
        public IList<CareerItem> Items { get; set; } = new List<CareerItem>();

        public int TotalCourses => Items.Count;
    }
}