using TreeTest.Domain.Entities;
using TreeTest.Infrastructure;

// == Desenho do teste ==

// folhas finais
var leaf1 = new Leaf("Leaf 1");
var leaf2 = new Leaf("Leaf 2");
var leaf3 = new Leaf("Leaf 3");
var leaf4 = new Leaf("Leaf 4");
var leaf5 = new Leaf("Leaf 5");

// branch final com duas folhas
var lastBranch = new Branch();
lastBranch.AddChild(leaf4);
lastBranch.AddChild(leaf5);

// branch que tem Leaf 2, lastBranch e Leaf 3
var middleBranch = new Branch();
middleBranch.AddChild(leaf2);
middleBranch.AddChild(lastBranch);
middleBranch.AddChild(leaf3);

// branch inicial que tem Leaf 1 e middleBranch
var root = new Branch();
root.AddChild(leaf1);
root.AddChild(middleBranch);

// monitoramento e impressão (importado da infra, em um contexto real, seria injetado via DI)
var monitor = new ConsoleMonitor();

Console.WriteLine("=== Impressão do Documento ===");
root.Print();

Console.WriteLine("\n=== Monitoramento da Árvore ===");
root.Accept(monitor, 0);

// Exemplo de saída esperada:
/*
root
├── Leaf 1
└── middleBranch
    ├── Leaf 2
    ├── lastBranch
    │   ├── Leaf 4
    │   └── Leaf 5
    └── Leaf 3
*/