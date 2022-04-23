using Microsoft.AspNetCore.Mvc.Rendering;
using PartialConcert.Data.Entities;

namespace PartialConcert.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync(IEnumerable<Entrance> filter);
    }
}
