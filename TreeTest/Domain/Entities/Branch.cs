using TreeTest.Domain.Interfaces;

namespace TreeTest.Domain.Entities;

public class Branch : IDocumentComponent
{
    /// <summary>
    /// Children são os componentes que podem ser folhas ou outras Branches.
    /// Isto permite que Branches sejam compostas de outras Branches ou Leaves.
    /// </summary>
    private List<IDocumentComponent> Children { get; } = [];

    public void AddChild(IDocumentComponent child)
    {
        Children.Add(child);
    }

    public void Print()
    {
        foreach (var child in Children)
        {
            child.Print();
        }
    }

    public void Accept(IMonitor monitor, int depth)
    {
        monitor.Track(nameof(Branch), depth);
        foreach (var child in Children)
        {
            // depth + 1 é usado para indicar a profundidade do filho em relação à Branch atual.
            // Exemplo: se a Branch está no nível 0, seus filhos estarão no nível 1 e assim por diante.
            child.Accept(monitor, depth + 1);
        }
    }
}
