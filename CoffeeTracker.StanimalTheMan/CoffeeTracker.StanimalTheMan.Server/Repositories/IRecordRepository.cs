using CoffeeTracker.StanimalTheMan.Server.Models;

namespace CoffeeTracker.StanimalTheMan.Server.Repositories;

public interface IRecordRepository
{
	Task AddRecordAsync(Record record);
	Task<Record> GetRecordByIdAsync(int id);
	Task<IEnumerable<Record>> GetAllRecordsAsync();
}
