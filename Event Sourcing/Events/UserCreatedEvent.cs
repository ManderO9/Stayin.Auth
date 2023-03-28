﻿namespace Stayin.Auth;

public class UserCreatedEvent : BaseEvent
{
    public required string UserId { get; set; }

    public Task Handle(ApplicationDbContext db)
    {
        Console.WriteLine("User created: Id: " + UserId);
        return Task.CompletedTask;
    }
}