using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatoria.")]
        public string Name { get; set; }
        public bool? IsComplete { get; set; }=false;
    }
}
