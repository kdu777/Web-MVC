namespace LHPet.Models;
classe pública Cliente
{
/* No trecho de código a seguir são criados os
atributos de Cliente e seus getters e setters
correspondentes. */
public int ID { get; definir; }
string pública Nome {obter; definir; }
string pública Cpf { obter; definir; }
public string E-mail { get; definir; }
public string Paciente { get; definir; }
/* Nesse trecho do código, é criado o Construtor do
modelo Cliente e determina quais parâmetros são
necessária na criação das instâncias. */
public Cliente(int id, string nome, string cpf,
string email, string paciente)
{
this.Id = id;
this.Nome = nome;
this.Cpf = cpf;
this.Email = email;
this.Paciente = paciente;
}
}
