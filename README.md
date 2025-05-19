## 🌐 English Version

### 📦 CleanArchitecture

[![.NET](https://img.shields.io/badge/.NET-8-blue)](https://dotnet.microsoft.com/)
[![Architecture](https://img.shields.io/badge/Pattern-Clean%20Architecture-brightgreen)]()
[![MediatR](https://img.shields.io/badge/MediatR-CQRS-yellow)]()
[![License](https://img.shields.io/github/license/lucianolemgruber/CleanArchitecture)](LICENSE)

This is a simple reference project demonstrating a clean and modular structure using **Clean Architecture**, **CQRS**, **MediatR**, and **FluentValidation** with .NET 8.

> ⚠️ I'm not a teacher or content creator — this repository is just a **personal base project** that can be used as a starting point or inspiration for your own applications.

---

### 🧰 Tech Stack

* ✅ Clean Architecture principles
* ✅ CQRS pattern (Command Query Responsibility Segregation)
* ✅ MediatR for decoupled communication
* ✅ FluentValidation for input validation
* ✅ .NET 8

---

### 🚀 Getting Started

1. Clone the repo:

   ```bash
   git clone https://github.com/lucianolemgruber/CleanArchitecture.git
   ```

2. Make sure to update the connection string in `appsettings.json`:

   ```json
   "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=CleanArchitecture;Trusted_Connection=True;TrustServerCertificate=True;"
   ```

3. Apply Entity Framework Core migrations (if needed):

   ```bash
   dotnet ef database update --project Clean.Api
   ```

4. Navigate to the main project folder and run:

   ```bash
   dotnet restore
   dotnet build
   dotnet run --project Clean.Api
   ```

(Replace `Your.WebApi.ProjectName` with the actual project name if different.)

---

### 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

## 🌎 Versão em Português

### 📦 CleanArchitecture

[![.NET](https://img.shields.io/badge/.NET-8-blue)](https://dotnet.microsoft.com/)
[![Architecture](https://img.shields.io/badge/Padr%C3%A3o-Arquitetura%20Limpa-brightgreen)]()
[![MediatR](https://img.shields.io/badge/MediatR-CQRS-yellow)]()
[![License](https://img.shields.io/github/license/lucianolemgruber/CleanArchitecture)](LICENSE)

Este é um projeto de referência simples que demonstra uma estrutura limpa e modular usando **Arquitetura Limpa**, **CQRS**, **MediatR** e **FluentValidation** com .NET 8.

> ⚠️ Não sou professor nem criador de conteúdo — este repositório é apenas uma **base pessoal** que pode ser usada como ponto de partida ou inspiração para seus próprios projetos.

---

### 🧰 Tecnologias Utilizadas

* ✅ Princípios da Arquitetura Limpa
* ✅ Padrão CQRS (Command Query Responsibility Segregation)
* ✅ MediatR para comunicação desacoplada
* ✅ FluentValidation para validação de entradas
* ✅ .NET 8

---

### 🚀 Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/lucianolemgruber/CleanArchitecture.git
   ```

2. Altere a connection string no `appsettings.json` para corresponder ao seu ambiente:

   ```json
   "DefaultConnection": "Server=SEU_SERVIDOR;Database=CleanArchitecture;Trusted_Connection=True;TrustServerCertificate=True;"
   ```

3. Execute as migrações do Entity Framework Core (se necessário):

   ```bash
   dotnet ef database update --project Clean.Api
   ```

4. Navegue até a pasta principal e execute:

   ```bash
   dotnet restore
   dotnet build
   dotnet run --project Clean.Api
   ```

(Substitua `Clean.Api` se o nome do seu projeto principal for diferente.)

---

### 📄 Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
