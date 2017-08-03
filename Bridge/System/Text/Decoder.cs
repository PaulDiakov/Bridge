﻿using Bridge;

namespace System.Text
{
    public abstract class Decoder
    {        
        public abstract int GetCharCount(byte[] bytes, int index, int count);

        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount,
                                     char[] chars, int charIndex);

        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
        {
            throw new NotImplementedException();
        }

        public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
        {
            throw new NotImplementedException();
        }

        public virtual int GetChars(
            byte[] bytes, int byteIndex, int byteCount,
            char[] chars, int charIndex, bool flush)
        {
            throw new NotImplementedException();
        }

        public unsafe virtual int GetChars(byte* bytes, int byteCount,
            char* chars, int charCount, bool flush)
        {
            throw new NotImplementedException();
        }

        public virtual void Reset()
        {
            throw new NotImplementedException();
        }

        public unsafe virtual void Convert(
            byte* bytes, int byteCount,
            char* chars, int charCount, bool flush,
            out int bytesUsed, out int charsUsed, out bool completed)
        {
            throw new NotImplementedException();
        }

        public virtual void Convert(
            byte[] bytes, int byteIndex, int byteCount,
            char[] chars, int charIndex, int charCount, bool flush,
            out int bytesUsed, out int charsUsed, out bool completed)
        {
            throw new NotImplementedException();
        }
    };

};