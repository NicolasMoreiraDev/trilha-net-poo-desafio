namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    // Subclasse Nokia
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"[{Numero}] Nokia instalando {nomeApp} via Google Play...");
        }
    }
}