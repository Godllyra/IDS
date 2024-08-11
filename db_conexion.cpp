#include <sql.h>
#include <sqlext.h>
#include <iostream>

using namespace std;

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

    // Asignar un gestor de entorno
    ret = SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
    ret = SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);

    // Asignar un gestor de conexión
    ret = SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);

    // Conectarse a la base de datos
    ret = SQLConnect(hDbc, (SQLCHAR*)"Conect_uni", SQL_NTS, (SQLCHAR*)"zack", SQL_NTS, (SQLCHAR*)"0000", SQL_NTS);

    if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO) {
        cout << "Conectado a la base de datos exitosamente." << endl;
    } else {
        cout << "Fallo la conexion a la base de datos" << endl;
        printError(hDbc, SQL_HANDLE_DBC);
    }
    // Desconectar y liberar gestores de entorno
    SQLDisconnect(hDbc);
    SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
    SQLFreeHandle(SQL_HANDLE_ENV, hEnv);

    return 0;
}
