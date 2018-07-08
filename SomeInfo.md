# Crear solució i projectes:

``````

.
├── blazorpong
│   ├── blazorpong.Client
│   │   └── @TODO
│   ├── blazorpong.Server
│   │   └── @TODO
│   └── blazorpong.Shared
│       └── @TODO
├── blazorpong.sln
├── LICENSE
├── Readme.md
├── Resources.md
└── SomeInfo.md


mkdir blazorpong
cd blazorpong
dotnet new sln
mkdir blazorpong
cd blazorpong
mkdir blazorpong.Client
mkdir blazorpong.Server
mkdir blazorpong.Shared
touch blazorpong.Client/@TODO
touch blazorpong.Server/@TODO
touch blazorpong.Shared/@TODO
#TODO
dotnet sln blazorpong.sln add blazorpong.Client/blazorpong.Client.csproj
dotnet sln blazorpong.sln add blazorpong.Server/blazorpong.Server.csproj
dotnet sln blazorpong.sln add blazorpong.Shared/blazorpong.Shared.csproj
``````

