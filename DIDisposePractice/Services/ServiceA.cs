namespace DIDisposePractice.Services
{
    public class ServiceA : IServiceA
    {
        private readonly IServiceB serviceB;

        public ServiceA(IServiceB serviceB)
        {
            Console.WriteLine("service A intializing ...");
            this.serviceB = serviceB;
        }

        public void Dispose() => Console.WriteLine("Disposing service A....");

        public void DoTaskA()
        {
            Console.WriteLine("Executing Task from Service A ...");
        }
    }
}
