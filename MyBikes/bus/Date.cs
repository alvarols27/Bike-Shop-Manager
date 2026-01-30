using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public struct Date
    {
        //Fields
        private int day;
        private int month;
        private int year;

        //Properties
        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }
        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        //Constructors
        public Date()
        {
            this.day = 0;
            this.month = 0;
            this.year = 0;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        //Methods
        //Created to validate the data
        public bool IsValidDate()
        {
            if (year < 1880 || year > 2024)
                return false;

            if (month < 1 || month > 12)
                return false;

            if (day < 1 || day > 31)
                return false;

            //Months with less than 31 days
            if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                return false;

            // February
            if (month == 2)
            {
                // Leap year check
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    if (day > 29)
                        return false;
                }
                else
                {
                    if (day > 28)
                        return false;
                }
            }
            return true;
        }

        public string GetDateState()
        {
            string state;
            state = this.day + "/" + this.month + "/" + this.year;
            return state;
        }
    }
}