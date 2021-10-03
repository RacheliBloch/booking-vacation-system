using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Enums
    {
        //public enum Type
        //{
        //    zimmer, apartment, hotelRoom, tent
        //}

        //public enum Area
        //{
        //    North, South, Center, Jerusalem
        //}

        //public enum orderStatus
        //{
        //    NotAddressed, sentEmail, aproved, unanswered, expired, closedForCustomerUnresponsiveness, closedForCustomerResponse
        //}

        //public enum GuestRequestStatus
        //{
        //    Active, closedThroughTheSite, closedBecauseItExpired
        //}

        //public enum Pool
        //{
        //    Necessary, optional, uninterested
        //}

        //public enum Jacuzzi
        //{
        //    Necessary, optional, uninterested
        //}

        //public enum Garden
        //{
        //    Necessary, optional, uninterested
        //}

        //public enum ChildrensAttractions
        //{
        //    Necessary, optional, uninterested
        //}

        public enum Type
        {
            צימר, דירה, חדר_מלון, מחנאות
        }

        public enum Area
        {
            צפון, דרום, מרכז, ירושלים
        }

        public enum orderStatus
        {
            לא_טופלה, נשלח_מייל, אושרה, לא_נענתה, לא_בתוקף, נסגרה_מחוסר_היענות, נסגר_מהיענות
        }

        public enum GuestRequestStatus
        {
            פתוחה, נסגרה_דרך_האתר, נסגר_מפאת_פקיעת_תוקף
        }

        public enum Pool
        {
            נחוץ, אפשרי, לא_מעונין
        }

        public enum Jacuzzi
        {
            נחוץ, אפשרי, לא_מעונין
        }

        public enum Garden
        {
            נחוץ, אפשרי, לא_מעונין
        }

        public enum ChildrensAttractions
        {
            נחוץ, אפשרי, לא_מעונין
        }

    }

}
