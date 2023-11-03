using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeGenius
{
    public class AddRecipe
    {
        //Title for recipe
        public string RecipeTitle { get; set; }
        public string RecipeTime { get; set; }
        public string NumberOfServing { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }

        
        public string ToCsv()
        {
            return $"{RecipeTitle},{RecipeTime},{NumberOfServing},{Category},{'"' + Ingredients + '"'},{'"' + Description + '"'}";
        }

    }
}
