
int year = DateTime.Now.Year;


switch (year)
{
    case 2023:
        Console.WriteLine("2023 yılındasınız.");
        break;

    case 2022:
        Console.WriteLine("2022 yılındasınız.");
        break;

    case 2021:
        Console.WriteLine("2021 yılındasınız.");
        break;
}


switch (year)
{
    case 2020:
    case 2021:
    case 2022:
    case 2023:
        Console.WriteLine("Son 4 yıllık bir zaman dilimi seçtiniz.");
        break;

}







Console.ReadLine();
