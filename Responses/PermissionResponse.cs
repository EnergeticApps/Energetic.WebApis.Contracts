namespace Energetic.WebApis.Contracts.Responses
{
    /// <summary>
    /// A data transfer object that represents a permission to client applications.
    /// </summary>
    public class PermissionResponse
    {
        public PermissionResponse(long id, string name, string? category, string? description, string? module)
        {
            Id = id;
            Name = name;
            Category = category;
            Description = description;
            Module = module;
        }

        /// <summary>
        /// The unique identifier of the permission
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The unique name of the permission
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A category used to Group permissions in the UI
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// A description of the permission and its purpose within the application
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The name of the module to which this permission pertains, or blank if this permission is relevant app-wide.
        /// </summary>
        public string? Module { get; set; }
    }
}
