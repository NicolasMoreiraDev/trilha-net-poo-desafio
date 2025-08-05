namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    // Subclasse Iphone
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"[{Numero}] iPhone instalando {nomeApp} via App Store...");
        }
    }
}
