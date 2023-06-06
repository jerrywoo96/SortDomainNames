public class Program
{

  public static void Main(string[] args)
  {

    List<string> Domains = File.ReadAllLines("Domains.txt").ToList();

    List<string> ReversedDomains = Reverse(Domains);

    ReversedDomains.Sort();

    List<string> SortedDomains = Reverse(ReversedDomains);

    File.WriteAllLines("SortedDomains.txt", SortedDomains);

  }

  public static List<string> Reverse(List<string> Strings)
  {
    List<string> ReversedStrings = new();

    foreach (string String in Strings)
    {
      ReversedStrings.Add(string.Join('.', String.Split('.').Reverse()));
    }

    return ReversedStrings;
  }

}
