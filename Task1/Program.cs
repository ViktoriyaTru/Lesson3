double calculateformula(int a, int b, int c, int d)
{
    double numinator = a * b;
    int denominator = c + d;
    double result = numinator / denominator;
    return result;
}

double result = calculateformula(1, 2, 3, 4);

System.Console.WriteLine(result);
