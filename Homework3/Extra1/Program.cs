// Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает 
//радиус круга и находит его площадь округленную до целого числа, необходимо вывести 
//максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4 20 -> 7 30 -> 8

void ZadachaExtra1()
{
    Console.WriteLine("Введите радиус круга:  ");
    Console.WriteLine("R = :  ");
    int radius = Convert.ToInt32(Console.ReadLine());
    double pi = 3.14;
    double square = (pi * (radius * radius));
    int x = Convert.ToInt32(square);
        
    Console.WriteLine("Площадь = " + x);
    
    int max = 0;
    if (max < x%10) 
       {

        max = x % 10;
        x = x/100;
            }
            
   Console.WriteLine(max);
   


Console.WriteLine("наибольшее число = " + max);

}
ZadachaExtra1();