// See https://aka.ms/new-console-template for more information

using execp;

ExceptionHandling exceptionHandling = new ExceptionHandling(5, 0);

try
{
    exceptionHandling.div();
    exceptionHandling.checkage();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}