namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() { Id = 1, Name = "J. K. Rowling" },
                new Author() { Id = 2, Name = "Stephen King" },
                new Author() { Id = 3, Name = "Jeff Kinney" },
                new Author() { Id = 4, Name = "Dr. Seuss" }
                );

            context.Books.AddOrUpdate(
                new Book () {
                    Id = 1,
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Year = 2017,
                    AuthorId = 1,
                    Price = 9.99M,
                    Genre = "Children's Books"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Fantastic Beasts and Where to Find Them",
                    Year = 2017,
                    AuthorId = 1,
                    Price = 8.30M,
                    Genre = "Children's Books"
                }
                , new Book()
                {
                    Id = 3,
                    Title = "IT",
                    Year = 2017,
                    AuthorId = 2,
                    Price = 10.41M,
                    Genre = "Thriller"
                },
                new Book()
                {
                    Id = 4,
                    Title = "The Dark Tower",
                    Year = 2016,
                    AuthorId = 2,
                    Price = 7.58M,
                    Genre = "Fiction"
                },
                new Book()
                {
                    Id = 5,
                    Title = "The Getaway",
                    Year = 2017,
                    AuthorId = 3,
                    Price = 9.99M,
                    Genre = "Children's Books"
                },
                new Book()
                {
                    Id = 6,
                    Title = "You're Only Old Once!: A Book for Obsolete Children",
                    Year = 2009,
                    AuthorId = 4,
                    Price = 8.91M,
                    Genre = "Humor"
                },
                new Book()
                {
                    Id = 7,
                    Title = "How the Grinch Stole Christmas!",
                    Year = 1957,
                    AuthorId = 4,
                    Price = 9.44M,
                    Genre = "Children's Books"
                } 
                );
        }
    }
}
