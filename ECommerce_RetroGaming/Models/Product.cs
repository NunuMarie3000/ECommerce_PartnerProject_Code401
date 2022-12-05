namespace ECommerce_RetroGaming.Areas.Admin.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string CategoryName { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public string Condition { get; set; }
    public string ImagePath { get; set; }
  }
}
