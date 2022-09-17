/* Котрольная задача
Написать программу которая будет из заданного массива 
выбирать строки с длинной 3 и меннее символов и из них создавать новый массив.
Пример: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"];
["1234", "4567"] -> [].
*/

Console.Clear();

string[] array = { "12345", "123", "day","Wed", "1", "-888"};
CosnolePrint(array);
Console.Write(" -> ");

string[] resarray = GetResArray(array);
CosnolePrint(resarray);

///////////////////////////////////////////////////////////////////////////
string[] GetResArray(string[] arr)
{
    int count;
    string[] res;
    string[] x;
    count = 0;
    res = new string[count];
    for(int j = 0; j < arr.Length; j ++)
    {
        x = new string[count];
        if(arr[j].Length < 4)
        {
            count ++;
            x[count - 1] = arr[j];
            
        }
        res = x;
    }
    return res;
}

//////////////////////////////////////////////////////////////////////
void CosnolePrint(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length -1; i ++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}
/*

      Console.WriteLine("Enter strings:");
      count = 0; 
      do
      {
        s = Console.ReadLine();
        if (s!="")
        {
        count++;
        AS2 = new string[count];
        for (int i = 0; i < AS2.Length - 1; i++)
        AS2[i] = AS[i];
        AS2[count - 1] = s;
        AS = AS2;
        }
      } while (s != "");
*/

