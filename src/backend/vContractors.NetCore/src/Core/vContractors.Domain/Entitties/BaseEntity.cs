namespace vContractors.Domain.Entitties;

public abstract class BaseEntity
{
    public virtual Guid Id { get; protected set; }
}
