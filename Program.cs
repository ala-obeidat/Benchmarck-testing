using BenchmarkDotNet.Running;

namespace Testing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchy>();
        }
    }


}
