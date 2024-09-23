using DP.ChainOfResponsibility.DAL;
using DP.ChainOfResponsibility.Models;

namespace DP.ChainOfResponsibility.ChainOfResponsibility
{
    public class RegionalManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı, bölge direktörünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi. Müşterinin günlük maksimum çekebileceği tutar 400.000₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekmektedir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
