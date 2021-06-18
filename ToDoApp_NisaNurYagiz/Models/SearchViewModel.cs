using System;
using System.Collections.Generic;

namespace ToDoApp_NisaNurYagiz.Models
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }

        public bool ShowAll { get; set; }

        public List<ToDo> Result { get; set; }
    }
}
