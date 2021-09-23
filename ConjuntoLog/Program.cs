using System;
using System.Collections.Generic;
using System.IO;

namespace ConjuntoLog {
    class Program {
        static void Main(string[] args){
            HashSet<Log> logs = new HashSet<Log>();
            string caminho = @"/home/vinicius/Documentos/projetos/csharp/ConjuntoLog/log.txt";
            
            try {
                using (StreamReader reader = File.OpenText(caminho)) {
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        string usuário = line.Split(" ")[0];
                        DateTime momento = DateTime.Parse(line.Split(" ")[1]);
                        logs.Add(new Log(usuário, momento));
                    }
                } 
            } catch (IOException erro) {
                Console.WriteLine(erro.Message);                
            }

            Console.WriteLine($"Usuários totais: {logs.Count}");
        }
    }
}
