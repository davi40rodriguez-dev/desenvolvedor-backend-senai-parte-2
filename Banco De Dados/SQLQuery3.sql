--OP READ - LER
/*
SELECT * FROM Contas;
GO


SELECT Id,Titular,Numero_da_Conta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas
Where Titular LIKE '%Maria%';
GO

SELECT * FROM Contas
WHERE Numero_da_conta = 1002
GO

--Ordenas por saldo do maior p/ menor
SELECT * FROM Contas
ORDER BY Saldo ASC
GO
*/
-- Contar quantar contas existe na tabela
SELECT COUNT(*) AS TotalContas FROM Contas

--Ordenas por  saldo do MENOR p/MAIOR
SELECT * FROM Contas
ORDER BY Saldo ASC
GO

--Soma todos Saldos das contas na tabela
SELECT SUM(Saldo) AS SaldoTotal FROM Contas

--
SELECT AVG(Saldo) AS MediaSaldos FROM Contas
GO