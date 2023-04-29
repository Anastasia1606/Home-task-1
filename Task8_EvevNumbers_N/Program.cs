Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int count = 2;
string result;
while (count <= number1)
{
  Console.Write(count + " ");
  count = count + 2;
}