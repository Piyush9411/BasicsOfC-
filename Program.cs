//decimal a = 5;
//decimal b = 6;

//decimal c = a / b;

//Console.WriteLine(c);
//-----------------------------------------
//int a = 4;
//int b = 3;

// a = a + b;
//b = a - b;
//a = a - b;


//Console.WriteLine(a);
//Console.WriteLine(b);


//-----------------SWITCH Case--------------------------
//(A)--
//string a = "A";

//switch (a)
//{
//    case "AB":
//    case "A":
//    case "b":
//        Console.WriteLine("AB");
//            break;

//    default:
//        Console.WriteLine("not found");
//        break;
//}


//(B)--
//char a = 'A';

//switch (a)
//{
//    case 'a':
//    case 'b':
//    case 'c':
//        Console.WriteLine("AB");
//        break;

//    default:
//        Console.WriteLine("not found");
//        break;
//}


//(C)--
//Console.WriteLine("Please enter chararcter");

//char a =Convert.ToChar(Console.ReadLine());

//switch (a)
//{
//    case 'a':
//    case 'e':
//    case 'i':
//    case 'o':
//    case 'u':
//        Console.WriteLine("It is a vowel");
//        break;

//    default:
//        Console.WriteLine("It is not a vowel");
//        break;
//}

//-----------FOR LOOP---------------

//for (int i=0; i<10;i++)
//{
//    Console.WriteLine(i);
//}

//------Even Number------------------

//for (int i=1; i<=10; i++)
//{
//    if (i % 2 == 0)
//    { 
//    Console.WriteLine(i);
//    }
//}

//------Odd Number------

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//---------nested loop----------------
//for (int row = 1; row <= 5; row++)
//{
//    for (int col = 1; col <= 5; col++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}

//-----------------Right angled triangle---------

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//--------------Change in row  = print coloum (values of coloum are same)---------------------------------

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j <=i; j++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine();
//}

//--------------Change in column  = print row (values of coloum are same)---------------------------------

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(j);
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i<=4; i++)
//{
//    for (int j = 4; j>= i; j--)
//    {
//        Console.Write(j);
//    }

//    Console.WriteLine();
//}

//-------while Loop--------------------

//int i = 0;

//while(i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int j = 0;

//while (j < 10)
//{
//    j++;
//    Console.Write(j);

//}

//-----------------do while loop------------------------

//int a = 10;

//do
//{
//    Console.WriteLine(a);
//    a++;
//}
//while (a < 20);

//----------------------------------ARRAY-------------------------------------------

//int[]d = new int[2];

//d[0] = 2;
//d[1] = 22;

//foreach (int i in d)
//{
//    Console.WriteLine(i);
//}

//------- Apply array size 5, insert any values & display positive value-------------

//int[]d2 = new int[5];

//d2[0] = 2;
//d2[1] = -5;
//d2[2] = 11;
//d2[3] = -10;
//d2[4] = 22;

//foreach (int i in d2)
//{
//    if (i > 0)
//    {

//        Console.WriteLine(i); 
//    }
//}

//-------------------Find min value from the given array

//int[] d2 = new int[5];

//d2[0] = 2;
//d2[1] = -5;
//d2[2] = 11;
//d2[3] = -10;
//d2[4] = 22;

//int min = d2[0];

//foreach (int i in d2)
//{
//    if (i < min)
//    {
//        min = i;
//    }
//}
//Console.WriteLine(min);

//-------------------Find MAX value from the given array

//int[] d2 = new int[5];

//d2[0] = 2;
//d2[1] = -5;
//d2[2] = 11;
//d2[3] = -10;
//d2[4] = 22;

//int max = d2[0];

//foreach (int i in d2)
//{
//    if (i > max)
//    {
//        max = i;
//    }
//}
//Console.WriteLine(max);

//---------------Count Number, Capital letter, Small letter from the given string---------------------------------------
//string a = "ABdbEfGha135";

////Console.WriteLine("Insert ramdom string");

////string a = Console.ReadLine();

//int small = 0;
//int big = 0;
//int num = 0;

//foreach (char b in a)
//{
//    if (b >= 'A' && b <= 'Z')
//    {
//        small++;
//    }
//    else if (b >= '0' && b <= '9')
//    {
//        num++;
//    }
//    if (b >= 'a' && b <= 'z')
//    {
//        big++;
//    }
//}
//Console.WriteLine(small);
//Console.WriteLine(big);
//Console.WriteLine(num);

//foreach (char c in a)
//{
//    if (c >= 'a' && c <= 'z')
//    {
//        big++;
//    }
//}
//Console.WriteLine(big);

//foreach (int d in a)
//{
//    if (d >= '0' && d <= '9')
//    {
//        num++;
//    }
//}
//Console.WriteLine(num);

//---------------------Convert Capital to Small Letter & Small to Capital Letter--------------------------

String a = "AbC";

foreach (char b in a)
{
    if (b>='A' && b<='Z')
    {
       char c = Convert.ToChar(64 + b);
    }

    Console.WriteLine(c);
}










