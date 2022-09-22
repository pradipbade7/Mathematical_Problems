using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation;

public class JadenCasing
{
    /// <summary>
    /// Jaden casing is a special casing where every word in a sentence starts with a capital letter. Method receives input which it converts to jaden casing.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string JadenCase(string input)
    {
        StringBuilder builder = new StringBuilder();
        if (input[0] != ' ')
            builder.Append(Char.ToUpper(input[0])); 
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i - 1] == ' ')
                builder.Append(Char.ToUpper(input[i]));
            else
                builder.Append(input[i]);
        }
        return builder.ToString();
    }
}