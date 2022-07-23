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
    
        string[] KNOWN_SERVICES = { "VMTools", "Vmhgfs", "vm3dservice", "Vmmouse", "Vmrawdsk", "Vmusbmouse", "Vmvss", "Vmscsi", "Vmxnet", "vmx_svga", "Vmware Tools", "Vmware Physical Disk Helper Service" };
        List<string>? serviceOutput = await Utils.RunPowershellCommand("get-service", null, "Name");
        
            if (serviceOutput != null){
                
                foreach(string service in KNOWN_SERVICES){
                    
                    foreach (string s in serviceOutput){
                        
                        if (string.Compare(s.ToLower(), service.ToLower()) == 0)
                            return true;
                    }
                }
          return false;
        }

    
    public static void Main(string[] args)
    {
        
        isVMware();
    }
}
