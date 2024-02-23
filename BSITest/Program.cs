/////// SOAL NO. 1 /////////

int[] input = { 2, 4, 6, 5, 3, 1, 7, 9, 10, 8 };
int faktor = 45;
List<int> output = new List<int>();

for (int i = 0; i < input.Length; i++)
{
    if (faktor % input[i] == 0)
    {
        output.Add(input[i]);
    }
    //else { break; }

}
int[] ouputSort = output.ToArray();
Array.Sort(ouputSort);
Array.Reverse(ouputSort);


foreach (int i in ouputSort)
{ Console.Write(i.ToString()); }

Console.ReadKey();


//////// SOAL NO 2 ///////////////
string strings = "aaabbcccaaaac";
var count = strings.GroupBy(x => x).OrderByDescending(x => x.Count());
count.ToList().ForEach(x => Console.WriteLine("{0}: {1}", x.Key, x.Count()));