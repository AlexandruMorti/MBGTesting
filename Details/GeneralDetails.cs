using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Details
{
    public class GeneralDetails
    {
        public static void Main()
        {         
        }

        // mobbyslots.com        - MOB
        // mobjackpot.com        - MJP
        // anydaycasino.com      - ADC
        // ukcasinogames.co.uk   - UCG
        // slotstiches.com       - SLR

        public class Details
        {
            public static string BaseUrl = "";

            public static string Navigate = "Navigate to - " + BaseUrl;

            public static string Username = "";

            public static string Password = "";

            public static string ConfirmPassword = "";

            //Reset Password
            public static string YesterdayEmail = "";

            public static string Email = "";

            public static string Phone = "";

            public static string ActivationURL = "";

            //TEST WRONG ACTIVATION CODE

            public static string WrongNr1 = "";
            public static string WrongNr2 = "";
            public static string WrongNr3 = "";
            public static string WrongNr4 = "";

            //ACTIVATION CODE

            public static string Nr1 = "";
            public static string Nr2 = "";
            public static string Nr3 = "";
            public static string Nr4 = "";

            //COMPLETE YOUR ACCOUNT

            public static string FirstName = "";
            public static string LastName = "";

            public static string Day = "";
            public static string Month = "";
            public static string Year = "";

            //ADDRESS

            public static string HouseNr = "";
            public static string Address1 = "";
            public static string Address2 = "";
            public static string TownOrCity = "";

            //Reset Password
            public static string YestardayTownOrCity = "";

            public static string PostCode = "";
            public static string Country = "";


        }

        public class AddCreditDetails
        {
            public static string BaseUrl = "";

            public static string Username = "";

            public static string Password = "";

            public static string UsernameToCredit = Details.Username;

            public static string Ammount = "";

            public static string Comments = "";

        }
    }
}
