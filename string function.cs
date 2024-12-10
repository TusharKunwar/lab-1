
    string str = "pikachu";

        // 1. Length of string
        Console.WriteLine("Length: " + str.Length);

        // 2. ToUpper
        Console.WriteLine(" ToUpper: " + str.ToUpper());

        // 3. ToLower
        Console.WriteLine(" ToLower: " + str.ToLower());

        // 4. Substring
        Console.WriteLine(" Substring (from index 3): " + str.Substring(3));

        // 5. IndexOf
        Console.WriteLine(" IndexOf 'chu': " + str.IndexOf("chu"));

        // 6. Replace
        Console.WriteLine(" Replace 'pika' with 'rai': " + str.Replace("pika", "rai"));

        // 7. Trim removes all leading and trailing white space
        Console.WriteLine(" Trim: '" + str.Trim() + "'");


        // 8. Contains
        Console.WriteLine(" Contains 'chu': " + str.Contains("chu"));

        // 9. StartsWith
        Console.WriteLine(" StartsWith 'pik': " + str.StartsWith("pik"));

        // 10. EndsWith
        Console.WriteLine(" EndsWith 'chu': " + str.EndsWith("chu"));