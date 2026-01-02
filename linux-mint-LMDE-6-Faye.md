1. install .net

- install following debian 12, .net v8 [see](https://learn.microsoft.com/en-us/dotnet/core/install/linux-debian?tabs=dotnet8)

2. install podman

```sh

sudo apt update
sudo apt install -y podman

sudo apt install -y podman-compose

```

- check version

```sh

podman --version
podman-compose --version

```

3. start project

```sh

chmod +x ./start.sh

./start.sh

```