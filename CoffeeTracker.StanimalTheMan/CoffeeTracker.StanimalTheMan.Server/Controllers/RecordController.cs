using CoffeeTracker.StanimalTheMan.Server.Models;
using CoffeeTracker.StanimalTheMan.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTracker.StanimalTheMan.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecordController : Controller
{
	private readonly IRecordService _recordService;

	public RecordController(IRecordService recordService)
	{
		_recordService = recordService;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Record>>> GetRecords()
	{
		try
		{
			var records = await _recordService.GetAllRecordsAsync();
			return Ok(records);
		}
		catch (Exception ex)
		{
			return StatusCode(500, $"Internal server error: {ex.Message}");
		}
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Record>> GetRecordById(int id)
	{
		try
		{
			var record = await _recordService.GetRecordByIdAsync(id);
			if (record == null)
			{
				return NotFound();
			}

			return Ok(record);
		}
		catch (Exception ex)
		{
			return StatusCode(500, $"Internal server error: {ex.Message}");
		}
	}

	[HttpPost]
	public async Task<ActionResult<Record>> AddRecord(Record record)
	{
		try
		{
			await _recordService.AddRecordAsync(record);
			return CreatedAtAction(nameof(GetRecordById), new { id = record.Id }, record);
		}
		catch (Exception ex)
		{
			return StatusCode(500, $"Internal server error: {ex.Message}");
		}
	}
}
