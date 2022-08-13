using n5now_repo.Data;
using n5now_repo.Interfaces;

namespace n5now_repo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        //public IEnterpriseRepository Enterprise { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            //Enterprise = new EnterpriseRepository(_db);
        }

        public void Save() => _db.SaveChanges();

        public void Dispose() => _db.Dispose();
    }
}
