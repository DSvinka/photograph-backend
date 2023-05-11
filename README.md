# photograph-backend

Перед запуском проекта необходимо провести миграцию базы данных.
Для этого переименуйте `appsettings.json.example` в `appsettings.json` и введите в консоль следующие команды:
```
dotnet-ef database update --startup-project App --project Database --context AppDbContext 
```
