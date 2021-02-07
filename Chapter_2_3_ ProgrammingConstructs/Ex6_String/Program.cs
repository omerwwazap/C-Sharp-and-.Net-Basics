using System;
using System.Text;

namespace Ex6_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", "hey hey"));
            Console.WriteLine();

            Console.WriteLine("=> String concatenation:");
            string st1 = "Programming the ";
            string st2 = "C#";
            //string st3 = st1 + st2;
            string st3 = String.Concat(st1, st2, st2);
            Console.WriteLine(st3);
            Console.WriteLine();

            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "\\ \" \' Black\tBlue\a\nGreen\tYellow\rBlue\tRed\a ";
            Console.WriteLine(strWithTabs);

            int age = 4;
            string name = "Soren";
            // Using curly-bracket syntax.
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            Console.WriteLine(greeting);
            // Using string interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting2);


            Console.WriteLine("C:\\MyApp\\bin\\Debug");


            // The following string is printed verbatim,
            // thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");


            // Whitespace is preserved with verbatim strings.
            string myLongString = @"This is a very
						very
				very
					long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
            string interp = "interpolation";
            string myLongString2 = $@"This is a very
					very
						 long string with {interp}";
            Console.WriteLine(myLongString2);

            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();


            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();

            Console.WriteLine("=> String equality (Case Insensitive:");
            s1 = "Hello!";
            s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Check the results of changing the default compare rules.
            Console.WriteLine("Default rules: s1={0},s2={1} s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();

            Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();

            //Strings Are Immutable
            // Set initial string value.
            s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);
            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);


            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
    }
}
