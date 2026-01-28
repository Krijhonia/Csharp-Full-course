// Dict in cs

Dictionary<string,string> Capitalcities = new Dictionary<string, string>();


//You can also use collection initializar in dictionary
Dictionary<int,string> Employeenames = new Dictionary<int,string>
{
    {101,"Kunal"},
    {102,"Rahul"},
    {103,"Alice"}
};

// Iterate through each pair
foreach (var item in Employeenames)
{
    // You access the Key and Value properties of the pair
    Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
}


  