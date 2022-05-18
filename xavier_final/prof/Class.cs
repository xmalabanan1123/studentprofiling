using System.ComponentModel.DataAnnotations;
namespace xavier_final.prof
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double Contact { get; set; }


    }
}
