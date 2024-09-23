using DP.ChainOfResponsibility.Models;

namespace DP.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee? NextApprover;
        public void SetNextApprover(Employee superVisior)
        {
            this.NextApprover = superVisior;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
    }
}
