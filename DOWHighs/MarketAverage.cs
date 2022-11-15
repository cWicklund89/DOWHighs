using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWHighs
{
    /// <summary>
    /// Marketing Average
    /// </summary>
    public class MarketAverage
    {
        [DisplayName("Date")]
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        [DisplayName("Closing Value")]
        /// <summary>
        /// Closing Value
        /// </summary>
        public Decimal ClosingValue { get; set; }

        [DisplayName("Opening Value")]
        /// <summary>
        /// Opening Value
        /// </summary>
        public Decimal OpeningValue { get; set; }

        [DisplayName("Low Value")]
        /// <summary>
        /// Low Value for this Date
        /// </summary>
        public Decimal LowValue { get; set; }

        [DisplayName("High Value")]
        /// <summary>
        /// High Value for this Date
        /// </summary>
        public Decimal HighValue { get; set; }

        /// <summary>
        /// No Argument Constructor
        /// </summary>
        public MarketAverage()
        {
        }

        /// <summary>
        /// All Argument Constructor
        /// </summary>
        /// <param name="date">Market Date</param>
        /// <param name="closingValue">Closing Value for this date</param>
        /// <param name="openingValue">Opening Value for this date</param>
        /// <param name="lowValue">Low Value for this date</param>
        /// <param name="highValue">High Value for this date</param>
        public MarketAverage(DateTime date, decimal closingValue, decimal openingValue,
            decimal lowValue, decimal highValue)
        {
            Date = date;
            ClosingValue = closingValue;
            OpeningValue = openingValue;
            LowValue = lowValue;
            HighValue = highValue;
        }

        /// <summary>
        /// Check to see if this instance matches a passed in value
        /// by checking the instance's argument values
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // Is the object passed in null?  If so, it cannot be equal
            if (obj == null)
                return false;

            // Is the object passed in the same type as this class?  If not,
            // then it cannot be equal
            if (obj.GetType() != typeof(MarketAverage))
                return false;

            // Now it is safe to cast the generic object that was passed in
            // as a MarketAverage
            MarketAverage marketAverage = (MarketAverage)obj;

            // In order to see if this instance of an object is equal to the object
            // passed in, we need to check the values.
            if (this.Date.CompareTo(marketAverage) == 0 &&
                this.ClosingValue == marketAverage.ClosingValue &&
                this.OpeningValue == marketAverage.OpeningValue &&
                this.LowValue == marketAverage.LowValue &&
                this.HighValue == marketAverage.HighValue)
                return true;
            else
                return false;
        }

        /// <summary>
        /// When the Equals method is overridden the practice is to override the GetHashCode
        /// as well.  Here since we made the equals dependent on the fields, we consistently 
        /// apply the same principle and return a HashCode value based on the objects values
        /// </summary>
        /// <returns>The generated hashcode value as an integer</returns>
        public override int GetHashCode() => (Date, ClosingValue, OpeningValue, LowValue,
            HighValue).GetHashCode();
    }
}
