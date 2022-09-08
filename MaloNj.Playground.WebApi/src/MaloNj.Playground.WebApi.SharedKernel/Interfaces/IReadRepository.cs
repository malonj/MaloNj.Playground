using Ardalis.Specification;

namespace MaloNj.Playground.WebApi.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
