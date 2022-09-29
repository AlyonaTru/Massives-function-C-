// вид 1

// void Method1()
// {
//     Console.WriteLine("Студент Алена")
// }
//Method1();

// // вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
    
// }
// Method21(msg: "текст сообщения", count: 4); // именованный аргументы

// вид 3
// int Method3()
// {
//    return DateTime.Now.Year;
    
// }
// int year = Method3();
// Console.WriteLine(year);


// вид 4
// string Method4(int count, string c)
// {
//   int i = 0;
//   string result = String.Empty; // или просто "";

// while( i < count)
// {
//     result = result +c;
//   i++;
// }
//     return result;
// }
// string res = Method4(10, "бла");
// Console.WriteLine(res);

string Method4(int count, string c)
{ 
   string result = String.Empty; // или просто "";

   for (int i = 0; i < count; i++)
   {
    result = result + c;
   }
  return result;
}
string res = Method4(10, "бла");
Console.WriteLine(res);
