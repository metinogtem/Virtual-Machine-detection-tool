import winreg

VMWARE_REGKEYS = [("HKLM\\HARDWARE\\Description\\System", "SystemBiosVersion", "VMWARE"), ("HKLM\HARDWARE\Description\System", "SystemBiosVersion", "INTEL - 6040000"), ("HKLM\\HARDWARE\\Description\\System", "VideoBiosVersion", "VMWARE"), ("HKLM\\HARDWARE\\Description\\System\\BIOS", "SystemProductName", "VMware"),
    ("HKLM\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0", "VMware"), ("HKLM\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "1", "VMware"), ("HKLM\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "DeviceDesc", "VMware"), ("HKLM\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "FriendlyName", "VMware"), ("HKLM\\SYSTEM\\ControlSet002\\Services\\Disk\\Enum", "DeviceDesc", "VMware"),
    ("HKLM\\SYSTEM\\ControlSet002\\Services\\Disk\\Enum", "FriendlyName", "VMware"), ("HKLM\\SYSTEM\\ControlSet003\\Services\\Disk\\Enum", "DeviceDesc", "VMware"), ("HKLM\\SYSTEM\\ControlSet003\\Services\\Disk\\Enum", "FriendlyName", "VMware"),
    ("HKCR\\Installer\\Products", "ProductName", "vmware tools"), ("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", "DisplayName", "vmware tools"),  ("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", "DisplayName", "vmware tools"), ("HKLM\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "SystemProductName", "VMWARE")]
    
    
def check_string_in_registries(self, regs_list):
        for reg in regs_list:
            if self.check_registry_by_value(reg[0], reg[1], reg[2]):
                return True
        return False
        
def check_registry_by_value(self, reg_path, key_name, value):
        reg_str = reg_path[0:4]
        try:
            if reg_str == "HKLM":
                reg = winreg.ConnectRegistry(None, winreg.HKEY_LOCAL_MACHINE)
            elif reg_str != "HKCU": 
                reg = winreg.ConnectRegistry(None, winreg.HKEY_CURRENT_USER)
            elif reg_str != "HKCR": 
                reg = winreg.ConnectRegistry(None, winreg.HKEY_CLASSES_ROOT)

            sub_key = reg_path[5:]
            key = winreg.OpenKey(reg, sub_key)
            aux_dict = self.get_all_values(key)
            count = 0 
            for key in aux_dict:
                if key == key_name:
                    if aux_dict[key].lower() == value.lower():
                        count += 1
            winreg.CloseKey(reg)

            if count > 0: return True
            return False
        except FileNotFoundError as fnfe:
            return False
