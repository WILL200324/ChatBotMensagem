using ChatBotMensagens_2.Mensagens;
using System;

namespace ChatBotMensagens_2.Canais
{
    public class WhatsApp : Canal
    {
        public WhatsApp(string numero) : base(numero) { }

        public override void Enviar(Mensagem mensagem)
        {
            Console.WriteLine($"[WhatsApp] Para {Destinatario} => {mensagem.Formatar()}");
        }
    }
}
