// ****************************************************************************
// * Copyright (c) 2011 Nicolas Repiquet
// *
// * Permission is hereby granted, free of charge, to any person obtaining a
// * copy of this software and associated documentation files (the "Software"),
// * to deal in the Software without restriction, including without limitation
// * the rights to use, copy, modify, merge, publish, distribute, sublicense,
// * and/or sell copies of the Software, and to permit persons to whom the
// * Software is furnished to do so, subject to the following conditions:
// *
// * The above copyright notice and this permission notice shall be included in
// * all copies or substantial portions of the Software.
// *
// * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// * DEALINGS IN THE SOFTWARE.
// *
// ****************************************************************************

using System;
using System.IO;

namespace ArchAssembler.Elements
{
    public abstract class ConcreteElement : Element
    {
        internal ConcreteElement()
        {

        }

        internal virtual bool SizeDependsOnAddress
        {
            get { return false; }
        }

        internal virtual uint ComputeFileSize(IAssemblingContext context)
        {
            return ComputeSize(context);
        }

        internal virtual uint ComputeMemorySize(IAssemblingContext context)
        {
            return ComputeSize(context);
        }

        internal virtual uint ComputeSize(IAssemblingContext context)
        {
            throw new NotImplementedException();
        }

        internal virtual void RegisterDependencies(IDependencyCollection dependencies)
        {
        }

        internal abstract void WriteTo(BinaryWriter writer, IAssemblingContext context);
    }
}