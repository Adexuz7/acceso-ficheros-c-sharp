
namespace AccesoFicheros
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExamine = new System.Windows.Forms.Button();
            this.lstFilePick = new System.Windows.Forms.ComboBox();
            this.chkFileLength = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.btnVisualizeFileContent = new System.Windows.Forms.Button();
            this.btnSaveFileChanges = new System.Windows.Forms.Button();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIsFile = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(6, 19);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(683, 20);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.Text = "Directorio";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(695, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(695, 48);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(75, 23);
            this.btnExamine.TabIndex = 2;
            this.btnExamine.Text = "Examinar";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // lstFilePick
            // 
            this.lstFilePick.FormattingEnabled = true;
            this.lstFilePick.Location = new System.Drawing.Point(87, 50);
            this.lstFilePick.Name = "lstFilePick";
            this.lstFilePick.Size = new System.Drawing.Size(602, 21);
            this.lstFilePick.TabIndex = 3;
            this.lstFilePick.Text = "Seleccione un archivo";
            // 
            // chkFileLength
            // 
            this.chkFileLength.AutoSize = true;
            this.chkFileLength.Checked = true;
            this.chkFileLength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileLength.Location = new System.Drawing.Point(87, 77);
            this.chkFileLength.Name = "chkFileLength";
            this.chkFileLength.Size = new System.Drawing.Size(122, 17);
            this.chkFileLength.TabIndex = 4;
            this.chkFileLength.Text = "Longitud del archivo";
            this.chkFileLength.UseVisualStyleBackColor = true;
            // 
            // chkLastAccess
            // 
            this.chkLastAccess.AutoSize = true;
            this.chkLastAccess.Checked = true;
            this.chkLastAccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLastAccess.Location = new System.Drawing.Point(215, 77);
            this.chkLastAccess.Name = "chkLastAccess";
            this.chkLastAccess.Size = new System.Drawing.Size(134, 17);
            this.chkLastAccess.TabIndex = 5;
            this.chkLastAccess.Text = "Hora del último acceso";
            this.chkLastAccess.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(355, 77);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(115, 17);
            this.chkSave.TabIndex = 6;
            this.chkSave.Text = "Guardar resultados";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(6, 19);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(633, 229);
            this.txtFileContent.TabIndex = 7;
            this.txtFileContent.Text = "Aquí se visualizará el contenido del fichero";
            // 
            // btnVisualizeFileContent
            // 
            this.btnVisualizeFileContent.Location = new System.Drawing.Point(645, 196);
            this.btnVisualizeFileContent.Name = "btnVisualizeFileContent";
            this.btnVisualizeFileContent.Size = new System.Drawing.Size(125, 23);
            this.btnVisualizeFileContent.TabIndex = 8;
            this.btnVisualizeFileContent.Text = "Ver contenido";
            this.btnVisualizeFileContent.UseVisualStyleBackColor = true;
            this.btnVisualizeFileContent.Click += new System.EventHandler(this.btnVisualizeFileContent_Click);
            // 
            // btnSaveFileChanges
            // 
            this.btnSaveFileChanges.Location = new System.Drawing.Point(645, 225);
            this.btnSaveFileChanges.Name = "btnSaveFileChanges";
            this.btnSaveFileChanges.Size = new System.Drawing.Size(125, 23);
            this.btnSaveFileChanges.TabIndex = 9;
            this.btnSaveFileChanges.Text = "Guardar cambios";
            this.btnSaveFileChanges.UseVisualStyleBackColor = true;
            this.btnSaveFileChanges.Click += new System.EventHandler(this.btnSaveFileChanges_Click);
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(6, 20);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(535, 20);
            this.txtNewFileName.TabIndex = 10;
            this.txtNewFileName.Text = "Nombre de fichero o directorio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lstFilePick);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.btnExamine);
            this.groupBox1.Controls.Add(this.chkFileLength);
            this.groupBox1.Controls.Add(this.chkSave);
            this.groupBox1.Controls.Add(this.chkLastAccess);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar fichero o directorio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIsFile);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.txtNewFileName);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear, mover (y renombrar) fichero o directorio";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(614, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(695, 18);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 12;
            this.btnMove.Text = "Mover";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFileContent);
            this.groupBox3.Controls.Add(this.btnSaveFileChanges);
            this.groupBox3.Controls.Add(this.btnVisualizeFileContent);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 254);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualizar y modificar fichero";
            // 
            // chkIsFile
            // 
            this.chkIsFile.AutoSize = true;
            this.chkIsFile.Location = new System.Drawing.Point(547, 22);
            this.chkIsFile.Name = "chkIsFile";
            this.chkIsFile.Size = new System.Drawing.Size(61, 17);
            this.chkIsFile.TabIndex = 13;
            this.chkIsFile.Text = "Fichero";
            this.chkIsFile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Acceso a ficheros";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.ComboBox lstFilePick;
        private System.Windows.Forms.CheckBox chkFileLength;
        private System.Windows.Forms.CheckBox chkLastAccess;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Button btnVisualizeFileContent;
        private System.Windows.Forms.Button btnSaveFileChanges;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIsFile;
    }
}

