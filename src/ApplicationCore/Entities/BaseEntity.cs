namespace Microsoft.eShopWeb.ApplicationCore.Entities;\r\n\r\n/// <summary>\r\n/// Represents a base entity class for other entities.\r\n/// </summary>

/// <summary>
/// Represents a base entity with an integer Id.
/// </summary>
/// <remarks>
/// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
/// </remarks>
// Using non-generic integer types for simplicity and to ease caching logic
/// <summary>\r\n/// Represents a base entity with an integer Id.\r\n/// </summary>\r\n/// <summary>
/// Represents a base entity with an integer Id.
/// </summary>
/// <summary>
/// Represents a base entity with an integer Id.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>\r\n/// Gets or sets the unique identifier of the entity.\r\n/// </summary>\r\n/// <summary>
/// Gets or sets the unique identifier of the entity.
/// </summary>
/// <summary>
/// Gets or sets the unique identifier of the entity.
/// </summary>
public virtual int Id { get; protected set; }
}
