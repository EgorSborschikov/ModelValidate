using System;

namespace validation_models_exmaple{
    public class Validator{
        public bool IsValid(object model){
            if (model is Person person){
                return person.IsValid();
            }

            if (model is Address address){
                return address.IsValid();
            }

            throw new ArgumentException("Неподдерживаемый тип модели");
        }
    }
}