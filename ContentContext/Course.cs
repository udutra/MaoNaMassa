namespace MaoNaMassa.ContentContext
{
    public class Course: Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

        protected Course()
        {
            Modules = new List<Module>();
        }
    }
}