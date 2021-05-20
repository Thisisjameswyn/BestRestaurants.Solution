namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    // public string Description { get; set; }
    // public int Price { get; set; }
    // public int Score { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    // public virtual Cuisine CuisineTag { get; set; }
  }
}