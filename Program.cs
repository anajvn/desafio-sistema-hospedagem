using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}"); // Esperado: 2
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}"); // Esperado: 150,00

// Cria uma nova reserva, com um numero de dias igual a 10
Reserva reserva2 = new Reserva(diasReservados: 10);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}"); // Esperado: 2
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria().ToString("C2")}"); // Esperado: 270,00

// Cria uma nova reserva, com um numero de hospedes maior que a capacidade da suite
Reserva reserva3 = new Reserva(diasReservados: 5);
reserva3.CadastrarSuite(new Suite(tipoSuite: "Premium Single", capacidade: 1, valorDiaria: 30));
reserva3.CadastrarHospedes(hospedes); // Esperado: Exceção
