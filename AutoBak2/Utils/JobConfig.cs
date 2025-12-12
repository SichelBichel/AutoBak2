using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutoBak2.Utils
{
    public class JobConfig
    {
        public enum ArchiveFormat
        {
            None,
            Zip,
            Rar,
            SevenZip,
            Gzip
        }

        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement("Description")]
        public string JobDescription { get; set; } = string.Empty;

        // --- Archivierungs-Einstellungen ---

        [XmlElement("ArchiveEnabled")]
        public bool ArchiveEnabled { get; set; } = false;

        [XmlElement("Format")]
        public ArchiveFormat ArchiveType { get; set; } = ArchiveFormat.None;

        // --- Ziel-Einstellungen ---

        [XmlElement("TargetPath")]
        public string TargetPath { get; set; } = string.Empty;

        [XmlElement("CreateSubdirectory")]
        public bool CreateSubdirectory { get; set; } = false;

        [XmlElement("UseSourcedirectoryName")]
        public bool UseSourcedirectoryName {  get; set; }

        [XmlElement("SubdirectoryName")]
        public string SubdirectoryName { get; set; } = string.Empty;

        // --- Quell-Einstellungen ---

        [XmlElement("SourcePath")]
        public string SourcePath { get; set; } = string.Empty;

        // --- Exklusions-Einstellungen ---

        [XmlArray("Exclusions")]
        [XmlArrayItem("Exclusion")]
        public List<string> ExcludedItems { get; set; } = new List<string>();
    }
}
