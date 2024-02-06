namespace MaoNaMassa.ContentContext
{
    public abstract class Content
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }


        protected Content()
        {
            Id = Guid.NewGuid();
        }
    }
}