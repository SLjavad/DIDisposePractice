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
            Console.WriteLine("Disposing Service B ..."); // set breakpoint here and check call stack in the Call Stack tab.
        }

        public void DoTaskB()
        {
            Console.WriteLine("execuring task from service B ...");
        }
    }
}
