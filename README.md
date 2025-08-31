# Consultoria Financeira - Victor Neves

Este projeto � uma landing page para consultoria financeira, desenvolvida com ASP.NET Core Razor Pages e Entity Framework Core. O objetivo � apresentar servi�os de consultoria financeira e permitir que visitantes entrem em contato atrav�s de um formul�rio seguro e moderno.

## Funcionalidades
- Apresenta��o dos servi�os de consultoria financeira
- Se��o sobre o profissional
- Formul�rio de contato com valida��o e consentimento LGPD
- Layout responsivo com Bootstrap 5
- Integra��o com banco de dados PostgreSQL (padr�o)

## Tecnologias Utilizadas
- ASP.NET Core Razor Pages
- Entity Framework Core
- PostgreSQL
- Bootstrap 5
- C#

## Como Executar Localmente
1. **Clone o reposit�rio:**
   ```bash
   git clone <url-do-repositorio>
   ```
2. **Configure a string de conex�o** no `appsettings.json` para seu banco PostgreSQL ou SQLite.
3. **Restaure os pacotes:**
   ```bash
   dotnet restore
   ```
4. **Aplique as migra��es:**
   ```bash
   dotnet ef database update
   ```
5. **Execute o projeto:**
   ```bash
   dotnet run
   ```
6. Acesse em `https://localhost:5001` ou conforme indicado no terminal.

## Deploy na Azure
- Utilize o Azure App Service para hospedar a aplica��o.
- Crie um banco de dados PostgreSQL ou SQL Server na Azure e configure a string de conex�o nas configura��es do App Service.
- Fa�a o deploy via Visual Studio, GitHub Actions ou FTP.

## Seguran�a
- O arquivo `.gitignore` protege arquivos sens�veis como `appsettings.Development.json` e segredos locais.
- Os dados do formul�rio s�o armazenados com seguran�a e utilizados apenas para contato.

## Contato
- WhatsApp: [Clique aqui](https://wa.me/message/RVWTWL6CPJPGI1)
- E-mail: V.nevesconsultor.financeiro@hotmail.com
- Instagram: [@consultor_victorneves](https://www.instagram.com/consultor_victorneves/)

---
Desenvolvido por Fabricio Rosa. Todos os direitos reservados.
