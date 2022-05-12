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

## Reference

- base on video [.NET Microservices – Full Course](https://youtu.be/DgVjEo3OGBI) by [Les Jackson](https://www.youtube.com/c/binarythistle)
