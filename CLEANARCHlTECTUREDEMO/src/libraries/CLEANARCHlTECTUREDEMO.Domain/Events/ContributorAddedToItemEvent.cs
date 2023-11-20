using Ardalis.SharedKernel;
using CLEANARCHlTECTUREDEMO.Domain.Entities;

namespace CLEANARCHlTECTUREDEMO.Domain.Events;

public class ContributorAddedToItemEvent : DomainEventBase
{
    public int ContributorId { get; set; }
    public ToDoItem Item { get; set; }

    public ContributorAddedToItemEvent(ToDoItem item, int contributorId)
    {
        Item = item;
        ContributorId = contributorId;
    }
}
