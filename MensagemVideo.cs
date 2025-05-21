namespace ChatBotMensagens_2.Mensagens
{
    public class MensagemVideo : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }
        public int Duracao { get; set; }

        public MensagemVideo(string texto, string arquivo, string formato, int duracao) : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
            Duracao = duracao;
        }

        public override string Formatar()
        {
            return $"[Vídeo] {Texto} - Arquivo: {Arquivo}.{Formato} - Duração: {Duracao}s - {DataEnvio}";
        }
    }
}
