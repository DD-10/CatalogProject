using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using Catalog.Dtos;
namespace Catalog.Controllers{
    
    
    //Get /items
    //Could add [controller] to make it the default class controller route
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        //Could be improved by not using explicit dependency. 
        private readonly IItemsRepository repository;
        
        public ItemsController(IItemsRepository repository){
            this.repository = repository;
        }

        //This is used to make the reaction happen when user types GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
           var items = repository.GetItems().Select(item => item.AsDto());
           return items;
        }

        //We need to specify a template for the route, in this case is the id 
        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id){
            var item = repository.GetItem(id);
            if (item is null)
                return NotFound();
            return item.AsDto();
        }
    }
}