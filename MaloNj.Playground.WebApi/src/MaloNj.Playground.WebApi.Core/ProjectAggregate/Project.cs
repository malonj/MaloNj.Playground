using Ardalis.GuardClauses;
using MaloNj.Playground.WebApi.Core.ProjectAggregate.Events;
using MaloNj.Playground.WebApi.SharedKernel;
using MaloNj.Playground.WebApi.SharedKernel.Interfaces;

namespace MaloNj.Playground.WebApi.Core.ProjectAggregate;

public class Project : EntityBase, IAggregateRoot
{
  public string Name { get; private set; }

  private List<ToDoItem> _items = new List<ToDoItem>();
  public IEnumerable<ToDoItem> Items => _items.AsReadOnly();
  public ProjectStatus Status => _items.All(i => i.IsDone) ? ProjectStatus.Complete : ProjectStatus.InProgress;

  public PriorityStatus Priority { get; }

  public Project(string name, PriorityStatus priority)
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
    Priority = priority;
  }

  public void AddItem(ToDoItem newItem)
  {
    Guard.Against.Null(newItem, nameof(newItem));
    _items.Add(newItem);

    var newItemAddedEvent = new NewItemAddedEvent(this, newItem);
    base.RegisterDomainEvent(newItemAddedEvent);
  }

  public void UpdateName(string newName)
  {
    Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }
}
