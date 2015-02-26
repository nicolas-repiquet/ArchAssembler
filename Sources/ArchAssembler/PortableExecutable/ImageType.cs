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
    /// Type of an image
    /// </summary>
    public sealed class ImageType
    {
        // ********************************************************************

        /// <summary>
        /// Executable image (.exe)
        /// </summary>
        public static readonly ImageType Executable = new ImageType("Executable", 0x400000);

        /// <summary>
        /// Library image (.dll)
        /// </summary>
        public static readonly ImageType Library = new ImageType("Library", 0x10000000);

        private readonly ulong m_defaultImageBase;
        private readonly string m_name;

        private ImageType(string name, uint defaultImageBase)
        {
            m_name = name;
            m_defaultImageBase = defaultImageBase;
        }

        /// <summary>
        /// Name of this image type
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        /// <summary>
        /// Default image base of this image type
        /// </summary>
        public ulong DefaultImageBase
        {
            get { return m_defaultImageBase; }
        }

        public override string ToString()
        {
            return m_name;
        }

        // ********************************************************************

        // ********************************************************************
    }
}