# Asp.Net Identity Sample

The ASP.NET Membership System was introduced with ASP.NET 2.0 back in 2005. Since then there have been lots of changes. ASP.Net membership system is a fresh look at what the membership system should be when you are developing modern applications for web, phone or tablet.

## Background: Membership in ASP.Net

### ASP.Net Membership

Asp.Net membership system was designed to solve membership requirements that were common in 2005. Which was involved Forms Authentication and SQL Server for usernames, passwords and profile data.
Today there is a much broader array of data storage options for web applications. And developers want to enable their sites to use social identity providers for authentication and authorization functionality. The design of Membership design is make this transition difficult:

* The database schema was designed for SQL Server and you can not change it
* The provider system enables you to change backing data store, but the system is designed around assumptions that you have a relational database
* Since the log-in/log-out functionality is based on Forms Authentication, developers can not use OWIN.  

### ASP.Net Simple Membership

It was built as a membership system for Asp.Net Web Pages.
It was released with WebMatrix and Visual Studio 2010 SP1. The goal of it was to make it easy to add membership functionalities to web pages. But it did not make it.
It has some limitations like ASP.Net Membership system:

* It was hard to persist membership system data to a non-relational store
* You can not use OWIN
* It does not work well with existing Asp.Net Membership providers
* It is not extensible

### ASP.Net Universal Providers

It was developed to make it possible to persist membership information in Microsoft Azure SQL Database. It can work with SQL Server Compact. It was built on Entity framework code first. this means, you can persist membership information on any storage that supports EF.

The Universal Providers are built on Asp.Net membership infrastructure. So it carry the same limitations with it.

## ASP.Net Identity

Like web and social media evolution, ASP.Net membership evolved too. The assumption that users will sign in to your system by entering username and password that are persisted in your own system is not valid any more. The web has become more social. People are interacting with each other nearly real time on facebook, twitter, instagram etc. Developers wants users to be able to sign in with their social identities so that they can have a rich experience on their website. A modern membership system must enable redirection-based log-in to authentication providers like facebook, twitter.

Considering the changes in web development, ASP.Net Identity was developed with the following goals:

* One Asp.Net Identity System
* Ease of plugging in data about user
* Persistence control
* Unit testability
* Role provider
* Claims based
* Social Login Providers
* Owin integration
* Nuget Packages


###### Resources: https://docs.microsoft.com/en-us/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity