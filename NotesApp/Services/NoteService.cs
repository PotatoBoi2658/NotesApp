using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Services
{
    public class NoteService
    {
        private readonly NotesDbContext _context;

        public NoteService()
        {
            _context = new NotesDbContext();
        }
        public NoteService(NotesDbContext context)
        {
            _context = context;
        }
        public void AddNote(string title, string content, int userId)
        {
            var note = new Note
            {
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now,
                UserId = userId
            };

            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public List<Note> GetNotesByUser(int userId)
        {
            return _context.Notes
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public void DeleteNote(int noteId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
            }
        }

        public void UpdateNote(int noteId, string newTitle, string newContent)
        {
            var note = _context.Notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)
            {
                note.Title = newTitle;
                note.Content = newContent;
                _context.SaveChanges();
            }
        }
    }
}
