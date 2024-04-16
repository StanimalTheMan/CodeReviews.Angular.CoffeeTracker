using System.ComponentModel.DataAnnotations;

namespace CoffeeTracker.StanimalTheMan.Server.Models;

public class Record
{
	public int Id { get; set; }

	[Required(ErrorMessage = "Name of coffee drink is required")]
	[StringLength(50)]
	public string Name { get; set; }

	[Required(ErrorMessage = "Date is required.")]
	public DateTime Date { get; set; }

	[Required(ErrorMessage = "Amount of caffiene in mg is required")]
	public int CaffeineAmountInMg { get; set; }
}
