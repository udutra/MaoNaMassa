namespace MaoNaMassa.ContentContext
{
    public class Career: Content
    {
        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;

        public Career()
        {
            Items = new List<CareerItem>();
        }
        
    }
}