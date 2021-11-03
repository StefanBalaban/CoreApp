# CoreApp
API app based on eShopOnWeb Clean Architecture Example with several key modifications to the architecute and including a code generator for creation of new API Endpoints for entity models used in the app.
# Usage
To generate an endpoint, add a model in the entities directory, populate it with properties and add attributes for Get, Put, or Create. Get requires parameters which signify the filters that it can be called with in the List endpoint. The Dto attribute signifies that the entities DTO object will contain that property.
After doing so add the entities path in the Generator project and run the console app. It will return the generated code as result.
Paste the code into the direcotires that are indicated by the comments inside the generated code.
## Data
To generate migrations and update the database run this command from the Infrastructure project `dotnet ef migrations add init -c AppContext --startup-project ..\PublicApi\`.
## Repository Searches
Using the Specification derivate class you can query the repository instance of each entity.
## Entity Insertion and Updates
n the Post and Put methods of the service classes you should create an object and assign properties that are allowed for these two operations. Alternatively use the constructor and setter methods on the entities themselves.
