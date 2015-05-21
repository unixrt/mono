/******************************************************************************
* The MIT License
* Copyright (c) 2007 Novell Inc.,  www.novell.com
*
* Permission is hereby granted, free of charge, to any person obtaining  a copy
* of this software and associated documentation files (the Software), to deal
* in the Software without restriction, including  without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to  permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*******************************************************************************/

// Authors:
// 		Thomas Wiest (twiest@novell.com)
//		Rusty Howell  (rhowell@novell.com)
//
// (C)  Novell Inc.

using System;
using System.Text;
using System.Management.Internal.Batch;

namespace System.Management.Internal
{
    internal class InvokeMethodOpSettings : SingleRequest
    {
        ICimObjectName _objName;
        CimName _methodName;
        CimParameterValueList _parameterList;

        #region Constructors
        public InvokeMethodOpSettings(ICimObjectName objectName, CimName methodName, CimParameterValueList parameterList)
        {
            ReqType = RequestType.InvokeMethod;

            ObjectName = objectName;
            MethodName = methodName;
            ParameterList = parameterList;
        }
        #endregion

        #region Properties and Indexers
        public ICimObjectName ObjectName
        {
            get { return _objName; }
            set { _objName = value; }
        }

        public CimName MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        public CimParameterValueList ParameterList
        {
            get { return _parameterList; }
            set { _parameterList = value; }
        }
        #endregion
    }
}
