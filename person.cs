using System;

namespace validation_models_exmaple{
    public class Person{
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public bool IsValid(){
            if (string.IsNullOrEmpty(Name)){
                Console.WriteLine("Имя является обязательным");
                return false;
            }

            if (Age < 18 || Age > 100){
                Console.WriteLine("Возраст должен быть от 18 до 100 лет");
                return false;
            }

            return true;
        }
    }
}