using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFluentValidation
{
    class CasCadeTest01
    {


        public void Run()
        {
            var book = new Book("프로그램 개발", "홍길동", new DateTime());
            var bookValidator = new BookValidator();
            var result = bookValidator.Validate(book);

            Console.WriteLine($"Is Valid {result.IsValid}");

            if (!result.IsValid)
            {
                foreach (var errors in result.Errors)
                {
                    Console.WriteLine($"Error en {errors.PropertyName} {errors.ErrorMessage}");
                }
            }
        }
    }

    public class Book 
    {
        public readonly string author;
        public DateTime publishedDate;
        public string Name { get;  }

        public Book(string name, string author, DateTime publishedDate)
        {
            Name = name;
            this.author = author;
            this.publishedDate = publishedDate;
        }
    }

    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            //모든 에러 체크 안하고 한번만 발생해도 중지처리 
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(book => book.publishedDate).NotEqual(new DateTime()).Must(x => x >= DateTime.Now);
        }
    }
}
