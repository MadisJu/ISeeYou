namespace ISeeYou.Data.Extensions
{
    public static class IAuditExtensions
    {
        public static void SetCreated(this IAudit audit, Guid? userId = null)
        {
            audit.CreatedAtUtc = DateTime.UtcNow;
            audit.ModificationBy = userId;
        }
        public static void SetUpdated(this IAudit audit, Guid? userId = null)
        {
            audit.UpdatedAtUtc = DateTime.UtcNow;
            audit.ModificationBy = userId;
        }
    }
}
