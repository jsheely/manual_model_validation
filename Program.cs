using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace model_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new TestModel
            {
                Name = "Wow. That totally works!"
            };

            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(data, new ValidationContext(data), results, true);
        }
    }
    public class TestModel
    {
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
