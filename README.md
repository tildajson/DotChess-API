<h1 align="center">DotChess API</h1>

  <p align="center">
    Web API created for chess players to join communities and connect with other players online.
    <br />
     </p>
</div>


<!-- ABOUT THE PROJECT -->
## About The Project

Web API project created for chess players to connect with other players and join chess clubs. Written with Docker and SQL.

This app handles user authentication, creating, editing and deleting objects (CRUD), and filtering / sorting objects.

Deployment with Kubernetes and extensive Unit Testing in progress.

The goal with this project was to stay on top of the .NET 8 update by creating something substantial with guidance from the new documentations.
I also wanted to develop my ASP.NET and RESTful API skills.
There seems to be a gap in the market for online chess clubs in my area and as I have a great passion for chess I decided to create an app dedicated to that.

### Built With

* ![](https://img.shields.io/badge/C%23-232F3E?style=flat-square&logo=csharp&logoColor=white)
* ![](https://img.shields.io/badge/ASP.NET-232F3E?style=flat-square&logo=.NET&logoColor=white)
* ![](https://img.shields.io/badge/Docker-232F3E?style=flat-square&logo=Docker&logoColor=white)
* ![](https://img.shields.io/badge/SQL-232F3E?style=flat-square&logo=MySQL&logoColor=white)
* ![](https://img.shields.io/badge/VisualStudio-232F3E?style=flat-square&logo=VisualStudio&logoColor=white)

## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

To run the app you will need to have Docker installed on your machine.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/tildajson/DotChess-API.git
   ```
2. Start server
   ```sh
   docker-compose up
   ```
3. To visit app
   ```sh
   http://127.0.0.1:8080
   ```

## Roadmap

- [x] Authentication & Authorization
- [ ] Create Tournaments Model
- [ ] Add Profile Picture to User Model
- [x] Dockerize API
  - [ ] Deploy with Kubernetes
- [ ] Unit Testing


