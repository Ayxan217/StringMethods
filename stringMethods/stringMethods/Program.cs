using System.Text;
using System.Text.RegularExpressions;

namespace stringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "       EverytHing  i neeD,    is a CuP   of       CoFFee    ";
          

            
            Console.WriteLine(CustomCorrector(sentence));
        }
    public static string CustomCorrector(string sentence)
    {
          
      string newSentence = Regex.Replace(sentence, @"\s+", " ");
            newSentence = newSentence.Trim();
            string[] splitedSentence = newSentence.Split(' ');
            for (int i = 0; i < splitedSentence.Length; i++)
            {
                if (splitedSentence[i].Length > 0)
                {
                    splitedSentence[i] = char.ToUpper(splitedSentence[i][0]) + splitedSentence[i].Substring(1).ToLower();
                }
            }
            newSentence = string.Join(" ", splitedSentence);




            return newSentence;

    }
    }
}
