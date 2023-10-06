using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}" + "\n" );
}

Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}" + "\n");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
string[] items = result.Split(',');
foreach (string item in items) {
    Console.WriteLine(item + "\n");
}

    string pangram = "The quick brown fox jumps over the lazy dog";
    string reversedPangram = ReverseWords(pangram);
    Console.WriteLine(reversedPangram);
static string ReverseWords(string input) {
    string[] words = input.Split(' ');
    for (int i = 0; i < words.Length; i++) {
        char[] characters = words[i].ToCharArray();
        Array.Reverse(characters);
        words[i] = new string(characters);
    }
    return string.Join(" ", words + "\n");
}

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
foreach (var order in orders) {
    if (order.Length > 4) {
        Console.WriteLine($"{order} - Error");
    } else {
        Console.WriteLine(order);
    }
}

