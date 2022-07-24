using Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class VMwareDetect
{
    
    public bool isVMware(){
    
        string[] KNOWN_FILES = { "C:\\Windows\\System32\\Drivers\\Vmmouse.sys", "C:\\Windows\\System32\\Drivers\\vm3dgl.dll", "C:\\Windows\\System32\\Drivers\\vmdum.dll", "C:\\Windows\\System32\\Drivers\\vm3dver.dll", "C:\\Windows\\System32\\Drivers\\vmtray.dll", "C:\\Windows\\System32\\Drivers\\VMToolsHook.dll", "C:\\Windows\\System32\\Drivers\\vmmousever.dll", "C:\\Windows\\System32\\Drivers\\vmhgfs.dll", "C:\\Windows\\System32\\Drivers\\vmGuestLib.dll", "C:\\Windows\\System32\\Drivers\\VmGuestLibJava.dll", "C:\\Windows\\System32\\Driversvmhgfs.dll", "C:\\Windows\\System32\\Drivers\\VBoxMouse.sys", "C:\\Windows\\System32\\Drivers\\VBoxGuest.sys", "C:\\Windows\\System32\\Drivers\\VBoxSF.sys", "C:\\Windows\\System32\\Drivers\\VBoxVideo.sys", "C:\\Windows\\System32\\vboxdisp.dll", "C:\\Windows\\System32\\vboxhook.dll", "C:\\Windows\\System32\\vboxmrxnp.dll", "C:\\Windows\\System32\\vboxogl.dll", "C:\\Windows\\System32\\vboxoglarrayspu.dll", "C:\\Windows\\System32\\vboxoglcrutil.dll", "C:\\Windows\\System32\\vboxoglerrorspu.dll", "C:\\Windows\\System32\\vboxoglfeedbackspu.dll", "C:\\Windows\\System32\\vboxoglpackspu.dll", "C:\\Windows\\System32\\vboxoglpassthroughspu.dll", "C:\\Windows\\System32\\vboxservice.exe", "C:\\Windows\\System32\\vboxtray.exe", "C:\\Windows\\System32\\VBoxControl.exe" };
        foreach (string path in KNOWN_FILES)
            {
                if (File.Exists(path))
                    return true;
            }

            return false;
            
        }

    
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello World");
    }
}
