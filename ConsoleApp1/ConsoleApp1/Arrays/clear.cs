// Partial clearing an array
int[] numbers = {10,20,30,40,50};

Array.Clear(numbers,1,3); //It gonna clear 3 elements starting from the index 1
Console.WriteLine("Partial Clear: " +string.Join(",",(numbers)));

//Full clear
Array.Clear(numbers,0,numbers.Length);
Console.WriteLine("Full clear: "+string.Join(",",(numbers)));