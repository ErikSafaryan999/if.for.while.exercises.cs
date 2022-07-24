//see https://aka.ms/new-console-template for more information


//ternary operator
//while (true) {
//    int n = Convert.ToInt32(Console.ReadLine());
//    int m = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine((n < m) ? "ayo" : "voch");
//    Console.ReadKey();
//    Console.Clear(); }

//______________________________________________________________

//exercises No 151-166
//151-print the sum of all natural numbers that
//divide the given natural number n without a remainder.
//while (true)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    int sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//            sum += i;
//    }
//    Console.WriteLine(sum);
//    Console.ReadKey();
//    Console.Clear();
//}


//152-print the product of all natural numbers that
//divide the given natural number n without a remainder.

//while (true)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    int product = 1;
//    for (int i = 2; i <= n; i++)
//    {
//        if (n % i == 0 && n!=0)
//            product *= i;
//        else if(n==0)
//            product=0;
//    }
//    Console.WriteLine(product);
//    Console.ReadKey();
//    Console.Clear();
//}

//153-print the sum of all the natural numbers by which
//there will be 2 remainders when dividing the given natural number n.

//while (true)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    int sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 2)
//            sum += i;
//    }
//    Console.WriteLine(sum);
//    Console.ReadKey();
//    Console.Clear();
//}


//154-print the product of all the natural numbers by which
//there will be 3 remainders when dividing the given natural number n.

//while (true)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    int product = 1;
//    for (int i = 2; i <= n; i++)
//    {
//        if (n % i == 3)
//            product *= i;


//    }
//    if(product==1)
//    {
//        Console.WriteLine("Null");

//    }
//   else  Console.WriteLine(product);
//    Console.ReadKey();
//    Console.Clear();
//}

//155-print the sum of all two-digit numbers that are multiples of 3.

//int sum=0;
//for(int i = 12; i < 100; i += 3)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

//156-print the product of all two-digit numbers that are multiples of 3 and 5.

//ulong product = 1;

//for(ulong i = 15; i < 100; i += 15)
//{
//    product *= i;
//}
//Console.WriteLine(product);

//157-print the sum of all three-digit numbers that are not a multiple of 5.

//int sum = 0;

//for(int i = 100; i < 1000 ; i++)
//{
//    if(i%5!=0)
//    sum += i;
//}
//Console.WriteLine(sum);


//158-Print the product of all three-digit numbers that are not multiples of 2 and 3.

//ulong product = 1;

//for(uint i = 100; i < 120; i++)
//{
//    if (i % 2 != 0 && i%3!=0)
//        product *= i;
//}
//Console.WriteLine(product);



//159-Print the product of all three-digit numbers that leave a remainder of 1 when
//divided by 3 and leave a remainder of 2 when divided by 4.

//int product = 1;

//for(int i = 100; i < 1000; i++)
//{
//    if (i % 3 == 1 && i % 4 == 2)
//        product *= i;
//}
//Console.WriteLine(product);


//160-Print the smallest three-digit number that, when multiplied by 16,
//becomes the square of a natural number.



//for (int i = 100; i < 1000; i++)
//{
//    if (Math.Sqrt(i * 16) % 1 == 0)
//    {
//    Console.WriteLine(i);
//        break;

//    }
//}


//161-Print the smallest four-digit number that, when multiplied by 26,
//becomes the square of a natural number.

//for(int i = 1000; i < 10000; i++)
//{
//    if (Math.Sqrt(i * 26) % 1 == 0)
//    {
//        Console.WriteLine(i);
//        break;

//    }
//}


//164-Print the smallest three-digit number whose square root is
//greater than the given natural number n.
//while (true)
//{
//    Console.Write("Please enter your number:");
//    int n = Convert.ToInt32(Console.ReadLine());

//    for (int i = 100; i < 1000; i++)
//    {
//        if (Math.Sqrt(i) > n)
//        {
//            Console.WriteLine(i);
//            break;
//        }
//        else if (i == 999)
//            Console.WriteLine("Your number is greater");
//    }
//    Console.ReadKey();
//    Console.Clear();
//}


//165-will assign the value true to the logical type variable t if the given
//natural number n is a power of 3, otherwise false. Print the value of t.

//while (true)
//{
//    bool t = true;
//    Console.Write("Enter your number:");
//    int n = Convert.ToInt32(Console.ReadLine());


//    for(int i= 0; i < n; i++)
//    {
//        if (Math.Pow(3, i) == n)
//        {
//            Console.WriteLine(t);
//            break;
//        }
//        if (i >= n/2)
//        {
//            t = false;
//            Console.WriteLine(t);
//            break;
//        }

//    }

//    Console.ReadKey();
//    Console.Clear();

//}



//166- Assign the value 0 to the variable y if the given natural number n is not a power of 4,
//    otherwise - the value 1. Print the value of y.

//while (true)
//{
//    Console.Write("Enter your number:");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int y;


//    for (int i = 0; i < n; i++)
//    {
//        if (Math.Pow(4, i) == n)
//        {
//            y = 1;
//            Console.WriteLine(y);
//            break;
//        }
//        if (i >= n / 2)
//        {
//            y = 0;
//            Console.WriteLine(y);
//            break ;
//        }
//    }


//Console.ReadKey();
//    Console.Clear();

//}


