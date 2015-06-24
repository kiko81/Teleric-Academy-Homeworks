/*
Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
from this title: https://social.technet.microsoft.com/Forums/exchange/en-US/69f393aa-d555-4f8f-bb16-c636a129fc25/what-are-valid-and-invalid-email-address-characters we see almost every character is valid, except space and coma, so the problem is very big and i cant distinguish valid and invalid mails except by containing @ and dot, which, anyway, is not enough
*/
 
class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine(); // all these mails are valid: 1@12.bg, 123_4-bg.38dsd@[1.2.3.4], but the second according to the condition is not valid

        var splittedText = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < splittedText.Length; i++)
        {
            splittedText[i].TrimEnd('!', '#', '$', '%', '&', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~', '\'', ' ');
            if (splittedText[i].Contains("@") && splittedText[i].Contains(".")
                && splittedText[i].IndexOf("@") > 0 && splittedText[i].LastIndexOf(".") > splittedText[i].IndexOf("@") + 2 && splittedText[i].LastIndexOf(".") < splittedText[i].Length - 2 )
            {
                Console.WriteLine(splittedText[i]);
            }
        }

        
    }
}
