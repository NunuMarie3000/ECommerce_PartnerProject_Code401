namespace ECommerce_RetroGaming.Areas.Admin.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public List<CategoryProduct>? CategoryProducts { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
  }
}
