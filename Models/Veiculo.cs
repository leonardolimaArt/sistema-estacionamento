using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Veiculo
    {
        private String _placa;
        public String placa{
                    get { return _placa; }
                    set { _placa = value; }
                    }

        private String _modelo;
        public String modelo{
                    get { return _modelo; }
                    set { _modelo = value; }
                    }
    }
}