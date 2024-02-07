# eShopOnWeb Application Functionality Overview

## Introduction
The eShopOnWeb application serves as a sample ASP.NET Core reference application, powered by Microsoft, to demonstrate a monolithic application architecture and deployment model. It is designed as a learning tool for developers new to .NET development, focusing on ASP.NET Core and Azure.

## PublicApi Project
The PublicApi project is dedicated to handling the backend logic for managing catalog items within the eShopOnWeb application. It provides a set of endpoints for performing Create, Read, Update, and Delete (CRUD) operations on catalog items.

### CatalogItemEndpoints
- **CreateCatalogItemEndpoint**: Allows for the creation of new catalog items. 
  - Request: `CreateCatalogItemRequest`
  - Response: `CreateCatalogItemResponse`
- **CatalogItemGetByIdEndpoint**: Retrieves a catalog item by its ID.
  - Request: `GetByIdCatalogItemRequest`
  - Response: `GetByIdCatalogItemResponse`
- **CatalogItemListPagedEndpoint**: Lists catalog items with pagination support.
  - Request: `ListPagedCatalogItemRequest`
  - Response: `ListPagedCatalogItemResponse`
- **UpdateCatalogItemEndpoint**: Updates an existing catalog item.
  - Request: `UpdateCatalogItemRequest`
  - Response: `UpdateCatalogItemResponse`
- **DeleteCatalogItemEndpoint**: Deletes a catalog item by its ID.
  - Request: `DeleteCatalogItemRequest`
  - Response: `DeleteCatalogItemResponse`

## Web Project
The Web project is responsible for providing the user interface and handling user interactions. It includes functionalities for user management and data presentation.

### Identity
Located under the `Areas/Identity` directory, this section includes functionalities for user registration, login, logout, and account management. It ensures users can securely access their accounts and manage their information.

### ViewModels
The `ViewModels` directory contains a series of view models used across the Web project to display data and manage user inputs. These include:
- **LoginViewModel**: Manages user login information.
- **RegisterViewModel**: Handles new user registration data.
- **OrderViewModel**: Represents order details for display.
- **CatalogIndexViewModel**: Used for displaying catalog items with pagination.

## Conclusion
The eShopOnWeb application showcases key features of ASP.NET Core and Azure development, focusing on a monolithic architecture. It serves as an invaluable learning tool for developers looking to deepen their understanding of web application development in the .NET ecosystem.
