# define a imagem base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# define o diret�rio de trabalho
WORKDIR /app

# copia todos os arquivos .csproj para o diret�rio de trabalho
COPY cleanarch.Domain/*.csproj ./cleanarch.Domain/
COPY cleanarch.Infra.Data/*.csproj ./cleanarch.Infra.Data/
COPY cleanarch.Infra.IoC/*.csproj ./cleanarch.Infra.IoC/
COPY cleanarch.UI/*.csproj ./cleanarch.UI/

# restaura as depend�ncias
RUN dotnet restore ./cleanarch.Domain/cleanarch.Domain.csproj
RUN dotnet restore ./cleanarch.Infra.Data/cleanarch.Infra.Data.csproj
RUN dotnet restore ./cleanarch.Infra.IoC/cleanarch.Infra.IoC.csproj
RUN dotnet restore ./cleanarch.UI/cleanarch.UI.csproj

# copia o resto dos arquivos da aplica��o para o diret�rio de trabalho
COPY . ./

# compila a aplica��o
RUN dotnet publish -c Release -o out cleanarch.Domain/cleanarch.Domain.csproj
RUN dotnet publish -c Release -o out cleanarch.Infra.Data/cleanarch.Infra.Data.csproj
RUN dotnet publish -c Release -o out cleanarch.Infra.IoC/cleanarch.Infra.IoC.csproj
RUN dotnet publish -c Release -o out cleanarch.UI/cleanarch.UI.csproj

# define a imagem de destino
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# define o diret�rio de trabalho
WORKDIR /app

# copia a sa�da da compila��o para a imagem de destino
COPY --from=build-env /app/out .

# inicia a aplica��o quando o cont�iner for iniciado
CMD ASPNETCORE_URLS=http://*:$PORT dotnet cleanarch.UI.dll
