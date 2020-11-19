#nullable enable
using System;
using System.ComponentModel.DataAnnotations;

namespace Netopes.Blazor.UI.Components.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class RequiredGuidValidationAttribute : ValidationAttribute
    {
        /// <summary>
        ///     Protected virtual method to override and implement validation logic.
        ///     <para>
        ///         Derived classes should override this method instead of <see cref="IsValid(object)" />, which is deprecated.
        ///     </para>
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">
        ///     A <see cref="ValidationContext" /> instance that provides
        ///     context about the validation operation, such as the object and member being validated.
        /// </param>
        /// <returns>
        ///     When validation is valid, <see cref="ValidationResult.Success" />.
        ///     <para>
        ///         When validation is invalid, an instance of <see cref="ValidationResult" />.
        ///     </para>
        /// </returns>
        /// <exception cref="InvalidOperationException"> is thrown if the current attribute is malformed.</exception>
        /// <exception cref="NotImplementedException">
        ///     is thrown when <see cref="IsValid(object, ValidationContext)" />
        ///     has not been implemented by a derived class.
        /// </exception>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var result = ValidationResult.Success;

            // call overridden method.
            if (!(value is Guid guid) || guid == Guid.Empty)
            {
                string[]? memberNames = validationContext.MemberName is { } memberName
                    ? new[] { memberName }
                    : null;
                result = new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
            }

            return result;
        }
    }
}