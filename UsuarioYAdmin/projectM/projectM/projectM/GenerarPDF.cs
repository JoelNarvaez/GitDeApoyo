using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace projectM
{
    internal class GenerarPDF
    {
        public void CrearPDF(string nombreArchivo, string metodoPago, List<carrito> carritoPago, string referenciaOTarjeta, string nombreUsuario, decimal total, decimal totalImpuestos, decimal totalFinal)
        {
            // Ruta del archivo PDF
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);

            Document documento = new Document(PageSize.A4, 50, 50, 25, 25);

            try
            {
                // Creación del archivo PDF en la ruta especificada
                PdfWriter.GetInstance(documento, new FileStream(ruta, FileMode.Create));
                documento.Open();

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.NavigaLogoLog, System.Drawing.Imaging.ImageFormat.Png);
                logo.ScaleAbsolute(100f, 100f);
                logo.Alignment = Element.ALIGN_CENTER;
                documento.Add(logo);

                var fuenteEslogan = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.ITALIC);
                Paragraph eslogan = new Paragraph("Conecta con el futuro", fuenteEslogan)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                documento.Add(eslogan);
                documento.Add(new Paragraph(" "));

                var fuenteNormal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);
                documento.Add(new Paragraph($"Fecha: {DateTime.Now:F}", fuenteNormal));
                documento.Add(new Paragraph($"Nombre: {nombreUsuario}", fuenteNormal));
                documento.Add(new Paragraph($"Método de Pago: {metodoPago}", fuenteNormal));
                documento.Add(new Paragraph(
                    metodoPago == "OXXO" ? $"Número de referencia: {referenciaOTarjeta}" : $"Número de tarjeta: {referenciaOTarjeta}",
                    fuenteNormal
                ));
                documento.Add(new Paragraph(" "));

                var fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                Paragraph tituloProductos = new Paragraph("Productos", fuenteTitulo)
                {
                    Alignment = Element.ALIGN_LEFT
                };
                documento.Add(tituloProductos);
                documento.Add(new Paragraph(" "));

                PdfPTable tabla = new PdfPTable(4) { WidthPercentage = 100 };
                tabla.SetWidths(new float[] { 40f, 20f, 20f, 20f });

                AgregarCelda(tabla, "Descripción", true);
                AgregarCelda(tabla, "Cantidad", true);
                AgregarCelda(tabla, "Precio Unitario", true);
                AgregarCelda(tabla, "Total", true);

                usuario obj = new usuario();
                foreach (var p in carritoPago)
                {
                    productos producto = obj.obtenerProductoPorId(p.IdProducto);
                    if (producto != null)
                    {
                        AgregarCelda(tabla, producto.Descripcion);
                        AgregarCelda(tabla, p.Cantidad.ToString());
                        AgregarCelda(tabla, $"${producto.Precio:F2}");
                        AgregarCelda(tabla, $"${(producto.Precio * p.Cantidad):F2}");
                    }
                }

                documento.Add(tabla);
                documento.Add(new Paragraph(" "));

                documento.Add(new Paragraph($"Total: ${total:F2}", fuenteTitulo));
                documento.Add(new Paragraph($"Impuestos (6%): ${totalImpuestos:F2}", fuenteTitulo));
                documento.Add(new Paragraph($"Total con impuestos: ${totalFinal:F2}", fuenteTitulo));

                documento.Close();

                System.Windows.Forms.MessageBox.Show($"Archivo PDF generado correctamente en: {ruta}", "PDF Generado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        private void AgregarCelda(PdfPTable tabla, string texto, bool esEncabezado = false)
        {
            var fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, esEncabezado ? iTextSharp.text.Font.BOLD : iTextSharp.text.Font.NORMAL);
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = esEncabezado ? new BaseColor(240, 240, 240) : BaseColor.WHITE,
                Padding = 5
            };
            tabla.AddCell(celda);
        }
    }
}
