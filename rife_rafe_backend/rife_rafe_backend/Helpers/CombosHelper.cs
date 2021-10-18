using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using rife_rafe_backend.Data;

namespace rife_rafe_backend.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly ApplicationDbContext _context;

        public CombosHelper(ApplicationDbContext context)
        {
            _context = context;
        }


        /*
        public IEnumerable<SelectListItem> GetComboDocumentTypes()
        {
            List<SelectListItem> list = _context.DocumentType.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de documento...]",
                Value = "0"
            });

            return list;
        }

    }*/
    }
}
