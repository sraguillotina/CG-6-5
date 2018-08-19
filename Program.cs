using System;

namespace Class6_HoroscopeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Initialized program and takes first input by user to be used with local methods.
            Console.Write("Hi, there. Tell me your birthday (mm/dd/yyyy) and I'll tell you your fortune: ");
            //Assigned the user's entry to variable 'userBirthday'
            var userBirthday = Console.ReadLine();

            //Create line space
            Console.WriteLine();

            //Invoked 'DayOfBirth' method, and passed 'userBirthday' string, to get day of week.
            Console.WriteLine($"You were born on a {DayOfBirth(userBirthday)}.");
            //Invoked 'DayNextBirthday' method, and passed 'userBirthday' string, 
            //to get day of week for next birthday.
            Console.WriteLine($"Your next birthday will fall on a {DayNextBirthday(userBirthday)}.");

            //Creates a space before the zodiac- and fortune-telling method.
            Console.WriteLine();

            //Invoked 'GetZodiacSign' method, and passed 'userBirthday' string, to get Zodiac
            //and appropriate fortune.
            Console.WriteLine(GetZodiacSign(userBirthday));

            Console.ReadLine();
        }

        //Created a local method called 'DayOfBirth' to get the day of the week a date falls on.
        private static string DayOfBirth (string userInput)
        {
            //Created a DateTime object out of user input
            DateTime result = DateTime.Parse(userInput);
            //Created variable assigned to the day of the week for 'result' DateTime object.
            var day = result.DayOfWeek;
            //The method will return a string of the day of the week.
            return day.ToString();
        }

        //Created a local method called 'DayNextBirthday' to get the day of the week 
        //next year's birthday will be on.
        private static string DayNextBirthday (string message)
        {
            //Created a variable out of user input, parsed to DateTime value
            var messageParsed = DateTime.Parse(message); 
            //'birthMonth' variable tells the month of the date entered by user.
            var birthMonth = messageParsed.Month;
            //'birthDayOfMonth' gives the day of the month of the date entered by user.
            var birthDayOfMonth = messageParsed.Day;
            //'nextYear' variable is assigned DateTime object that first calls today's date,
            //adds a year to get value for a year from today, and extracts the year value from the future date.
            var nextYear = DateTime.Today.AddYears(1).Year;

            //'birthdateNextYear' is a new DateTime object created with next year's year, the month the user
            //was born, and the day the user was born.
            DateTime birthdateNextYear = new DateTime(nextYear, birthMonth, birthDayOfMonth);
            //Extract the day of the week 'birthdateNextYear' will fall on.
            var dayNextYear = birthdateNextYear.DayOfWeek;
            
            //returns string with the day of the week birthday will fall on next year.
            return dayNextYear.ToString();
        }

        private static string GetZodiacSign(string message)
        {
            var messageParsed = DateTime.Parse(message);
            
            //Extract the month from the user's input, assign to variable.
            var birthMonth = messageParsed.Month;
            //Extract the day of the month from the user's input, assign to variable.
            var birthDayOfMonth = messageParsed.Day;
            //Because the DateTime object requires some year input, I assigned an arbitrary year.
            //Will not affect results since the relevant information is the month and day.
            var year = 2018;

            //Created new DateTime object 'userZodiacBirthday' which keeps the user's
            //input month and day, but assigned the variable year to work with conditionals.
            DateTime userZodiacBirthday = new DateTime(year, birthMonth, birthDayOfMonth);

            //Created new DateTime objects for the starting and ending dates of each zodiac sign, in order to
            //use the date ranges with conditional expressions.
            DateTime startAries = new DateTime(year, 03, 21);
            DateTime endAries = new DateTime(year, 04, 19);

            DateTime startTaurus = new DateTime(year, 04, 20);
            DateTime endTaurus = new DateTime(year, 05, 20);

            DateTime startGemini = new DateTime(year, 05, 21);
            DateTime endGemini = new DateTime(year, 06, 20);

            DateTime startCancer = new DateTime(year, 06, 21);
            DateTime endCancer = new DateTime(year, 07, 22);

            DateTime startLeo = new DateTime(year, 07, 23);
            DateTime endLeo = new DateTime(year, 08, 22);

            DateTime startVirgo = new DateTime(year, 08, 24);
            DateTime endVirgo = new DateTime(year, 09, 22);

            DateTime startLibra = new DateTime(year, 09, 23);
            DateTime endLibra = new DateTime(year, 10, 22);

            DateTime startScorpio = new DateTime(year, 10, 23);
            DateTime endScorpio = new DateTime(year, 11, 21);

            DateTime startSagittarius = new DateTime(year, 11, 22);
            DateTime endSagittarius = new DateTime(year, 12, 21);

            DateTime startCapricorn = new DateTime(year, 12, 22);
            DateTime endCapricorn = new DateTime(year, 01, 19);

            DateTime startAquarius = new DateTime(year, 01, 20);
            DateTime endAquarius = new DateTime(year, 02, 18);

            DateTime startPisces = new DateTime(year, 02, 19);
            DateTime endPisces = new DateTime(year, 03, 20);


            //Created conditionals in order to evaluate where in the month-day range
            //the user's input falls and to assign it a zodiac according 
            //to the user input (birth month and day)
            if (userZodiacBirthday >= startAries && userZodiacBirthday <= endAries)
            {
                string fortune = "Hello, Aries. Your fortune: You will lived a blessed life.";
                return fortune;
            }
            else if (userZodiacBirthday >= startTaurus && userZodiacBirthday <= endTaurus)
            {
                string fortuneTaurus = "Hello, Taurus. Your fortune: You always know how to enjoy yourself. However, " +
                    "if you follow your desires without " +
                    "\napplying balance, you may encounter personal setbacks. Always follow your heart.";
                return fortuneTaurus;

            }
            else if (userZodiacBirthday >= startGemini && userZodiacBirthday <= endGemini)
            {
                string fortuneGemini = "Hello, Gemini. Your fortune:  If you are not careful about watching your tongue" +
                    "\nyou may encounter more difficulties than necessary in your career. Stay mindful.";
                return fortuneGemini;
            }
            else if (userZodiacBirthday >= startCancer && userZodiacBirthday <= endCancer)
            {
                string fortuneCancer = "Hello, Cancer. Your fortune: Only by accepting the help of others will \nyou" +
                    "find peace.";
                return fortuneCancer;
            }
            else if(userZodiacBirthday >= startLeo && userZodiacBirthday <= endLeo)
            {
                string fortuneLeo = "Hello, Leo. Your fortune: Your charisma will attract many followers, but \nremain" +
                    "humble.";
                return fortuneLeo;
            }
            else if(userZodiacBirthday >= startVirgo && userZodiacBirthday <= endVirgo)
            {
                string fortuneVirgo = "Hello, Virgo. Your fortune: Listen to what the wise one says.";
                return fortuneVirgo;
            }
            else if(userZodiacBirthday >= startLibra && userZodiacBirthday <= endLibra)
            {
                string fortuneLibra = "Hello, Libra. Your fortune: You will have many opporturnities to \nstart" +
                    "afresh. Still, avoid foolhardy choices.";
                return fortuneLibra;
            }
            else if(userZodiacBirthday >= startScorpio && userZodiacBirthday <= endScorpio)
            {
                string fortuneScorpio = "Hello, Scorpio. Your fortune: Trust in love and your fears will dissipate.";
                return fortuneScorpio;
            }
            else if(userZodiacBirthday >= startSagittarius && userZodiacBirthday <= endSagittarius)
            {
                string fortuneSagittarius = "Hello, Sagittarius. Your fortune: Smile when things seem to be at \ntheir" +
                    "worst, and doors will open in the least expected places.";
                return fortuneSagittarius;
            }
            else if(userZodiacBirthday >= startCapricorn && userZodiacBirthday <= endCapricorn)
            {
                string fortuneCapricorn = "Hello, Capricorn. Your fortune: You will be great!";
                return fortuneCapricorn;
            }
            else if(userZodiacBirthday >= startAquarius && userZodiacBirthday <= endAquarius)
            {
                string fortuneAquarius = "Hello, Aquarius. Your fortune: Be one with yourself and" +
                    " you will \nnever stray from your truth.";
                return fortuneAquarius;
            }
            else if (userZodiacBirthday >= startPisces && userZodiacBirthday <= endPisces)
            {
                string fortunePisces = "Hello, Pisces. Your fortune: Your life partner will not resemble you," +
                    "\nbut they will be the best complement to your pursuits.";
                return fortunePisces;
            }
            //created a dummy return variable 'thankYou' in order to get the method to return the conditional
            //strings coded above.
            var thankYou = "";
            return thankYou;
        }


    }
   
}
