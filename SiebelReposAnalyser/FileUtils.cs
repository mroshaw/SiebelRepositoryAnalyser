#region

using System;
using System.IO;
using BrightIdeasSoftware;

#endregion

namespace SiebelReposAnalyser
{
    internal static class FileUtils
    {
        public static void ExportFOlvToCsv(FastObjectListView olv, String fileName)
        {
            OLVExporter exporter = new OLVExporter(olv);
            String csv = exporter.ExportTo(OLVExporter.ExportFormat.CSV);
            File.WriteAllText(fileName, csv);
        }

        public static void ExportOlvToCsv(ObjectListView olv, String fileName)
        {
            OLVExporter exporter = new OLVExporter(olv);
            String csv = exporter.ExportTo(OLVExporter.ExportFormat.CSV);
            File.WriteAllText(fileName, csv);
        }

        public static void ExportFOlvToHtml(FastObjectListView olv, String fileName)
        {
            OLVExporter exporter = new OLVExporter(olv);
            String html = exporter.ExportTo(OLVExporter.ExportFormat.HTML);
            File.WriteAllText(fileName, html);
        }

        public static void ExportOlvToHtml(ObjectListView olv, String fileName)
        {
            OLVExporter exporter = new OLVExporter(olv);
            String html = exporter.ExportTo(OLVExporter.ExportFormat.HTML);
            File.WriteAllText(fileName, html);
        }
    }
}