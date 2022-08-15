using BenchmarkDotNet.Attributes;

public class ParseTest
{
    private string _guid = Guid.NewGuid().ToString();

    [Benchmark]
    public Guid Parse() => Guid.Parse(_guid);
}