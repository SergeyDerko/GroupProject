    REM @ECHO OFF

    cd..

    SET projectDirectory=%CD%

    cd /d “%WinDir%\Microsoft.NET\Framework\v4.0.*”

    SET net4Path=%CD%

    net stop Service_12

    %net4Path%\installutil /u “%PROJECTDIRECTORY%\bin\Debug\Service_12.exe”

    pause