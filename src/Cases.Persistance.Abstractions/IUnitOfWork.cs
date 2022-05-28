namespace Cases.Persistance.Abstractions
{
    /// <summary>
    /// Handles unit of work operations
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Saves changes to the store in given scope
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
