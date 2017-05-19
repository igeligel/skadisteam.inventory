cd .\src\skadisteam.inventory\ 

exec { & dotnet restore }

cd ..\skadisteam.inventory.test\

dotnet restore

ls

exec { & dotnet test -c release }

cd ..\skadisteam.inventory\

exec { & dotnet pack -c Release -o .\artifacts }
