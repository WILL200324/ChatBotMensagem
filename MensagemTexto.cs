namespace ChatBotMensagens_2.Mensagens
{
    public class MensagemTexto : Mensagem
    {
        public MensagemTexto(string texto) : base(texto) { }

        public override string Formatar()
        {
            return $"[Texto] {Texto} - {DataEnvio}";
        }
    }
}
