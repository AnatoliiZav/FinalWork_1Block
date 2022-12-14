string[] Main(string[] array)
{
  string[] result = new string[0];
  for (int i = 0; i < array.Length; i++)
  {
    string  correct = array[i];
    int j = result.Length;
    if (correct.Length <= 3)
    {
      Array.Resize(ref result, result.Length +1);
      result[j] = array[i];
    }
  }
  return result;
}

string[] arr = { "45", "Monday", "Hello", "P2P", "=G4", "Version", "I" };
Console.WriteLine($"[{String.Join(", ", Main(arr))}]");