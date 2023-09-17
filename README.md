# MauiSqlite
Use EF Core migrations with SQLite in MAUI App

to get EF to function properly

add   

public class MigrationHistory  
  {  
      public string MigrationId { get; set; }  
      public string ProductVersion { get; set; }  
  }


## To clear migrations or rollback last migration 
dotnet ef migrations remove --startup-project  .\MauiSqliteClassLibrary --project .\MauiSqliteClassLibrary


## Add migration 

dotnet ef migrations add <migration-name> --startup-project  .\MauiSqliteClassLibrary --project .\MauiSqliteClassLibrary 

eg

dotnet ef migrations add Init --startup-project  .\MauiSqliteClassLibrary --project .\MauiSqliteClassLibrary 



## File Location
C:\Users\<username>\AppData\Local\Packages\<PakageID>\LocalState
