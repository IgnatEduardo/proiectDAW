﻿using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<Book>? Books { get; set; }    

    }
}