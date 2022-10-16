
int i = 6;
string z = "Hello";
bool b = false;

TellMeType(i);


static void TellMeType(object o)
{
    switch (o)
    {
        case null:
            System.Console.WriteLine("Null!");
            break;
        case DateTime _:
            Console.WriteLine("It's a DateTime");
            break; // 
        case int i when i == 5:
            System.Console.WriteLine("Int równy 5");
            break;
        case int i:
            System.Console.WriteLine("Tylko int");
            break;
        case string s:
            System.Console.WriteLine("typ string");
            break;
        default:
            System.Console.WriteLine("Nieznany typ");
            break;
    }
}
