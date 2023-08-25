var sophia = new List<int>()
{
    93, 87, 98, 95, 100
};

var nicolas = new List<int>()
{
    80, 83, 82, 88, 85
};

var zahirah = new List<int>()
{
    84, 96, 73, 85, 79
};

var jeong = new List<int>()
{
    90, 92, 98, 100, 97
};

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t {sophia.Average():f1} \tA");
Console.WriteLine($"Nicolas:\t {nicolas.Average():f1} \tB");
Console.WriteLine($"Zahirah:\t {zahirah.Average():f1} \tB");
Console.WriteLine($"Jeong:\t\t {jeong.Average():f1} \tA");