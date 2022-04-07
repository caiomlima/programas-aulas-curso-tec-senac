use virtualdc;

-- Usamos apelidos no DB, para facilitar consultas, leitura e defini��o de refer�ncias de nomes de tabelas,
-- colunas (campos) e f�rmulas usa-se o comando AS
SELECT cliente.NOME, 
COUNT(*) AS TITULOS, SUM(venda.VALOR) AS TOTAL
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI
GROUP BY cliente.NOME;


-- Apresentaremos uma listagem identificada pelo apelido CLIENTE e VENCIDOS CLIENTE represewntar� o campo NOME e VENCIDOS o n�mero de
-- duplicatas vencidas na tabela "venda", que ser� calculada pela fun��o COUNT de todos os clientes que possuem tit�los com vencimento anterior a 06/04/2022
SELECT cliente.NOME AS CLIENTE, COUNT(*) AS VENCIDOS 
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI
AND VENCTO <= '06-04-2022' 
GROUP BY cliente.NOME ORDER BY cliente.NOME


-- Consultaremos duplicatas em atraso, anteriores a data de 06/04/2022, apresentando no nome do cliente, o calor da duplicata, o calor dos juros
-- e o valor total a ser cobrado do t�tulo em atraso
SELECT cliente.NOME, venda.VALOR, venda.VALOR * 0.15 AS JUROS, 
venda.VALOR * 1.15 AS TOTAL FROM cliente, venda 
WHERE cliente.CODCLI = venda.CODCLI AND VENCTO <= '06/04/2022'
ORDER BY cliente.NOME


-- Visualiza��o de dados
-- A partir de uma tabela existente, criamos tabelas virtuais
-- As tabelas virtuais se parecem com as tabelas reais, por�m s�o apenas uma composi��o em forma de cunsulta
-- predefinida a partir de uma tabela real. As tabelas reais possuem os dados cadastrados e, por essa raz�o,
-- ocupam espa�o em disco, j� as vituais possuem apenas as refer�ncias de acesso � consulta das tabelas reais e,
-- por assim dizer, n�o ocupam espa�o em disco. As VIEWS agilizam as consultas, j� que concentram em cada tabela
-- virtual os campos que realmente interessam

-- As VIEWS s�o �teis quando h� a necessidade de realizar certas consultas com muita frequ�ncia, isto �,
-- uma forma eficiente de deixar definidas as colunas que ser�o usadas como rel�toriose que ocorre frequentemente.
-- As VIEWS podem ocorrer a partir de uma �nica tabela, de m�ltiplas tabelas ou mesmo a partir de outras VIEWS j� consultadas.
-- Sintaxe: CREATE VIEW <tabela virtual> AS <consultas>
CREATE VIEW visao1 AS SELECT NOME, DEPTO, SALARIO FROM cadfun;
SELECT * FROM visao1;

-- Criamos uma vis�o chamada visao2 que apresenta os clientes que possuem titulos vencidos a partir de 31/12/2020
CREATE VIEW visao2 AS SELECT cliente.NOME AS CLIENTE, 
COUNT(*) AS VENCIDOS FROM cliente, venda
WHERE cliente.CODCLI = venda.CODCLI AND VENCTO <= '31/12/2021'
GROUP BY cliente.NOME;
SELECT * FROM visao2;

CREATE  VIEW visao3 AS SELECT cliente.CODCLI, cliente.NOME,
venda.DUPLIC, venda.VALOR, venda.VENCTO
FROM cliente, venda WHERE cliente.CODCLI = venda.CODCLI;
SELECT * FROM visao3;


-- Criaremos a vis�o a paritr da visao3, contendo apenas os campos CODCLI, NOME, DUPLIC, VENCTO
-- de todos os clientes. Execute as instru��es abaixo de forma separada
CREATE VIEW visao4 AS SELECT CODCLI, NOME, DUPLIC VENCTO FROM visao3;
SELECT * FROM visao4;


-- A remo��o de uma table virtual � semelhante a de uma tabela real. A diferen�a
-- est� na sintaxe, pois utiliza, pois utiliza a instru��o: DROP VIEW <nome>;
DROP VIEW visao4;


-- Indexa��o de tabelas
-- �ndice � uma estrutura de arquivo complementar que armazena o campo chave de uma
-- tabela e o local de onde o campo � encontrado. O recurso de defini��o de �ndice PRECISA
-- SER USADO COM CUIDADO pois pode causar LENTID�O, principalmente nas opera��es de UPDATE e de INSERT,
-- pois todos os �ndices associados � tabela devm ser atualizados � medida que os dados s�o atualizados
-- ou cadastrados.
-- Os �ndices podem ser:
-- - Simples
-- - Exclusivo
-- - Composto

-- OS CAPOS DEFINIDOS COMO CHAVE PRIM�RIA N�O DEVEM SER INDEXADOS, j� que possuem um �ndice
-- definido automaticamente para atender sua condi��o operacional; Uma PK cria indiretamente uma indexa��o.
-- Sintaxe: CREATE INDEX <index> ON <tabela>;
CREATE INDEX indice1 ON cadfun (NOME);

-- Criou-se o �ndice e ele passa a ser utilizado de forma automatica pelo SGBD quando usar os comandos INSERT e UPDATE
ALTER TABLE cadfun ADD CPF CHAR(11);
UPDATE cadfun SET CPF = '10020011199' WHERE CODFUN = 2;

-- Na tabela ccadfun, j� existe o campo CODFUN, que n�o possibilita o cadastro de dois funcion�rios com o mesmo c�digo,
-- uma vez que ele � definido como PK. Foi definido um novo campo chamado CPF que tamb�m deve ser �nico para cada um dos
-- funcion�rios. Sendo assim, dois funcion�rio n�o podem assumir o mesmo n�mero de CPF. Na seguinte instru��o criamos o 
-- �ndice2 com a defini��o do CPF como campo exclusivo
CREATE UNIQUE INDEX indice2 ON cadfun (CPF);

INSERT INTO cadfun VALUES (84, 'Marcos In�cio', '2', 'Gerente de Vendas', 9999.99, '06-04-2022', '12-06-1999', 2, '38283842773');


-- Sub-rotinas em T-SQL, tamb�m conhecidas como STORED PROCEDURES
-- Sintaxe: CREATE PROCEDURE <nome> [<par�metro>]

-- O c�digo interno de uma SP usar� BEGIN e END, podemos declarar vari�veis: 
-- DECLARE <@vari�vel><tipo> e podemos atribuir valores � variavel: SET <@vari�vel> = <valor>

-- Temos tamb�m, a possibilidade de condicionais e repeti��es:
-- IF <(condi��o verdadeira)>
--		intru��es
-- [ELSE]
--		intru��es

--	WHILE (condi��o)
--		intru��es

-- PRINT => escreve o conte�do de uma vari�vel

CREATE PROCEDURE sp_saudacao AS DECLARE @Mensagem CHAR(20) SET @Mensagem = 'Al�, alunos do TI25' PRINT @Mensagem;
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