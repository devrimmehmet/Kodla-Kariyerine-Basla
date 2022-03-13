using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Diezalgoritma
{
    public static void staircase(int n)
    {
       
        for(int i = 0; i<n; i++){
        for(int x = i+1; x < n; x++){
            Console.Write(" ");
        }
        for(int x = n-(i+1); x < n; x++){
            Console.Write("#");
        }
        Console.WriteLine();
    }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Diezalgoritma.staircase(n);
    }
}
