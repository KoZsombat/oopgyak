namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Suly:");
            //double suly = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Magassag:");
            //int magassag = Convert.ToInt32(Console.ReadLine());
            //Ember ember = new Ember(suly, magassag);
            //Console.WriteLine($"{ember.TestTomegIndex()} TTI");
            //Console.WriteLine($"{(ember.NormalTTI() ? "Normális TTI" : "Nem normális TTI")}");
            Emberek emberek = new Emberek();
            emberek.EmberekLetrehoz(5);
            Console.WriteLine(emberek.ToString());
            Console.WriteLine($"Átlag magasság: {emberek.AvgMagassag()}, Átlag súly: {emberek.AvgSuly()}");
        }
    }
}
