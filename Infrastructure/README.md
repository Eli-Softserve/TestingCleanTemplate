``` 
    dotnet ef migrations add "Intial" --project src/Infrastructure/ --startup-project src/Api/
    dotnet ef database update --project src/Infrastructure/ --startup-project src/Api/
    dotnet ef migrations remove --project src/Infrastructure/ --startup-project src/Api/
```