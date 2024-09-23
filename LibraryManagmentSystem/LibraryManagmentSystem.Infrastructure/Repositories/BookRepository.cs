using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly LibraryDBContext _context;

        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<int> GetTotalBooksAsync()
        {
            return await _context.Books.CountAsync();
        }

        public async Task IssueBookAsync(Book book, User member)
        {
            // Assuming there's an entity called IssuedBook
            var issuedBook = new IssuedBook
            {
                BookId = book.Id,
                UserId = member.Id,
                IssueDate = DateTime.Now
            };
            _context.IssuedBooks.Add(issuedBook);
            await _context.SaveChangesAsync();
        }

    }
}
