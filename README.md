# API Fluxo de caixa com micro-serviços

### Sobre
Aplicação de Fluxo de caixa é construída na arquitetura de microserviço em conjunto com as boas praticas de desenvolvimento, código limpo e os principios do SOLID.

### Como usar
#### Setup e execução
1. Clone o projeto
```PowerShell
git clone https://github.com/hudson-nascimento/act-digital-fluxo-caixa.git
```
2. Acesse a pasta do código fonte (src)
```PowerShell
cd src
```
3. Excute o comando abaixo no prompt.
O comando criará a rede 'fluxo-caixa-network' e os containers.
```PowerShell
docker-compose up -d
```
4. Execute o projeto
```PowerShell
dotnet run
```
### Construído com
#### Frameworks
- [.Net Framework 6](https://learn.microsoft.com/pt-br/shows/net-core-101/what-is-net)
- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)

#### Base de dados
- [PostgreSQL](https://www.postgresql.org/docs/)

#### Message brokers
- [Apache Kafka](https://kafka.apache.org/documentation/#introduction)

#### Arquitetura e Padrões de projeto
- [Microservice Architeture](https://microservices.io/patterns/microservices.html)

###### Creational design pattern
- [Builder]()
- [Factory]()
- [Singleton]()
###### Structural design pattern
- [Adapter]()
- [Decorator]()
###### Behavioral design pattern
- [Strategy]()


- [SOLID Principle](http://cleancoder.com/files/solid.md)

#### Containerização
- [Docker](https://docs.docker.com/)

### License
MIT
### Autor
Hudson Nascimento [Linkedin]()