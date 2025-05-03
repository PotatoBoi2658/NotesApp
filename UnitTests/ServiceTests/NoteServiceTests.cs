using Microsoft.EntityFrameworkCore;
using NotesApp.Data;
using NotesApp.Services;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Tests
{
    [TestFixture]
    public class NoteServiceTests
    {
        private NotesDbContext _context;
        private NoteService _noteService;
        private User _testUser;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<NotesDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // нова база за всеки тест
                .Options;

            _context = new NotesDbContext(options);
            _noteService = new NoteService(_context);

            _testUser = new User
            {
                Username = "user1",
                Email = "user1@example.com",
                Password = "pass"
            };

            _context.Users.Add(_testUser);
            _context.SaveChanges();
        }
        [TearDown]
        public void TearDown()
        {
            _context.Dispose();

        }
        [Test]
        public void AddNote_Should_Save_Note_In_Database()
        {
            _noteService.AddNote("Заглавие", "Съдържание", _testUser.Id);

            var note = _context.Notes.FirstOrDefault();
            ClassicAssert.IsNotNull(note);
            ClassicAssert.AreEqual("Заглавие", note.Title);
            ClassicAssert.AreEqual(_testUser.Id, note.UserId);
        }

        [Test]
        public void GetNotesByUser_Should_Return_Only_That_User_Notes()
        {
            _noteService.AddNote("Моя бележка", "Текст", _testUser.Id);

            // Добавяме чужда бележка
            var otherUser = new User { Username = "user2", Email = "u2@x.com", Password = "123" };
            _context.Users.Add(otherUser);
            _context.SaveChanges();

            _noteService.AddNote("Чужда бележка", "...", otherUser.Id);

            var notes = _noteService.GetNotesByUser(_testUser.Id);

            ClassicAssert.AreEqual(1, notes.Count);
            ClassicAssert.AreEqual("Моя бележка", notes[0].Title);
        }

        [Test]
        public void DeleteNote_Should_Remove_It_From_Database()
        {
            _noteService.AddNote("Ще бъде изтрита", "Delete me", _testUser.Id);
            var note = _context.Notes.First();

            _noteService.DeleteNote(note.Id);

            var deleted = _context.Notes.Find(note.Id);
            ClassicAssert.IsNull(deleted);
        }

        [Test]
        public void UpdateNote_Should_Change_Title_And_Content()
        {
            _noteService.AddNote("Стара бележка", "Стар текст", _testUser.Id);
            var note = _context.Notes.First();

            _noteService.UpdateNote(note.Id, "Нова бележка", "Нов текст");

            var updated = _context.Notes.Find(note.Id);
            ClassicAssert.AreEqual("Нова бележка", updated.Title);
            ClassicAssert.AreEqual("Нов текст", updated.Content);
        }
    }
}
