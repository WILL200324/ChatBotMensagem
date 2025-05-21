using ChatBotMensagens_2.Mensagens;

namespace ChatBotMensagens_2.Canais
{
    public abstract class Canal
    {
        protected string Destinatario;

        public Canal(string destinatario)
        {
            Destinatario = destinatario;
        }

        public abstract void Enviar(Mensagem mensagem);
    }
}

