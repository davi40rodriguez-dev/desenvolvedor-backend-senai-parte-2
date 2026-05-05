using MasterBanco.Classes.Entidade;

Banco conta1 = new Banco("Kelwin", 1005, 1674.69m);
Banco conta2 = new Banco("Kelwin2", 1007, 164.69m);
Banco conta3 = new Banco("Kelwin1", 1008, 174.69m);
Banco.CadastrarContas(conta1);
Banco.CadastrarContas(conta2);
Banco.CadastrarContas(conta3);


Banco.LerContas();

Banco.DeletarConta(2);

Banco.LerContas();