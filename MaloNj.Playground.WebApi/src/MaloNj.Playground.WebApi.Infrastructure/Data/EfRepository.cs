using Ardalis.Specification.EntityFrameworkCore;
using MaloNj.Playground.WebApi.SharedKernel.Interfaces;

namespace MaloNj.Playground.WebApi.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
