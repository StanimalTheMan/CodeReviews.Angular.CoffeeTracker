using CoffeeTracker.StanimalTheMan.Server.Models;

namespace CoffeeTracker.StanimalTheMan.Server.Services;

public interface IRecordService
{
	Task AddRecordAsync(Record record);
	Task<IEnumerable<Record>> GetAllRecordsAsync();
	Task<Record> GetRecordByIdAsync(int id);
}
