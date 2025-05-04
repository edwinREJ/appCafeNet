using System.ComponentModel.DataAnnotations.Schema;

namespace appCafeNet.Models
{
    [Table("Profile")] // Asegúrate que esta tabla exista en tu BD
    public class Profile
    {
        public int Id { get; set; }

        [Column("NombreCompleto")]
        public string FullName { get; set; } = string.Empty;

        [Column("TipoDocumento")]
        public string DocumentType { get; set; } = string.Empty;

        [Column("NumeroDocumento")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Column("NumeroCelular")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column("Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Contrasena")]
        public string Password { get; set; } = string.Empty;
    }
}


