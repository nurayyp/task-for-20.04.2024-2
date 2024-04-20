//1.0
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number == 0)
//{
//    Console.WriteLine("eded ne tek ne cutdur");
//}
//    else if (number % 2 == 0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else
//{
//    //Console.WriteLine("eded tekdir");
//}

//1.1
//int sum = 0;
//Console.WriteLine("1ci ededi daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3cu ededi daxil edin");
//int number3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("4cu ededi daxil edin");
//int number4 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("5ci ededi daxil edin");
//int number5 = Convert.ToInt32(Console.ReadLine());
//sum = sum + number1 + number2 + number3 + number4 + number5;
//Console.WriteLine(sum);

//1.2
//int kvadrat = 0;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//kvadrat = number * number;
//Console.WriteLine(kvadrat);

//1.3
//int max = 0;
//Console.WriteLine("1ci ededi daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3cu ededi daxil edin");
//int number3 = Convert.ToInt32(Console.ReadLine());
//if (number1 < number2 && number1 < number3)
//{
//    max = number1;
//}
//else if (number2 < number1 && number2 < number1)
//{
//    max = number2;
//}
//else
//{
//    max = number3;
//}
//Console.WriteLine(max);

//1.4
//int kub = 0;
//Console.WriteLine("1ci ededi daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin");
//int number2 = Convert.ToInt32(Console.ReadLine());
//kub = number1 * number1 * number1;
//if (kub < number2 )
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}

//1.5
//Console.WriteLine("eded daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//if (number1 % 3 == 0 && number1 % 5 ==0)
//{
//    Console.WriteLine("true");
//}
//else { Console.WriteLine("false"); }

//1.6
//Console.WriteLine("kartdaki mebleg");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("mehsulun qiymeti");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 <= number2)
//{
//    Console.WriteLine("yeterlidir");
//}
//else
//{
//    Console.WriteLine("yeterli deyil");
//}

//1.7
//int number1, number2, number3, number4, number5;
//do
//{
//    Console.WriteLine("eded1 eded2 eded3 eded4 eded5 daxil edin");
//    number1 = Convert.ToInt32(Console.ReadLine());
//    number2 = Convert.ToInt32(Console.ReadLine());
//    number3 = Convert.ToInt32(Console.ReadLine());
//    number4 = Convert.ToInt32(Console.ReadLine());
//    number5 = Convert.ToInt32(Console.ReadLine());
//} while ((number1 < 0 || number2 < 0 || number3 < 0 || number4 < 0 || number5 < 0) || (number1 > 100 && number2 > 100 && number3 > 100 && number4 > 100 && number5 > 100));
//Console.WriteLine((number1 + number2 + number3 + number4 + number5 ) / 5);

//1.8
//Console.WriteLine("1ci ededi daxil edin ");
//int number1 = Convert.ToInt32 (Console.ReadLine());
//if (number1 < 0 )
//{
//    Console.WriteLine("2ci ededi daxil edin");
//    int number2 = Convert.ToInt32(Console.ReadLine());
//    if (number2 < 0 )
//    {
//        if (number1 == number2)
//        {
//            Console.WriteLine("ededler beraberdir");
//        }
//        else if (number1 < number2)
//        {
//            Console.WriteLine("1ci eded 2ciden boyukdur");
//        }
//        else { Console.WriteLine("2ci eded 1ciden boyukdur"); }

//    }
//    else
//    {
//        Console.WriteLine("2ci ededi natural eded daxil edin");
//        int number20 = Convert.ToInt32(Console.ReadLine());
//        if (number1 == number20)
//        {
//            Console.WriteLine("ededler beraberdir");
//        }
//        else if (number1 < number20)
//        {
//            Console.WriteLine("1ci eded 2ciden boyukdur");
//        }
//        else { Console.WriteLine("2ci eded 1ciden boyukdur"); }

//    }
//}
//else
//{
//    Console.WriteLine("1ci ededi natural eded daxil edin ");
//    int number10 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("2ci ededi daxil edin");
//    int number2 = Convert.ToInt32(Console.ReadLine());
//    if (number2 < 0)
//    {
//        if (number10 == number2)
//        {
//            Console.WriteLine("ededler beraberdir");
//        }
//        else if (number10 < number2)
//        {
//            Console.WriteLine("1ci eded 2ciden boyukdur");
//        }
//        else { Console.WriteLine("2ci eded 1ciden boyukdur"); }

