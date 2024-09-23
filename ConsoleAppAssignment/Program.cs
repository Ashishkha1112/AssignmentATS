
internal class Program
{
    private static void Main(string[] args)

    {
        //     Console.WriteLine("Enter your Number of Units:");
        //    int unit=  (Console.Read());
        ElectricBill bill = new();
        bill.GetElectricityBill(110);

        bill.GetBill(49);
      
        bill.GetBill(24);
        bill.GetBill(50);

    }
}