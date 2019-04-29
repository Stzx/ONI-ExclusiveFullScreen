@ECHO OFF

SET DLL_PATH=\OxygenNotIncluded_Data\Managed

SET PATH=%ONI_PATH%%DLL_PATH%

XCOPY "%PATH%\UnityEngine*.dll" .\ /Y
XCOPY "%PATH%\Assembly-CSharp*.dll" .\ /Y
XCOPY "%PATH%\0Harmony.dll" .\ /Y
