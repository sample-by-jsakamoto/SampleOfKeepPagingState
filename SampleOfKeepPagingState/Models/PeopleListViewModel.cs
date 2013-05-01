using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleOfKeepPagingState.Models
{
    public class PeopleListViewModel
    {
        public IEnumerable<Person> PeopleAtAPage { get; set; }

        public int PageIndex { get; set; }

        public int NumberOfPages { get; set; }
    }
}