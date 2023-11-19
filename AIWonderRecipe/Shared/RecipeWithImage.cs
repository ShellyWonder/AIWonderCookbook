using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIWonderRecipe.Shared
{
    public class RecipeWithImage
    {
        public Guid Id { get; set; } = Guid.NewGuid(); //Auto generate ID
        public Recipe? Recipe { get; set; }
        public string? ImageUrl { get; set; } // URL from ImageData
        public string? MealTime { get; set; } // store MealTime category
    }

}
