
std::string TransferDecimalToAny(long double number, const unsigned int& base, const int& accuracy)
{
    const char* DIGITS = "0123456789abcdefghijklmnopqrstuvwxyz";
    int iter = 0, tmp = 0;
    bool FlagInverse = false;

    if (number < 0)
    {
        FlagInverse = true;
        number *= -1;
    }
    long long int integer;
    long double integer_tmp, fractional;
    std::string reversString, stringInBase;
    if (base < 2 || base > 36)
    {
        std::cout << "Error: основание должно быть от 2 до 36." << std::endl;
        return "-1";
    }

    fractional = modf(number, &integer_tmp);
    integer = static_cast<long long int>(integer_tmp);

    stringInBase += DIGITS[integer % base];
    integer = integer / base;
    while (integer)
    {
        stringInBase += DIGITS[integer % base];
        integer = integer / base;
    }

    if (FlagInverse == true)
        reversString = "-";
    for (int i = stringInBase.length() - 1; i >= 0; i--)
        reversString += stringInBase[i];
    reversString += '.';

    while (iter < accuracy)
    {
        fractional *= base;
        fractional = modf(fractional, &integer_tmp);
        tmp = static_cast<int>(integer_tmp);
        reversString += DIGITS[tmp];
        iter++;
    }

    return reversString;
}
long double number2 = 515.580;
std::cout << "Введите основание перевода: ";
std::cin >> base;

std::cout << "Перевод дробного: " << TransferDecimalToAny(number2, base, 13).c_str() << std::endl;