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


namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// Type of a section
    /// </summary>
    public sealed class ImageSectionType
    {
        // ********************************************************************

        /// <summary>
        /// Section containing executable code
        /// </summary>
        public static readonly ImageSectionType Code =
            new ImageSectionType("Code", true, canExecute: true);

        /// <summary>
        /// Section containing read-only data
        /// </summary>
        public static readonly ImageSectionType ReadonlyData =
            new ImageSectionType("ReadonlyData", containsInitializedData: true, canRead: true);

        /// <summary>
        /// Section containing initialized data
        /// </summary>
        public static readonly ImageSectionType InitializedData =
            new ImageSectionType("InitializedData", containsInitializedData: true, canRead: true, canWrite: true);

        /// <summary>
        /// Section containing uninitialized data
        /// </summary>
        public static readonly ImageSectionType UninitializedData =
            new ImageSectionType("UninitializedData", containsUninitializedData: true, canRead: true, canWrite: true);

        private readonly bool m_canExecute;
        private readonly bool m_canRead;
        private readonly bool m_canWrite;
        private readonly bool m_containsCode;
        private readonly bool m_containsInitializedData;
        private readonly bool m_containsUninitializedData;
        private readonly string m_name;

        private ImageSectionType(string name,
                                 bool containsCode = false,
                                 bool containsInitializedData = false,
                                 bool containsUninitializedData = false,
                                 bool canExecute = false,
                                 bool canRead = false,
                                 bool canWrite = false)
        {
            m_name = name;

            m_containsCode = containsCode;
            m_containsInitializedData = containsInitializedData;
            m_containsUninitializedData = containsUninitializedData;

            m_canExecute = canExecute;
            m_canRead = canRead;
            m_canWrite = canWrite;
        }

        /// <summary>
        /// Name of this type of section
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        internal bool ContainsCode
        {
            get { return m_containsCode; }
        }

        internal bool ContainsInitializedData
        {
            get { return m_containsInitializedData; }
        }

        internal bool ContainsUninitializedData
        {
            get { return m_containsUninitializedData; }
        }

        internal bool CanExecute
        {
            get { return m_canExecute; }
        }

        internal bool CanRead
        {
            get { return m_canRead; }
        }

        internal bool CanWrite
        {
            get { return m_canWrite; }
        }

        internal UInt32 Characteristics
        {
            get
            {
                UInt32 characteristics = 0;

                if (CanExecute)
                {
                    characteristics |= 0x20000000;
                }
                if (CanRead)
                {
                    characteristics |= 0x40000000;
                }
                if (CanWrite)
                {
                    characteristics |= 0x80000000;
                }

                if (ContainsCode)
                {
                    characteristics |= 0x00000020;
                }
                if (ContainsInitializedData)
                {
                    characteristics |= 0x00000040;
                }
                if (ContainsUninitializedData)
                {
                    characteristics |= 0x00000080;
                }

                return characteristics;
            }
        }

        public override string ToString()
        {
            return m_name;
        }

        // ********************************************************************

        // ********************************************************************
    }
}