//Manual reversal of an array
string[] tools = {"Hammer","Saw","Plier","Chainsaw"};

int left = 0;
int right = tools.Length - 1;

while(left < right)
{
    // swap the elements using a temporary variable
    string temp = tools[left];
    tools[left] = tools[right];
    tools[right] = temp;

    left++;
    right--;
}
Console.WriteLine("Manual Reversed array: "+string.Join(",",(tools)));