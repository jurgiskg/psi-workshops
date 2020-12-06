using System;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Helpers
{
    public static class SortDecider
    {
        public static Func<Person, IComparable> GetSortFunction()
        {
            return person => person.FirstName;
        }    
    }
}
