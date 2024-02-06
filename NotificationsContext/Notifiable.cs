namespace MaoNaMassa.NotificationsContext;

public abstract class Notifiable
{
    public List<Notification> Notifications { get; set; } = new();
    public bool IsInvalid => Notifications.Count != 0;

    public void AddNotification(Notification notification)
    {
        Notifications.Add(notification);
    }
    
    public void AddNotifications(IEnumerable<Notification> notifications)
    {
        Notifications.AddRange(notifications);
    }
    
    
}