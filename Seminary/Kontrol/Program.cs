/* Задача
Написать программу, которая из имеющего массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении задачи не рекомендуется пользоваться коллекциями, желательно применять  массивы.
Примеры: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"];
["1234", "4567"] -> [].
*/

Console.Clear();

string[] array = {"hello","2","world",":-)"};
CosnolePrint(array);
Console.Write(" -> ");

string[] resarray = GetResArray(array);
CosnolePrint(resarray);

///////////////////////////////////////////////////////////////////////////
string[] GetResArray(string[] arr)
{
    int count = 0;
    string[]res = new string[count];
    for(int j = 0; j < arr.Length; j ++)
    {
        if(arr[j].Length < 4)
        {
            Array.Resize(ref res, res.Length + 1);
            res[count] = arr[j];
            count ++;
        }
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