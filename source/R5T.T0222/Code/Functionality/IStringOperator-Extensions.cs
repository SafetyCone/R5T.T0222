using System;

using R5T.T0132;


namespace R5T.T0222.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IOrganizationName"/>
        public IOrganizationName ToOrganizationName(string value)
        {
            var output = new OrganizationName(value);
            return output;
        }
    }
}
