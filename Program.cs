string[] StringArr = new string[8] { "11", "222", "33", "4444", "string", "str", "a", "qwerty" };
string[] ResultStringfArr = new string[StringArr.Length];
 
void IdentifyingSuitableStr(string[] StringArr, string[] ResultStringfArr)
{ 
    int count = 0;

    for (int i = 0; i < StringArr.Length; i++)
    {
        if (StringArr[i].Length < 4)
        {
            ResultStringfArr[count] = StringArr[i];
            count++;
        }
    }
}
 
void Print2DArray(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
}
 
IdentifyingSuitableStr(StringArr, ResultStringfArr);

Print2DArray(StringArr);
Console.WriteLine();
Print2DArray(ResultStringfArr);