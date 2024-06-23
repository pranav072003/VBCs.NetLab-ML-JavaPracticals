# Contains the GUI interfaces and window forms designed using Visual Studio IDE Community 2022


# reference for creating MessageBox in C
#include <tchar.h> 

#include <Windows.h>

int _stdcall WinMain(HINSTANCE hinstance, HINSTANCE hPrevinstance, LPSTR lpszCmdline, int nCmdShow)
{

    MessageBox(NULL, _T("Hello World"), _T("caption"), 0);

    return(0);
}
