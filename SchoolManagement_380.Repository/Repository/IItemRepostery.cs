using SchoolManagement_380.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface IItemRepostery
    {
        IEnumerable<Items> GetItems();
    }
}
