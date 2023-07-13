using CQRS.Core.Events;
using System;

namespace CQRS.Core.Domain
{
    public abstract class AggregateRoot
    {
        protected Guid _id;
        
        private readonly List<BaseEvent> _changes = new();
        
        public Guid Id
        {
            get { return _id; }
        }

        public int Version { get; set; } = -1;
    }
}