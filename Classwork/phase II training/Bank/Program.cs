// See https://aka.ms/new-console-template for more information
using Bank;

BankDetails bankDetails = new BankDetails(7654321, "ranganathan", "Active", 97865743212213, 2003000);

while(true)
{
    Console.WriteLine("1.Custid\n2.name\n3.exit");
    int ctr=Convert.ToInt32(Console.ReadLine());
    if(ctr==1)
    {
        int scr=Convert.ToInt32(Console.ReadLine());
        bankDetails.Fetchacc(scr);
    }
    else if(ctr==2)
    {
        string? scr=Console.ReadLine();
        bankDetails.Fetchacc(scr);

    }
    else if(ctr==3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter a valid one");
    }
}
