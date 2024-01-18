namespace Microsoft.eShopWeb.ApplicationCore.Entities;\r\n\r\n/// <summary>\r\n/// Represents a base entity class for other entities.\r\n/// </summary>

// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
// Using non-generic integer types for simplicity and to ease caching logic
/// <summary>\r\n/// Represents a base entity with an integer Id.\r\n/// </summary>\r\npublic abstract class BaseEntity
{
    /// <summary>\r\n/// Gets or sets the unique identifier of the entity.\r\n/// </summary>\r\npublic virtual int Id { get; protected set; }
}
