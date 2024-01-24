/*
Combine literal and variable text data that contain special characters, formatting, and Unicode into meaningful messages for the end user.

Learning objectives
After you complete this module, you'll be able to:

Create string data containing tabs, new lines, and other special characters
Create string data containing Unicode characters
Combine string data into a new string value via concatenation
Combine string data into a new string value via interpolation
*/

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");