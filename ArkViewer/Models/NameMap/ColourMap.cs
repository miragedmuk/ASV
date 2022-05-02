using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    [DataContract]
    public class ColourMap
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Hex { get; set; }

        public Color Color
        {
            get
            {
                Color translatedColor = Color.White;
                try
                {
                    translatedColor = ColorTranslator.FromHtml(Hex);
                }
                finally
                {

                }

                return translatedColor;
            }

        }

    }
}
