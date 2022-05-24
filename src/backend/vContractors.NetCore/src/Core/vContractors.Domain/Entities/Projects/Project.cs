namespace vContractors.Domain.Entities.Projects;

public class Project : BaseEntity
{
    public string Title { get; set; }
    public string Location { get; set; }
    public decimal Area { get; set; }
    public string Type { get; set; }
}
