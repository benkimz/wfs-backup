FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine3.19 AS build

COPY . /source

WORKDIR /source/src/WireFrames.API

RUN  dotnet run

WORKDIR /source/src/MilesAhead.Web    

ENTRYPOINT ["dotnet", "watch", "--wfs-mode=dev"]

USER $APP_UID

CMD [ "echo", "Okay"]

