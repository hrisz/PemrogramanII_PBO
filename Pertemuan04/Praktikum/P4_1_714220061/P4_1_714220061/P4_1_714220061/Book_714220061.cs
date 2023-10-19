using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220061
{
    public class Book_714220061: Product_714220061
    {
        protected string pageCount;

        public Book_714220061(string type, string title, string pagecount): base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        { 
            get 
            { 
                return pageCount; 
            } 
            set 
            { 
                this.pageCount = value; 
            }
        }
    }
}
