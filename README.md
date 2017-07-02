# BookExercise
A small application to handle books in a library. 
# Application features
### Consumer features
      Manage categories (create/update/view)
      Manage authors (create/update/view)
      Manage book(create/update/view)
### Admin features
      Manage categories (create/update/view/delete)
      Manage authors (create/update/view/delete)
      Manage book(create/update/view/delete)
# Implementation
  - Technologies used: .NET Framework 4.5.2, MSSQL Server 2014, Entity Framework 6.1.3 with Database code first, Repository generic pattern
  - MS SQLServer used for storing and managing data.
# Struct of source code
  The solution include 4 projects
  1. BookStoreScreen project include GUI of book store
  2. BookStoreBusiness project include business logic of create/update/view/delete book, author, category
  3. BookStoreEntity project include Model, method connect Database
  4. Utilities project include comons logic of solution
# User guide
  1. Use files in SQL.zip to create Database
  2. Username and password information
  <br/> 2.1. User role admin
  - Username: Admin
  - Password: 123
  - Role: Admin
 <br/> 2.2. User role user
  - Username: User
  - Password: 321
  - Role: User
