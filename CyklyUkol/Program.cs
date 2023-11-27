if (false)
{
    bool proceed = true;
    string result = "";
    while (proceed)
    {
        string userInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userInput) != true)
        {
            result = result + userInput;
            proceed = true;
        }
        else
        {
            Console.WriteLine(result);
            proceed = false;
        }
    }
}
bool cycle = true;
string userInput = "";
for (int i = 0; i < max; i++)
{

}