using System;
using System.Collections.Generic;

class Decimo{

    static void Main(string[] args){
        List<string> Lista = new List<string>();

        Console.WriteLine("=== Lista de tarefas ===");
        Console.WriteLine("Anote suas tarefas aqui. Se quiser sair, digite 'sair'.");

        while (true){

            Console.Write("Tarefa: ");
            string tarefa = Console.ReadLine(); 

            if (tarefa.ToLower() == "sair") 
                break;

            Lista.Add(tarefa); 
        }

        Console.WriteLine("\nTarefas Cadastradas: ");
        for (int i = 0; i < Lista.Count; i++) {
            Console.WriteLine($"{i + 1}. {Lista[i]}");
        }

        Console.Write("\nQual tarefa gostaria de marcar como concluída? (Digite o número ou 0 para ignorar): ");
        int concluido = int.Parse(Console.ReadLine());

        if (concluido > 0 && concluido <= Lista.Count) {
            Console.WriteLine($"Tarefa concluída: {Lista[concluido - 1]}");
            Lista.RemoveAt(concluido - 1);
        }

        Console.WriteLine("\nLista atualizada:"); 
        for (int i = 0; i < Lista.Count; i++){
            Console.WriteLine($"{i + 1}. {Lista[i]}");
        }
    }
}
