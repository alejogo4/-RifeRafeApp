using rife_rafe_backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Data
{
    public class SeedDB
    {

        private readonly ApplicationDbContext _context;

        public SeedDB(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task SeedAsync()
        {
 
            await CheckDocumentTypesAsync();
            await CheckCategoryAsync();
            await CheckUserAsync("1010", "Alejandro", "Giraldo", "alejo@yopmail.com", "311 322 4620", "Calle Luna Calle Sol");
            await CheckUserAsync("2020", "Juan", "David", "juanda@yopmail.com", "311 322 4620", "Calle Luna Calle Sol");

        }


        private async Task CheckUserAsync(string document, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            /*
            User user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Address = address,
                    Document = document,
                    DocumentType = _context.DocumentTypes.FirstOrDefault(x => x.Description == "Cédula"),
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    UserName = email,
                    UserType = userType
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());

                string token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);
            }*/
        }

        private async Task CheckDocumentTypesAsync()
        {
            if (!_context.DocumentType.Any())
            {
                _context.DocumentType.Add(new DocumentType { Description = "Cédula" });
                _context.DocumentType.Add(new DocumentType { Description = "Tarjeta de Identidad" });
                _context.DocumentType.Add(new DocumentType { Description = "NIT" });
                _context.DocumentType.Add(new DocumentType { Description = "Pasaporte" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoryAsync()
        {
            if (!_context.Category.Any())
            {
                _context.Category.Add(new Category { Name = "Técnologia" });
                _context.Category.Add(new Category { Name = "Moda" });
                _context.Category.Add(new Category { Name = "Videojuegos" });
                _context.Category.Add(new Category { Name = "Arte" });

                await _context.SaveChangesAsync();
            }
        }

    }
}
