using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O2S.Components.PDFView4NET;
using Spire.Pdf;

namespace Assignment_Annotator_UI
{
    class PDF2IMG
    {
        public void ConvertPDF2Image(string pdfInputPath, string imageOutputPath, string imageName, ImageFormat imageFormat)
        {
            //PDFFile pdfFile = PDFFile.Open(pdfInputPath);
            PDFDocument pdfFile = new PDFDocument();
            pdfFile.FilePath = pdfInputPath;
            DATA.pageCount = pdfFile.PageCount;
            int startPageNum = 1;
            int endPageNum = DATA.pageCount;
            Console.WriteLine(imageOutputPath);

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > pdfFile.PageCount)
            {
                endPageNum = pdfFile.PageCount;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }
            
            //DATA.AnnotatedImages = new List<Bitmap>();
            // start to convert each page
            for (int i = startPageNum; i <= endPageNum; i++)
            {
                float pageWidth = pdfFile.Pages[i - 1].Width / 72;//pdfFile.GetPageSize(i - 1).Width / 72;
                float pageHeight = pdfFile.Pages[i - 1].Height / 72;//pdfFile.GetPageSize(i - 1).Height / 72;
                float resolution = DATA.panelWidth / pageWidth;
                //Bitmap pageImage = pdfFile.GetPageImage(i - 1, 56 * (int)definition);
                //Bitmap pageImage = pdfFile.Pages[i - 1].ConvertToImage(resolution);//pdfFile.GetPageImage(i - 1, resolution);               
                DATA.OriginalImages.Add(pdfFile.Pages[i - 1].ConvertToImage(resolution));
                //DATA.OriginalImages.Add(new Bitmap(imageOutputPath + "\\" + imageName + i.ToString() + "." + imageFormat.ToString()));

                //pageImage.Dispose();
                Console.WriteLine($"page {i} converted, width:{DATA.OriginalImages[i - 1].Width} height:{DATA.OriginalImages[i - 1].Height}");
            }

            if (Directory.Exists(imageOutputPath))
                Directory.Delete(imageOutputPath, true);
            Directory.CreateDirectory(imageOutputPath);
            int j = 1;
            foreach (var image in DATA.OriginalImages)
            {
                image.Save(imageOutputPath + "\\" + imageName + j.ToString() + "." + imageFormat.ToString(), imageFormat);
                j++;
            }

            pdfFile.Dispose();
            Console.WriteLine("Done!");
        }

    }
}
