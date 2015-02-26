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
using ArchAssembler.Elements;

namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// Hold informations and content of a section
    /// </summary>
    public sealed class ImageSection : ElementCollection
    {
        private readonly String m_name;
        private readonly ImageSectionType m_type;

        /// <summary>
        /// Create a new section
        /// </summary>
        /// <param name="name">Name of the section</param>
        /// <param name="type">Type of the section</param>
        public ImageSection(String name, ImageSectionType type)
        {
            m_name = name;
            m_type = type;
        }

        /// <summary>
        /// Name of the section
        /// </summary>
        public String Name
        {
            get { return m_name; }
        }

        /// <summary>
        /// Type of the section
        /// </summary>
        public ImageSectionType Type
        {
            get { return m_type; }
        }
    }
}