//    }
//    else
//    {
//        Console.WriteLine("2ci ededi yeniden daxil edin");
//        int number200 = Convert.ToInt32(Console.ReadLine());
//        if (number10 == number200)
//        {
//            Console.WriteLine("ededler beraberdir");
//        }
//        else if (number10 < number200)
//        {
//            Console.WriteLine("1ci eded 2ciden boyukdur");
//        }
//        else { Console.WriteLine("2ci eded 1ciden boyukdur"); }
//    }

//}

//1.9
//int donma = 0;
//Console.WriteLine("temperaturu daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number == donma)
//{
//    Console.WriteLine("donma temperaturudur");
//}
//else if (number < 0)
//{
//    Console.WriteLine("donma temperaturundan yuxaridir");
//}
//else
//{
//    Console.WriteLine("donma temperaturundan asagidir");
//}




//2.1
//int number = 0;
//do
//{
//    Console.WriteLine(number);
//    number++;
//} while (number <= 50);

//2.2
//int say = 0;
//int number = 1;
//do
//{
//    if (number % 3 == 0)
//    {
//        say++;
//        number++;
//    }
//    else
//    {
//        number++;
//    }
//} while (number <= 40);
//Console.WriteLine(say);

//2.3
//int number = 1;
//do
//{
//  if (number % 3 == 0 && number % 7 == 0)
//    {
//        Console.WriteLine(number);
//        number++;
//    }
//  else
//    {
//        number++;
//    }
//} while (number <= 100 );

//2.4
//int say = 0;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//do
//{
//    say++;
//    number /= 10;
//} while (number > 0);
//Console.WriteLine(say);

//2.5
//int say = 0;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//do
//{
//    say = say * 10 + number % 10;
//    number = number / 10;
//} while (number > 0);
//Console.WriteLine(say);

//2.6
//int faktorial = 1;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//do
//{
//    faktorial = faktorial * number;
//    number--;
//} while (number > 0);
//Console.WriteLine(faktorial);

//2.7
//int n = Convert.ToInt32(Console.ReadLine());
//int squareroot = Convert.ToInt32(Math.Sqrt(n));
//bool isprimitive = true;
//for (int i = 2; i <= squareroot; i++)
//{
//    if (n % i == 0 )
//    {
//        isprimitive = false;
//        break;
//    }
//}
//if (isprimitive)
//{
//    Console.WriteLine("sade ededdir");
//}
//else
//{
//    Console.WriteLine("murekkeb ededdir");
//}

//2.8
//int sum = 0;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//do
//{
//    sum = sum + number % 10;
//    number = number / 10;
//} while (number > 0);
//Console.WriteLine(sum);

//2.9
//int max = 0;
//int rem = 0;
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//do
//{
//    rem = number % 10;
//    if (rem > max)
//    {
//        max = rem;
//        number = number / 10;
//    }
//    else
//    {
//        number = number / 10;
//    }
//} while (number > 0);
//Console.WriteLine(max);

//2.10
//int number = 70;
//do
//{
//    Console.WriteLine(number);
//    number = number - 2;
//} while (number > 0);

//2.11
//Console.WriteLine("ilin ayini daxil edin");
//int month = Convert.ToInt32(Console.ReadLine());
//switch (month)
//{
//    case 1:
//        Console.WriteLine("yanvar qis feslidir");
//            break;
//    case 2:
//        Console.WriteLine("fevral qis feslidir");
//            break;
//    case 3:
//        Console.WriteLine("mart yaz feslidir");
//            break;
//    case 4:
//        Console.WriteLine("aprel yaz feslidir");
//            break;
//    case 5:
//        Console.WriteLine("may yaz feslidir");
//            break;
//    case 6:
//        Console.WriteLine("iyun yay feslidir");
//            break;
//    case 7:
//        Console.WriteLine("iyul yay feslidir");
//            break;
//    case 8:
//        Console.WriteLine("avqust yay feslidir");
//            break;
//    case 9:
//        Console.WriteLine("sentyabr payiz feslidir");
//            break;
//    case 10:
//        Console.WriteLine("oktyabr payiz feslidir");
//            break;
//    case 11:
//        Console.WriteLine("noyabr payiz feslidir");
//            break;
//    case 12:
//        Console.WriteLine("dekabr qis feslidir");
//            break;
//    default:
//        Console.WriteLine("duzgun daxil edilmeyib");
//        break;
//}    


//ulduz 11
//int num = 5;
//do 
//{
//    Console.WriteLine("*****");
//    num--;
//} while (num > 0);

//ulduz 12
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i <= number; i++)
//{
//    for (int j = 0; j < i ; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//ulduz 13
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = number; i >= 0; i--)
//{
//    for (int j = i; j > 0; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


