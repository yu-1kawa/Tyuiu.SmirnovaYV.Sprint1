using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SmirnovaYV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string result = "";
            value = value.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            string[] words = value.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string reversed = new string(word.ToLower().Reverse().ToArray());
                    if (word.ToLower() == reversed)
                    {
                        result = result + word + " ";
                    }
                }
            }
            return result.Trim();
        }
    }
}
