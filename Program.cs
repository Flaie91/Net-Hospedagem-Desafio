using System.Text;
using Net_Hospedagem_Desafio.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 20);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária

try
{
  Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
  Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}
catch (System.Exception)
{
  
  Console.WriteLine("Não é possível efetuar a reserva!");  
}

