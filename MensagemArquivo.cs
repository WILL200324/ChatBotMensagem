namespace ChatBotMensagens_2.Mensagens
{
    public class MensagemArquivo : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public MensagemArquivo(string texto, string arquivo, string formato) : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override string Formatar()
        {
            return $"[Arquivo] {Texto} - Arquivo: {Arquivo}.{Formato} - {DataEnvio}";
        }
    }
}
