using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBak2.Utils

{
    public class JobProgressData
    {
        public int ProgressPercentage { get; set; } // Gesamter Fortschritt 0-100
        public string CurrentFile { get; set; } // Aktuell bearbeitete Datei/Ordner
        public bool IsComplete { get; set; } // Flag, ob der Job fertig ist
    }
}