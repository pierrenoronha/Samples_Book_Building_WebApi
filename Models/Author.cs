using System;

namespace Samples_Book_Building_WebApi.Models
{
    public partial class Author
    {
        public DateTime? BirthDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

    }
}
