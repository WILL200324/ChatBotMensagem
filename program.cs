using System;
using System.Collections.Generic;
using ChatBotMensagens_2.Canais;
using ChatBotMensagens_2.Mensagens;

namespace ChatBotMensagens_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando mensagens
            var msgTexto = new MensagemTexto("Olá, tudo bem?");
            var msgFoto = new MensagemFoto("Veja essa imagem", "imagem", "jpg");
            var msgVideo = new MensagemVideo("Assista esse vídeo", "video", "mp4", 120);
            var msgArquivo = new MensagemArquivo("Segue o documento", "documento", "pdf");

            // Criando canais
            var canais = new List<Canal>
            {
                new WhatsApp("+551199999999"),
                new Telegram("@pedro_dev"),
                new Facebook("pedro.fb"),
                new Instagram("pedro_insta")
            };

            // Lista de mensagens para enviar
            var mensagens = new List<Mensagem> { msgTexto, msgFoto, msgVideo, msgArquivo };

            // Enviar todas as mensagens para todos os canais
            foreach (var canal in canais)
            {
                foreach (var mensagem in mensagens)
                {
                    canal.Enviar(mensagem);
                }
            }

            Console.ReadLine(); // Evita que o console feche imediatamente
        }
    }
}
