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
    /// List the functions imported by an image
    /// </summary>
    public sealed class ImportTableElement : CompositeElement
    {
        private readonly Dictionary<string, ImportLibrary> m_libraries;

        public ImportTableElement()
        {
            m_libraries = new Dictionary<string, ImportLibrary>();
        }

        /// <summary>
        /// Import a function
        /// </summary>
        /// <param name="library">Name of the library in which the function belong</param>
        /// <param name="function">Public name of the function</param>
        /// <returns>Function slot</returns>
        public Element Import(string library, string function)
        {
            return Import(library, function, 0);
        }

        /// <summary>
        /// Import a function
        /// </summary>
        /// <param name="library">Name of the library in which the function belong</param>
        /// <param name="function">Plublic name of the function</param>
        /// <param name="hint">Function hint</param>
        /// <returns>Function thunk</returns>
        public Element Import(string library, string function, UInt16 hint)
        {
            return GetLibrary(library).GetFunction(function, hint).ThunkMarker;
        }

        private ImportLibrary GetLibrary(string name)
        {
            ImportLibrary library;

            if (!m_libraries.TryGetValue(name, out library))
            {
                library = new ImportLibrary(name);
                m_libraries.Add(name, library);
            }

            return library;
        }

        internal override IEnumerable<Element> GetElements()
        {
            ElementCollection content = new ElementCollection();

            foreach (ImportLibrary library in m_libraries.Values)
            {
                content.RelativeMemoryAddress32(library.OriginalFirstThunkMarker); // OriginalFirstThunk
                content.UInt32(0); // TimeDateStamp
                content.UInt32(0); // ForwarderChain
                content.RelativeMemoryAddress32(library.NameElement); // Name
                content.RelativeMemoryAddress32(library.FirstThunkMarker); // FirstThunk
            }

            content.UInt32(0); // OriginalFirstThunk
            content.UInt32(0); // TimeDateStamp
            content.UInt32(0); // ForwarderChain
            content.UInt32(0); // Name
            content.UInt32(0); // FirstThunk

            foreach (ImportLibrary library in m_libraries.Values)
            {
                // Original thunks array
                content.Elements.Add(library.OriginalFirstThunkMarker);
                foreach (ImportFunction function in library.Functions)
                {
                    content.Elements.Add(function.OriginalThunkMarker);
                    content.RelativeMemoryAddressP(function.ImportByNameMarker);
                }
                content.UInt32(0); // End

                // Thunks array
                content.Elements.Add(library.FirstThunkMarker);
                foreach (ImportFunction function in library.Functions)
                {
                    content.Elements.Add(function.ThunkMarker);
                    content.RelativeMemoryAddressP(function.ImportByNameMarker);
                }
                content.UInt32(0); // End

                // Imports by name
                foreach (ImportFunction function in library.Functions)
                {
                    content.Elements.Add(function.ImportByNameMarker);
                    content.UInt16(function.Hint); // Hint
                    content.Elements.Add(function.NameElement);
                    content.Alignment(2, 0);
                }

                // Library name
                content.Elements.Add(library.NameElement);
            }

            return content.Elements;
        }

        #region Nested type: ImportFunction

        private sealed class ImportFunction
        {
            private readonly UInt16 m_hint;
            private readonly MarkerElement m_importByNameMarker;
            private readonly VariableSizeStringElement m_nameElement;
            private readonly MarkerElement m_originalThunkMarker;
            private readonly MarkerElement m_thunkMarker;

            public ImportFunction(string name, UInt16 hint)
            {
                m_hint = hint;
                m_nameElement = new VariableSizeStringElement(name);
                m_importByNameMarker = new MarkerElement();
                m_originalThunkMarker = new MarkerElement();
                m_thunkMarker = new MarkerElement();
            }

            public UInt16 Hint
            {
                get { return m_hint; }
            }

            public VariableSizeStringElement NameElement
            {
                get { return m_nameElement; }
            }

            public MarkerElement ImportByNameMarker
            {
                get { return m_importByNameMarker; }
            }

            public MarkerElement OriginalThunkMarker
            {
                get { return m_originalThunkMarker; }
            }

            public MarkerElement ThunkMarker
            {
                get { return m_thunkMarker; }
            }
        }

        #endregion

        #region Nested type: ImportLibrary

        private sealed class ImportLibrary
        {
            private readonly MarkerElement m_firstThunkMarker;
            private readonly Dictionary<string, ImportFunction> m_functions;
            private readonly VariableSizeStringElement m_nameElement;
            private readonly MarkerElement m_originalFirstThunkMarker;

            public ImportLibrary(string name)
            {
                m_nameElement = new VariableSizeStringElement(name);
                m_functions = new Dictionary<string, ImportFunction>();
                m_originalFirstThunkMarker = new MarkerElement();
                m_firstThunkMarker = new MarkerElement();
            }

            public VariableSizeStringElement NameElement
            {
                get { return m_nameElement; }
            }

            public IEnumerable<ImportFunction> Functions
            {
                get { return m_functions.Values; }
            }

            public MarkerElement OriginalFirstThunkMarker
            {
                get { return m_originalFirstThunkMarker; }
            }

            public MarkerElement FirstThunkMarker
            {
                get { return m_firstThunkMarker; }
            }

            public ImportFunction GetFunction(string name, UInt16 hint)
            {
                ImportFunction function;

                if (!m_functions.TryGetValue(name, out function))
                {
                    function = new ImportFunction(name, hint);
                    m_functions.Add(name, function);
                }

                return function;
            }
        }

        #endregion
    }
}