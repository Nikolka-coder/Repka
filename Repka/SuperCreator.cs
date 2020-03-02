using System;
using System.Collections.Generic;
using System.Text;

namespace Repka
{
    public class SuperCreator<T> where T : class
    {
        public List<T> Characters { get; set; }
        public SuperCreator()
        {
            Characters = new List<T>();
        }
    }
}
