using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Services
{
    public class ItemService : IItemRepostery
    {
        Sandhya_380Entities9 _dbTest = new Sandhya_380Entities9();
        public IEnumerable<Items> GetItems()
        {
            return _dbTest.Items.ToList();
        }
    }
}
