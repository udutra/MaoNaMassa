using MaoNaMassa.NotificationsContext;

namespace MaoNaMassa.SharedContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; } = Guid.NewGuid();
}