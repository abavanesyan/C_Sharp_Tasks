Console.WriteLine("Give the value of row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give the value of column");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[8, 8];
List<int[]> loc = new List<int[]>(); // This list is for gathering the free places
void queen(int n, int m)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (n - 1 == i && m - 1 == j)
            {
                arr[i, j] = 9;
            }
            else if ((Math.Abs(n - 1 - i) == Math.Abs(m - 1 - j)) || j == m - 1 || i == n - 1)
            {
                arr[i, j] = 1;
            }
        }
    }
    loc.Clear();
    for (int k = 0; k < 8; k++)
    {
        for (int l = 0; l < 8; l++)
        {
            if (arr[k, l] == 9)
            {
                Console.Write("Q ");
            }
            else if (arr[k, l] == 1)
            {
                Console.Write("1 ");
            }
            else
            {
                loc.Add([k, l]);
                Console.Write("0 ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("Do you want to continue (y or n)");
    string ans = Console.ReadLine();

    if (ans == "y")
    {
        if (loc.Count != 0)
        {
            Random rnd = new Random();
            int r1 = rnd.Next(0, loc.Count - 1);
            queen(loc[r1][0] + 1, loc[r1][1] + 1);
        }
        else
        {
            Console.WriteLine("There is no place left");
        }
    }
}
if (n > 0 && n < 9 && m > 0 && m < 9)
{
    queen(n, m);
}
else
{
    Console.WriteLine("You have mistaken the numbers");
}
