using ToursAndTravelsManagement.Enums;

namespace ToursAndTravelsManagement.Models
{
    public class Payment
    {

        public int PaymentId { get; set; }
        public int CabBookingId { get; set; }

        public decimal Amount { get; set; }
        public string UTR { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public CabBooking CabBooking { get; set; }



    }
    public class PaymentSetting
    {
        public int Id { get; set; }
        public string UpiId { get; set; }
        public string UpiName { get; set; }
    }


}
