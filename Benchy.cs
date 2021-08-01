using BenchmarkDotNet.Attributes;

using System;

namespace Testing
{
    [MemoryDiagnoser]
    public class Benchy
    {
        private readonly Guid[] _input = new Guid[100000];

        [Benchmark]
        public void ForLoop()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                Guid.NewGuid();
            }
        }

        [Benchmark]
        public void ForEarch()
        {
            foreach (Guid item in _input)
            {
                Guid.NewGuid();
            }
        }
    }
}
