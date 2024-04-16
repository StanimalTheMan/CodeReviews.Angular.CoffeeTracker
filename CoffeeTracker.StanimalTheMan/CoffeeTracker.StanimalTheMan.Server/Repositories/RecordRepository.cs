using CoffeeTracker.StanimalTheMan.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTracker.StanimalTheMan.Server.Repositories
{
	public class RecordRepository : IRecordRepository
	{
		private readonly RecordDbContext _context;

		public RecordRepository(RecordDbContext context)
		{
			_context = context;
		}

		public async Task AddRecordAsync(Record record)
		{
			await _context.Records.AddAsync(record);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Record>> GetAllRecordsAsync()
		{
			return await _context.Records.ToListAsync();
		}

		public async Task<Record> GetRecordByIdAsync(int id)
		{
			return await _context.Records.FindAsync(id);
		}
	}
}
