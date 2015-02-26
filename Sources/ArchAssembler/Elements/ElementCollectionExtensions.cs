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


namespace ArchAssembler.Elements
{
    public static class ElementCollectionExtensions
    {
        private static T Add<T>(ElementCollection collection, T value) where T : Element
        {
            collection.Elements.Add(value);
            return value;
        }

        // ********************************************************************
        // * Misc

        /// <summary>
        /// Create a nested collection on elements
        /// </summary>
        public static ElementCollection ElementCollection(this ElementCollection collection)
        {
            return Add(collection, new ElementCollection());
        }

        /// <summary>
        /// Put a mark in the collection of elements
        /// </summary>
        public static MarkerElement Marker(this ElementCollection collection)
        {
            return Add(collection, new MarkerElement());
        }

        /// <summary>
        /// Align the next element on a boundary
        /// </summary>
        /// <param name="alignment">Desired alignement</param>
        /// <param name="padding">Value used to fill the void</param>
        public static AlignmentElement Alignment(this ElementCollection collection, uint alignment, byte padding)
        {
            return Add(collection, new AlignmentElement(alignment, alignment, padding));
        }

        /// <summary>
        /// Align the next element on a boundary
        /// </summary>
        /// <param name="fileAlignment">Desired file alignment</param>
        /// <param name="memoryAlignment">Desired memory alignement</param>
        /// <param name="padding">Value used to fill the void</param>
        public static AlignmentElement Alignment(this ElementCollection collection, uint fileAlignment,
                                                 uint memoryAlignment, byte padding)
        {
            return Add(collection, new AlignmentElement(fileAlignment, memoryAlignment, padding));
        }

        // ********************************************************************
        // * File address and size

        /// <summary>
        /// File address of an element as a 16 bits unsigned integer
        /// </summary>
        public static FileAddress16Element FileAddress16(this ElementCollection collection, Element target)
        {
            return Add(collection, new FileAddress16Element(target));
        }

        /// <summary>
        /// File address of an element as a 32 bits unsigned integer
        /// </summary>
        public static FileAddress32Element FileAddress32(this ElementCollection collection, Element target)
        {
            return Add(collection, new FileAddress32Element(target));
        }

        /// <summary>
        /// File size of an element as a 16 bits unsigned integer
        /// </summary>
        public static FileSize16Element FileSize16(this ElementCollection collection, Element target)
        {
            return Add(collection, new FileSize16Element(target));
        }

        /// <summary>
        /// File size of an element as a 32 bits unsigned integer
        /// </summary>
        public static FileSize32Element FileSize32(this ElementCollection collection, Element target)
        {
            return Add(collection, new FileSize32Element(target));
        }

        // ********************************************************************
        // * Memory address and size

        /// <summary>
        /// Memory address of an element relative to the base memory address as a 32 bits unsigned integer
        /// </summary>
        public static RelativeMemoryAddress32Element RelativeMemoryAddress32(this ElementCollection collection,
                                                                             Element target)
        {
            return Add(collection, new RelativeMemoryAddress32Element(target));
        }

        /// <summary>
        /// Memory address of an element relative to the base memory address as a 32 bits or 64 bits unsigned integer depending on assembling context
        /// </summary>
        public static RelativeMemoryAddressPElement RelativeMemoryAddressP(this ElementCollection collection,
                                                                           Element target)
        {
            return Add(collection, new RelativeMemoryAddressPElement(target));
        }

        /// <summary>
        /// Absolute memory address of an element as a 32 bits unsigned integer
        /// </summary>
        public static AbsoluteMemoryAddress32Element AbsoluteMemoryAddress32(this ElementCollection collection,
                                                                             Element target)
        {
            return Add(collection, new AbsoluteMemoryAddress32Element(target));
        }

        /// <summary>
        /// Absolute memory address of an element as a 32 bits or 64 bits unsigned integer depending on assembling context
        /// </summary>
        public static AbsoluteMemoryAddressPElement AbsoluteMemoryAddressP(this ElementCollection collection,
                                                                           Element target)
        {
            return Add(collection, new AbsoluteMemoryAddressPElement(target));
        }

        /// <summary>
        /// Size in memory of an element as a 16 bits unsigned integer
        /// </summary>
        public static MemorySize16Element MemorySize16(this ElementCollection collection, Element target)
        {
            return Add(collection, new MemorySize16Element(target));
        }

        /// <summary>
        /// Size in memory of an element as a 32 bits unsigned integer
        /// </summary>
        public static MemorySize32Element MemorySize32(this ElementCollection collection, Element target)
        {
            return Add(collection, new MemorySize32Element(target));
        }

        // ********************************************************************
        // * UInt

        /// <summary>
        /// Immediate 8 bits unsigned integer
        /// </summary>
        public static UInt8Element UInt8(this ElementCollection collection, byte value)
        {
            return Add(collection, new UInt8Element(value));
        }

        /// <summary>
        /// Immediate 16 bits unsigned integer
        /// </summary>
        public static UInt16Element UInt16(this ElementCollection collection, UInt16 value)
        {
            return Add(collection, new UInt16Element(value));
        }

        /// <summary>
        /// Immediate 32 bits unsigned integer
        /// </summary>
        public static UInt32Element UInt32(this ElementCollection collection, UInt32 value)
        {
            return Add(collection, new UInt32Element(value));
        }

        /// <summary>
        /// Immediate 64 bits unsigned integer
        /// </summary>
        public static UInt64Element UInt64(this ElementCollection collection, UInt64 value)
        {
            return Add(collection, new UInt64Element(value));
        }

        /// <summary>
        /// Immediate 32 bits or 64 bits unsigned integer depending on assembling context
        /// </summary>
        public static UIntPElement UIntP(this ElementCollection collection, UInt64 value)
        {
            return Add(collection, new UIntPElement(value));
        }

        // ********************************************************************
        // * Character strings

        /// <summary>
        /// A string of ASCII characters with a fixed size. If value is longer than length, value is chopped. If it is
        /// shorter, value is padded with null characters
        /// </summary>
        public static FixedSizeStringElement FixedSizeString(this ElementCollection collection, string value,
                                                             uint length)
        {
            return Add(collection, new FixedSizeStringElement(value, length));
        }

        /// <summary>
        /// A null terminated string of ASCII characters
        /// </summary>
        public static VariableSizeStringElement VariableSizeString(this ElementCollection collection, string value)
        {
            return Add(collection, new VariableSizeStringElement(value));
        }

        // ********************************************************************
        // * Byte array

        /// <summary>
        /// Bulk data as an array of bytes
        /// </summary>
        public static ByteArrayElement ByteArray(this ElementCollection collection, byte[] value)
        {
            return Add(collection, new ByteArrayElement(value));
        }
    }
}