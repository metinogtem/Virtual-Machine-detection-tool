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
    
    public async Task<bool> isVMware(){
    
        string[] KNOWN_PROCESSES = { "vmtoolsd.exe", "vmwaretrat.exe", "vmwareuser.exe", "vmacthlp.exe"};
        List<string>? runningProcesses = await Utils.RunPowershellCommand("tasklist");

        foreach (string process in KNOWN_PROCESSES){
               if (runningProcesses.Contains(process))
                     return true;
            }
            return false;
            
        }

    
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
    }
}
