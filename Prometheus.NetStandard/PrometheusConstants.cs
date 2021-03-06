﻿using System.Text;

namespace Prometheus
{
    public static class PrometheusConstants
    {
        public const string ExporterContentType = "text/plain; version=0.0.4";

        // Use UTF-8 encoding, but provide the flag to ensure the Unicode Byte Order Mark is never
        // pre-pended to the output stream.
        public static readonly Encoding ExportEncoding = new UTF8Encoding(false);
    }
}
