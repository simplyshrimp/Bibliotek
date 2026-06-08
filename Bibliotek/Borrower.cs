using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class Borrower
    {
        public int BorrowerNumber { get; set; }
        public string Library { get; set; }

        public Borrower(int  BorrowerNumber, string Library)
        {
            this.BorrowerNumber = BorrowerNumber;
            this.Library = Library;
        }

        public string GetBorrower()
        {
            return ($"ID: {BorrowerNumber}\nLibrary: {Library}");
        }
    }
}
