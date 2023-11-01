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
        // Title for Recipie time
        public string RecipeTime { get; set; }
        public string NumberOfServing { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }

        public static AddRecipe FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            if (values.Length != 6)
            {
                MessageBox.Show("invalid csv format");
            }

            return new AddRecipe
            {
                RecipeTitle = values[0],
                RecipeTime = values[1],
                NumberOfServing = values[2],
                Category = values[3],
                Ingredients = values[4],
                Description = values[5]
            };

        }
        public string ToCsv()
        {
            return $"{RecipeTitle},{RecipeTime},{NumberOfServing},{Category},{'"' + Ingredients + '"'},{'"' + Description + '"'}";
        }

    }
}
