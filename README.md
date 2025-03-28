# CP-.NET

# API de Cadastro de Brinquedos

### Membros do Grupo
- **Enzo Franco Rocha** - RM: 553643
- **João Pedro Pereira** - RM: 553698
- **Herbert Santos de Sousa** - RM: 553227


## Descrição do Projeto

Este projeto é uma API desenvolvida em C# com .NET para gerenciar o cadastro de brinquedos de uma loja voltada para crianças de até 12 anos. A API permite realizar operações **CRUD** (Create, Read, Update, Delete) no banco de dados, utilizando **Entity Framework Core** para a comunicação com o banco de dados Oracle.

A API expõe endpoints para cadastro, consulta, atualização e remoção de brinquedos. Os testes podem ser feitos via **Swagger** e **Postman**.

## Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET Core  
- **ORM:** Entity Framework Core  
- **Banco de Dados:** Oracle SQL  
- **Ferramentas de Teste:** Swagger e Postman  

## Endpoints da API

| Método | Rota                         | Descrição                              |
|--------|------------------------------|----------------------------------------|
| GET    | `/api/brinquedo/buscar/{id}` | Obtém um brinquedo pelo ID            |
| POST   | `/api/brinquedo/cadastrar`   | Cadastra um novo brinquedo            |
| PUT    | `/api/brinquedo/atualizar/{id}` | Atualiza um brinquedo existente       |
| DELETE | `/api/brinquedo/apagar/{id}` | Remove um brinquedo do banco de dados |

## Exemplo de JSON para Cadastro no Postman

```json
{
  "id_brinquedo": 0,
  "nome_brinquedo": "Carrinho de Controle Remoto",
  "tipo_brinquedo": "Eletrônico",
  "classificacao": "Acima de 5 anos",
  "tamanho": "Médio",
  "preco": "199.99"
}

