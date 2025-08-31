# Consultoria Financeira - Victor Neves

Este projeto é uma landing page para consultoria financeira, desenvolvida com ASP.NET Core Razor Pages e Entity Framework Core. O objetivo é apresentar serviços de consultoria financeira e permitir que visitantes entrem em contato através de um formulário seguro e moderno.

## Funcionalidades
- Apresentação dos serviços de consultoria financeira
- Seção sobre o profissional
- Formulário de contato com validação e consentimento LGPD
- Layout responsivo com Bootstrap 5
- Integração com banco de dados PostgreSQL (padrão)

## Tecnologias Utilizadas
- ASP.NET Core Razor Pages
- Entity Framework Core
- PostgreSQL
- Bootstrap 5
- C#

## Como Executar Localmente
1. **Clone o repositório:**
   ```bash
   git clone <url-do-repositorio>
   ```
2. **Configure a string de conexão** no `appsettings.json` para seu banco PostgreSQL ou SQLite.
3. **Restaure os pacotes:**
   ```bash
   dotnet restore
   ```
4. **Aplique as migrações:**
   ```bash
   dotnet ef database update
   ```
5. **Execute o projeto:**
   ```bash
   dotnet run
   ```
6. Acesse em `https://localhost:5001` ou conforme indicado no terminal.

## Deploy na Azure
- Utilize o Azure App Service para hospedar a aplicação.
- Crie um banco de dados PostgreSQL ou SQL Server na Azure e configure a string de conexão nas configurações do App Service.
- Faça o deploy via Visual Studio, GitHub Actions ou FTP.

## Segurança
- O arquivo `.gitignore` protege arquivos sensíveis como `appsettings.Development.json` e segredos locais.
- Os dados do formulário são armazenados com segurança e utilizados apenas para contato.

## Contato
- WhatsApp: [Clique aqui](https://wa.me/message/RVWTWL6CPJPGI1)
- E-mail: V.nevesconsultor.financeiro@hotmail.com
- Instagram: [@consultor_victorneves](https://www.instagram.com/consultor_victorneves/)

---
Desenvolvido por Fabricio Rosa. Todos os direitos reservados.
