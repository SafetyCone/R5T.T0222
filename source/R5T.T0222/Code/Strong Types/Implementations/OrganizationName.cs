using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0222
{
    /// <inheritdoc cref="IOrganizationName"/>
    [StrongTypeImplementationMarker]
    public class OrganizationName : TypedBase<string>, IStrongTypeMarker,
        IOrganizationName
    {
        public OrganizationName(string value)
            : base(value)
        {
        }
    }
}