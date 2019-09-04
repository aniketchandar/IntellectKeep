using IntellectKeep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntellectKeep.Controllers
{
    [RoutePrefix("api/Notes")]
    public class NotesApiController : ApiController
    {
        // GET: api/Notes/GetNotes
        [HttpGet]
        [Route("GetNotes")]
        public List<Models.Note> Get()
        {
            NotesDBContext db = new NotesDBContext();
            var NotesList = db.Notes.ToList();
            return NotesList;
        }


        // POST: api/Notes/AddNote
        [HttpPost]
        [Route("AddNote")]
        public Boolean AddNote(string title, string desc)
        {
            NotesDBContext db = new NotesDBContext();
            Models.Note note = new Note();
            note.Title = title;
            note.Desc = desc;

            db.Notes.Add(note);
            db.SaveChanges();
            return true;

        }

        // POST: api/Notes/DeleteNote
        [HttpPost]
        [Route("DeleteNote")]
        public Boolean DeleteNote(int id)
        {
            NotesDBContext db = new NotesDBContext();
            Note note = db.Notes.Find(id);
            db.Notes.Remove(note);
            db.SaveChanges();
            return true;

        }

    }
}
