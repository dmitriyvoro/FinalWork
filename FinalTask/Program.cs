string[] n = new string[6] {"3124", "11", "18", "123", "3211", "3188"};
string[] m = new string[n.Length];

void InputArray(string[] n, string[] m)
{
    int count = 0;
    for (int i = 0; i < n.Length; i++)
    {
    if(n[i].Length <= 3)
        m[count] = n[i];
        count++;
    }
}
void PrintArray(string[] n)
{
    for (int i = 0; i < n.Length; i++)
    {
        Console.Write($"{n[i]} ");
    }
}
InputArray(n, m);
PrintArray(m);

