using System.Collections.Generic;

namespace Serious.Dtos
{
    /// <summary>
    /// A data transfer object that represents a user to client applications.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// The unique identifier of the user
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The unique name of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The primary email address of the user
        /// </summary>
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// Secondary email addresses of the user
        /// </summary>
        public IEnumerable<string> AlternativeEmails { get; set; }

        /// <summary>
        /// The given name of the user
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// The family name of the user
        /// </summary>
        public string FamilyName { get; set; }
    }
}
