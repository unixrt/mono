//
// AssemblyInfo.cs
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
[assembly: AssemblyTitle ("System.Worklflow.ComponentModel.dll")]
[assembly: AssemblyDescription ("System.Workflow.ComponentModel.dll")]
[assembly: AssemblyDefaultAlias ("System.Workflow.ComponentModel.dll")]

[assembly: AssemblyCompany (Consts.MonoCompany)]
[assembly: AssemblyProduct (Consts.MonoProduct)]
[assembly: AssemblyCopyright (Consts.MonoCopyright)]

#if MOBILE
[assembly: AssemblyVersion ("4.0.0.0")]
[assembly: SatelliteContractVersion ("4.0.0.0")]
[assembly: AssemblyInformationalVersion ("4.0.50524.0")]
[assembly: AssemblyFileVersion ("4.0.50524.0")]
#else
[assembly: AssemblyVersion (Consts.FxVersion)]
[assembly: SatelliteContractVersion (Consts.FxVersion)]
[assembly: AssemblyInformationalVersion (Consts.FxFileVersion)]
[assembly: AssemblyFileVersion (Consts.FxFileVersion)]
#endif

[assembly: NeutralResourcesLanguage ("en-US")]
[assembly: CLSCompliant (true)]
[assembly: AssemblyDelaySign (true)]
#if NET_2_1
[assembly: AssemblyKeyFile ("../winfx.pub")]
#else
[assembly: AssemblyKeyFile ("../ecma.pub")]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ComCompatibleVersion (1, 0, 3300, 0)]
[assembly: SecurityCritical (SecurityCriticalScope.Explicit)]
#endif
[assembly: InternalsVisibleTo ("System.Runtime.Serialization, PublicKey=" + AssemblyRef.FrameworkPublicKeyFull2)]
[assembly: InternalsVisibleTo ("System.Workflow.Runtime, PublicKey=" + AssemblyRef.FrameworkPublicKeyFull2)]
[assembly: ComVisible (false)]

