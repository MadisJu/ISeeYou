namespace ISeeYou.Data
{
    public interface IAudit
    {
        DateTime CreatedAtUtc { get; set; }
        DateTime? UpdatedAtUtc { get; set; }
        Guid? ModificationBy { get; set; }
    }
}
