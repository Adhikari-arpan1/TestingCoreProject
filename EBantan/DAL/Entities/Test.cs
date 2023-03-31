using MessagePack;

using System.ComponentModel.DataAnnotations.Schema;
namespace EBantan.DAL.Entities
{
    [Table("test")]
    public class Test
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
    }
}
