double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b; // числитель
    int denumenator = c + d; // знаменатель
    double result = numenator / denumenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4); // если нет аргументов, то просто ()
Console.WriteLine(result);
