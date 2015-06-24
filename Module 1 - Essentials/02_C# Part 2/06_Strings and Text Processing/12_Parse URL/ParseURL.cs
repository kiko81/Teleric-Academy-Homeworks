/*
Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseURL
{
    static void Main()
    {
        Console.Write("URL: "); // http://telerikacademy.com/Courses/Courses/Details/212
        string url = Console.ReadLine();

        int index = 0;

        index = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0, index));
        url = url.Remove(0, index + 3);

        index = url.IndexOf('/');
        Console.WriteLine("[server] = {0}", url.Substring(0, index));
        url = url.Remove(0, index );

        Console.WriteLine("[resource] = {0}", url);
    }
}
