# Q&A app
## using .net core 6 and vuejs 3.*

## Features list:
  - [ ] auth with jwt tokens
  - [ ] notifications
    - [ ] ws protocol for delivering
    - [ ] kafka for event bus
  - [ ] elasticsearch/sphinx for indexing and searching
  - [ ] questions crud
  - [ ] user achivements system

## How to run
```
Server:
docker compose build && docker compose up

Cleint:
cd client && npm i && npm run serve