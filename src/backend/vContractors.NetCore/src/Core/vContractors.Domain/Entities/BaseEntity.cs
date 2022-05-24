namespace vContractors.Domain.Entities;

public abstract class BaseEntity
{
    public virtual Guid Id { get; protected set; }
}
