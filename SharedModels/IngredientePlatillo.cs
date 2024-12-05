using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class IngredientePlatillo
    {
        public int IdPlatillo { get; set; }
        public int IdIngrediente { get; set; }
        public int CantidadNecesaria { get; set; }
    }
}
