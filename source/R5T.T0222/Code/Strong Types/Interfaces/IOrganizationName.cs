using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0222
{
    /// <summary>
    /// Strongly-types a string as the name of an organization.
    /// </summary>
    [StrongTypeMarker]
    public interface IOrganizationName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}