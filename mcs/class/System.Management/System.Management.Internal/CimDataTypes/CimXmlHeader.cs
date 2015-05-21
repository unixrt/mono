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
using System.Collections.Generic;
using System.Text;

namespace System.Management.Internal
{
    /// <summary>
    /// Holds the connection data for the http client to build the request from.
    /// </summary>
    internal class CimXmlHeader
    {
        string _cimVersion = string.Empty;
        string _dtdVersion = string.Empty;
        string _messageId = string.Empty;
        string _protocolVersion = string.Empty;
        string _methodName = string.Empty;
        bool _isMultipleResponse = false;
        int _responseNumber = 0;

        #region Constructors
        /// <summary>
        /// Creates an empty CimXmlHeader
        /// </summary>
        public CimXmlHeader()        
        {
        }
        #endregion

        #region Properties and Indexers
        public string CimVersion
        {
            get { return _cimVersion; }
            set { _cimVersion = value; }
        }

        public string DtdVersion
        {
            get { return _dtdVersion; }
            set { _dtdVersion = value; }
        }

        public string MessageId
        {
            get { return _messageId; }
            set { _messageId = value; }
        }

        public string ProtocolVersion
        {
            get { return _protocolVersion; }
            set { _protocolVersion = value; }
        }

        public string MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        public bool IsMultipleResponse
        {
            get { return _isMultipleResponse; }
            set { _isMultipleResponse = value; }
        }

        public int ResponseNumber
        {
            get { return _responseNumber; }
            set { _responseNumber = value; }
        }        
        #endregion
    }
}
