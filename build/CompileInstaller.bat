
set VERSION_BUILD=%VERSION%.%BUILD_NUMBER%

"%INNO_SETUP_PATH%\ISCC.exe" -dMyAppVersion=%version_build% -dMyAppParentDir="%WORKSPACE%" .\code\Comparsa.Setup\Setup_Comparsa_1_0.iss

set installer_name=Instalar_Comparsa_%VERSION_BUILD%.exe

