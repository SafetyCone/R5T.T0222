using System;


namespace R5T.T0222.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToOrganizationName(string)"/>
        public static IOrganizationName ToOrganizationName(this string value)
        {
            return Instances.StringOperator_Extensions.ToOrganizationName(value);
        }
    }
}
