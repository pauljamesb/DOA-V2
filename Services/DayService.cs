// Using here

namespace DOA.Services
{
    
    public class DayService : IDayService
    {
    
            private readonly ApplicationDbContext _db;
            public DayService(ApplicationDbContext db) 
            {
                    _db = db;
            }
    
    
            Task<Day[]> DisplayAllDaysAsync()
            {
                    var items = await _db.AllDaysFromDbContext
                    .ToArrayAsync();
                    return items;   
            }
    
    }
    
}


