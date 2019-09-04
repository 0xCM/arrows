mklink /d mkl "..\..\mkl\"
mklink /d ms "..\..\ms\"

dotnet sln add external/mkl/src/z0.mkl.csproj
dotnet sln add external/mkl/test/z0.mkl.test.csproj
dotnet sln add external/ms/z0.ms.csproj


dotnet sln remove external/mkl/src/z0.mkl.csproj
dotnet sln remove external/mkl/test/z0.mkl.test.csproj
dotnet sln remove external/ms/z0.ms.csproj