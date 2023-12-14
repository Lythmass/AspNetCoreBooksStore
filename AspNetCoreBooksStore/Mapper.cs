using AspNetCoreBooksStore.Dtos;
using AspNetCoreBooksStore.Models;
using Riok.Mapperly.Abstractions;

namespace AspNetCoreBooksStore
{
    [Mapper]
    public partial class Mapper
    {
        public partial Book DtoToBook(BookDto book);
    }
}
