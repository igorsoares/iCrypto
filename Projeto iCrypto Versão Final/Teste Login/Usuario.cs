using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Login
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public ServidorSMTP servidorSMTP { get; set; }
        public string historicoRSA { get; set; }
        public string historicoEsteganografia { get; set; }
        public string historicoAES { get; set; }
        public string historicoAESArquivo { get; set; }
        public string historicoMorse { get; set; }
        public string historicoCesar { get; set; }
    }
}
