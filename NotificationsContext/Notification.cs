﻿namespace MaoNaMassa.NotificationsContext;

public sealed class Notification
{
    public string Property { get; set; }
    public string Message { get; set; }

    public Notification()
    {
        
    }
    
    public Notification(string property, string message)
    {
        Property = property;
        Message = message;
    }
}