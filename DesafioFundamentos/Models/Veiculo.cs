using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    class Veiculo
    {
        public string modelo { get; set; }
        public string placa { get; set; }

        public Veiculo(string modelo, string placa)
        {
            this.modelo = modelo;
            this.placa = placa;
        }

        public Veiculo()
        {
        }

        public override string ToString() 
        {
            return ("Modelo: " + modelo + " Placa: " + placa);
        }


    }
}
