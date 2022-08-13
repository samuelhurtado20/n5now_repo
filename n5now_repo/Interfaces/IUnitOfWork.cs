namespace n5now_repo.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IEnterpriseRepository Enterprise { get; }
        void Save();
    }
}
