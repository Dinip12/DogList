using WebApplication1.Models;
using DogList.Data;

namespace WebApplication1.Repository
{
    public class DogList
    {
        private readonly ApplicationDbContext db;
        public DogList()
        {
            db = new ApplicationDbContext();
        }
    }
}
