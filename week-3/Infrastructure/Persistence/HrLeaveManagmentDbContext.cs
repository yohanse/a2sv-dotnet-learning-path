using System.Security.Cryptography.X509Certificates;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class HrLeaveManagmentDbContext : DbContext
{
    public HrLeaveManagmentDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrLeaveManagmentDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach(var entry in ChangeTracker.Entries<BaseEntity>()) {
            entry.Entity.LastModifiedDate = DateTime.Now;
            if (entry.State == EntityState.Added) {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveType> LeaveTypes {get; set;}
    public DbSet<LeaveAllocation> LeaveAllocations {get; set;}
}
