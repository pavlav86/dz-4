// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void ShowNumberPower(int num, int power)
{
  int result = 1;
  for (int i = 0; i < power; i++)
  {
    result *= num;
  }
  Console.Write($"{num}, {power} -> {result}");
}

int GetNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int numA = GetNumber("Enter number A");
int numB = GetNumber("Enter number B");

ShowNumberPower(numA, numB);
