namespace Bookify.Domain.Abstractions
{
    public abstract class Entity
    {
        //init - once defined, it is set for life and cannot be changed
        public Guid Id { get; init; }

        private readonly List<IDomainEvent> _domainEvents = new();

        protected Entity(Guid id)
        {
            Id = id;
        }

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            if (domainEvent == null)
            {
                throw new ArgumentNullException(nameof(domainEvent), "Domain event cannot be null.");
            }

            _domainEvents.Add(domainEvent);
        }

    }
}
