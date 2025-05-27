[Setup]
AppName=ProductionRequestManager
AppVersion=1.0
DefaultDirName={pf}\ProductionRequestManager
DefaultGroupName=ProductionRequestManager
OutputDir=.
OutputBaseFilename=ProductionRequestManagerInstaller
SetupIconFile=app_icon.ico
Compression=lzma
SolidCompression=yes

[Files]
[Files]
Source: "bin\\Release\\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs


[Icons]
Name: "{group}\ProductionRequestManager"; Filename: "{app}\ProductionRequestManager.exe"
Name: "{commondesktop}\ProductionRequestManager"; Filename: "{app}\ProductionRequestManager.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Создать ярлык на рабочем столе"; GroupDescription: "Дополнительные значки:"
