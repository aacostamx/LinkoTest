using LinkoTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LinkoTest.DataAccess
{
    public class BooksRepository : IBooksRepository
    {
        private LinkoContext context;
        private bool disposed = false;

        public BooksRepository(LinkoContext context)
        {
            this.context = context;
        }

        public void AddBook(Libro libro)
        {
            context.Libros.Add(libro);
        }

        public void DeleteBook(int LibroId)
        {
            Libro libro = context.Libros.Find(LibroId);
            context.Libros.Remove(libro);
        }

        public List<Libro> GetallBooks()
        {
            return context.Libros.ToList<Libro>();
        }

        public Libro GetBook(int LibroId)
        {
            return context.Libros.Find(LibroId);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateBook(Libro libro)
        {
            context.Entry(libro).State = EntityState.Modified;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}