#include <stdio.h>
int main(int argc, char const *argv[])
{
    int edad;
    printf("INGRESA TU EDAD: ");
    scanf("%d", &edad);
    if (edad<18)
    {
        printf("AÚN ERES MENOR DE EDAD");
    }else
    {
        printf("ERES MAYOR DE EDAD");
    }
    
    return 0;
}   