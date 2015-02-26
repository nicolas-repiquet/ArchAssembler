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


namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// PE image directories
    /// </summary>
    public sealed class ImageDirectory
    {
        public static readonly ImageDirectory Export = new ImageDirectory(0, "Export");
        public static readonly ImageDirectory Import = new ImageDirectory(1, "Import");
        public static readonly ImageDirectory Resource = new ImageDirectory(2, "Resource");
        public static readonly ImageDirectory Exception = new ImageDirectory(3, "Exception");
        public static readonly ImageDirectory Certificate = new ImageDirectory(4, "Certificate");
        public static readonly ImageDirectory Base = new ImageDirectory(5, "Base");
        public static readonly ImageDirectory Debug = new ImageDirectory(6, "Debug");
        public static readonly ImageDirectory Architecture = new ImageDirectory(7, "Architecture");
        public static readonly ImageDirectory GlobalPointer = new ImageDirectory(8, "GlobalPointer");
        public static readonly ImageDirectory ThreadStorage = new ImageDirectory(9, "ThreadStorage");
        public static readonly ImageDirectory LoadConfiguration = new ImageDirectory(10, "LoadConfiguration");
        public static readonly ImageDirectory BoundImport = new ImageDirectory(11, "BoundImport");
        public static readonly ImageDirectory ImportAddressTable = new ImageDirectory(12, "ImportAddressTable");
        public static readonly ImageDirectory DelayImport = new ImageDirectory(13, "DelayImport");
        public static readonly ImageDirectory ComDescriptor = new ImageDirectory(14, "ComDescriptor");
        public static readonly ImageDirectory Reserved = new ImageDirectory(15, "Reserved");
        private readonly int m_index;
        private readonly string m_name;

        private ImageDirectory(int index, string name)
        {
            m_index = index;
            m_name = name;
        }

        internal int Index
        {
            get { return m_index; }
        }

        /// <summary>
        /// Directory name
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        public override string ToString()
        {
            return m_name;
        }

        // ********************************************************************
    }
}