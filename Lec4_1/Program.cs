// Закрашивание рисунка

int[,] pic = new int[,]
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0}
};
PrintPic(pic);
FillImage(5, 10);
PrintPic(pic);

void PrintPic(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

