import os

def isVMwareInstalled():
    
    if os.path.isdir('C:\Program Files (x86)\VMware\') or os.path.isdir('C:\Program Files\VMware\'):
        return True
    return False
