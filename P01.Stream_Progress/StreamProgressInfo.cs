using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStream _stream;

        // If we want to stream a music file, now we can
        public StreamProgressInfo(IStream stream)
        {
            this._stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (this._stream.BytesSent * 100) / this._stream.Length;
        }
    }
}
