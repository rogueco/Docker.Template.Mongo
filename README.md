# Docker.Template.Mongo

# Part of a small series of Docker API's that have different Persisted Databases that can be used as a base template for developing. 

## Run Application From Docker
```bash
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

Once the image has been create you can hit the URL From either: http://localhost:8001/swagger/index.html / http://host.docker.internal:8001/swagger/index.html 


## Creating a Docker Contained Instance of Mongo

```bash
 docker run --name mongo-docker -d -p 27017:27017 mongo:latest
```

This will allow a mongo db instance to run on your machine without needing to install mongo. Also, you'll be able to connect to your DB from a DBClient (DataGrip)
