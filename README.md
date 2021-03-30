```plantuml
@startuml
actor client
node "one"
node "two"
database redis

client -> one
one -> two
two -> redis
@enduml
```

[PlantUML](https://blog.anoff.io/2018-07-31-diagrams-with-plantuml)

# Dependencies

1. Api One
2. Api Two
3. Redis

## Running locally

1. Clone the repo and cd into the directory
2. ` dotnet tool install -g Microsoft.Tye --version "0.6.0-alpha.21070.5"`
3. `tye run`
4. open dashboard at `http://localhost:8000/`