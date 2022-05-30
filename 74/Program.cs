/*4 друга должны посетить 12 пабов, в котором
 выпить по британской пинте пенного напитка. До каждого бара идти 
примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга 
лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3
 литра, это их максимум. Необходимо выяснить, до скольки баров смогут 
дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет.
 И сколько всего времени будет потрачено на выпивку.*/


double [] drinkLimits = new double [4] {1.1,1.5,2.2,3.3};

//int timeWalk = new Random().Next(15,21);
int timeDrink = 15;
int countPubs = 0;
int maxPubs = 12;
double portionDrink = 0.57;
double sumDrink = 0;
double sumTime = 0;

if(countPubs > maxPubs)
{
    Console.WriteLine ("Вы обошли все 12 пабов");
}
else
{
    for (int i = 0; i < drinkLimits.Length; i++)
    {
        Console.WriteLine($"Друг {i + 1} имеет лимит на выпивку {drinkLimits[i]} литра");
        while (sumDrink < drinkLimits[i])
        {
            sumTime = sumTime + timeDrink;
            sumDrink = sumDrink + portionDrink;
            countPubs++;

        }
        Console.WriteLine($"Общее время выпивки : {sumTime} ");
        Console.WriteLine($"Количество посещённых пабов : {countPubs} ");
        Console.WriteLine();

    }
}

