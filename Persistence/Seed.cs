using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser{DisplayName = "Bob", UserName = "bob", Email = "bob@test.com"},
                    new AppUser{DisplayName = "Tom", UserName = "tom", Email = "tom@test.com"},
                    new AppUser{DisplayName = "Jane", UserName = "jane", Email = "jane@test.com"},
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if (context.Documents.Any()) return;

            var documents = new List<Document>
            {
                new Document
                {
                    DocumentName = "ID",
                    FirstName = "Haruna A",
                    LastName = "Baldeh",
                    DocumentNumber = "123-2344-5555",
                    FounderName = "1234567",
                    PlaceFound = "Sinchu Alagi",
                    DateFound = DateTime.UtcNow

                },
                new Document
                {
                    DocumentName = "ID",
                    FirstName = "Fabala",
                    LastName = "Dibbasey",
                    DocumentNumber = "123-2344-5555",
                    FounderName = "1234567",
                    PlaceFound = "Sinchu Alagi",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                    DocumentName = "ID",
                    FirstName = "Oliver",
                    LastName = "Valentine",
                    DocumentNumber = "123-2344-5555",
                    FounderName = "1234567",
                    PlaceFound = "Serekunda Mosque",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                    DocumentName = "ID",
                    FirstName = "Abdoulie",
                    LastName = "Kassama",
                    DocumentNumber = "123-2344-5555",
                    FounderName = "1234567",
                    PlaceFound = "Brusubi",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                    DocumentName = "ID",
                    FirstName = "Michael",
                    LastName = "Jallow",
                    DocumentNumber = "123-2344-5555",
                    FounderName = "1234567",
                    PlaceFound = "Bakau New Town",
                    DateFound = DateTime.UtcNow
                },
            };

            await context.Documents.AddRangeAsync(documents);
            await context.SaveChangesAsync();
        }
    }
}