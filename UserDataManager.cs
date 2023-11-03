using System;
using System.Collections.Generic;
using System.IO;

namespace RecipeGenius
{
    public class UserDataManager
    {
        RecipeBook recipeBook = new RecipeBook();
        private List<string[]> AdminDataList;

        public UserDataManager()
        {
            AdminDataList = LoadUserDat();
        }

        public List<string[]> GetUserDataList()
        {
            return AdminDataList;
        }

        public bool CheckUserCredentials(string enteredUserName, string enteredPassword)
        {
            foreach (string[] user in AdminDataList)
            {
                if (user.Length == 2 && user[0] == enteredUserName && user[1] == enteredPassword)
                {
                    return true;
                }
            }
            return false;
        }

        private List<string[]> LoadUserDat()
        {
            List<string[]> data = new List<string[]>();

            try
            {
                

                using (StreamReader reader = new StreamReader(recipeBook.AdminLoggIn))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            data.Add(parts);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
         
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return data;
        }
    }
}
