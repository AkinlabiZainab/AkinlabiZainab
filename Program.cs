// See https://aka.ms/new-console-template for more information
//  Greeting();
//  Greetings("zainab");

//Console.WriteLine(FindAreaOfTriangle(12,8));//or
//  double result = FindAreaOfTriangle(12,8);
//  Console.WriteLine(result);

//  string answer = FindAreaOfTriangles(24,12);
//  Console.WriteLine(answer);

// string response = EvenNumbers(8);
// Console.WriteLine(response);

// int[] num = {2,4,5,8,9,1};
// double sum  = SumOfArray(num);
// Console.WriteLine(sum);
// int[] num = {2,4,5,8,9,1};
// Compare(num);
// double divide = OddEven(num);
// Console.WriteLine(divide);
// int num= -1;
// string num2 = CheckNumber(num);
// Console.WriteLine(num2);

//Console.WriteLine($"static varriable y = {example.y}");
// string[] names = {"Ade", "Bola","Anita"};
// Console.WriteLine(StartsA(names));
// StartsA("ade", "bola", "anita");
// string[] names = {"Ade", "Bola","Anita"};
// string n = TotalA(names);
// Console.WriteLine(n);
//WithA("Ade", "bola", "Anita");
//Console.WriteLine(499/100);

//Console.WriteLine(Average());
// int[] num = SizeOfArray();
// Console.WriteLine(num);



// static void Greeting()
// {
//     Console.WriteLine("Hello, it is nice metting you");
// }
// static void Greetings(string name)
// {
//     Console.WriteLine($"hello {name}, it is nice meeting you");

// }
// static double FindAreaOfTriangle( double b, double h)
// {
//     double area = 0.5 *b* h;
//    return area;
//     //Console.WriteLine($"area of a triangle is {area}");
// }
// static string FindAreaOfTriangles( double b, double h)
// {
//       double area = 0.5 *b* h;
//    return $"the area of  a triangle is{area}";
//     //Console.WriteLine($"area of a triangle is {area}");
// }
// static string EvenNumbers(int num)
// {
//     if(num %2 == 0)
//     {
//         return $"the number {num} is even";
//     }
//     return $"the number {num} is not even";



// }
// static double SumOfArray(int[] numbers)
// {
//     double sum = 0;
//     foreach (var item in numbers)
//     {
//         sum +=item;
//     }
//     return sum;
// }
// static void Compare(int[] numbers)
// {
//     int biggest = int.MinValue;
//     int smallest = int.MaxValue;

//     for (int i = 0; i <= numbers.Length -1; i++)
//     {
//         if( numbers[i]> biggest)
//         {
//          biggest = numbers[i];
//         }
//     }
//     Console.WriteLine( biggest);

//     for (int i = 0; i <= numbers.Length -1; i++)
//     {  
//          if(numbers[i] < smallest)
//         {
//             smallest = numbers[i];
//         }


//     } 

//     Console.WriteLine(smallest);

// }   
// static double OddEven(int[] numbers)
// {
//     double sum1 = 0;
//     double sum2 = 0;
//     foreach (var item in numbers)
//     {
//      if(item % 2 == 0)   
//      {
//         sum1+=item;
//         Console.WriteLine(sum1);
//      }
//      else{
//         sum2+=item;
//          Console.WriteLine(sum2);
//      }


//     }
//     return sum2/sum1; 
// }
// static string CheckNumber(int number)
// {
//     if(number > 0)
//     {
//         return "it is postive";
//     }
//     return "its is negative";
// }
// static string StartsA(params string[] names)
// {
//     int count = 0;
//     foreach (var item in names)
//     {

//         if(item[0] == 'A')
//         {
//             count++;
//         }
//     }
//     return $"the number of names starting with A are {count}";
// }
// static string TotalA( string[] names)
// {
//     int count = 0;
//     foreach (var item in names)
//     {

//         Console.WriteLine(item);

//             count++;

//     }
//     return $"the number of names  are {count}";
// }
static string[] WithA(params string[] names)
{
    string[] NamesWithA = new string[names.Length];
    int count = 0;
    for (int i = 0; i < names.Length; i++)
    {
        if (names[i].StartsWith("A"))
        {
            NamesWithA[i] = names[i];
            count++;
        }
    }
    foreach (var item in NamesWithA)
    {
        Console.WriteLine(item);
    }
    return NamesWithA;
    // foreach (var item in names)
    // {


    //             count++;
    //             NamesWithA[count] = item;

    // }
    //  foreach (var item in NamesWithA)
    //  {
    //Console.WriteLine(item);
    // }




    //return $"the number of names  are {count}";
}
static int[] SizeOfArray(){
    Console.WriteLine("enter the size of the array");
    int length = int.Parse(Console.ReadLine());
    int[] num = new int[length];
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"enter the value at index{i}  ");
        num[i] = int.Parse(Console.ReadLine());
    }
    return num;
}
static string JoinedEven()
{
    string response = "";
    var x = SizeOfArray();
    foreach (var item in x)
    {
        if(item %2 == 0)
        {
            response += item.ToString() + ",";
            //Console.Write(item.ToString() + ",");
        }
        
    }
    return response.Remove(response.Length-1);
}
static double Average()
{
    
    double sum = 0;
     string input = JoinedEven();
     var splittedInput = input.Split(',');
    
    foreach (var item in splittedInput)
    {
       sum+= double.Parse(item);
       
    }
    
    return  sum/splittedInput.Length;
     

}




class example
{
    public static int y = 200;

    public void examples(int num)
    {
        Console.Write(y);
    }
    public static int Getaward()
    {
        return 7;
    }
}

