namespace ChatBotMensagens_2.Mensagens
{
    public class MensagemFoto : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public MensagemFoto(string texto, string arquivo, string formato) : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override string Formatar()
        {
            return $"[Foto] {Texto} - Arquivo: {Arquivo} ({Formato}) - {DataEnvio}";
        }
    }
}
