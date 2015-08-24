using LinkoTest.Models;
using System;
using System.Collections.Generic;

namespace LinkoTest.DataAccess
{
    public interface IBooksRepository : IDisposable
    {
        List<Libro> GetallBooks();
        Libro GetBook(int LibroId);
        void AddBook(Libro libro);
        void DeleteBook(int LibroId);
        void UpdateBook(Libro libro);
        void Save();
    }
}
