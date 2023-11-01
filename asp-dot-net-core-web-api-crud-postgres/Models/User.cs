using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dot_net_core_web_api_crud_postgres.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("email")]
        public required string Email { get; set; }
        
        [Column("phone")]
        public required string Phone { get; set; }
    }
}