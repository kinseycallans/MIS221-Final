using System;
using System.Collections.Generic;
using System.Text;

namespace PA5
{
    class TransactionFile
    {
        int transactionID;
        string cusEmail;
        int movieID;
        string rentalDate;
        string returnDate;

        //No-Arg Constructor
        public TransactionFile()
        {

        }

        //Initialization Data-Shadowing Constructor
        public TransactionFile(int transactionID, string cusEmail, int movieID, string rentalDate, string returnDate)
        {
            this.transactionID = transactionID;
            this.cusEmail = cusEmail;
            this.movieID = movieID;
            this.rentalDate = rentalDate;
            this.returnDate = returnDate;
        }


    }
}
