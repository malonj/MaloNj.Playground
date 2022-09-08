using Ardalis.Result;
using MaloNj.Playground.WebApi.Core.ProjectAggregate;

namespace MaloNj.Playground.WebApi.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
