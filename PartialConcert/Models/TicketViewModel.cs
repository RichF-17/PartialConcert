using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PartialConcert.Models
{
    public class TicketViewModel : EditTicketViewModel
    {
        [Display(Name = "Entrada")]
        public int EntranceId { get; set; }

        public IEnumerable<SelectListItem> Entrances { get; set; }

    }
}
