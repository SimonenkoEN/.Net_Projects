string s = "128759746539867648";
int[] arr = s.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
Console.WriteLine(string.Join("-", arr));
