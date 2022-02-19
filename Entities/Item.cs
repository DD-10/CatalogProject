
namespace Catalog.Entities{
    public record Item
    {
        //init property just allows value in initialization
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset  CreatedDate { get; set; }      
    }
}