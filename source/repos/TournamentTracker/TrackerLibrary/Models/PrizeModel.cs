namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Current place number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Place name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the prize
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}