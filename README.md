
# Módulo de agendamento de aulas coletivas 

**Olá, Por favor leia tudo!!!** Me empenhei para tentar deixar claro minha maneira de pensar ao desenvolver essa API, aqui você encontrará o codigo de uma WEP APi para um pequeno modulo de agendamento de aulas, o foco dessa API como solicitado são aulas de uma academia, mas ela pode ser facilmente utilizada para outros tipos de nichos, basta algumas penas alterações...


## Documentação e Swagger

 - [Todas as rotas estão documentadas no Swagger](https://awesomeopensource.com/project/elangosundar/awesome-README-templates)


## Sobre as tecnologias usadas na API

A api usa .NET 8 como framework e tecnologia principal, entretando ele está loge de ser o unico, entre os principais merecem destaque:

- Docker: Aqui usamos o docker para não precisar "Seujar" nossas maquinas com a estação de um banco de dados local, basta ter o docker em seu computador e ao executar os passos de iniciação do projeto terá um banco postgres 100% funcional rodando em paralelo a api

- EntityFramework: O principal framework de criação e manipulação de entidades no banco de dados, com ele a API Cria e manipula as tabelas em uma abordagem Fist code, ou seja quem cuida do mapeamento e a criação do banco é o C# .Net, sem a necessidade de criar as tabelas e depois mapelas no codigo 


## Estrutura do projeto

O Projeto segue uma estrutura de arquitura limpa, utilizando a maioria das camadas que um projeto em produção precisa:

- Camada WEB (API): Aqui é onde fazemos as requisições e encaminhamos os dados para acamada de aplicação.

- Camada de aplicação: A camada por sua vez é responsavel por tratar os dados que tem de ser enviados para o repositorio e tratar a resposta do mesmo, aqui é onde maior parte das regras que não envolvem SQL ocorrem.

- Camada de dominio: Aqui mapeamos as classes e seus DTOs e interfaces, uma camada de definições nem uma regra ocorre aqui.

- Camada de infraestrutura/repositorio: Aqui é a alma do projeto, a unica camada que lida diretamente com o banco, todos os dados passam por aqui é ela quem manda nas classes e tabelas, define o tamanho das colunas e suas restrições



