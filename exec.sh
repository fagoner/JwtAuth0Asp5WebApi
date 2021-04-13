docker rmi -f jwtauth0:dev || true
docker build -t jwtauth0:dev . || true
docker rmi $(docker images -f "dangling=true" -q) || true
