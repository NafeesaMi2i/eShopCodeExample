# Architecture Overview

The eShopOnWeb application is designed with a focus on modularity, maintainability, and scalability. It follows a layered architecture pattern, which allows for separation of concerns among different aspects of the application. Below is an overview of the architecture and the roles of each project within the application.

## ApplicationCore Project

The ApplicationCore project serves as the domain model and business logic layer of the eShopOnWeb application. It encapsulates the core functionality and is the heart of the application's operations. This project contains entities such as `Basket`, `Buyer`, `CatalogBrand`, `CatalogItem`, `CatalogType`, and `Order`, which represent the business objects. It also includes the business rules and validation logic that govern the application.

## BlazorAdmin Project

The BlazorAdmin project is an administrative interface designed for managing the application's catalog items. It provides a user-friendly web interface for administrators to create, read, update, and delete catalog items. This project interacts with the ApplicationCore through services such as `CatalogItemService` and `CatalogLookupDataService`, which abstract the operations on the domain model.

## BlazorShared Project

The BlazorShared project provides shared models, requests, and responses that are used by both the BlazorAdmin and Web projects. It contains definitions for models like `CatalogBrand`, `CatalogItem`, and `LookupData`, which are essential for the transfer of data between the client-side and server-side parts of the application. This project ensures consistency and reusability of the data contracts across the application.

## Web Project

The Web project is the primary user interface for customers of the eShopOnWeb application. It presents the catalog to the users and allows them to browse items, add them to the basket, and place orders. The Web project leverages the ApplicationCore to perform these operations and provides additional functionalities such as caching through `CacheHelpers` and email sending via `EmailSenderExtensions`.

## Conclusion

Each of these projects is modular and can be developed, tested, and deployed independently, which aligns with a microservices-oriented architecture. This modularity enables individual parts of the application to be updated without impacting others, facilitates scaling, and allows for flexible deployment strategies. While the application is not fully decomposed into microservices, the architecture provides a solid foundation for moving towards a microservices-oriented approach if desired.
