// cs0647.cs : Security custom attribute 'DebugPermission' attached to invalid parent
// Line : 11

using System;
using System.Security;
using System.Security.Permissions;

public class Program {

        [return: DebugPermission (SecurityAction.LinkDemand)]
        public int Show (string message)
        {
                return 2;
        }    
}

[AttributeUsage (AttributeTargets.All, AllowMultiple = true, Inherited = false)]
[Serializable]
public class DebugPermissionAttribute : CodeAccessSecurityAttribute {

	public DebugPermissionAttribute (SecurityAction action)
		: base (action)
	{
	}
        
	public override IPermission CreatePermission ()
	{
		return null;
	}
}
