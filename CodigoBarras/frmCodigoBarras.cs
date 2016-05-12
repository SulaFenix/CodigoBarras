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

                StreamReader sr = new StreamReader(ofdImportarTxt.FileName);
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

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + "\\Download\\example_with_font.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Font arial = FontFactory.GetFont("C39Hrp24dhtt");
            string teste;
            string teste2 = "123456";
            teste = String.Format("*{0}*", teste2);
            

            doc.Add(new Paragraph(teste, arial));
            doc.Close();
        }
    }
}
