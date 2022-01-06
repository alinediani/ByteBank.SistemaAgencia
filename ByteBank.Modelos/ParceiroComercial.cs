using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper autenticacaoHelper = new AutenticacaoHelper ();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return autenticacaoHelper.CompararSenha (Senha, senha);
        }
    }
}