namespace TreeTest.Domain.Interfaces;

public interface IMonitor
{
    void Track(string componentType, int depth);
}
