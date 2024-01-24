/*
Learning objectives
After you complete this module, you'll be able to:

Create literal values for five basic data types
Declare and initialize variables
Retrieve and set values in variables
Allow the compiler to determine the data type for your variable when initializing
*/

/*
Store the following values in variables:

Bob
3
34.4
These variables should be given names that reflect their purpose.

Make sure you select the correct data type for each of the variables based on the type of data it will hold.

Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.
*/

string firstName = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, " );
Console.Write(firstName);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celcius.");