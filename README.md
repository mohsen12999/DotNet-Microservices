# Dot Net Micro Controller

- a project to learn dotnet, web api, docker, kubernetes, and micro services

## Platform Service WebAPI

- make project `dotnet new webapi -n PlatformService`
- add ignore file `dotnet new gitignore`
- add packages
  - AutoMapper: `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`
  - Entity Framework: `dotnet add package Microsoft.EntityFrameworkCore`, `dotnet add package Microsoft.EntityFrameworkCore.Design`, `dotnet add package Microsoft.EntityFrameworkCore.InMemory`, `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

## Dockerize

- build image: `docker build -t mohsen1299/platformservice .`
- run image: `docker run -p 8080:80 -d mohsen1299/platformservice`
- push image to docker hub: `docker push mohsen1299/platformservice`

## Kubernetes

- test kubernetes: `kubectl version`
- `kubectl apply -f platforms-depl.yaml`
- `kubectl get deployments`
- `kubectl get pods`
- `kubectl get services`
- `kubectl delete deployment platforms-depl`
- add node port `kubectl apply -f platform-np-srv.yaml`
- show services: `kubectl get services`
- restart deployment for get new image form docker file:`kubectl rollout restart deployment platforms-depl`

## Commands Services WebAPI

- make project: `dotnet new webapi -n CommandsService`
- build docker image: `docker build -t mohsen1299/commandservice .`
- push image to docker hub: `docker push mohsen1299/commandservice`

## Ingress Nginx

- [ingress-nginx](https://github.com/kubernetes/ingress-nginx) is an Ingress controller for Kubernetes using NGINX as a reverse proxy and load balancer.
- from getting started find the config file for this image
`kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.2.0/deploy/static/provider/cloud/deploy.yaml`
- create pods in difference namespace
- see the name space `kubectl get namespace` and see the pods in the name space `kubectl get pods --namespace=ingress-nginx`

## use hostname

- change hosts `C:\Windows\System32\drivers\etc` and add `127.0.0.1 acme.com`

## Storage

- get storage: `kubectl get storageclass`
- we have 3 type of storage:
  - Persistent Volume Claim
  - Persistent Volume
  - Storage Class
- for see Persistent Volume Claim: `kubectl get pvc`
- make secret in kubernetes: `kubectl create secret generic mssql --from-literal=SA_PASSWORD="pa55w0rd!"`
- after making deploy can connect from sql server application with ServerName: `localhost,1433`, login: `sa`, password: `pa55w0rd!`
- add migration: `dotnet ef migrations add InitialMigration` if get error install dotnet-ef with `dotnet tool install --global dotnet-ef`

## RabbitMQ

- A Message Broker: it accepts and forward messages.
- Messages send by Publisher and receive by Subscribers.
- Message can store (buffer) on Queues.
- Exchange can be used to add "routing" functionality.
- 4 Type of Exchange:
  - Direct Exchange - deliver message base on routing key, ideal for direct or unicast message
  - Fanout Exchange - deliver message to all queues, ideal for broadcast
  - Topic Exchange - route message to 1 or more queues base on the routing key (and pattern), use multicast message, implement various Publisher / Subscribers Patterns
  - Header Exchange

- connect to RabbitMq management with `localhost:15672` with username and password `guest`

- add RabbitMQ as a package to project: `dotnet add package RabbitMQ.Client`

## gRPC

- google Remote Procedural Call
- use HTTP/2 protocol to transport binary message (include TLS).
- very light weight and fucus on high performance.
- relies on "Protocol Buffers" (aka Protobuf) to define between end point.
- multi-language support.
- frequently use as a method of service to service communication.

## Reference

- base on video [.NET Microservices – Full Course](https://youtu.be/DgVjEo3OGBI) by [Les Jackson](https://www.youtube.com/c/binarythistle)
