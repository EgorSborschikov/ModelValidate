using System;

namespace validation_models_exmaple{
    class Program{
        static void Main(string[] args){
            var consoleInputService = new ConsoleInputService();
            var validator = new Validator();

            var person = new Person{
                Name = consoleInputService.GetStringInput("Введите имя: "),
                Age = consoleInputService.GetIntInput("Введите возраст: "),
                Address = new Address{
                    City = consoleInputService.GetStringInput("Введите город: "),
                    Street = consoleInputService.GetStringInput("Введите улицу: ")
                }
            };

            if (validator.IsValid(person)){
                Console.WriteLine("Модель валидна");
            }
            else{
                Console.WriteLine("Модель невалидна");
            }
        }
    }
}