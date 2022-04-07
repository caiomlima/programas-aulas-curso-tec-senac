USE virtualdc;

-- AVG � a m�dia aritm�tica
SELECT AVG (SALARIO) FROM cadfun;
SELECT AVG (DISTINCT SALARIO) FROM cadfun;
SELECT AVG (SALARIO) FROM cadfun WHERE DEPTO = '11';
SELECT AVG(DISTINCT SALARIO) FROM cadfun WHERE DEPTO = '11';
SELECT AVG (DISTINCT FILHOS) FROM cadfun;

-- COUNT retorna o valor num�rico inteiro de itens de um campo
SELECT COUNT (*) FROM cadfun WHERE DEPTO = '10';
SELECT COUNT (FILHOS) FROM cadfun;
SELECT COUNT (*) FROM cadfun WHERE SALARIO > 75000;
SELECT COUNT (*) FROM cadfun WHERE FUNCAO = 'Est�giario';


-- MAX retorna o maior valor num�rico da lista
SELECT MAX (SALARIO) FROM cadfun;


-- MIN retorna o menor valor num�rico da lista
SELECT MIN (SALARIO) FROM cadfun;


-- STDEV Retorna o desvio padr�o estat�stico
SELECT STDEV (FILHOS) FROM cadfun;
SELECT STDEV (DISTINCT FILHOS) FROM cadfun;


/* Fun��es de DATA */
-- DATEDIFF Retorna como contagem um valor inteiro relacionado aos limites definidos de uma parte em rela��o a um in�cio e fim
SELECT NOME, DATEDIFF(Day, ADMISSAO, '31-03-2022') FROM cadfun;
SELECT NOME, DATEDIFF(Day, ADMISSAO, '31-03-2022') FROM cadfun WHERE DEPTO = '11';

-- DATENAME Retorna uma cadeia de caracteres que representam a parte especificada da data informada
SELECT NOME, ADMISSAO, DATENAME(MONTH, ADMISSAO) FROM cadfun;

-- DATEPART Retorna os n�meros que representam a parte especificada da data informada
SELECT NOME, ADMISSAO, DATEPART(MONTH, ADMISSAO) FROM cadfun;

-- GETDATE Retorna a data e a hora atual do sistema
SELECT GETDATE();


-- FLOOR Retorna a data e a hora atual do sistema
SELECT FLOOR(1.1);
SELECT FLOOR(1.5);
SELECT FLOOR(1.99);
SELECT FLOOR(SALARIO) FROM cadfun;

-- RAND([espress�o]) retorna valores aleat�rios entre 0 e 1
SELECT RAND();
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);
SELECT FLOOR(RAND() * 59 + 1);


/* Fun��es de String */
-- Fun��es de ASCII() retorna o valor do c�digo da tabela ASCII mais � esquerda de uma espress�o alfanum�rica
SELECT ASCII('A');
SELECT ASCII('ABACATE');
SELECT ASCII('#caio');

-- Fun��o CHAR() � a fun��o inversa do ASCII, retornando o valor da tabela
SELECT CHAR(35);
SELECT CHAR(64);
SELECT CHAR(65);
SELECT CHAR(181);

-- Fun��o LEN() retorna o n�mero de caracteres da espress�o, excluindo os espa�os em branco
SELECT LEN('Caio Moreira Lima');
SELECT NOME, LEN(NOME) FROM cadfun WHERE DEPTO = '10';

-- Fun��o LOWER() retorna o formato min�sculo e UPPER() o formato mai�sculo de uma espress�o
SELECT lOWER('Caio Moreira Lima Da Silva Santo Aben�oado Por Jesus');
SELECT UPPER('Caio Moreira Lima Da Silva Santo Aben�oado Por Jesus');