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
        int type = 0;  // Correct variable name

        if (unit <= 20)
        {
            type = 1;
        }
        else if (unit > 20 && unit < 25)
        {
            type = 2;
        }
        else if (unit >= 25 && unit < 50)
        {
            type = 3;
        }
        else if (unit >=50)
        {
            type = 4;
        }

        switch (type)
        {
            case 1:
                Console.WriteLine("Your bill amount is: Rs. 100.");
                break;
            case 2:
               Console.WriteLine($"Your bill Amount is: Rs. {unit * 5}");
                break;
            case 3:
               Console.WriteLine($"Your bill Amount is: Rs. {unit * 10}");
               break;
            case 4:
                Console.WriteLine("Your bill amount is: Rs. 2000.");
                break;
        }
    }

}