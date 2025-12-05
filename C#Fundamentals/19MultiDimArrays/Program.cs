namespace _19MultiDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[12, 3];

            students[0, 0] = "Ahmet";
            students[0, 1] = "Soyalan";
            students[1, 0] = "Mehmet";
            students[1, 1] = "Unalan";

            string[,] array = { { "Ahmet", "Soyalan" }, { "Mehmet", "Unalan" } };
        }
    }
}
