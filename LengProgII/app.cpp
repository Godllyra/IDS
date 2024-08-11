// Se incluyen los encabezados necesarios para utilizar las funciones de ODBC: sql.h y sqlext.h.
#include <sql.h>
#include <sqlext.h>
#include <iostream>
#include <iomanip>
using namespace std;
// Se define una función printError que imprime los detalles de un error ODBC.
void printError(SQLHANDLE handle, SQLSMALLINT type) {
    SQLCHAR sqlState[1024];
    SQLCHAR message[1024];
    SQLINTEGER nativeError;
    SQLSMALLINT textLength;
    SQLGetDiagRec(type, handle, 1, sqlState, &nativeError, message, sizeof(message), &textLength);
    cout << "Error: " << message << " SQLState: " << sqlState << endl;
}
int main() { 
    SQLHENV hEnv;
    SQLHDBC hDbc;
    SQLRETURN ret;
    // Asignar un gestor de entorno ODBC (SQLHENV) y se establece la versión de ODBC a 3.0.
    ret = SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
    ret = SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);
    // Asignar un gestor de conexión ODBC (SQLHDBC)
    ret = SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);
    /* Se intenta conectar a la base de datos utilizando la función SQLConnect(). Los parámetros son el nombre de
    la fuente de datos (DSN), el nombre de usuario del DBSM y la contraseña.*/
    ret = SQLConnect(hDbc, (SQLCHAR*)"Conect_uni", SQL_NTS, (SQLCHAR*)"zack", SQL_NTS, (SQLCHAR*)"0000", SQL_NTS);
    // Si la conexión es exitosa, se imprime un mensaje de éxito.
    if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO) {
        cout << "Conectado a la base de datos exitosamente." << endl;
        
        SQLHSTMT hStmt;
        ret = SQLAllocHandle(SQL_HANDLE_STMT, hDbc, &hStmt);
        if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO) {
            ret = SQLExecDirect(hStmt, (SQLCHAR*)"SELECT * FROM uni_db.empleados", SQL_NTS);
            if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO) {
                SQLINTEGER num_empleado;
                SQLCHAR nombre[16];
                SQLCHAR apellido_paterno[16];
                SQLCHAR apellido_materno[16];
                SQLCHAR fecha_nacimiento[10];
                SQLCHAR centro_trabajo[64];
                SQLCHAR puesto[16];
                SQLCHAR descripcion_puesto[128];
                SQLCHAR directivo;
                SQLCHAR rfc[18];
                SQLLEN num_empleadoLen, nombreLen, apellido_paternoLen, apellido_maternoLen, fecha_nacimientoLen, centro_trabajoLen, puestoLen, descripcion_puestoLen, directivoLen, rfcLen;

                // Obtener y mostrar los resultados
                cout << "+---------------+---------------------------------+------------+--------------------------+---------+-------------+-------------+" << endl;
                cout << "| No. empleado  |   Nombre                        | Nacimineto |          Centro          |  Puesto | ¿Directivo? |    RFC      |" << endl;
                cout << "+---------------+---------------------------------+------------+--------------------------+---------+-------------+-------------+" << endl;
                while (SQLFetch(hStmt) == SQL_SUCCESS) {
                    SQLGetData(hStmt, 1, SQL_C_SLONG, &num_empleado, sizeof(num_empleado), &num_empleadoLen);
                    SQLGetData(hStmt, 2, SQL_C_CHAR, nombre, sizeof(nombre), &nombreLen);
                    SQLGetData(hStmt, 3, SQL_C_CHAR, apellido_paterno, sizeof(apellido_paterno), &apellido_paternoLen);
                    SQLGetData(hStmt, 4, SQL_C_CHAR, apellido_materno, sizeof(apellido_materno), &apellido_maternoLen);
                    SQLGetData(hStmt, 5, SQL_C_CHAR, fecha_nacimiento, sizeof(fecha_nacimiento), &fecha_nacimientoLen);
                    SQLGetData(hStmt, 6, SQL_C_CHAR, centro_trabajo, sizeof(centro_trabajo), &centro_trabajoLen);
                    SQLGetData(hStmt, 7, SQL_C_CHAR, puesto, sizeof(puesto), &puestoLen);
                    SQLGetData(hStmt, 8, SQL_C_CHAR, descripcion_puesto, sizeof(descripcion_puesto), &descripcion_puestoLen);
                    SQLGetData(hStmt, 9, SQL_C_BIT, &directivo, sizeof(directivo), &directivoLen);
                    SQLGetData(hStmt, 10, SQL_C_CHAR, rfc, sizeof(rfc), &rfcLen);
                    string nombre_com = string((char*)nombre) + " " + string((char*)apellido_paterno) + " " + string((char*)apellido_materno);
                    cout << "| " << setw(14) << right << num_empleado 
                         << "| " << setw(32) << left << nombre_com  
                         << "| " << setw(11) << left<< fecha_nacimiento
                         << "| " << setw(25) << left << centro_trabajo 
                         << "| " << setw(8) << left << puesto
                         << "| " << setw(12) << left << (directivo ? "Si" : "No")
                         << "| " << setw(10) << left << rfc
                         << " |" << endl;
                }
                cout << "+---------------+---------------------------------+------------+--------------------------+---------+-------------+-------------+" << endl;
            } else {
                cout << "Error al ejecutar la consulta SQL" << endl;
                printError(hStmt, SQL_HANDLE_STMT);
            }
            SQLFreeHandle(SQL_HANDLE_STMT, hStmt);
        } else {
            cout << "Error al asignar el gestor de declaración" << endl;
            printError(hDbc, SQL_HANDLE_DBC);
        }
    // Si la conexión falla, se imprime un mensaje de error y se llama a la función printError() para obtener más detalles.
    } else {
        cout << "Fallo la conexion a la base de datos" << endl;
        printError(hDbc, SQL_HANDLE_DBC);
    }
    // Finalmente, se desconecta de la base de datos y se liberan los gestores de entorno y conexión
    SQLDisconnect(hDbc);
    SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
    SQLFreeHandle(SQL_HANDLE_ENV, hEnv);
    return 0;
    }
