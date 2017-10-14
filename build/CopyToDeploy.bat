
set VERSION_BUILD=%VERSION%.%BUILD_NUMBER%

c:\windows\system32\xcopy .\bin\Comparsa\*.exe d:\Deployment\comparsa\bin\Comparsa /S /Y /I
c:\windows\system32\xcopy .\bin\Comparsa\*.dll d:\Deployment\comparsa\bin\Comparsa /S /Y /I
c:\windows\system32\xcopy .\bin\Comparsa\*.exe d:\FTPShared\users\comparsa\Comparsa\bin\Comparsa /S /Y /I
c:\windows\system32\xcopy .\bin\Comparsa\*.dll d:\FTPShared\users\comparsa\Comparsa\bin\Comparsa /S /Y /I

c:\windows\system32\xcopy .\installers\Instalar_Comparsa_%VERSION_BUILD%.exe d:\Deployment\comparsa\installers\ /S /Y /I
c:\windows\system32\xcopy .\installers\Instalar_Comparsa_%VERSION_BUILD%.exe d:\FTPShared\users\comparsa\Comparsa\installers\ /S /Y /I
