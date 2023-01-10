using RestWithASPNet5Udemy1.Data.VO;
using RestWithASPNet5Udemy1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using RestWithASPNet5Udemy1.Data.Converter.Contract;

namespace RestWithASPNet5Udemy1.Data.Converter.Implementions {
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO> {
        public Book Parse(BookVO origin) {
            if (origin == null) return null;
            return new Book {
                Id = origin.Id,
                Author = origin.Author,
                Launch_Date = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public BookVO Parse(Book origin) {
            if (origin == null) return null;
            return new BookVO {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.Launch_Date,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public List<Book> Parse(List<BookVO> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
