using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp_NisaNurYagiz.Models
{
    public class ToDo
    {
        public ToDo() {
            CreatedDate = DateTime.Now;
        }
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DisplayName(displayName: "Is completed?")]
        public bool IsCompleted { get; set; }

        public DateTime DueDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Completed { get; set; }

        public int RemainingHour
        {
            get
            {
                var remainingTime = (DateTime.Now - DueDate);
                return (int)remainingTime.TotalHours;
            }
        }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Something { get; set; }
        
    }
}
