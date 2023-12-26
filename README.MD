# Who Am I for Windows containers
This is the source code used to build an image for Windows containers that contains a simple **Who am I** server. 

Building the image

------------------

To build the image, run the following command from the root of the repository:

```
docker build -t nexus-t.n96.co.uk/repository/docker-hosted/qlib/web/whoami .
```

Running the image

-----------------

To run the image, run the following command:

```
docker run -d -p 80:80 whoami
```

You can then browse to http://localhost to see the server running.

On some systems building from contaianers often fails with the following error:

```
 Step 5/11 : RUN dotnet restore
 ---> Running in 8ac2d6b11948
  Determining projects to restore...
C:\Program Files\dotnet\sdk\8.0.100\NuGet.targets(156,5): error : Unable to load the service index for source https://api.nuget.org/v3/index.json. [C:\app\app.csproj]
C:\Program Files\dotnet\sdk\8.0.100\NuGet.targets(156,5): error :   No such host is known. (api.nuget.org:443) [C:\app\app.csproj]
C:\Program Files\dotnet\sdk\8.0.100\NuGet.targets(156,5): error :   No such host is known. [C:\app\app.csproj]
The command 'cmd /S /C dotnet restore' returned a non-zero code: 1
```

To get around this issue use the local image:

```
docker build -t nexus-t.n96.co.uk/repository/docker-hosted/qlib/web/whoami -f Dockerfile-copybin .
```
