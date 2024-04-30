@ECHO.
@ECHO.
@ECHO. *****************************************************************************
@ECHO. ***                  		YGCM          			         ***
@ECHO. ***                     PROGRAMLAMASI BASLATILIYOR                        ***
@ECHO. ***                                                                       ***
@ECHO. *****************************************************************************

@ECHO OFF
echo Starting Programming Application
cd "C:\Users\serkan.baki\Desktop\YGCM_Programming\HEX-file"
dir /b /a-d > out.tmp
set /p hexname=< out.tmp
del out.tmp
cd ..
echo.
echo.
echo Hex File name picked from the folder is: %hexname%
echo.
echo.
@ECHO. *****************************************************************************
"C:\Users\serkan.baki\Desktop\YGCM_Programming\PSoC_4_Programmer.exe" %hexname%

