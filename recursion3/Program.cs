﻿int m = 3;
int n = 10;


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1,1);
    }
    else 
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
    
}

System.Console.WriteLine(Akkerman(m,n));