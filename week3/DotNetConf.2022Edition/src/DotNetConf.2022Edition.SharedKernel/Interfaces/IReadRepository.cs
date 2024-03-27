using Ardalis.Specification;

namespace DotNetConf._2022Edition.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
