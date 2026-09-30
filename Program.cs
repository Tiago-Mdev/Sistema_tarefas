Console.WriteLine("==================");
Console.WriteLine("Sistema de tarefas");
Console.WriteLine("==================");
Console.WriteLine("\nRegistrar tarefas - 1 \nListar tarefas - 2 \nExcluir tarefas - 3 \nSair - 4");

int respostaMenuInicial = int.Parse(Console.ReadLine());
List<string> tarefas = ["caçar rato"]; 


switch(respostaMenuInicial)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Bem vindo ao registro de tarefas");
        Console.WriteLine("\nRegistre aqui : ");
        Console.ReadLine();
        tarefas.Add(Console.ReadLine());
        break;
    case 2:
        Console.Clear();
        Console.WriteLine($"Aqui esta a lista de tarefas : {string.Join(", ", tarefas)}");
        Console.ReadLine();    
        break;
    case 3:
        Console.Clear();
        Console.WriteLine($"Qual tarefa deseja excluir? " +
            $"\n Lista de tarefas : {string.Join(", ", tarefas)}");
        var tarefaInutil = Console.ReadLine();
        if (tarefas.Contains(tarefaInutil)) { tarefas.Remove(tarefaInutil); Console.WriteLine("tarefa removida com sucesso"); } else { Console.WriteLine("Tarefa não encontrada"); }
        break;
    default:
        Console.Clear();
        Console.WriteLine("Adeus :(");
        break;
}