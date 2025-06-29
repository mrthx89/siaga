; Inno Setup Script - Installer Aplikasi .NET Framework 4.6.1
; Buat file ini dengan ekstensi .iss dan buka di Inno Setup Compiler

#define MyAppName "Siaga Asset Manajemen"
#define MyAppVersion "1.0.0.1"
#define MyAppPublisher "YH Dev"
#define MyAppCopyright "Copyright @ 2025 YH Dev"
#define MyAppURL "https://yhdev.click"
#define MyAppURLSupport "https://yhdev.click/#contact"
#define MyAppURLProduct "https://yhdev.click/#showcase"
#define MyAppExeName "Siaga.App.exe"
#define MyGroupApp "Siaga"
#define MyYearApp "2025"
#define MyAppId "{ECEB9351-F77C-40BB-8FC9-3CF49BD69044}"

[Setup]
AppId={{#MyAppId}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURLSupport}
AppUpdatesURL={#MyAppURLProduct}
AppCopyright={#MyAppCopyright}
CreateUninstallRegKey=True
DefaultDirName={commonpf}\{#MyGroupApp}\{#MyYearApp}\{#MyAppName}
DefaultGroupName={#MyGroupApp}\{#MyYearApp}\{#MyAppName}
OutputBaseFilename=Siaga_Setup
UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallFilesDir={app}\uninst
SetupIconFile=icon.ico
Compression=lzma
SolidCompression=yes
AllowRootDirectory=True
EnableDirDoesntExistWarning=True
InternalCompressLevel=ultra
PrivilegesRequired=admin
MinVersion=6.1.7601

[Languages]
Name: "indonesian"; MessagesFile: "compiler:Languages\Indonesian.isl";

[Types]
Name: "custom"; Description: "Custom installation"; Flags: iscustom

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone

[Files]
Source: "Prerequisites\NDP461-KB3102436-x86-x64-AllOS-ENU.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall; Check: FrameworkIsNotInstalled; AfterInstall: InstallFramework
Source: "Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Permissions: everyone-full
Source: "Fonts\*"; DestDir: "{commonfonts}"; Flags: ignoreversion recursesubdirs createallsubdirs onlyifdoesntexist skipifsourcedoesntexist
Source: "uninstall.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; AfterInstall: SetElevationBit('{group}\{#MyAppName}.lnk')
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"; IconFilename: "{app}\uninstall.ico"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon; AfterInstall: SetElevationBit('{commondesktop}\{#MyAppName}.lnk')

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Dirs]
Name: "{app}"; Permissions: everyone-full
Name: "{app}\Report"; Permissions: everyone-full
Name: "{app}\System"; Permissions: everyone-full
Name: "{app}\System\Layouts"; Permissions: everyone-full

[Code]
var CancelWithoutPrompt: boolean;

procedure CancelButtonClick(CurPageID: Integer; var Cancel, Confirm: Boolean);
begin
  if CurPageID=wpInstalling then
    Confirm := not CancelWithoutPrompt;
end;

function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1'          .NET Framework 1.1
//    'v2.0'          .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//    'v4.5.1'        .NET Framework 4.5.1
//    'v4.5.2'        .NET Framework 4.5.2
//    'v4.6'          .NET Framework 4.6
//    'v4.6.1'        .NET Framework 4.6.1
//    'v4.6.2'        .NET Framework 4.6.2
//    'v4.7'          .NET Framework 4.7
//    'v4.7.1'        .NET Framework 4.7.1
//    'v4.7.2'        .NET Framework 4.7.2
//    'v4.8'          .NET Framework 4.8
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key, versionKey: string;
    install, release, serviceCount, versionRelease: cardinal;
    success: boolean;
begin
    versionKey := version;
    versionRelease := 0;

    // .NET 1.1 and 2.0 embed release number in version key
    if version = 'v1.1' then begin
        versionKey := 'v1.1.4322';
    end else if version = 'v2.0' then begin
        versionKey := 'v2.0.50727';
    end

    // .NET 4.5 and newer install as update to .NET 4.0 Full
    else if Pos('v4.', version) = 1 then begin
        versionKey := 'v4\Full';
        case version of
          'v4.5':   versionRelease := 378389;
          'v4.5.1': versionRelease := 378675; // 378758 on Windows 8 and older
          'v4.5.2': versionRelease := 379893;
          'v4.6':   versionRelease := 393295; // 393297 on Windows 8.1 and older
          'v4.6.1': versionRelease := 394254; // 394271 before Win10 November Update
          'v4.6.2': versionRelease := 394802; // 394806 before Win10 Anniversary Update
          'v4.7':   versionRelease := 460798; // 460805 before Win10 Creators Update
          'v4.7.1': versionRelease := 461308; // 461310 before Win10 Fall Creators Update
          'v4.7.2': versionRelease := 461808; // 461814 before Win10 April 2018 Update
          'v4.8':   versionRelease := 528040; // 528049 before Win10 May 2019 Update
        end;
    end;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + versionKey;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0 and newer use value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 and newer use additional value Release
    if versionRelease > 0 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= versionRelease);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;

function FrameworkIsNotInstalled: Boolean;
begin
  Result := not IsDotNetDetected('v4.5', 0);
end;

procedure InstallFramework;
var
  StatusText: string;
  ResultCode: Integer;
begin
  StatusText := WizardForm.StatusLabel.Caption;
  WizardForm.StatusLabel.Caption := 'Installing .NET framework 4.6.1...';
  WizardForm.ProgressGauge.Style := npbstMarquee;
  try
      if not Exec(ExpandConstant('{tmp}\NDP461-KB3102436-x86-x64-AllOS-ENU.exe'), '/q /norestart', '', SW_SHOW, ewWaitUntilTerminated, ResultCode) then
      begin
        // you can interact with the user that the installation failed
        MsgBox('.NET installation failed with code: ' + IntToStr(ResultCode) + '.',
               mbError, MB_OK);
        CancelWithoutPrompt := true;
        WizardForm.Close;       
      end;
  finally
    WizardForm.StatusLabel.Caption := StatusText;
    WizardForm.ProgressGauge.Style := npbstNormal;
  end;
end;

procedure SetElevationBit(Filename: string);
var
  Buffer: string;
  Stream: TStream;
begin
  Filename := ExpandConstant(Filename);
  Log('Setting elevation bit for ' + Filename);

  Stream := TFileStream.Create(FileName, fmOpenReadWrite);
  try
    Stream.Seek(21, soFromBeginning);
    SetLength(Buffer, 1);
    Stream.ReadBuffer(Buffer, 1);
    Buffer[1] := Chr(Ord(Buffer[1]) or $20);
    Stream.Seek(-1, soFromCurrent);
    Stream.WriteBuffer(Buffer, 1);
  finally
    Stream.Free;
  end;
end;

function InitializeSetup(): Boolean;
var
  ResultCode: Integer;
  ResultStr:string;
begin
  // Check if the application is already install
  // MsgBox('MyAppId = ' + '{#MyAppId}', mbInformation, mb_Ok);
  begin
    If RegQueryStringValue(HKLM, 'SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{#MyAppId}_is1', 'UninstallString', ResultStr) then begin
      If ResultStr<>'' then begin
        ResultStr:=RemoveQuotes(ResultStr);
          if MsgBox('Aplikasi telah diinstall. Jika diteruskan data akan kembali ke Reset sesuai setelah Installasi.' #13#13 'Apakah akan melakukan Uninstall program sebelumnya?', mbConfirmation, MB_YESNO) = idYes then begin
            if not Exec(ResultStr, '/silent', '', SW_SHOW, ewWaitUntilTerminated, ResultCode) then begin
              MsgBox('Error !!! ' #13#13 '' + SysErrorMessage(ResultCode) + '.', mbError, MB_OK);
              Abort();
              end
            end
          else
            Abort();
      end;
    end;
  end;
  Result := True;
end;
