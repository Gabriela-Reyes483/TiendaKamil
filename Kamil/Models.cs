using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kamil
{
    // Tabla Catálogo de Puestos
    public class CatalogoPuestos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Puesto { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descripcion_Puesto { get; set; }

        // Navegación
        public virtual ICollection<Empleado> Empleados { get; set; }
    }

    // Tabla Catálogo de Centros
    public class CatalogoCentros
    {
        [Key]
        public int Numero_Centro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre_Centro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ciudad { get; set; }

        // Navegación
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Directivo> DirectivosSupervisados { get; set; }
    }

    // Tabla Empleado
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numero_Empleado { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido_Paterno { get; set; }

        [MaxLength(50)]
        public string Apellido_Materno { get; set; }

        [Required]
        public DateTime Fecha_Nacimiento { get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; }

        [Required]
        public bool Directivo { get; set; } // 1 = Directivo, 0 = Empleado normal

        [Required]
        public int ID_Puesto { get; set; }

        [Required]
        public int Numero_Centro { get; set; }

        // Propiedades de navegación
        [ForeignKey("ID_Puesto")]
        public virtual CatalogoPuestos Puesto { get; set; }

        [ForeignKey("Numero_Centro")]
        public virtual CatalogoCentros Centro { get; set; }

        public virtual Directivo DirectivoInfo { get; set; }
    }

    // Tabla Directivo (hereda de Empleado)
    public class Directivo
    {
        [Key]
        [ForeignKey("Empleado")]
        public int Numero_Empleado { get; set; }

        [Required]
        public int Centro_Supervisado { get; set; }

        [Required]
        public bool Prestacion_Combustible { get; set; } // 1 = Sí, 0 = No

        // Propiedades de navegación
        public virtual Empleado Empleado { get; set; }

        [ForeignKey("Centro_Supervisado")]
        public virtual CatalogoCentros CentroSupervisado { get; set; }
    }
}