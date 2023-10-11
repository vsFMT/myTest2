//int numberA = 3;
//int numberB = 10;
//Console.WriteLine(numberA + numberB);
//первый вариант

//int numberA = 31;
//int numberB = 10;
//int result = (numberA + numberB);
//Console.WriteLine(result);
//второй вариант с добавлением переменной

int numberE = new Random().Next(1, 10); // рандомное число от 1 до 9 (10 не включается)
Console.WriteLine(numberE);
int numberF = new Random().Next(1, 10);
Console.WriteLine(numberF);
int result = numberE + numberF;
Console.WriteLine(result);