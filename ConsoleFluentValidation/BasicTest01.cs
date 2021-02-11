using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace ConsoleFluentValidation
{
    class BasicTest01
    {

        public class BeerValidator : AbstractValidator<Beer>
        {
            List<Beer> _beers = new List<Beer>();
            public BeerValidator(List<Beer> beers)
            {
                RuleFor(x => x.Name).NotEmpty().MaximumLength(50).Must(ExistBeer);
                RuleFor(x => x.Alcohol).NotNull().GreaterThan(0);
                RuleFor(x => x.Brand).NotNull().MaximumLength(20).NotEqual("Corona");
                _beers = beers;
            }

            public bool ExistBeer(string name)
                => _beers.Any(d => d.Name == name) ? false : true;
        }


        public class Beer
        {
            public string Name { get; set; }
            public decimal Alcohol { get; set; }
            public string Brand { get; set; }
        }


        public void Run()
        {
            Console.WriteLine("Hello World!");

            List<Beer> beers = new List<Beer>();

            var beer = new Beer() { Name = "Themes", Alcohol = 8.5m, Brand = "카스" };
            beers.Add(beer);

            var beer2 = new Beer() { Name = "Themes2", Alcohol = -0.5m, Brand = "카스" };
            beers.Add(beer2);

            var validator = new BeerValidator(beers);
            ValidationResult result = validator.Validate(beer);

            if (!result.IsValid)
            {
                foreach (var errors in result.Errors)
                {
                    Console.WriteLine($"Error en {errors.PropertyName} {errors.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine("종료!!");
            }
        }
    }
}
