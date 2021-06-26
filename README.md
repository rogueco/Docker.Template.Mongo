# Docker.Template.Mongo

# Part of a small series of Docker API's that have different Persisted Databases that can be used as a base template for developing. 

## Creating a Docker Contained Instance of Mongo

```bash
 docker run --name mongo-docker -d -p 27017:27017 mongo:latest
```

This will allow a mongo db instance to run on your machine without needing to install mongo. Also, you'll be able to connect to your DB from a DBClient (DataGrip)
