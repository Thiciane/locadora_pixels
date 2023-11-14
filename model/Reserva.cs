using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.model
{
    public class Reserva
    {
        public bool status { get; set; }
        public double valorcarro { get; set; }
        public double conta { get; set; }
        public double tempocarro { get; set; }

        public Reserva(bool status, double valorcarro, double conta, double tempocarro)
        {
            this.status = status;
            this.valorcarro = valorcarro;
            this.conta = conta;
            this.tempocarro = tempocarro;
        }
        public double Reservar()
        {
            Console.WriteLine("Digite a quantidade de tempo que você irá ficar com o veículo: ");
            tempocarro = Convert.ToDouble(Console.ReadLine());

            if (status == true)
            {
                Console.WriteLine("Escolha uma marca: \n 0_sair \n 1_Chevrolet \n 2_FIAT ");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        break; // Não é necessário o uso de goto
                    case 1:
                        Console.WriteLine("Escolha seu Modelo: \n 1_Montana \n 2_S10 \n 3_Onix");
                        string opcaoChevrolet = Console.ReadLine();
                        CalcularConta(opcaoChevrolet, 250, 300, 100);
                        break;
                    case 2:
                        Console.WriteLine("Escolha seu Modelo: \n 1_Strada \n 2_Cronos \n 3_Mobi ");
                        string opcaoFiat = Console.ReadLine();
                        CalcularConta(opcaoFiat, 200, 150, 80);
                        break;
                }
            }
            else
            {
                Console.WriteLine("O carro não está disponível.");
            }

            return conta;
        }
        private void CalcularConta(string opcao, double valorOpcao1, double valorOpcao2, double valorOpcao3)
        {
            switch (opcao)
            {
                case "1":
                    conta = valorOpcao1 * tempocarro;
                    break;
                case "2":
                    conta = valorOpcao2 * tempocarro;
                    break;
                case "3":
                    conta = valorOpcao3 * tempocarro;
                    break;
            }
        }
    }
}
