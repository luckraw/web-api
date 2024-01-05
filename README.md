# Web API

Este é um projeto de API desenvolvido em C# utilizando ASP.NET, Entity Framework e SQLite, com a implementação do padrão de projeto Repository. O objetivo principal é gerenciar informações de funcionários, permitindo operações como criação, leitura, atualização e exclusão.

# Tecnologias Utilizadas

- C# ASP.NET
- Entity Framework
- SQLite
- Repository Pattern

## Estrutura do Projeto

O projeto está organizado nas seguintes seções:

### Models
- FuncionarioModel: Define a estrutura de dados para um funcionário, incluindo nome, sobrenome, departamento, turno, ativo, e datas de criação e alteração.
- ServiceResponse: Um modelo genérico utilizado para encapsular respostas do serviço, incluindo dados, mensagem e indicador de sucesso.

### Enums
- TurnoEnum: Enumeração dos turnos possíveis para um funcionário.
- DepartamentoEnum: Enumeração dos departamentos possíveis para um funcionário.

### Interface
- IFuncionarioInterface: Interface que define os métodos disponíveis para interação com os funcionários.

### Services
- FuncionarioService: Implementação da interface IFuncionarioInterface, que contém a lógica de negócios para as operações CRUD de funcionários.

### Controller
- FuncionarioController: Controlador da API que lida com as requisições HTTP, chamando os métodos apropriados do serviço.

## Utilizando a API


`GET /api/Funcionario:` Retorna a lista de todos os funcionários.

`GET /api/Funcionario/{id}:` Retorna os detalhes de um funcionário específico pelo ID.

`POST /api/Funcionario:` Cria um novo funcionário.

`PUT /api/Funcionario:` Atualiza as informações de um funcionário existente.

`PUT /api/Funcionario/inativaFuncionario:` Inativa um funcionário (define Ativo como false).

`DELETE /api/Funcionario:` Exclui um funcionário pelo ID.
