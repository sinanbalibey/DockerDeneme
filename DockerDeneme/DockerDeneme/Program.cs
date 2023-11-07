namespace DockerDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.Second);
                Console.Write("İntellium SOFTWARE");
                Thread.Sleep(1000);
            }
        }
    }
}