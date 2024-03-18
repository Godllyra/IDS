#include <iostream>
int main(int argc, char const *argv[])
{
    float a, b;
    std::cout << "INGRESA EL VALOR DEL PRIMER NUMERO: ";
    std::cin >> a;
    std::cout << "INGRESA EL VALOR DEL SEGUNDO NUMERO: ";
    std::cin >> b;

    std::cout << "\nLa suma es: " << a + b << std::endl;
    std::cout << "La resta es: " << a - b << std::endl;
    std::cout << "La multiplicacion es: " << a * b <<std::endl;
    if (b == 0)
    {
        std::cout << "Division por cero. Sin solucion";
    }else
    {
        std::cout << "La division es: " << a / b << std::endl;
    }
    return 0;
}