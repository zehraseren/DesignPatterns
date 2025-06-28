using DP.Decorator.DAL;

namespace DP.Decorator.DecoratorPattern
{
    public class EncryptoByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();

        public EncryptoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendeMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageSubject = "Publish";
            message.MessageContent = "Saat 17:00'de Publish yapılacak.";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendeMessageByEncryptoContent(message);
        }
    }
}
