namespace DIDisposePractice.Services
{
    public class ServiceB : IServiceB
    {
        public ServiceB()
        {
            Console.WriteLine("Initializing Service B ...");
        }
        public void Dispose()
        {
            Console.WriteLine("Disposing Service B ...");
        }

        public void DoTaskB()
        {
            Console.WriteLine("execuring task from service B ...");
        }
    }
}
