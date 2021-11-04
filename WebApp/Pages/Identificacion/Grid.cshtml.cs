using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;

namespace WebApp.Pages.Identificacion
{
    public class GridModel : PageModel
    {
        private readonly IIdentificacionService identificacionService;

        public GridModel(IIdentificacionService identificacionService)
        {
            this.identificacionService = identificacionService;
        }


        public IEnumerable<IdentificacionEntity> GridList { get; set; } = new List<IdentificacionEntity>();

        public string Mensaje { get; set; } = "";
        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await identificacionService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {

            try
            {
                var result = await identificacionService.Delete(new() { IdCedula = id });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }

                TempData["Msg"] = "Se elimino correctamente";

                return Redirect("Grid");


            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
} 



