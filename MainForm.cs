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

namespace AccesoFicheros
{
    public partial class MainForm : Form
    {
        private string NewPath;
        private FileInfo thisFile;
        private string ErrorMessage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtDirectory.Text = Directory.GetCurrentDirectory();

            ListFilesAndFolders();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ListFilesAndFolders();
        }

        private void ListFilesAndFolders()
        {
            NewPath = txtDirectory.Text;
            string sourceDirectory = NewPath;

            try
            {
                // Change the location to NewPath.
                Directory.SetCurrentDirectory(NewPath);

                lstFilePick.Text = "Seleccione un archivo";
                lstFilePick.Items.Clear();

                var txtDirectories = Directory.EnumerateDirectories(sourceDirectory);
                foreach (string currentDirectory in txtDirectories)
                {
                    string fileName = currentDirectory.Substring(sourceDirectory.Length + 1);
                    lstFilePick.Items.Add(currentDirectory);
                }

                var txtFiles = Directory.EnumerateFiles(sourceDirectory);
                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    lstFilePick.Items.Add(currentFile);
                }

            }
            catch (DirectoryNotFoundException)
            {   // This catches errors caused by a path
                ErrorMessage = "You must enter a valid path. If trying to access a different drive, remember to include the drive letter.";
            }
            catch
            {   // This checks to make sure the path is not blank.
                ErrorMessage = "You must enter a path.";
            }
            finally
            {
                // Display the error message only if one exists.
                if (ErrorMessage != null)
                    MessageBox.Show(ErrorMessage);
            }
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());

            string texto = "Los atributos del fichero " + lstFilePick.SelectedItem.ToString() + " son : ";
            
            if (chkFileLength.Checked)
            {
                texto = texto + " La Longitud del fichero es : " + thisFile.Length.ToString();
            }
            
            if (chkLastAccess.Checked)
            {
                texto = texto + " última modificación fue : " + thisFile.LastAccessTime.ToString();
            }

            MessageBox.Show(texto);

            if (chkSave.Checked)
            {
                // si no existe el fichero lo crea y si existe sobreescribe el contenido
                File.WriteAllText(NewPath + "/log.txt", texto);
            }

            ListFilesAndFolders();

        }

        private void btnVisualizeFileContent_Click(object sender, EventArgs e)
        {
            thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());
            string text = File.ReadAllText(thisFile.FullName);
            txtFileContent.Text = text;
        }

        private void btnSaveFileChanges_Click(object sender, EventArgs e)
        {
            thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());
            File.WriteAllText(thisFile.FullName, txtFileContent.Text);
            MessageBox.Show("Cambios guardados");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());
            FileAttributes attr = File.GetAttributes(thisFile.FullName);
            
            if (MessageBox.Show("¿Seguro que desea eliminar " + thisFile.Name + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Directory.Delete(thisFile.FullName, true);
                }
                else
                {
                    File.Delete(thisFile.FullName);
                }   
            }
            // ListFilesAndFolders();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string newFilePath = txtDirectory.Text + Path.DirectorySeparatorChar + txtNewFileName.Text;

            if (chkIsFile.Checked)
            {
                File.Create(newFilePath);
            }
            else if (chkIsFile.Checked == false)
            {
                Directory.CreateDirectory(newFilePath);
            }

            ListFilesAndFolders();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());
            FileAttributes attr = File.GetAttributes(thisFile.FullName);
            string newFilePath = txtDirectory.Text + Path.DirectorySeparatorChar + txtNewFileName.Text;
            
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Directory.Move(thisFile.FullName, newFilePath);
            }
            else
            {
                File.Move(thisFile.FullName, newFilePath);
            }

            ListFilesAndFolders();
        }
    }
}
