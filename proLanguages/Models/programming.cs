using System;
using System.ComponentModel.DataAnnotations;

namespace languages.models
{
        public class proLanguage
        {
            public int id {get; set;}
            public string name {get; set;}

            [DataType(DataType.Date)]
            public DateTime releaseYear {get; set;}

            public string developBy {get; set;}
            public string usedBy {get; set;}
        }
    
}