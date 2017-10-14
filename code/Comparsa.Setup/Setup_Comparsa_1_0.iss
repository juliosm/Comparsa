; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Comparsa"
#ifndef MyAppVersion
    #define MyAppVersion "0"
#endif
#define MyAppPublisher "Comparsa Falf�n"
#define MyAppURL "http://artesustentable.org/"
#define MyAppExeName "Comparsa.exe"
#define InnoSetupDir "C:\Program Files (x86)\Inno Setup 5"
#ifndef MyAppParentDir
	#define MyAppParentDir "C:\Desarrollo\Comparsa"
#endif	

[Setup]
AppId={{CF076538-794E-4AB1-AD9B-8A7E34F64772}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={sd}\Comparsa\
DefaultGroupName=Comparsa
SourceDir={#MyAppParentDir}
OutputBaseFilename=Instalar_Comparsa_{#MyAppVersion}
OutputDir={#MyAppParentDir}\installers\
Compression=lzma
SolidCompression=yes
WizardStyle=modern
WizardImageFile={#InnoSetupDir}\WizModernImage-IS.bmp
WizardSmallImageFile={#InnoSetupDir}\WizModernSmallImage-IS.bmp
;LicenseFile={#MyAppParentDir}\docs\license\Licencia.txt
InternalCompressLevel=max

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

;[Types]
;Name: tipo_completa; Description: "Instalaci�n completa"
;Name: tipo_admin; Description: "Instalaci�n de administrador"
;Name: tipo_monitor; Description: "Instalaci�n de monitor"

;[Components]
;Name: comp_admin; Description: Programa; Types: tipo_completa tipo_admin
;Name: comp_monitor; Description: Programa; Types: tipo_completa tipo_monitor

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#MyAppParentDir}\bin\Comparsa\Comparsa.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppParentDir}\bin\Comparsa\Comparsa*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppParentDir}\bin\Comparsa\FirebirdSql.Data.FirebirdClient.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyAppParentDir}\bin\Comparsa\linq2db.dll"; DestDir: "{app}"; Flags: ignoreversion
                                                   
[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Flags: nowait postinstall skipifsilent; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"

[UninstallDelete]
Type: files; Name: "{app}\Config.xml"