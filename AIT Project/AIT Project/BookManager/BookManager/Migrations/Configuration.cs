namespace BookManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookManager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookManager.Models.ApplicationDbContext context)
        {
            context.Books.AddOrUpdate(p => p.Name,
        new Books
        {
            BookID = 1,
            Name = "Gone Girl",
            Author = "Gillian Flynn",
            Genre = "Fiction",
            ISBN = "1780228228",
        },

        new Books
        {
            BookID = 2,
            Name = "The Sleeper and the Spindle",
            Author = "Neil Gaiman",
            Genre = "Fiction",
            ISBN = "1408859645",
        },

         new Books
         {
             BookID = 3,
             Name = "What If?",
             Author = "Randall Munroe",
             Genre = "Non-Fiction",
             ISBN = "1848549571",
         },

         new Books
         {
             BookID = 4,
             Name = "The Goldfinch",
             Author = "Donna Tartt",
             Genre = "Fiction",
             ISBN = "0349139636",
         },

         new Books
         {
             BookID = 5,
             Name = "Unbroken",
             Author = "Laura Hillenbrand",
             Genre = "Non-Fiction",
             ISBN = "0007378033",
         }
         );

        }
    }
}
