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
    /// Execution subsytem
    /// </summary>
    public sealed class ImageSubsystem
    {
        // ********************************************************************

        /// <summary>
        /// Image will execute as a windows application
        /// </summary>
        public static readonly ImageSubsystem Windows = new ImageSubsystem("Windows", 2, 4, 0);

        /// <summary>
        /// Image will execute as a console application
        /// </summary>
        public static readonly ImageSubsystem Console = new ImageSubsystem("Console", 3, 4, 0);

        private readonly int m_id;
        private readonly int m_major;
        private readonly int m_minor;
        private readonly string m_name;

        private ImageSubsystem(string name, int id, int major, int minor)
        {
            m_name = name;
            m_id = id;
            m_major = major;
            m_minor = minor;
        }

        /// <summary>
        /// Name of this subsystem
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        internal int Id
        {
            get { return m_id; }
        }

        internal int Major
        {
            get { return m_major; }
        }

        internal int Minor
        {
            get { return m_minor; }
        }

        public override string ToString()
        {
            return m_name;
        }

        // ********************************************************************

        // ********************************************************************
    }
}