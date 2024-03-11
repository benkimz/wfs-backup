# syntax=docker/dockerfile:1

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine3.19 AS build

COPY ../../ /source

WORKDIR /source/src/WireFrames.API

ARG TARGETARCH

RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish -a ${TARGETARCH/amd64/x64} --use-current-runtime --self-contained false -o /wfs-api

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.19 AS final

WORKDIR /wfs-api

COPY --from=build /wfs-api .

USER $APP_UID

ENTRYPOINT ["dotnet", "WireFrames.API.dll"]
