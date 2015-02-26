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
using System.Collections.Generic;
using ArchAssembler.Elements;

namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// List the functions exported by an image
    /// </summary>
    public sealed class ExportTableElement : CompositeElement
    {
        // ********************************************************************

        private readonly Dictionary<string, ExportFunction> m_functions;
        private readonly string m_moduleName;
        private readonly VariableSizeStringElement m_moduleNameElement;

        public ExportTableElement(string moduleName)
        {
            m_moduleName = moduleName;
            m_moduleNameElement = new VariableSizeStringElement(m_moduleName);
            m_functions = new Dictionary<string, ExportFunction>();
        }

        /// <summary>
        /// Export a function
        /// </summary>
        /// <param name="function">Function to export</param>
        /// <param name="name">Public name of the exported function</param>
        public void Export(Element function, string name)
        {
            if (!m_functions.ContainsKey(name))
            {
                m_functions.Add(name, new ExportFunction(function, name));
            }
        }


        internal override IEnumerable<Element> GetElements()
        {
            // ****************************************************************

            List<ExportFunction> functions = new List<ExportFunction>(m_functions.Values);
            functions.Sort();

            ElementCollection content = new ElementCollection();
            ElementCollection header = content.ElementCollection();
            ElementCollection functionAddresses = content.ElementCollection();
            ElementCollection functionNames = content.ElementCollection();
            ElementCollection functionOrdinals = content.ElementCollection();
            ElementCollection names = content.ElementCollection();

            header.UInt32(0); // Export flags
            header.UInt32(0); // date
            header.UInt16(0); // major version
            header.UInt16(0); // minor version
            header.RelativeMemoryAddress32(m_moduleNameElement); // module name
            header.UInt32(1); // ordinal base

            header.UInt32((UInt32) functions.Count); // address table entries
            header.UInt32((UInt32) functions.Count); // number of name pointers
            header.RelativeMemoryAddress32(functionAddresses); // function addresses
            header.RelativeMemoryAddress32(functionNames); // function names
            header.RelativeMemoryAddress32(functionOrdinals); // function ordinals

            // Module name
            names.Elements.Add(m_moduleNameElement);

            for (int i = 0; i < functions.Count; i++)
            {
                ExportFunction function = functions[i];

                functionAddresses.RelativeMemoryAddress32(function.Function);
                functionNames.RelativeMemoryAddress32(function.NameElement);
                functionOrdinals.UInt16((UInt16) i);

                names.Elements.Add(function.NameElement);
            }

            return content.Elements;
        }

        #region Nested type: ExportFunction

        private sealed class ExportFunction : IComparable<ExportFunction>
        {
            private readonly Element m_function;
            private readonly string m_name;
            private readonly VariableSizeStringElement m_nameElement;

            public ExportFunction(Element function, string name)
            {
                m_function = function;
                m_name = name;
                m_nameElement = new VariableSizeStringElement(name);
            }

            public Element Function
            {
                get { return m_function; }
            }

            public VariableSizeStringElement NameElement
            {
                get { return m_nameElement; }
            }

            #region IComparable<ExportFunction> Members

            public int CompareTo(ExportFunction other)
            {
                return m_name.CompareTo(other.m_name);
            }

            #endregion
        }

        #endregion
    }
}