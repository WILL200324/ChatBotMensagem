using System;

namespace ChatBotMensagens_2.Mensagens
{
    public abstract class Mensagem
    {
        public string Texto { get; set; }
        public DateTime DataEnvio { get; set; }

        public Mensagem(string texto)
        {
            Texto = texto;
            DataEnvio = DateTime.Now;
        }

        public abstract string Formatar();
    }
}
