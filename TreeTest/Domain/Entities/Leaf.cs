using TreeTest.Domain.Interfaces;

namespace TreeTest.Domain.Entities;

public class Leaf(string text) : IDocumentComponent
{
    public string Text { get; } = text;

    public void Print()
    {
        Console.WriteLine(Text);
    }

    public void Accept(IMonitor monitor, int depth)
    {
        monitor.Track(nameof(Leaf), depth);
    }
}
