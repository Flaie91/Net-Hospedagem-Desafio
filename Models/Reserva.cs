namespace Net_Hospedagem_Desafio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {                
                 Console.WriteLine($"Quantidade de hospedes ({hospedes.Count}), é maior que a capacidade da Suite ({Suite.Capacidade}).");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {                                  
            return Hospedes.Count;
        }
        

        public decimal CalcularValorDiaria()
        {            
            decimal valor = 0;  

            valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados>=10)
            {
                valor *= 0.90m;
            }   
            return valor;
        }
    }
}