
# Módulo de agendamento de aulas coletivas 

**Olá, Por favor leia tudo!!!** Me empenhei para tentar deixar claro minha maneira de pensar ao desenvolver essa API, aqui você encontrará o codigo de uma WEP APi para um pequeno modulo de agendamento de aulas, o foco dessa API como solicitado são aulas de uma academia, mas ela pode ser facilmente utilizada para outros tipos de nichos, basta algumas penas alterações...


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




## Rotas das regras de negocio pedidas

#### Retorna o relatorio pedido no desafio

```http
  GET /Aluno/GerarRelatorioAluno
```


#### Retorna o objeto cadastrado no banco, caso tente cadastrar um que ja existe da update em vez de salvar

```http
  POST /Agendamento
```





## Melhorias

Para melhorias futuras acho que fiquei devendo a parte de AUTENTIFICAÇÂO da APi, que é bem importante mas acabou não dando tempo, e como ao meu ver ao chegar nesse modulo o usuario ja devia estar logado acho que para esse crud não faz muita diferença mas se eu fosse fazer usaria um JWT no cabeçalho, Alem do token eu tambem colocaria o  Scrutor para não precisar injetar as dependencias na mão


## Rodando os testes

Para rodar a aplicação use os comando no CMD do gerenciador de nugets, e tenha o docker na maquina (IMPORTANTE)

No seu terminal (CMD, PowerShell, etc.) da pasta em que clonou :

```bash
  docker-compose up -d
```

No Console do Gerenciador de Pacotes do Visual Studio

```bash
  Update-Database -StartupProject AgendamentoDeAulas.Api
```

Depois disso o projeto deve rodar só lembre de setar o Api como projeto de iniciação

