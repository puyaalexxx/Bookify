namespace Bookify.Domain.Apartments
{
    public interface IApartmentRepository
    {
        Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /*Task<IEnumerable<Apartment>> GetAllAsync(CancellationToken cancellationToken = default);
        void Add(Apartment apartment);
        void Update(Apartment apartment);
        void Delete(Apartment apartment);*/
    }
}
