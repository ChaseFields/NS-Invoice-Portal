using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalObjects
{
    public class Invoice
    {
        private string date;

        public Invoice()
        {
            // date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            date = DateTime.Now.ToString("MM-dd-yyyy");
        }

        public int AccountNumber { get; set; }
        public bool Liquid { get; set; }
        public bool Granular { get; set; }
        public bool Blanket { get; set; }
        public bool Spot { get; set; }
        public int SpotPercentage { get; set; }
        public bool Frick34 { get; set; }
        public bool Frick15 { get; set; }
        public bool Granico34 { get; set; }
        public bool Naturescape363 { get; set; }
        public bool CavalcadeWFert { get; set; }
        public bool Cavalcade4L { get; set; }
        public bool Prodiamine { get; set; }
        public bool Triad { get; set; }
        public string PropertyComments { get; set; }
        public string ServiceComments { get; set; }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int InvoiceNumber { get; set; }

    }
}
