using Microsoft.EntityFrameworkCore;
using Moq;
using NotesApp.Data;
using NotesApp.Services;
using NUnit.Framework.Legacy;
using System.Net.NetworkInformation;

namespace NotesApp.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private NotesDbContext _context;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<NotesDbContext>()
                .UseInMemoryDatabase(databaseName: "UserServiceTestsDb")
                .Options;

            _context = new NotesDbContext(options);
            _userService = new UserService(_context);

            // Създаваме тестов потребител
            var user = new User
            {
                Username = "testuser",
                Email = "test@example.com",
                Password = "password123"
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        [Test]
        public void Login_WithCorrectCredentials_ReturnsUser()
        {
            var user = _userService.Login("testuser", "password123");
            ClassicAssert.IsNotNull(user);
            ClassicAssert.AreEqual("testuser", user.Username);
        }

        [Test]
        public void Login_WithIncorrectCredentials_ReturnsNull()
        {
            var user = _userService.Login("testuser", "wrongpassword");
            ClassicAssert.IsNull(user);
        }

        [Test]
        public void GetUserByUsername_ShouldReturnCorrectUser()
        {
            var user = _userService.GetUserByUsername("testuser");
            ClassicAssert.IsNotNull(user);
            ClassicAssert.AreEqual("test@example.com", user.Email);
        }
        [Test]
        public void GetUserByEmail_ShouldReturnCorrectEmail()
        {
            var email = _userService.GetUserByEmail("testuser");
            ClassicAssert.IsNotNull(email);
            ClassicAssert.AreEqual("testuser", email.Username);
        }

        [Test]
        public void GetUserById_ShouldReturnCorrectUser()
        {
            var userInDb = _context.Users.First();
            var user = _userService.GetUserById(userInDb.Id);
            ClassicAssert.IsNotNull(user);
            ClassicAssert.AreEqual("testuser", user.Username);
        }

        [Test]
        public void GetAllUsers_ShouldReturnAllUsers()
        {
            var users = _userService.GetAllUsers();
            ClassicAssert.AreEqual(1, users.Count);
            ClassicAssert.AreEqual("testuser", users[0].Username);
        }

        [Test]
        public void AddUser_ShouldCreateNewUser()
        {
            _userService.AddUser("newuser", "new@example.com", "newpass");

            var user = _context.Users.FirstOrDefault(u => u.Username == "newuser");
            ClassicAssert.IsNotNull(user);
            ClassicAssert.AreEqual("new@example.com", user.Email);
        }

        [Test]
        public void DeleteUser_ShouldRemoveUser()
        {
            var user = _context.Users.First();
            _userService.DeleteUser(user.Id);

            var deleted = _context.Users.Find(user.Id);
            ClassicAssert.IsNull(deleted);
        }

        [Test]
        public void UpdateUser_ShouldChangeUserInfo()
        {
            var user = _context.Users.First();
            user.Email = "updated@example.com";
            _userService.UpdateUser(user);

            var updated = _context.Users.First(u => u.Id == user.Id);
            ClassicAssert.AreEqual("updated@example.com", updated.Email);
        }
    }
}
