using Ardalis.Specification.EntityFrameworkCore;
using DotNetConf._2022Edition.SharedKernel.Interfaces;

namespace DotNetConf._2022Edition.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
