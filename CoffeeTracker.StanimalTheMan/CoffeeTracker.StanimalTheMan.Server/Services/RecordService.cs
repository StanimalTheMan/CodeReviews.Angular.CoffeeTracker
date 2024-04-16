using CoffeeTracker.StanimalTheMan.Server.Models;
using CoffeeTracker.StanimalTheMan.Server.Repositories;

namespace CoffeeTracker.StanimalTheMan.Server.Services;

public class RecordService : IRecordService
{
	private readonly IRecordRepository _recordRepository;

	public RecordService(IRecordRepository recordRepository)
	{
		_recordRepository = recordRepository;
	}
	public async Task AddRecordAsync(Record record)
	{
		await _recordRepository.AddRecordAsync(record);
	}

	public async Task<IEnumerable<Record>> GetAllRecordsAsync()
	{
		return await _recordRepository.GetAllRecordsAsync();
	}

	public async Task<Record> GetRecordByIdAsync(int id)
	{
		return await _recordRepository.GetRecordByIdAsync(id);
	}
}
