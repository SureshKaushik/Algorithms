using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atalasoft;
using Atalasoft.PdfDoc.Generating;
using Atalasoft.PdfDoc.Generating.Shapes;
using Atalasoft.PdfDoc.Geometry;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfTableDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Form1()
                {
            Atalasoft.Licensing.AtalaLicense.SetAssemblyLicense(@"<?xml version='1.0' encoding='utf-8'?>
<License>
  <Assembly>Atalasoft.PdfDoc</Assembly>
  <Assembly>Atalasoft.dotImage.Dicom</Assembly>
  <Assembly>Atalasoft.dotImage</Assembly>
  <Assembly>Atalasoft.DotTwain</Assembly>
  <Assembly>Atalasoft.dotImage.Barcoding.Reading</Assembly>
  <Assembly>Atalasoft.dotImage.Dwg</Assembly>
  <Assembly>Atalasoft.dotImage.Jbig2</Assembly>
  <Assembly>Atalasoft.dotImage.Jpeg2000</Assembly>
  <Assembly>Atalasoft.dotImage.Pdfium</Assembly>
  <Version>11.2</Version>
  <Name>ATALASOFT_PKL_ReadSoft_Master_v11.2_2019-11-21</Name>
  <ServerCPUs>4</ServerCPUs>
  <PublicKey>0240048000940006200024005253413104001010bd9a8e956fb61164e784e871a46b3de286fd2dba351d899d6d871f47ede3c4c502cb7903bc0c9a049c18f8459535827a8dae6483e2a4ff46f2464d677d7984b7f58448d247f195c2e0f862c3eb494275c2ea2a7c6ff6877a6ff1b7e9acef3383b8fa9deef27dc466567d59e8cb546048ef8aee744f4acbe2a1a46456e9</PublicKey>
  <Flag name='Document' />
  <Flag name='v2Signature' />
  <Flag name='Professional' />
  <Flag name='All1Dand2D' />
  <Flag name='AdvancedDocClean' />
  <Signature>PkeL5ZXCuBDPMoc534RpM+MCTbDd0ez97i61aZPjJdnR1/coJXKpK83wZ0W81QRNg2BhWk3fbfY4Z/gT05AHYESq23U9Iy+kwXmPqwErO6aUZRmuRZhJQ5SNnX8LcZFkWK7WIg2AVsLUjwSt9Z9KoCRBfLCb5ibRMz1yck+d3z4=</Signature>
</License>");

        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            SetTablezcolumnWidth();
            //MakeSimpleTable();
        }

        private void SetTablezcolumnWidth()
        {
            string[] headers = new string[]
            { 
                "Order Id", "Customer Id", "Customer Name", "Product Id",
                "Product Description", "Quantity", "Product Received"
            };
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14, iTextSharp.text.Font.ITALIC);
            font.Color = BaseColor.BLUE;
            // WidthPercentage = 100, 
            var table = new PdfPTable(headers.Length) { TotalWidth=headers.Length };
            table.SetWidths(GetHeaderWidths(font, headers));

            using (var stream = new MemoryStream())
            {
                using (var document = new Document(PageSize.A4.Rotate()))
                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    for (int i = 0; i < headers.Length; ++i)
                    {
                        table.AddCell(new PdfPCell(new Phrase(headers[i], font)));
                    }
                    document.Add(table);
                }
                File.WriteAllBytes("PdtTableDemo.pdf", stream.ToArray());
            }
        }

        private float[] GetHeaderWidths(iTextSharp.text.Font font, string[] headers)
        {
            var total = 0;
            var columns = headers.Length;
            var widths = new int[columns];
            for (var i = 0; i < columns; ++i)
            {
                var w =font.GetCalculatedBaseFont(true).GetWidth(headers[i]);
                total += w;
                widths[i] = w;
            }
            var result = new float[columns];
            float totPercentage = 0;
            for (var i = 0; i < columns; ++i)
            {
                result[i] = (float)widths[i] / total * 100;
                totPercentage += result[i];
            }
            return result;
        }

        [Serializable]
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Color { get; set; }
        }

        public void MakeSimpleTable()
        {
            PdfGeneratedDocument doc = new PdfGeneratedDocument();
            PdfGeneratedPage page = doc.AddPage(PdfDefaultPages.Letter);
            PdfTable table = new PdfTable(new PdfBounds(72, 300, 400, 400), "Arial", 12);
            table.HeaderFontName = "Arial Bold Italic";
            table.BorderStyle = PdfTableBorderStyle.Grid;
            table.Columns.Add(new PdfTableColumn("Name", "Person", 120, PdfTextAlignment.Center,
            8, 8));
            table.Columns.Add(new PdfTableColumn("Age", "Age", 60, PdfTextAlignment.Center, 8,
            8));
            table.Columns.Add(new PdfTableColumn("Color", "Favorite Color", 0,
            PdfTextAlignment.Center, 8, 8));
            List<Person> people = new List<Person>() {
                 new Person() { Name = "John", Age = 15, Color = "Orange" },
                 new Person() { Name = "Emily", Age = 37, Color = "Blue" },
                 new Person() { Name = "Philippe", Age = 19, Color = "Green" },
                 new Person() { Name = "Jill", Age = 23, Color = "Ochre" }
                 };
            table.AddRows(people.GetEnumerator());
            table.Fill(doc.Resources.Fonts);
            page.DrawingList.Add(table);
            doc.Save("basictable.pdf");
        }
    }
}
