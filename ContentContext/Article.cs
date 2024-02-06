using MaoNaMassa.NotificationsContext;

namespace MaoNaMassa.ContentContext
{
    public class Article(string title, string url) : Content(title, url)
    {
        public IList<Notification> Notifications { get; set; }
    }
}