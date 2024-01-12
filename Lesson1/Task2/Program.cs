int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

// если тип данных разный, то результат - более объемный и вместительный тип
long l1 = 6;
long sum2 = l1 + i1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + i1;
Console.WriteLine(sum3);

int product1 = i1 * i2;
long product2 = l1 *i1;
double product3 = d1 * i1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient = i1 / i2;
Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
Console.WriteLine(quotient2);


double q1 = 1;
double q2 = 1;
double product4 = q1 * q2;
Console.WriteLine(product4);

int q3 = 1;
int q4 = 1;
double sum4 = q3 + q4;
Console.WriteLine(sum4);

double quotient3 = product4 / sum4;
Console.WriteLine(quotient3);


