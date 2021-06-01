using System;


namespace enumeracaob.Entities
{
    public class HourContract
    {
                public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract(DateTime date, Double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;

        }

        public Double TotalValue(){

            return ValuePerHour * Hour;
            



        }



    }
}
