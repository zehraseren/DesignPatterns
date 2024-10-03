using DP.Decorator.DAL;

namespace DP.Decorator.Decorator
{
    // DesignPattern klasöründe yeniden düzenlenerek yapıldı.
    public class CreateNotifier : INotifier
    {
        Context context = new Context();
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}
