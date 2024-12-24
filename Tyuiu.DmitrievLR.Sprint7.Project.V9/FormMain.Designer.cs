namespace Tyuiu.DmitrievLR.Sprint7.Project.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelWMP = new Panel();
            WMP = new AxWMPLib.AxWindowsMediaPlayer();
            panelInfo = new Panel();
            textBoxDesc = new TextBox();
            labelDesc = new Label();
            labelS = new Label();
            textBoxS = new TextBox();
            labelM = new Label();
            textBoxM = new TextBox();
            labelH = new Label();
            textBoxH = new TextBox();
            labelDuration = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxFilePath = new TextBox();
            labelFilePath = new Label();
            panelCntrl = new Panel();
            buttonDeleteFile = new Button();
            buttonAddFile = new Button();
            buttonHelp = new Button();
            panelPlaylist = new Panel();
            dataGridViewPlaylist = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            panelWMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WMP).BeginInit();
            panelInfo.SuspendLayout();
            panelCntrl.SuspendLayout();
            panelPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).BeginInit();
            SuspendLayout();
            // 
            // panelWMP
            // 
            panelWMP.Controls.Add(WMP);
            panelWMP.Location = new Point(1, 0);
            panelWMP.Name = "panelWMP";
            panelWMP.Size = new Size(1003, 393);
            panelWMP.TabIndex = 0;
            // 
            // WMP
            // 
            WMP.Dock = DockStyle.Fill;
            WMP.Enabled = true;
            WMP.Location = new Point(0, 0);
            WMP.Name = "WMP";
            WMP.OcxState = (AxHost.State)resources.GetObject("WMP.OcxState");
            WMP.Size = new Size(1003, 393);
            WMP.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.Fixed3D;
            panelInfo.Controls.Add(textBoxDesc);
            panelInfo.Controls.Add(labelDesc);
            panelInfo.Controls.Add(labelS);
            panelInfo.Controls.Add(textBoxS);
            panelInfo.Controls.Add(labelM);
            panelInfo.Controls.Add(textBoxM);
            panelInfo.Controls.Add(labelH);
            panelInfo.Controls.Add(textBoxH);
            panelInfo.Controls.Add(labelDuration);
            panelInfo.Controls.Add(textBoxName);
            panelInfo.Controls.Add(labelName);
            panelInfo.Controls.Add(textBoxFilePath);
            panelInfo.Controls.Add(labelFilePath);
            panelInfo.Location = new Point(1, 399);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(669, 177);
            panelInfo.TabIndex = 2;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(74, 91);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(588, 72);
            textBoxDesc.TabIndex = 25;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(3, 91);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(65, 15);
            labelDesc.TabIndex = 24;
            labelDesc.Text = "Описание:";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.Location = new Point(246, 34);
            labelS.Name = "labelS";
            labelS.Size = new Size(49, 15);
            labelS.TabIndex = 23;
            labelS.Text = "Секунд:";
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(301, 31);
            textBoxS.Name = "textBoxS";
            textBoxS.ReadOnly = true;
            textBoxS.Size = new Size(25, 23);
            textBoxS.TabIndex = 22;
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Location = new Point(171, 34);
            labelM.Name = "labelM";
            labelM.Size = new Size(46, 15);
            labelM.TabIndex = 21;
            labelM.Text = "Минут:";
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(215, 31);
            textBoxM.Name = "textBoxM";
            textBoxM.ReadOnly = true;
            textBoxM.Size = new Size(25, 23);
            textBoxM.TabIndex = 20;
            // 
            // labelH
            // 
            labelH.AutoSize = true;
            labelH.Location = new Point(96, 34);
            labelH.Name = "labelH";
            labelH.Size = new Size(43, 15);
            labelH.TabIndex = 19;
            labelH.Text = "Часов:";
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(140, 31);
            textBoxH.Name = "textBoxH";
            textBoxH.ReadOnly = true;
            textBoxH.Size = new Size(25, 23);
            textBoxH.TabIndex = 18;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(3, 34);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(87, 15);
            labelDuration.TabIndex = 17;
            labelDuration.Text = "Длительность:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(92, 59);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(393, 23);
            textBoxName.TabIndex = 16;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 15);
            labelName.TabIndex = 15;
            labelName.Text = "Название:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(74, 5);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(588, 23);
            textBoxFilePath.TabIndex = 14;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(3, 62);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(83, 15);
            labelFilePath.TabIndex = 13;
            labelFilePath.Text = "Путь к файлу:";
            // 
            // panelCntrl
            // 
            panelCntrl.BorderStyle = BorderStyle.Fixed3D;
            panelCntrl.Controls.Add(buttonDeleteFile);
            panelCntrl.Controls.Add(buttonAddFile);
            panelCntrl.Controls.Add(buttonHelp);
            panelCntrl.Location = new Point(676, 504);
            panelCntrl.Name = "panelCntrl";
            panelCntrl.Size = new Size(328, 72);
            panelCntrl.TabIndex = 3;
            // 
            // buttonDeleteFile
            // 
            buttonDeleteFile.Location = new Point(123, 3);
            buttonDeleteFile.Name = "buttonDeleteFile";
            buttonDeleteFile.Size = new Size(102, 62);
            buttonDeleteFile.TabIndex = 2;
            buttonDeleteFile.Text = "Удалить видеофайл";
            buttonDeleteFile.UseVisualStyleBackColor = true;
            buttonDeleteFile.Click += buttonDeleteFile_Click;
            // 
            // buttonAddFile
            // 
            buttonAddFile.Location = new Point(3, 3);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(114, 62);
            buttonAddFile.TabIndex = 1;
            buttonAddFile.Text = "Добавить видеофайл";
            buttonAddFile.UseVisualStyleBackColor = true;
            buttonAddFile.Click += buttonAddFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(233, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(88, 62);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelPlaylist
            // 
            panelPlaylist.BorderStyle = BorderStyle.Fixed3D;
            panelPlaylist.Controls.Add(dataGridViewPlaylist);
            panelPlaylist.Location = new Point(676, 399);
            panelPlaylist.Name = "panelPlaylist";
            panelPlaylist.Size = new Size(323, 99);
            panelPlaylist.TabIndex = 1;
            // 
            // dataGridViewPlaylist
            // 
            dataGridViewPlaylist.AllowUserToAddRows = false;
            dataGridViewPlaylist.AllowUserToDeleteRows = false;
            dataGridViewPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlaylist.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewPlaylist.Dock = DockStyle.Fill;
            dataGridViewPlaylist.Location = new Point(0, 0);
            dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            dataGridViewPlaylist.ReadOnly = true;
            dataGridViewPlaylist.Size = new Size(319, 95);
            dataGridViewPlaylist.TabIndex = 0;
            dataGridViewPlaylist.CellContentDoubleClick += dataGridViewPlaylist_CellContentDoubleClick;
            dataGridViewPlaylist.CellDoubleClick += dataGridViewPlaylist_CellContentDoubleClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Видеотека:";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 91;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 576);
            Controls.Add(panelCntrl);
            Controls.Add(panelInfo);
            Controls.Add(panelPlaylist);
            Controls.Add(panelWMP);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            Text = "Видеотека";
            Activated += FormMain_Activated;
            panelWMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WMP).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelCntrl.ResumeLayout(false);
            panelPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWMP;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private Panel panelInfo;
        private Panel panelCntrl;
        private Panel panelPlaylist;
        private DataGridView dataGridViewPlaylist;
        private Button buttonAddFile;
        private Button buttonHelp;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBoxDesc;
        private Label labelDesc;
        private Label labelS;
        private TextBox textBoxS;
        private Label labelM;
        private TextBox textBoxM;
        private Label labelH;
        private TextBox textBoxH;
        private Label labelDuration;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxFilePath;
        private Label labelFilePath;
        private Button buttonDeleteFile;
    }
}
