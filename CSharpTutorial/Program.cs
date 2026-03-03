using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");

        // Type casting - converting a a value to a different data type
        try {
            string str = "true";
            bool b = Convert.ToBoolean(str);
            Console.WriteLine(b.GetType());
        } catch(Exception ex) { // <-- use 'Exception' type and a variable
            Console.WriteLine(ex);        // full exception info
            Console.WriteLine(ex.Message); // just the message
            Console.WriteLine($"Error found: {ex.Message}"); // formatted string
        }
    }
}
