using System;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public class DatabaseController : IDatabaseController
    {
        private AppDbContext context;
        public IJobRepository jobRepository { get; set; }
        public IScheduleRepository scheduleRepository { get; set; }
        public IPathRepository pathRepository { get; set; }
        public DatabaseController(string connectionString)
        {
            context = new AppDbContext(connectionString);
            jobRepository = new JobRepository(context);
            scheduleRepository = new ScheduleRepository(context);
            pathRepository = new PathRepository(context);
        }

        public async Task Complete()
        {
            await context.SaveChangesAsync();
        }

        public void Initialize()
        {
                context.Database.Initialize(false);
        }
    }
}
