using ChatBotMensagens_2.Mensagens;
using System;

namespace ChatBotMensagens_2.Canais
{
    public class Telegram : Canal
    {
        public Telegram(string usuario) : base(usuario) { }

        public override void Enviar(Mensagem mensagem)
        {
            Console.WriteLine($"[Telegram] Para {Destinatario} => {mensagem.Formatar()}");
        }
    }
}
