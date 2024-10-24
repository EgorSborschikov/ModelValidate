using System;

namespace validation_models_exmaple{
    public class Address{
        public string City { get; set; }
        public string Street { get; set; }

        public bool IsValid(){
            if (string.IsNullOrEmpty(City)){
                Console.WriteLine("Город является обязательным");
                return false;
            }

            if (string.IsNullOrEmpty(Street)){
                Console.WriteLine("Улица является обязательной");
                return false;
            }

            return true;
        }
    }
}