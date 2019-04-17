namespace BooksAPI.Migrations
{
    using BooksAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksAPI.Models.BooksAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BooksAPI.Models.BooksAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Authors.AddOrUpdate(new Author[]
                {
                    new Author(){AuthorId=1, Name="Suresh"},
                    new Author(){AuthorId=2, Name ="Manish"},
                    new Author(){AuthorId=3, Name="Raju"},
                    new Author(){AuthorId=4, Name ="Ajay"}
                });

            context.Books.AddOrUpdate(new Book[]
                {
                    new Book() {BookId =1, Title ="Title1", Genre = "Fantasy",
                    PublishDate=new DateTime(2000, 12, 6), AuthorId=1, Description = "Title1 Description", Price = 100M},
                    new Book (){ BookId=2, Title ="Title2", Genre ="Fantasy",
                    PublishDate =new DateTime (2001, 12, 10), AuthorId =2, Description ="Title2 description", Price=150M},
                    new Book(){BookId=3, Title="Title3", Genre ="Romance", 
                    PublishDate =new DateTime(2002, 10, 2), AuthorId=2, Description ="Title3 description", Price =100M},
                                        new Book() {BookId =4, Title ="Title1", Genre = "Fantasy",
                    PublishDate=new DateTime(2010, 12, 6), AuthorId=3, Description = "Title4 Description", Price = 1100M},
                    new Book (){ BookId=5, Title ="Title2", Genre ="Fantasy",
                    PublishDate =new DateTime (2002, 12, 10), AuthorId =4, Description ="Title5 description", Price=1500M}
                });
        }
    }
}
