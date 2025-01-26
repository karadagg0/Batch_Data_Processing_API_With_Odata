

namespace Batch_Data_Processing_API_With_Odata.DbModels
{
    public class USERS
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int AGE { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public virtual ICollection<ORDERS> Orders { get; set; }

    }
}
