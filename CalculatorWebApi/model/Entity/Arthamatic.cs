using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CalculatorWebApi.model.Entity
{
    [Table("Arthamatic")]
    public class Arthamatic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double oprand1 { get; set; }
        [Required]
        public double oprand2 { get; set; }
        [Required]
        public char symbol { get; set; }
        public double result { get; set; }

        public override string ToString()
        {
            return $"{oprand1} {symbol} {oprand2} = {result}";
        }
    }
}
