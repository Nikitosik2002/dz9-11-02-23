
void function (int n)
{
   if (n > 0 ) System.Console.WriteLine(n);
   if (n == 0) return ;
    function(n-1);
}

function(20);