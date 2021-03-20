namespace Serious.Dtos
{
    /// <summary>
    /// A data transfer object that represents a user to client applications.
    /// </summary>
    public class RegistrationDto
    {
        /// <summary>
        /// The primary email address of the user
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The new user's chosen password
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Repeat the new user's chosen password to ensure it was typed correctly
        /// </summary>
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
