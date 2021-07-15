using MyMDB.Models;
using MyMDB.Data.EFCore;

namespace MyMDB.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyMDBContext>
    {
        public EfCoreStarRepository(MyMDBContext context) : base(context)
        {

        }
    }
}
