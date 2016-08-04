# Docker Today

## Docker Commands

### Dev
docker build --tag webapp:dev --file Dockerfile.dev .

docker run --rm --name webapp -v `pwd`:/app -it -p 8080:80 -link service webapp:dev

docker build --tag service:dev --file Dockerfile.dev .

docker run --rm --name service -v `pwd`:/app -it -p 8081:80 service:dev

### Deploy

docker build --tag gmatech/dockertoday:1.0.0-webapp .

docker run -d --name webapp -p 8080:80 -link service gmatech/dockertoday:1.0.0-webapp

docker build --tag gmatech/dockertoday:1.0.0-service .

docker run -d --name service -p 8081:80 gmatech/dockertoday:1.0.0-service


## Dotnet Commands

dotnet run --server.urls http://0.0.0.0:80/

## Mac Stuff

https://forums.docker.com/t/is-there-a-way-to-go-into-the-docker-host/12104

## Resources

https://docs.docker.com/

https://github.com/OmniSharp/generator-aspnet

https://hub.docker.com/r/microsoft/dotnet/

https://github.com/Azure/azure-xplat-cli