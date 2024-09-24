public class ElectricBill
{


    public void GetElectricityBill(int unit)
    {

        if (unit <= 20)
        {
            Console.WriteLine("Your bill amount is : Rs.100.");
        }
        else if (unit > 20 && unit < 25)
        {
            Console.WriteLine($"Your bill Amount is: Rs. {unit * 5}");

        }
        else if (unit >= 25 && unit < 50)
        {
            Console.WriteLine($"Your bill Amount is: Rs. {unit * 10}");
        }
        else if(unit>=50)
        {
            Console.WriteLine("Your bill amount is : Rs.2000");
        }
    }

    public void GetBill(int unit)
{
    switch (unit)
    {
        case <= 20:
            Console.WriteLine("Your bill amount is: Rs. 100.");
            break;

        case > 20 and < 25:
            Console.WriteLine($"Your bill amount is: Rs. {unit * 5}");
            break;

        case >= 25 and < 50:
            Console.WriteLine($"Your bill amount is: Rs. {unit * 10}");
            break;

        case >= 50:
            Console.WriteLine("Your bill amount is: Rs. 2000.");
            break;

       
    }
}


}
