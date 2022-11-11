using System.Collections;
using System.Collections.Generic;

using pr15._10._2022;


//KeyValue<string> kv = new KeyValue<string>()
//{
//    id = 5,
//    Value = " jj"
//};








//Random random = new Random();
//var numbers = new List<int>();


//for(int i = 0;i<5; i++)
//{
//    numbers.Add(random.Next(0,50));


//};

//int sred = (int)numbers.Average();
//numbers.Add(sred);


//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}










var peple = new List<Human>() {

  new Human("Nikita", "Popova", 20, true),
    new Human("Anna", "Code", 20, true),
    new Human("Nikita", "Bomj", 46, true),
    new Human("Woloda", "Kalnitskiy", 3, false),
    new Human("Woloda", "Kalnitskiy", 37, true),
    new Human("Roma", "Bomj", 23, true),
    new Human("Nik", "Kalnitskiy", 17, false),
    new Human("Sur", "Popova", 16, false),
    new Human("Nikita", "Kalnitskiy", 20, true),
    new Human("Anna", "Pavlova", 21, true),
    new Human("Vasya", "Bomj", 47, false),
    new Human("Sasha", "Hooligan", 12, false),
    new Human("Gosha", "Dudar", 25, true),
    new Human("Simple", "Code", 26, false),
    new Human("Roman", "Odynets", 24, true),
    new Human("Masha", "Popova", 15, false)


};

//1.Вывести всех совершеннолетних работающих.
Console.WriteLine("Вывести всех совершеннолетних работающих.");
foreach (Human human in peple)
{
    if (human.Age >= 18)
    {
        Console.WriteLine(human.ToString());
    }
}


//2. Вывести всех людей, у которых длинна фамилии больше 8 символов.
Console.WriteLine("Вывести всех людей, у которых длинна фамилии больше 8 символов.");
foreach (Human human in peple)
{
    if (human.Surname.Length > 8)
    {
        Console.WriteLine(human.ToString());
    }
}


//3. Вывести всех людей задом наперёд.
Console.WriteLine("Вывести всех людей задом наперёд.");
for (int i = peple.Count-1; i >= 0; i--)
{
    Console.WriteLine(peple[i].ToString());

}

//4. Сделать всех несовершеннолетних людей неработающими.
Console.WriteLine("Сделать всех несовершеннолетних людей неработающими.");
foreach (Human human in peple)
{
    if (human.Age < 18)
    {
        human.IsWorking=false;
    }
}



//5. Сделать всех людей, у которых в фамилии есть слог "ру" неработающими.
Console.WriteLine("Сделать всех людей, у которых в фамилии есть слог ру неработающими.");
foreach (Human human in peple)
{
    int indexOfry = human.Surname.IndexOf("py");
    if (indexOfry > 0 )
    {
        human.IsWorking = false;
    }
}


//6. Удалить из списка людей всех, кому больше 65 лет.
Console.WriteLine("Удалить из списка людей всех, кому больше 65 лет.");
for (int i=0; i < peple.Count; i++) { 
    if (peple[i].Age > 65)
    {
        peple.RemoveAt(i);
    }
}




Console.WriteLine("Все-");
foreach (Human human in peple)
{
  Console.WriteLine(human.ToString());
}











