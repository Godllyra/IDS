#include <iostream>
#include <string>
#include <cctype>

bool esVocal(char letra)
{
    letra = std::tolower(letra);
    return (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u');
}

char getPrimeraVolcal(const std::string &apellido_p)
{
    for (char letra : apellido_p)
    {
        if (esVocal(letra))
        {
            return letra;
        }
    }
    return 'X';
}

std::string calcRFC(const std::string &nombre, const std::string &apellido_p, const std::string &apellido_m, const std::string &nacimiento)
{
    std::string rfc;

    char primerLetra_p = apellido_p[0];
    char primerVocal = getPrimeraVolcal(apellido_p);

    char primeraLetra_m = (!apellido_m.empty()) ? apellido_m[0] : 'x';
    char primeraLetra_n = nombre[0];

    std::string anio = nacimiento.substr(2, 2);
    std::string mes = nacimiento.substr(5, 2);
    std::string dia = nacimiento.substr(8, 2);

    rfc = primerLetra_p;
    rfc += primerVocal;
    rfc += primeraLetra_m;
    rfc += primeraLetra_n;
    rfc += anio;
    rfc += mes;
    rfc += dia;
    return rfc;
}
int main(int argc, char const *argv[])
{
    std::string nombre, apellido_p, apellido_m, nacimiento;
    std::cout << "INGRESA TU NOMBRE> ";
    std::getline(std::cin, nombre);

    std::cout << "INGRESA TU APILLIDO PATERNO> ";
    std::getline(std::cin, apellido_p);

    std::cout << "INGRESA TU APELLIDO MATERNO (presiona <ENTER> si no tienes)> ";
    std::getline(std::cin, apellido_m);

    std::cout << "INGRESA TU FECHA DE NACIMIENTO EN EL SIGUIENTE FORMATO: YYYY-MM-DD> ";
    std::getline(std::cin, nacimiento);

    std::string RFC = calcRFC(nombre, apellido_p, apellido_m, nacimiento);

    std::cout << "RFC: " << RFC << std::endl;
    return 0;
}