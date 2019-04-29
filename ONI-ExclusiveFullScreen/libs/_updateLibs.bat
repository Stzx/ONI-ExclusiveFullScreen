@echo off

set PATH=%ONI_PATH%\OxygenNotIncluded_Data\Managed

xcopy "%PATH%\UnityEngine*.dll" %~dp0 /Y
xcopy "%PATH%\Assembly-CSharp*.dll" %~dp0 /Y
xcopy "%PATH%\0Harmony.dll" %~dp0 /Y
