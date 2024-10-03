using DP.Decorator.DAL;

namespace DP.Decorator.Decorator
{
    // DesignPattern klasöründe yeniden düzenlenerek yapıldı.
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        Context context = new Context();

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendeMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }

        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendeMailNotify(notifier);
        }
    }
}
