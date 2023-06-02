<h1 align="center"> Sistema simples para cadastro de produto</h1>
<br>
Sistema desenvolvido com o intuito de criar uma pequena solução com um CRUD para cadastro de produto e categoria, a fim de aplicar o ORM EntityFramework Core e reforçar alguns tópicos de estudos como estruturação e injeção de dependência.
<hr>
✔️ Técnicas e Tecnologias utilizadas:

- ``C# 11``
- ``Paradigma de Orientação a Objetos``
- ``.Net Core 7.0``
- ``PostgresSQL 14``
- ``EntityFramework Core``
- ``Swagger`` 

✔️ Estrutura do Projeto:

![estrutura](https://github.com/EduardoGomesSa/supermarket-api/assets/99502227/911c573f-92a9-49a4-9121-965c1a55b51c)

- ``API`` - Cuida da entrada e disponibilização de dados através dos Controllers
- ``Application`` - Cuida das requisições entre o sistema e usuário e faz conversões quando necessário
- ``Service`` - Cuida do acesso ao banco de dados
- ``Model`` - Cuida do armazenamento de objetos e enumeradores do sistema
- ``Data`` - Cuida da configuração do EntityFramework Core
- ``DependecyInjection`` - Cuida das injeções de dependência do projeto, as organizando separadamente

✔️ Funções do sistema:

![swagger](https://github.com/EduardoGomesSa/supermarket-api/assets/99502227/946f38b2-3eff-41eb-9f39-671430a63655)

- ``Post - product`` - Adiciona um novo produto e caso ainda não exista, uma nova categoria
- ``Delete - product`` - Deleta o produto e caso não haja mais produtos na sua categoria, também a exclui
- ``Put - product`` - Atualiza o produto
- ``Get - product`` - Busca todos os produtos cadastrados
- ``Get - product/getbyid`` - Busca um produto por seu Id
- ``Put - category`` - Atualiza a categoria
- ``Get - category`` - Busca todas as categorias cadastradas
- ``Get - category/getbyid`` - Busca uma categoria por seu id

<br>:construction: Projeto em construção :construction:
