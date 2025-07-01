namespace TreeTest.Domain.Interfaces;

public interface IDocumentComponent
{
    /// <summary>
    /// Print é um método que imprime o componente.
    /// Branch irá imprimir todos os seus filhos recursivamente até chegar nas folhas
    /// Leaf irá imprimir seu conteúdo, que é um texto.
    /// </summary>
    void Print();

    /// <summary>
    /// Accept é um método que aceita um monitor que irá rastrear o componente e sua profundidade na árvore.
    /// Observação: o nome Accept foi escolhido para seguir o Visitor Pattern, onde o componente aceita a visita de um monitor.
    /// </summary>
    /// <param name="monitor"></param>
    /// <param name="depth"></param>
    void Accept(IMonitor monitor, int depth);
}
