#include <iostream>
int main(int argc, char const *argv[])
{
    char rfc [10] = {'\0'};
    char vocals [2] = {'\0'};
    std::string apellido_p, apellido_m, nombre, dia, mes, anio;
    std::cout << "INGRESA TU APELLIDO PATERNO: ";
    std::getline(std::cin, apellido_p);
    std::cout << "INGRESA TU APELLIDO MATERNO: ";
    std::getline(std::cin, apellido_m);
    std::cout << "INGRESA TU NOMBRE: ";
    std::getline(std::cin, nombre);
    std::cout << "FECHA DE NACIMIENTO (solo numero)\nDIA: ";
    std::cin >> dia;
    std::cout << "MES";
    std::cin >> mes;
    std::cout << "ANIO";
    std::cin >> anio;
    int j = 0;
    for (size_t i = 0; i < apellido_p.length(); i++)
    {   
        if (j > 1)
        {
            i = apellido_p.length();
        }
        if (apellido_p[i] == 'a' || apellido_p[i] == 'e' || apellido_p[i] == 'i' || apellido_p[i] == 'o' || apellido_p[i] == 'u')
        {
            vocals[j] = apellido_p[i];
            j++;   
        }
    }
    if (apellido_p[0] == 'a' || apellido_p[0] == 'e' || apellido_p[0] == 'i' || apellido_p[0] == 'o' || apellido_p[0] == 'u')
    {
        for (size_t i = 0; i < 2; i++)
        {
            rfc[i] = vocals[i];
        }
    }else
    {
        rfc[0] = apellido_p[0];
        rfc[1] = vocals[0];
    }
    rfc[2] = apellido_m[0];
    rfc[3] = nombre[0];
    rfc[4] = anio[0];
    rfc[5] = anio[1];
    rfc[6] = mes[0];
    rfc[7] = mes[1];
    rfc[8] = dia[0];
    rfc[9] = dia[1];
    for (size_t i = 0; i < 10; i++)
    {
        std::cout << rfc[i];
    }
    return 0;
}