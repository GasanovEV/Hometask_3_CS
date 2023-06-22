Console.Clear ();


 int userInput = GetNumberFromUser("Введите целое число : ", "Ошибка ввода!");
string result = PalindromeNumber(userInput);

Console.WriteLine($"{userInput} -> {result}");

//////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber)&&userNumber>9999&&userNumber<100000)
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}
string PalindromeNumber(int number)
{
    string palindrom ;
   if ((number % 10 == number / 10000) && ((number / 1000) % 10 == (number % 100) / 10))
    {
        palindrom = "да";
    }
   else    { palindrom = "нет";} 
    
    return palindrom;
}

 