namespace Serious.Dtos
{
    /// <summary>
    /// A data transfer object that represents a role to client applications.
    /// </summary>
    public class RoleToCreateOrUpdateDto
    {
        /// <summary>
        /// The unique name of the role
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the role and its purpose within the application
        /// </summary>
        public string Description { get; set; }
    }
}
