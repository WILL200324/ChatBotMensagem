using ChatBotMensagens_2.Mensagens;
using System;

namespace ChatBotMensagens_2.Canais
{
    public class Instagram : Canal
    {
        public Instagram(string usuario) : base(usuario) { }

        public override void Enviar(Mensagem mensagem)
        {
            Console.WriteLine($"[Instagram] Para {Destinatario} => {mensagem.Formatar()}");
        }
    }
}
