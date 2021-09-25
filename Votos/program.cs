using System;
using System.Collections.Generic;
using System.IO;

namespace Votos {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, int> votos = new Dictionary<string, int>();
            
            string path = @"/home/vinicius/Documentos/projetos/csharp/Votos/votos.csv";
            try {
                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        string key = line.Split(',')[0];
                        int value = int.Parse(line.Split(',')[1]);
                        
                        if (!votos.ContainsKey(key))
                            votos[key] = value;
                        else
                            votos[key] += value;
                    }
                }
            } catch (IOException erro) {
                Console.WriteLine(erro.Message);
            }

            foreach (KeyValuePair<string, int> item in votos) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
