namespace TestOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date(5, 1995);

            //Console.WriteLine(d1.GetDate());

            //Employee e1 = new Employee();
            //e1.id = 1000;
            //e1.Fname = "Ahmed";
            //e1.Lname = "A.";

            //Employee e2 = new Employee()
            //{
            //    id = 1200,
            //    Fname = "Ali",
            //    Lname = "A."
            //};

            Dollar doller = new Dollar(0);
            doller.SetAmount(0m);
            Console.WriteLine(doller.Amount);
            Console.WriteLine(doller.IsZero);


        }

    }
    // Adding Comment for test
    //   public class Date
    //    {
    //        private static readonly int[] daysTomonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    //        private static readonly int[] daysTomonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    //        private readonly int day=01;
    //        private readonly int month=01 ;
    //        private readonly int year = 01;

    //        //-----Constructor--- the same name as class name without data type
    //        public Date(int day,int month,int year)
    //        {
    //            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

    //            if(year>=0 && year<=9999 && month <= 12)
    //            {
    //                int[] days = isLeap ? daysTomonth366 : daysTomonth365;
    //                if (day >= 1 && day <= days[month])
    //                {
    //                    this.day = day;
    //                    this.month = month;
    //                    this.year = year;
    //                }


    //            }

    //        }

    //        public Date(int year) : this(01, 01, year)
    //        {

    //        }
    //        public Date(int month, int year) : this(01, month, year)
    //        {

    //        }


    //        public string GetDate() 
    //        {

    //            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
    //        }
    //    } 

    //   public class Employee
    //    {
    //        public int id;
    //        public string Fname;
    //        public string Lname;

    //        public Employee()
    //        {

    //        }

    //    }
    //}

    public class Dollar
    {
        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            private set
            {
                this._amount = ProcessValue(value);
            }
        }
        public void SetAmount(decimal value)
        {
            Amount = value;
        }

        //لو انا عايز اعمل خاصية منها بس اعرف القيمة واحطها وخلاص من غير اي constraint عليها
        public decimal AmountValu { get; set; } 

        public bool IsZero =>  _amount == 0;
        // Initialzation a new value to the set
        public decimal ConversionFactor { get; set; } = 1.299m;

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);
        }

        //Experisson body syntax.
        private decimal ProcessValue(decimal value) => value <=0 ? 0 : Math.Round(value,1);

    }

}
