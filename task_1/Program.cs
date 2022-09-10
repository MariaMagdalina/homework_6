// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Программа считает сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите натуральное число ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array_M = new int [M];
int quantity = 0;
for(int i=0; i<M; i++)
   {
      Console.WriteLine("введите число_" + i);
      array_M[i] = Convert.ToInt32(Console.ReadLine());
      if (array_M[i] > 0) 
         quantity++;
   }
Console.WriteLine("Вы ввели " + quantity + " положительных чисел");