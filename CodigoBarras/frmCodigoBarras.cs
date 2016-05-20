using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Drawing.Text;
using System.Web;
using Root.Reports;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CodigoBarras
{
    public partial class frmCodigoBarras : Form
    {
        public frmCodigoBarras()
        {
            InitializeComponent();
        }

        private void btnGerarCodigoBarras_Click(object sender, EventArgs e)
        {
            this.ofdImportarTxt.Multiselect = false;
            this.ofdImportarTxt.Title = "Selecionar Arquivo";
            ofdImportarTxt.FileName = "";
            ofdImportarTxt.InitialDirectory = @"C:\";
            ofdImportarTxt.Filter = "*.txt | *.txt";
            ofdImportarTxt.CheckFileExists = true;
            ofdImportarTxt.CheckPathExists = true;
            ofdImportarTxt.FilterIndex = 2;
            ofdImportarTxt.RestoreDirectory = true;
            ofdImportarTxt.ReadOnlyChecked = true;
            ofdImportarTxt.ShowReadOnly = true;

            DialogResult dr = this.ofdImportarTxt.ShowDialog();
           
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application wordApplication = default(Microsoft.Office.Interop.Word.Application);
                wordApplication = new Microsoft.Office.Interop.Word.Application();

                // template normal
                object newTemplate = false;
                object docType = 0;
                object isVisible = true;

                // Cria um novo Documento  chamando a função Add na coleção de documentos
                Microsoft.Office.Interop.Word.Document aDoc = wordApplication.Documents.Add(Type.Missing, newTemplate, docType, isVisible);

                // torna o documento visivel
                wordApplication.Visible = true;
                aDoc.Activate();
                //aDoc.Save();

                StreamReader sr = new StreamReader(ofdImportarTxt.FileName);
                string nomeArquivo = ofdImportarTxt.SafeFileName;
                string linha = sr.ReadLine();

                PrivateFontCollection pfc = new PrivateFontCollection();
                System.Drawing.Font _Fonte;

                string CAMINHO_FONTES = Application.StartupPath + "\\Fonts";

                pfc.AddFontFile(CAMINHO_FONTES + @"\" + "BARCOD39.TTF");

                FontFamily fontFamily = pfc.Families[0];
                _Fonte = new System.Drawing.Font(fontFamily, 30);

                string primeiraLinha;
                string linhaT;
                string linhaZ;
                string linhaX;
                int count = 1;

                while (linha != null)
                {
                    if (count == 1)
                    {
                        primeiraLinha = linha;

                        wordApplication.Selection.Font.Size = 20;
                        wordApplication.Selection.Font.Bold = 0;
                        wordApplication.Selection.Font.Name = "Times";
                        wordApplication.Selection.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                        wordApplication.Selection.TypeParagraph();
                        wordApplication.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        wordApplication.Selection.TypeText(primeiraLinha);
                    }

                    if (count == 2)
                    {
                        linhaT = String.Format("*{0}*", linha.Replace("T=",""));

                        wordApplication.Selection.Font.Size = 80;
                        wordApplication.Selection.Font.Bold = 0;
                        wordApplication.Selection.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                        wordApplication.Selection.TypeParagraph();
                        wordApplication.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        wordApplication.Selection.Font.Name = "Times";
                        wordApplication.Selection.TypeText("T= ");
                        wordApplication.Selection.Font.Name = "C39Hrp24dhtt";
                        wordApplication.Selection.TypeText(linhaT);
                    }

                    if (count == 3)
                    {
                        linhaZ = String.Format("*{0}*", linha.Replace("Z=",""));

                        wordApplication.Selection.Font.Size = 80;
                        wordApplication.Selection.Font.Bold = 0;
                        wordApplication.Selection.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                        wordApplication.Selection.TypeParagraph();
                        wordApplication.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        wordApplication.Selection.Font.Name = "Times";
                        wordApplication.Selection.TypeText("Z= ");
                        wordApplication.Selection.Font.Name = "C39Hrp24dhtt";
                        wordApplication.Selection.TypeText(linhaZ);
                    }

                    if (count == 4)
                    {
                        linhaX = String.Format("*{0}*", linha.Replace("X=",""));

                        wordApplication.Selection.Font.Size = 80;
                        wordApplication.Selection.Font.Bold = 0;
                        wordApplication.Selection.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                        wordApplication.Selection.TypeParagraph();
                        wordApplication.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        wordApplication.Selection.Font.Name = "Times";
                        wordApplication.Selection.TypeText("X= ");
                        wordApplication.Selection.Font.Name = "C39Hrp24dhtt";
                        wordApplication.Selection.TypeText(linhaX);
                    }
                    
                    linha = sr.ReadLine();
                    count++;
                }

                sr.Close();

                //string vArq = "";
                //FolderBrowserDialog vSalvar = new FolderBrowserDialog();

                //if (vSalvar.ShowDialog() == DialogResult.Cancel)
                //    return; // Cancela todo processo
                // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo
                //vArq = vSalvar.SelectedPath + "\\" + "teste" + ".pdf";


                // Cria um objeto PDF
                //Report vPdf = new Report(new PdfFormatter());
                // Define a fonte que sera usada no relatório PDF
                //FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);
                //FontProp vDrop = new FontProp(vDef, 10);
                // Cria uma Nova Pagina
                //Page vPage = new Page(vPdf);

                // Escreve no Arquivo
                //vPage.AddCB_MM(5, new RepString(vDrop, codigoBarras)); // Centraliza
                //vPage.AddCB_MM(0, new RepString(vDrop, ""));

                // Salvar Arquivo no disco
                //vPdf.Save(vArq);
                //MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdtDoc.Checked)
                textBox1.Text = rdtDoc.Checked.ToString();

            if (rdtPdf.Checked)
                textBox1.Text = rdtPdf.Checked.ToString();

            #region Exemplo 1
            //Document doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + "\\Download\\example_with_font.pdf", FileMode.Create));
            //doc.Open();

            //iTextSharp.text.Font arial = FontFactory.GetFont("Times");
            //string teste;
            //string teste2 = "123456";
            //teste = String.Format("*{0}*", teste2);


            //doc.Add(new Paragraph(teste, arial));
            //doc.Close();

            //link.Text = Application.StartupPath + "\\Download\\example_with_font.pdf";
            ////HLink.NavigateUrl = Request.ApplicationPath + "/example_with_db.pdf"; 
            #endregion

            #region Exemplo 2
            //// Create a new Microsoft Word application object
            //Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            //// C# doesn't have optional arguments so we'll need a dummy value
            //object oMissing = System.Reflection.Missing.Value;

            //// Get list of Word files in specified directory
            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Suellen\Documents\CodigoBarras\CodigoBarras\bin\Debug\Download");
            //FileInfo[] wordFiles = dirInfo.GetFiles("*.doc");

            //word.Visible = false;
            //word.ScreenUpdating = false;

            //foreach (FileInfo wordFile in wordFiles)
            //{
            //    // Cast as Object for word Open method
            //    Object filename = (Object)wordFile.FullName;

            //    // Use the dummy value as a placeholder for optional arguments
            //    //Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref filename, ref oMissing,
            //    //    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            //    //    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            //    //    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            //    //doc.Activate();







            //    this.ofdImportarTxt.Multiselect = false;
            //    this.ofdImportarTxt.Title = "Selecionar Arquivo";
            //    ofdImportarTxt.FileName = "";
            //    ofdImportarTxt.InitialDirectory = @"C:\";
            //    ofdImportarTxt.Filter = "*.txt | *.txt";
            //    ofdImportarTxt.CheckFileExists = true;
            //    ofdImportarTxt.CheckPathExists = true;
            //    ofdImportarTxt.FilterIndex = 2;
            //    ofdImportarTxt.RestoreDirectory = true;
            //    ofdImportarTxt.ReadOnlyChecked = true;
            //    ofdImportarTxt.ShowReadOnly = true;

            //    DialogResult dr = this.ofdImportarTxt.ShowDialog();

            //    if (dr == System.Windows.Forms.DialogResult.OK)
            //    {
            //        Microsoft.Office.Interop.Word.Application wordApplication = default(Microsoft.Office.Interop.Word.Application);
            //        wordApplication = new Microsoft.Office.Interop.Word.Application();

            //        // template normal
            //        object newTemplate = false;
            //        object docType = 0;
            //        object isVisible = true;

            //        // Cria um novo Documento  chamando a função Add na coleção de documentos
            //        Microsoft.Office.Interop.Word.Document doc = wordApplication.Documents.Add(Type.Missing, newTemplate, docType, isVisible);

            //        // torna o documento visivel
            //        wordApplication.Visible = true;
            //        doc.Activate();
            //        //aDoc.Save();


            //        StreamReader sr = new StreamReader(ofdImportarTxt.FileName);
            //        string nomeArquivo = ofdImportarTxt.SafeFileName;
            //        string linha = sr.ReadLine();

            //        PrivateFontCollection pfc = new PrivateFontCollection();
            //        System.Drawing.Font _Fonte;

            //        string CAMINHO_FONTES = Application.StartupPath + "\\Fonts";

            //        pfc.AddFontFile(CAMINHO_FONTES + @"\" + "BARCOD39.TTF");

            //        FontFamily fontFamily = pfc.Families[0];
            //        _Fonte = new System.Drawing.Font(fontFamily, 30);

            //        string primeiraLinha;
            //        string linhaT;
            //        string linhaZ;
            //        string linhaX;
            //        int count = 1;

            //        while (linha != null)
            //        {
            //            if (count == 1)
            //            {
            //                primeiraLinha = linha;

            //                wordApplication.Selection.Font.Size = 20;
            //                wordApplication.Selection.Font.Bold = 0;
            //                wordApplication.Selection.Font.Name = "Times";
            //                wordApplication.Selection.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
            //                wordApplication.Selection.TypeParagraph();
            //                wordApplication.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            //                wordApplication.Selection.TypeText(primeiraLinha);
            //            }

            //            linha = sr.ReadLine();
            //            count++;
            //        }

            //        sr.Close();










            //        object outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
            //        object fileFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF;

            //        // Save document into PDF Format
            //        doc.SaveAs(ref outputFileName,
            //            ref fileFormat, ref oMissing, ref oMissing,
            //            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            //            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            //            ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            //        // Close the Word document, but leave the Word application open.
            //        // doc has to be cast to type _Document so that it will find the
            //        // correct Close method.                
            //        object saveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
            //        ((Microsoft.Office.Interop.Word._Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
            //        doc = null;


            //    }

            //    // word has to be cast to type _Application so that it will find
            //    // the correct Quit method.
            //    ((Microsoft.Office.Interop.Word._Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            //    word = null;
            //}
            #endregion

            #region Exemplo 3
            //http://stackoverflow.com/questions/26275581/getting-system-runtime-interopservices-comexception-command-failed
            /*
            string sInputFile = @"C:\Users\Suellen\Documents\CodigoBarras\CodigoBarras\bin\Debug\Download\Testdoc.doc";
            string sOutputFile = @"C:\Users\Suellen\Downloads\testepdf.pdf";

            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;

            word.Visible = false;
            word.ScreenUpdating = false;


            //if (File.Exists(sInputFile))
            //{

            FileInfo wordFile = new FileInfo(sInputFile);

                // Cast as Object for word Open method
                Object filename = (Object)wordFile.FullName;

                // Use the dummy value as a placeholder for optional arguments
                Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();

                object outputFileName = sOutputFile;
                object fileFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF;

                // Save document into PDF Format
                doc.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                // Close the Word document, but leave the Word application open.
                // doc has to be cast to type _Document so that it will find the
                // correct Close method.                
                object saveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                ((Microsoft.Office.Interop.Word._Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;

            //}

            // word has to be cast to type _Application so that it will find
            // the correct Quit method.
            ((Microsoft.Office.Interop.Word._Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            word = null;
             */
            #endregion
        }
             
    }
}
