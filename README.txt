Part of Angular 2's tutorial (through part 5) added to an ASP.NET 4 application.

ASP.NET Core (vNext) includes tooling that makes using npm + TypeScript +
Angular2 from within VS2015 more straightforward. ASP.NET 4.x projects don't
have all of this functionality, so this solution shows how client-side code
can be developed in an ASP.NET Core project and then copied to an ASP.NET 4
project.

When building AspNetHybrid, JavaScript libraries and transpiled versions of
TypeScript files will be copied to the /heroesapp folder, and the main page of
the Angular2 application is at the URL /Heroes (defined in RouteConfig.cs),
with the page being /Views/Heroes/Index.cshtml. Routing is NOT included in
this demo.

I initially started with this: https://github.com/joergjo/aspnet5-angular2-vs2015
