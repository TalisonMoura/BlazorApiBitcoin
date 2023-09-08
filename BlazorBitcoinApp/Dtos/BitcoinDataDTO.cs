namespace BlazorBitcoinApp.Dtos
{
    public class BitcoinDataDTO
    {
        public DateTime Day { get; set; }
        public decimal CloseValue { get; set; }

        public BitcoinDataDTO() { }

        public BitcoinDataDTO(DateTime day, decimal closeValue)
        {
            Day = day;
            CloseValue = closeValue;
        }
    }
}
