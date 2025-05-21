using ChatBotMensagens_2.Mensagens;
using System;

namespace ChatBotMensagens_2.Canais
{
    public class Facebook : Canal
    {
        public Facebook(string usuario) : base(usuario) { }

        public override void Enviar(Mensagem mensagem)
        {
            Console.WriteLine($"[Facebook] Para {Destinatario} => {mensagem.Formatar()}");
        }
    }
}
