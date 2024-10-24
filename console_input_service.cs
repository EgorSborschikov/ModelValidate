using System;

namespace validation_models_exmaple{
    public class ConsoleInputService{
        public string GetStringInput(string prompt){
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public int GetIntInput(string prompt){
            while (true){
                if (int.TryParse(GetStringInput(prompt), out int value)){
                    return value;
                }

                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }
}