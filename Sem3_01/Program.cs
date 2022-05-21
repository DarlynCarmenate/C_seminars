// 

double Distance(int x1, int x2, int y1, int y2)
{
	return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine(Distance(3, 6, 2, 1));