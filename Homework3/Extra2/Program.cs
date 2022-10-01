// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая на вход 
//принимает букву, необходимо создать массив из 5 названий городов, и вывести на экран те 
//(тот), где чаще всего встречается введённая буква.
//Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"

void ZadachaExtra2 ()
{
string[] goroda = {"Париж", "Москва", "Тюмень", "Новосибирск", "Ульяновск"};
Console.WriteLine("Введите букву: ");
string letter = Console.ReadLine();

for (int i = 0; i < goroda.Length; i++)
            {
               // Console.Write(words[i].Contains(letter));
               if (words[i].Contains(letter))
                {
 
                Console.WriteLine(words[i]);
 
               }
               
               else Console.Write("No match");
              
            }

}