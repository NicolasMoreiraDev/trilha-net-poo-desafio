using DesafioPOO.Models;
// Testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Smartphone nokia   = new Nokia("11-98877-6655", "Nokia", "123456789", 46);
        Smartphone iphone  = new Iphone("11-97766-5544", "iPhone", "987654321", 64);

        nokia.Ligar();
        nokia.InstalarAplicativo("LinkedIn");
        nokia.ReceberLigacao();

        Console.WriteLine();

        iphone.Ligar();
        iphone.InstalarAplicativo("GitHub");
        iphone.ReceberLigacao();
    }
}