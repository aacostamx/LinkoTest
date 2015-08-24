using LinkoTest.DataAccess;
using LinkoTest.Models;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace LinkoTest.Controllers
{
    [Authorize]
    public class LibrosController : Controller
    {
        private IBooksRepository bookRepository;

        public LibrosController()
        {
            this.bookRepository = new BooksRepository(new LinkoContext());
        }

        public LibrosController(IBooksRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public ActionResult Index()
        {
            var libros = from l in bookRepository.GetallBooks()
                         select l;

            return View(libros.ToList());
        }

        public ActionResult Details(int id)
        {
            Libro libro = bookRepository.GetBook(id);

            if (libro == null)
                return HttpNotFound();

            return View(libro);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LibroId,NombreLibro,Autor,ISBN")] Libro libro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookRepository.AddBook(libro);
                    bookRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "No fue posible agregar los cambios. Por favor, intentarlo de nuevo, y si el problema persiste contacta al administrador.");
            }

            return View(libro);
        }

        public ActionResult Edit(int id)
        {
            Libro libro = bookRepository.GetBook(id);
            if (libro == null)
                return HttpNotFound();

            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LibroId,NombreLibro,Autor,ISBN")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                bookRepository.UpdateBook(libro);
                bookRepository.Save();
                return RedirectToAction("Index");
            }
            return View(libro);
        }

        public ActionResult Delete(int id)
        {
            Libro libro = bookRepository.GetBook(id);
            if (libro == null)
                return HttpNotFound();
            return View(libro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libro libro = bookRepository.GetBook(id);
            bookRepository.DeleteBook(libro.LibroId);
            bookRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            bookRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}