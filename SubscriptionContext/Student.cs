﻿using MaoNaMassa.NotificationsContext;
using MaoNaMassa.SharedContext;

namespace MaoNaMassa.SubscriptionContext;

public class Student() : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);


    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "O Aluno ja tem uma assinatura ativa!"));
            return;
            
        }
        Subscriptions.Add(subscription);
    }
}