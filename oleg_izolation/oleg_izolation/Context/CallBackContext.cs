using System.Data.Entity;
using oleg_izolation.Models;

namespace oleg_izolation.Context
{
    public class CallBackContext: DbContext
    {
        public CallBackContext() : base("DbConnection") { }
        public DbSet<CallBackModel> CallBackModels { get; set; }
    }
}