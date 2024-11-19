using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //Tranformando a classe em pública e estática (para todos poderem utilizar)
    //E estática (para todos utilizarem a mesma classe, não é necessário instaciar)
    public static class Usersession
    {
        //As variáveis que vão guardar as informações do usuário
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;
        

        //Encapsulei a variável para ter controle
        //Do que será inserido ou pego
        public static string Usuario
        {
            get { return _usuario; }
            set {
                value = value.ToUpper();
                _usuario =  value; 
            }
        }

        public static string Senha
        {
            get { return _senha; }
            set
            {
                value = value.ToUpper();
                _senha = value;
            }
        }

        public static string Nome
        {
            get { return _nome; }
            set
            {
                value = value.ToUpper();
                _nome = value;
            }
        }
    }
}
