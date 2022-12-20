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
                    FounderFullName = "Haruna A Baldeh",
                    FounderPhoneNumber = "123-456-7",
                    FounderAddress = "Nafugan Jomel",
                    OwnerFullName = "Ensa Wally",
                    DocumentNumber = "123-2344-5555",
                    PlaceFound = "Sinchu Alagi",
                    DateFound = DateTime.UtcNow

                },
                new Document
                {
                    DocumentName = "Passport",
                    FounderFullName = "Awa Krubally",
                    FounderPhoneNumber = "123-456-7",
                    FounderAddress = "Kunkujang Keitya",
                    OwnerFullName = "Anna Marie Mendy",
                    DocumentNumber = "123-2344-5555",
                    PlaceFound = "Wellingara",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                    DocumentName = "ID",
                    FounderFullName = "Musa Ndow",
                    FounderPhoneNumber = "123-456-7",
                    FounderAddress = "Nusrat Village",
                    OwnerFullName = "Edrisa Buwaro",
                    DocumentNumber = "123-2344-5555",
                    PlaceFound = "Kunkujang Keitaya",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                    DocumentName = "Work ID",
                    FounderFullName = "Sulayman Mbye",
                    FounderPhoneNumber = "123-456-7",
                    FounderAddress = "Sare Bojo",
                    OwnerFullName = "Mariatou Waggeh",
                    DocumentNumber = "123-2344-5555",
                    PlaceFound = "Basse, Mansanjang",
                    DateFound = DateTime.UtcNow
                },
                new Document
                {
                   DocumentName = "Passport",
                    FounderFullName = "Medina Krubally",
                    FounderPhoneNumber = "123-456-7",
                    FounderAddress = "Sinchu Alagi",
                    OwnerFullName = "Abdoulie Mbye",
                    DocumentNumber = "123-2344-5555",
                    PlaceFound = "Nafugan Jomel",
                    DateFound = DateTime.UtcNow
                },
            };

            await context.Documents.AddRangeAsync(documents);
            await context.SaveChangesAsync();
        }
    }
}