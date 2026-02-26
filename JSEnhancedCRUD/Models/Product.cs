using System.ComponentModel.DataAnnotations;

namespace JSEnhancedCRUD.Models;

/// <summary>
/// A product for sale
/// </summary>
public class Product
{
	/// <summary>
	/// A unique identifier for the product
	/// </summary>
	public int Id { get; set; }

	/// <summary>
	/// The customer facing name of the product
	/// </summary>
	[StringLength(30, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 30 characters.")]
	[RegularExpression("^(?=.*[a-zA-Z0-9 ])[a-zA-Z0-9]+$", ErrorMessage = "Name must be alphanumeric characters and spaces only.")]
	public required string Name { get; set; }

	/// <summary>
	/// The sales price in USD for the product
	/// </summary>
	public required decimal Price { get; set; }

}
