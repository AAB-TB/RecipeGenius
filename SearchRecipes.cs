using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeGenius
{
    public class SearchRecipes
    {
        FilePaths filePaths = new FilePaths();
        private List<string[]> AllRecipies { get; set; } = new List<string[]>();
        public List<string[]> Items { get; set; }
        public SearchRecipes()
        {
           AllRecipies = filePaths.LoadRecipiesData();
        }

        public void Search(string searchfor)
        {
            List<string[]> search = new List<string[]>();

            var recipeShow = AllRecipies.Where(arr => arr[3].Equals(searchfor.Trim(), StringComparison.CurrentCultureIgnoreCase) || arr[0].Equals(searchfor.Trim(), StringComparison.CurrentCultureIgnoreCase));

            Items = recipeShow.ToList();
            
            

        }

    }
}
