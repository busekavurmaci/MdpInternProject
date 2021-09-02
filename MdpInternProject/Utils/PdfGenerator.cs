using System;
using System.IO;

namespace efatura.Tools
{
    public class PdfGenerator
    {
        /// <param name="pdfOutputFolder"></param>
        /// <param name="outputFilenamePrefix"></param>
        /// <param name="urls"></param>
        /// <param name="options"></param>
        /// <param name="pdfHtmlToPdfExePath1"></param>
        /// <returns>the URL of the generated PDF</returns>
        public static string HtmlToPdf(string workingFolder, string outputFileName, string inputFileName,
            string[] options = null)
        {
            string pdfHtmlToPdfExePath = "C:\\Program Files (x86)\\wkhtmltopdf\\wkhtmltopdf.exe";
            string urlsSeparatedBySpaces = string.Empty;
            options = new string [] { "--disable-external-links" };

            if (!File.Exists(pdfHtmlToPdfExePath))
                pdfHtmlToPdfExePath = "C:\\Program Files\\wkhtmltopdf\\bin\\wkhtmltopdf.exe";

            try
            {
                //Determine inputs
                //if ((htmlString == null) || (htmlString.Length == 0))
                //    throw new Exception("No input URLs provided for HtmlToPdf");
                //else
                //    urlsSeparatedBySpaces = String.Join(" ", urls); //Concatenate URLs

                //string outputFilename = outputFilenamePrefix + "_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fff") + ".PDF"; // assemble destination PDF file name
                //string outputFilename = outputFileName; // assemble destination PDF file name

                if (!File.Exists(pdfHtmlToPdfExePath))
                    throw new Exception("Pdf App not found!.");

                var p = new System.Diagnostics.Process()
                {
                    StartInfo =
                    {
                        FileName = pdfHtmlToPdfExePath,
                        Arguments = ((options == null) ? "" : String.Join(" ", options)) + " " + inputFileName + " " + outputFileName,
                        UseShellExecute = false, // needs to be false in order to redirect output
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true, // redirect all 3, as it should be all 3 or none
                        WorkingDirectory = workingFolder
                    }
                };

                p.Start();

                // read the output here...
                var output = p.StandardOutput.ReadToEnd();
                var errorOutput = p.StandardError.ReadToEnd();

                // ...then wait n milliseconds for exit (as after exit, it can't read the output)
                p.WaitForExit(180000);

                // read the exit code, close process
                int returnCode = p.ExitCode;
                p.Close();

                // if 0 or 2, it worked so return path of pdf
                if ((returnCode == 0) || (returnCode == 1) || (returnCode == 2))
                    return workingFolder + outputFileName;
                else
                    throw new Exception(errorOutput);
            }
            catch (Exception exc)
            {
                throw new Exception("Problem generating PDF from HTML, URLs: " + urlsSeparatedBySpaces + ", outputFilename: " + outputFileName, exc);
            }
        }
    }
}