use virtualdc;

-- Usamos apelidos no DB, para facilitar consultas, leitura e definição de referências de nomes de tabelas,
-- colunas (campos) e fórmulas usa-se o comando AS
SELECT cliente.NOME, 
COUNT(*) AS TITULOS, SUM(venda.VALOR) AS TOTAL
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI
GROUP BY cliente.NOME;


-- Apresentaremos uma listagem identificada pelo apelido CLIENTE e VENCIDOS CLIENTE represewntará o campo NOME e VENCIDOS o número de
-- duplicatas vencidas na tabela "venda", que será calculada pela função COUNT de todos os clientes que possuem titúlos com vencimento anterior a 06/04/2022
SELECT cliente.NOME AS CLIENTE, COUNT(*) AS VENCIDOS 
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI
AND VENCTO <= '06-04-2022' 
GROUP BY cliente.NOME ORDER BY cliente.NOME


-- Consultaremos duplicatas em atraso, anteriores a data de 06/04/2022, apresentando no nome do cliente, o calor da duplicata, o calor dos juros
-- e o valor total a ser cobrado do título em atraso
SELECT cliente.NOME, venda.VALOR, venda.VALOR * 0.15 AS JUROS, 
venda.VALOR * 1.15 AS TOTAL FROM cliente, venda 
WHERE cliente.CODCLI = venda.CODCLI AND VENCTO <= '06/04/2022'
ORDER BY cliente.NOME


-- Visualização de dados
-- A partir de uma tabela existente, criamos tabelas virtuais
-- As tabelas virtuais se parecem com as tabelas reais, porém são apenas uma composição em forma de cunsulta
-- predefinida a partir de uma tabela real. As tabelas reais possuem os dados cadastrados e, por essa razão,
-- ocupam espaço em disco, já as vituais possuem apenas as referências de acesso à consulta das tabelas reais e,
-- por assim dizer, não ocupam espaço em disco. As VIEWS agilizam as consultas, já que concentram em cada tabela
-- virtual os campos que realmente interessam

-- As VIEWS são úteis quando há a necessidade de realizar certas consultas com muita frequência, isto é,
-- uma forma eficiente de deixar definidas as colunas que serão usadas como relátoriose que ocorre frequentemente.
-- As VIEWS podem ocorrer a partir de uma única tabela, de múltiplas tabelas ou mesmo a partir de outras VIEWS já consultadas.
-- Sintaxe: CREATE VIEW <tabela virtual> AS <consultas>
CREATE VIEW visao1 AS SELECT NOME, DEPTO, SALARIO FROM cadfun;
SELECT * FROM visao1;

-- Criamos uma visão chamada visao2 que apresenta os clientes que possuem titulos vencidos a partir de 31/12/2020
CREATE VIEW visao2 AS SELECT cliente.NOME AS CLIENTE, 
COUNT(*) AS VENCIDOS FROM cliente, venda
WHERE cliente.CODCLI = venda.CODCLI AND VENCTO <= '31/12/2021'
GROUP BY cliente.NOME;
SELECT * FROM visao2;

CREATE  VIEW visao3 AS SELECT cliente.CODCLI, cliente.NOME,
venda.DUPLIC, venda.VALOR, venda.VENCTO
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI;
SELECT * FROM visao3;


-- Criaremos a visão a paritr da visao3, contendo apenas os campos CODCLI, NOME, DUPLIC, VENCTO
-- de todos os clientes. Execute as instruções abaixo de forma separada
CREATE VIEW visao4 AS SELECT CODCLI, NOME, DUPLIC VENCTO FROM visao3;
SELECT * FROM visao4;


-- A remoção de uma table virtual é semelhante a de uma tabela real. A diferença
-- está na sintaxe, pois utiliza, pois utiliza a instrução: DROP VIEW <nome>;
DROP VIEW visao4;


-- Indexação de tabelas
-- Índice é uma estrutura de arquivo complementar que armazena o campo chave de uma
-- tabela e o local de onde o campo é encontrado. O recurso de definição de índice PRECISA
-- SER USADO COM CUIDADO pois pode causar LENTIDÃO, principalmente nas operações de UPDATE e de INSERT,
-- pois todos os índices associados à tabela devm ser atualizados à medida que os dados são atualizados
-- ou cadastrados.
-- Os índices podem ser:
-- - Simples
-- - Exclusivo
-- - Composto

-- OS CAPOS DEFINIDOS COMO CHAVE PRIMÁRIA NÃO DEVEM SER INDEXADOS, já que possuem um índice
-- definido automaticamente para atender sua condição operacional; Uma PK cria indiretamente uma indexação.
-- Sintaxe: CREATE INDEX <index> ON <tabela>;
CREATE INDEX indice1 ON cadfun (NOME);

-- Criou-se o índice e ele passa a ser utilizado de forma automatica pelo SGBD quando usar os comandos INSERT e UPDATE
ALTER TABLE cadfun ADD CPF CHAR(11);
UPDATE cadfun SET CPF = '10020011199' WHERE CODFUN = 2;

-- Na tabela ccadfun, já existe o campo CODFUN, que não possibilita o cadastro de dois funcionários com o mesmo código,
-- uma vez que ele é definido como PK. Foi definido um novo campo chamado CPF que também deve ser único para cada um dos
-- funcionários. Sendo assim, dois funcionário não podem assumir o mesmo número de CPF. Na seguinte instrução criamos o 
-- índice2 com a definição do CPF como campo exclusivo
CREATE UNIQUE INDEX indice2 ON cadfun (CPF);

INSERT INTO cadfun VALUES (84, 'Marcos Inácio', '2', 'Gerente de Vendas', 9999.99, '06-04-2022', '12-06-1999', 2, '38283842773');


-- Sub-rotinas em T-SQL, também conhecidas como STORED PROCEDURES
-- Sintaxe: CREATE PROCEDURE <nome> [<parâmetro>]

-- O código interno de uma SP usará BEGIN e END, podemos declarar variáveis: 
-- DECLARE <@variável><tipo> e podemos atribuir valores à variavel: SET <@variável> = <valor>

-- Temos também, a possibilidade de condicionais e repetições:
-- IF <(condição verdadeira)>
--		intruções
-- [ELSE]
--		intruções

--	WHILE (condição)
--		intruções

-- PRINT => escreve o conteúdo de uma variável

CREATE PROCEDURE sp_saudacao AS DECLARE @Mensagem CHAR(20) SET @Mensagem = 'Alô, alunos do TI25' PRINT @Mensagem;
EXEC sp_saudacao;

CREATE PROCEDURE sp_dados AS SELECT NOME, SALARIO FROM cadfun;
EXEC sp_dados;

CREATE PROCEDURE sp_decisao1 @A FLOAT, @B FLOAT AS
DECLARE @X FLOAT
SET @X = @A + @B
IF(@X >= 10) 
PRINT @X;

EXEC sp_decisao1 5.5, 4;
EXEC sp_decisao1 5.5, 4.5;
EXEC sp_decisao1 5.5, 7.5;