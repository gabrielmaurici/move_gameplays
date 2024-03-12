# MoveGameplays

Aplicação automatizada para identificar input de um HD externo no windows, verificar se o HD conectado é o mesmo que foi configurado na aplicação, mover todas as fotos e as gameplays para o computador (com opções de mover a última gameplay ou as últimas 10) e deletar os arquivos do HD Externo


Consulte **[Implantação](#-implanta%C3%A7%C3%A3o)** para saber como implantar o projeto.

### 📋 Pré-requisitos

Necessário que o sistema operacional seja Windows, devido as bibliotecas utilizadas com suporte apenas para Windows

* [Visual Studio 2022 - Comunity](https://visualstudio.microsoft.com/pt-br/vs/community/)
* [SDK .NET 8.0](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)


### 🔧 Instalação

Restaure as dependências dos projetos na pasta /move_gameplays/MoveGameplays:

```
dotnet restore
```

Rode o projeto na pasta onde se contra o projeto Windows Forms /move_gameplays/MoveGameplays/MoveGameplays.Wfp:

```
dotnet run
```

## 📦 Implantaçãos



## 🛠️ Construído com

Mencione as ferramentas que você usou para criar seu projeto

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - O framework web usado
* [Maven](https://maven.apache.org/) - Gerente de Dependência
* [ROME](https://rometools.github.io/rome/) - Usada para gerar RSS