using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }

        public Book Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
