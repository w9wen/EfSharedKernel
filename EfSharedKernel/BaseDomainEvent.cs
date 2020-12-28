using MediatR;
using System;

namespace w9wen.EfSharedKernel
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTime DateOccurred { get; protected private set; } = DateTime.UtcNow;
    }
}