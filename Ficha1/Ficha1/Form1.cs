using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definir as variaveis 
            int buffersize = 2048;
            byte[] buffer = new byte[buffersize];

            int bytesRead = 0;

            String originalpath = "security.jpg";
            String copyFilepath = "copy_security.jpg";


            //Extra 2 - gerar um ficheiro log com as ações realizadas
            String logFilePath = "log.txt";
            StreamWriter logStreamWriter = new StreamWriter(logFilePath, true);

            
            //verificar se o ficheiro existe
            if (File.Exists(copyFilepath))
            {
                File.Delete(copyFilepath);
            }

            //criar controladores de ficheiros
            FileStream originalFileStream = new FileStream(originalpath, FileMode.Open);
            FileStream copyFileStream = new FileStream(copyFilepath, FileMode.Create);

            //definir os limites da progressBar
            progressBarCopyFile.Minimum = 0;
            progressBarCopyFile.Maximum = (int)originalFileStream.Length;
            progressBarCopyFile.Step = buffersize;

            //copiar o conteúdo
            while ((bytesRead = originalFileStream.Read(buffer, 0, buffersize)) >0)
            {
                System.Threading.Thread.Sleep(1000);
                copyFileStream.Write(buffer, 0, bytesRead);
                progressBarCopyFile.PerformStep();
            }

            //mostrar a mensagem ao utilizador
            String msg = "Ficheiro copiado [" + originalFileStream.Length + " bytes]\r\n";
            LabelCopyMessage.Text = msg;
            LabelCopyMessage.Visible = true;

            //escrever um ficheiro log
            logStreamWriter.WriteLine(msg);

            //libertar recuros
            originalFileStream.Close();
            copyFileStream.Close();
            
            //Extra 2
            logStreamWriter.Close();

        
        
        
        
        }
    }
}
