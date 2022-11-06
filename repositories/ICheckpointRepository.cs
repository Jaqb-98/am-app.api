using Api.Model;

namespace Api.Repository;

public interface ICheckpointRepository{
	Task<Checkpoint> GetRandomCheckpoint();
	Task<Checkpoint> CreateRandomCheckpoint(double lat, double lng);
}