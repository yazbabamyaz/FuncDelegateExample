internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı gir:");
        int number = Convert.ToInt32(Console.ReadLine());
        //delegemiz parametre almamaktadır.Geriye de bool döndürür.Son parametre.
        //=> ifadesinden önce parametre yazılır.PARAMETRE yoksa() yazılır.
        //scope lar içine geriye bool döndürecek kodlarımızı yazıyoruz.
        Func<bool> result = () =>
        {
            if (number <5)
            {
                return true;
            }
            else
            {
                return false;
            }
        };
        Console.WriteLine(result());
        Console.ReadLine();
    }
}