using Api;
using Api.Model;
using Api.Repository;

namespace Api.Repository
{
    public class CheckpointRepository : ICheckpointRepository
    {
        private readonly ApplicationDbContext _context;

        public CheckpointRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public Task<Checkpoint> GetRandomCheckpoint()
        {
            return Task
                .Run(() =>
                {
                    return _context
                        .Checkpoints
                        .OrderBy(r => Guid.NewGuid())
                        .First();
                });
        }

        public Task<Checkpoint> CreateRandomCheckpoint(double lat, double lng)
        {
            return Task
                .Run(() =>
                {
                    return new Checkpoint() { Lat = lat, Lng = lng };
                });
        }
    }
}
