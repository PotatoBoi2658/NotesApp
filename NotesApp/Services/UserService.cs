using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp.Services;

namespace NotesApp.Services
{
    public class UserService
    {
        private readonly NotesDbContext _context;

        public UserService()
        {
            _context = new NotesDbContext();


        }
        public UserService(NotesDbContext context)
        {
            _context = context;
        }
        public User? Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
        public User? GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
        public User? GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public User AddUser(string username, string email , string password)
        {
            var user = new User
            {
                Username = username,
                Email = email,
                Password = password
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id == userId);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.OrderBy(u => u.Username).ToList();
        }

        public void DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
