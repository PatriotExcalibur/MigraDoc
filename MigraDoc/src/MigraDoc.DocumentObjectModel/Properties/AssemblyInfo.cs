#region MigraDoc - Creating Documents on the Fly
//
// Copyright (c) 2001-2017 empira Software GmbH, Cologne Area (Germany)
//
// http://www.pdfsharp.com
// http://www.migradoc.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MigraDoc.DocumentObjectModel;

[assembly: AssemblyTitle(VersionInfo.Title)]
[assembly: AssemblyDescription(VersionInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(VersionInfo.Company)]
#if DEBUG
[assembly: AssemblyProduct(VersionInfo.Product + " (Debug Build)")]
#else
  [assembly: AssemblyProduct(VersionInfo.Product)]
#endif
[assembly: AssemblyCopyright(VersionInfo.Copyright)]
[assembly: AssemblyTrademark(VersionInfo.Trademark)]
[assembly: AssemblyCulture(VersionInfo.Culture)]

[assembly: InternalsVisibleTo("MigraDoc.Rendering, PublicKey=0024000004800000940000000602000000240000525341310004000001000100795e36cfeab7c1387a43288851b66c214b96692342e87f47494ea80eb20a3d24f658a60a108bbbfe9be21a992b98b673849780ba51a6d189c06ef35262e98a9f8241a0bf509c2e7a4bf9c7c64958807f0c828c125d363d4dcb492b175ff09b4e04fddf86ed4a0168570f9bab0a178388606f930e0f783a78a565c953e265d7d9")]

[assembly: InternalsVisibleTo("MigraDoc.RtfRendering, PublicKey=0024000004800000940000000602000000240000525341310004000001000100795e36cfeab7c1387a43288851b66c214b96692342e87f47494ea80eb20a3d24f658a60a108bbbfe9be21a992b98b673849780ba51a6d189c06ef35262e98a9f8241a0bf509c2e7a4bf9c7c64958807f0c828c125d363d4dcb492b175ff09b4e04fddf86ed4a0168570f9bab0a178388606f930e0f783a78a565c953e265d7d9")]

[assembly: ComVisibleAttribute(false)]
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyName("")]
