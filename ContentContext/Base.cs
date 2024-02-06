using MaoNaMassa.NotificationsContext;

namespace MaoNaMassa.ContentContext;

public abstract class Base:Notifiable 
{
    public Guid Id { get; set; } = Guid.NewGuid();
}