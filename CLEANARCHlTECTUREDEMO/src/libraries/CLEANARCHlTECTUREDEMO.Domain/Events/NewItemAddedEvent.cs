using Ardalis.SharedKernel;
using CLEANARCHlTECTUREDEMO.Domain.Entities;

namespace CLEANARCHlTECTUREDEMO.Domain.Events;

public class NewItemAddedEvent : DomainEventBase
{
    public ToDoItem NewItem { get; set; }
    public Project Project { get; set; }

    public NewItemAddedEvent(Project project,
        ToDoItem newItem)
    {
        Project = project;
        NewItem = newItem;
    }
}
