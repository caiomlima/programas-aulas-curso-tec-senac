USE virtualdc;

-- AVG é a média aritmética
SELECT AVG (SALARIO) FROM cadfun;
SELECT AVG (DISTINCT SALARIO) FROM cadfun;
SELECT AVG (SALARIO) FROM cadfun WHERE DEPTO = '11';
SELECT AVG(DISTINCT SALARIO) FROM cadfun WHERE DEPTO = '11';
SELECT AVG (DISTINCT FILHOS) FROM cadfun;

-- COUNT retorna o valor numérico inteiro de itens de um campo
SELECT COUNT (*) FROM cadfun WHERE DEPTO = '10';
SELECT COUNT (FILHOS) FROM cadfun;
SELECT COUNT (*) FROM cadfun WHERE SALARIO > 75000;
SELECT COUNT (*) FROM cadfun WHERE FUNCAO = 'Estágiario';


-- MAX retorna o maior valor numérico da lista
SELECT MAX (SALARIO) FROM cadfun;


-- MIN retorna o menor valor numérico da lista
SELECT MIN (SALARIO) FROM cadfun;


-- STDEV Retorna o desvio padrão estatístico
SELECT STDEV (FILHOS) FROM cadfun;
SELECT STDEV (DISTINCT FILHOS) FROM cadfun;


/* Funções de DATA */
-- DATEDIFF Retorna como contagem um valor inteiro relacionado aos limites definidos de uma parte em relação a um início e fim
SELECT NOME, DATEDIFF(Day, ADMISSAO, '31-03-2022') FROM cadfun;
SELECT NOME, DATEDIFF(Day, ADMISSAO, '31-03-2022') FROM cadfun WHERE DEPTO = '11';

-- DATENAME Retorna uma cadeia de caracteres que representam a parte especificada da data informada
SELECT NOME, ADMISSAO, DATENAME(MONTH, ADMISSAO) FROM cadfun;

-- DATEPART Retorna os números que representam a parte especificada da data informada
SELECT NOME, ADMISSAO, DATEPART(MONTH, ADMISSAO) FROM cadfun;

-- GETDATE Retorna a data e a hora atual do sistema
SELECT GETDATE();


-- FLOOR Retorna a data e a hora atual do sistema
SELECT FLOOR(1.1);
SELECT FLOOR(1.5);
SELECT FLOOR(1.99);
SELECT FLOOR(SALARIO) FROM cadfun;

-- RAND([espressão]) retorna valores aleatórios entre 0 e 1
SELECT RAND();
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);


/* Funções de String */
-- Funções de ASCII() retorna o valor do código da tabela ASCII mais à esquerda de uma espressão alfanumérica
SELECT ASCII('A');
SELECT ASCII('ABACATE');
SELECT ASCII('#caio');

-- Função CHAR() é a função inversa do ASCII, retornando o valor da tabela
SELECT CHAR(35);
SELECT CHAR(64);
SELECT CHAR(65);
SELECT CHAR(181);

-- Função LEN() retorna o número de caracteres da espressão, excluindo os espaços em branco
SELECT LEN('Caio Moreira Lima');
SELECT NOME, LEN(NOME) FROM cadfun WHERE DEPTO = '10';

-- Função LOWER() retorna o formato minúsculo e UPPER() o formato maiúsculo de uma espressão
SELECT lOWER('Caio Moreira Lima Da Silva Santo Abençoado Por Jesus');
SELECT UPPER('Caio Moreira Lima Da Silva Santo Abençoado Por Jesus');