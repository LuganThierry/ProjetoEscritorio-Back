<h1> Deméter - Escritório Online </h1>

O Deméter é um sistema de gestão de escritórios de advocacia. 

O sistema foi criado como uma etapa avaliativa do processo seletivo para integrar a equipe de Tecnologia e Inovação. 

Segundo o documento de requisitos, trata-se de:

*Um filtro de processos que consiste em, a partir da base de dados fornecida, criar um programa que liste todos os processos pelos quais o advogado é responsável.*

Para construir esse filtro, decidimos usar uma arquitetura que conectasse uma página web com um banco de dados por meio de uma API, conforme a ilustração abaixo. 

![image](https://github.com/LuganThierry/ProjetoEscritorio-Back/assets/106288264/493e0bc4-df13-4bee-b425-129c7069618e)

<strong> Banco de dados </strong>

O banco de dados utilizado foi o MySQL, por se tratar de requisito da atividade. 
As tabelas foram geradas por migration de esquemas estabelecidos pela API. Essas tabelas foram populadas manualmente, com dados fornecidos pelos requisitos da atividade. 

<strong> Web API </strong>

Web API foi desenvolvida em linguagem de programação C# no framework .NET 6.0. Esse README visa detalhá-la. 

<strong> Página Web </strong>

O repositório da aplicação pode ser encontrado no github, pelo link:
https://github.com/LuganThierry/ProjetoEscritorio-Front

<h2> Tecnologias Utilizadas na API </h2>
<ol> 
    <li> C# </li>
    <li> .NET 6.0 </li>
    <li> Entity Framework </li>
</ol>

<h2> Pacotes instalados </h2>
O sistema instalou uma série de pacotes via NuGet Packeges Manager. 

Os pacotes instalados foram os seguintes.

<ol> 
    <li> Microsoft.EntityFrameworkCore (versão 6.0.0) </li>
    <li> Microsoft.EntityFrameworkCore.Design (versão 6.0.0) </li>
    <li> Microsoft.EntityFrameworkCore.Tools (versão 6.0.0) </li>
    <li> Pomelo.EntityFrameworkCore.MySQL (versão 6.0.0) </li>
    <li> Swashbuckle.AspNetCore (versão 6.2.3) </li>
</ol>

O Entity Framework é uma ferramenta de mapeamento e persistência de dados em diversos bancos. 

A ferramenta Pomelo foi instalada para que o Entity Framework pudesse ser usado no bando de dados MySQL. 
(Por ser tratar de ferramentas da Microsoft, o ambiente do Entity é preparado para administratar bancos SQL Server). 

Por fim, o último pacote é instalado nativamente na aplicação quando ela é construída a partir de um modelo de Web API. 
Trata-se da ferramenta Swagger que tem como finalidade a documentação das respostas JSON e códigos HTTPS dadas pela API. 

<h2> Conexão com o bando de dados </h2>

1º - Criar uma string de conexão com os dados de um banco de dados MySQL. A conexão com o banco de dados já está criado no elemento program.cs. 
2º - Criar as migrações das models para o banco de dados. As models já estão mapeadas no elemento map, dentro da pasta "data". 
Para executar as migrations, deve-se executar, no Package Manager Console, os seguintes comandos. Os comandos devem ser executados na pasta na qual se encontra a solution. 

 > Add-Migration <nome-da-migration> -Context SistemaProcessosDBContext
    
 > Update-Database <nome-da-migration> -Context SistemaProcessosDBContext

O primeiro comando cria uma mapeamento de migração das classes model dentro do sistema. 
O segundo comando cria as respectivas tabelas no bando de dados conectado pela string de conexão. 
    
No projeto, as tabelas foram populadas manualmente com os dados enviados na proposta de requisitos no SGBD do banco de dados. 
Como a migração foi feita com base nos parâmetros sugeridos, os dados foram persistidos no banco de dados sem nenhum erro. 
    
<h2> Rotas da API </h2>

A API possui três rotas do tipo GET:

<h2> Tecnologias Utilizadas na API </h2>
<ol> 
    <li> https://localhost:7176/api/Processos/advogado/${id}/processos </li>
    
- Esta rota, quando fornecido um ID válido de um advogado, devolve todos os processos que estão vinculados a este ID. 
- É a rota que efetivamente cumpre o requisito principal da proposta. Isto é, recebe um ID de advogado que, quando válido, devolve os processos deste. 
    
    <li> https://localhost:7176/api/Pessoas/${id} </li>
    
- Esta rota é auxiliar. Foi criada primeiramente para testes. 
- Foi aproveitada. O front-end recebe essa API, busca o nome do advogado relacionado ao ID e mostra na tela. 
    
    <li> https://localhost:7176/api/Pessoas </li>
    
- Foi a primeira rota criada. Tinha intuito de validar a relação com banco de dados. 
- Pode ser comentada sem afetar a aplicação. Como ela abertas mostra os dados do banco e não os altera, não se observou a necessidade de excluí-la. 
</ol>

Importante: A porta do localhost pode mudar de acordo com a conexão com o banco de dados. 

