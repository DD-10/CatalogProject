using Catalog.Entities;

namespace Catalog.Repositories
{
    public class SqlDbItemsRepository : IItemsRepository
    {

        private const string databaseName = "Catalog";
        public SqlDbItemsRepository(){
            
        }

        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}