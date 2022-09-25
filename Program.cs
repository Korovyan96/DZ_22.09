void Zadacha19()
{ 
    int num,a,s=0,t;
    Console.WriteLine("Задача №19 ");  	
    Console.WriteLine("Введите пятизначное число ");
    num = Convert.ToInt32(Console.ReadLine()); 	
    for(t=num;num!=0;num=num/10)
    {
         a=num % 10;
         s=s*10+a;
    }
    if(t==s)
         Console.WriteLine("Палиндром числа");
    else
         Console.WriteLine("Не является палиндромом ");
	}	
    


void Zadacha21()
{
Console.WriteLine("Задача № 21 ");
Console.WriteLine ("Ввведите координаты точки А ");
Console.WriteLine ("Ввведите X ");
int x_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите Y ");
int y_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите Z ");
int z_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите координаты точки B ");
Console.WriteLine ("Ввведите X ");
int x_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите Y ");
int y_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите Z ");
int z_2=Convert.ToInt32(Console.ReadLine());
double x=Math.Pow((x_2-x_1),2);
double y=Math.Pow((y_2-y_1),2);
double z=Math.Pow((z_2-z_1),2);
double r=Math.Round(Math.Sqrt(x+y+z),2);
Console.WriteLine ("Расстояние между точками А и В = "+r);
}
    

void Zadacha23()
{
Console.WriteLine("Задача № 23 ");
Console.WriteLine(" Введите число ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число \tКуб числа ");
for (int i=1; i<=num; i++)
{
    Console.WriteLine("{0} \t{1}\t",i,Math.Pow(i,3));
}
}






Zadacha19();
Zadacha21();
Zadacha23();
