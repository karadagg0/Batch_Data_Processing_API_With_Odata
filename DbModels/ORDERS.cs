

using System.Text.Json.Serialization;

namespace Batch_Data_Processing_API_With_Odata.DbModels
{
    public class ORDERS
    {
        public int ID { get; set; }
        public int USER_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal AMOUNT { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public  USERS USER { get; set; }
    }
}
