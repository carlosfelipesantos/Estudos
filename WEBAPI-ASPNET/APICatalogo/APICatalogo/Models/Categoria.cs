using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models
{

    [Table("Categorias")] //Anotação para definir o nome da tabela no banco de dados
    public class Categoria
    {
        [Key]//Anotação para definir a chave primaria, mas é opcional nesse caso
        public int CategoriaId { get; set; } //Entity Framework entende que Id= chave primaria, e nome da classe+id tambem (Categoria+Id)

        [Required]
        [StringLength(50)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }

        [JsonIgnore]
        public ICollection<Produto>? Produtos { get; set; } //propriedade de navegação para representar o relacionamento entre Categoria e Produto
    }
}
