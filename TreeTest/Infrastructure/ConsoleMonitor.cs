using TreeTest.Domain.Interfaces;

namespace TreeTest.Infrastructure;

public class ConsoleMonitor : IMonitor
{
    public void Track(string componentType, int depth)
    {
        Console.WriteLine($"[MONITOR] Tipo: {componentType}, Profundidade: {depth}, Horário: {DateTime.Now:HH:mm:ss.fff}");
    }
}
