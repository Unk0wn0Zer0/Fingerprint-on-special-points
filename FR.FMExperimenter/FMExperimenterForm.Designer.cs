namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class FMExperimenterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResources = new System.Windows.Forms.TextBox();
            this.btnFindResources = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVisualMatch = new System.Windows.Forms.Button();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gbxProperties = new System.Windows.Forms.GroupBox();
            this.lblMinutiaExtractor = new System.Windows.Forms.Label();
            this.lblOrientationImageExtractor = new System.Windows.Forms.Label();
            this.lblSkeletonImageExtractor = new System.Windows.Forms.Label();
            this.lblMatcher = new System.Windows.Forms.Label();
            this.lblFeatureProvider = new System.Windows.Forms.Label();
            this.lblExperiment = new System.Windows.Forms.Label();
            this.cbxFeatureProvider = new System.Windows.Forms.ComboBox();
            this.cbxMatcher = new System.Windows.Forms.ComboBox();
            this.cbxSkeletonImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxOrientationImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxMinutiaExtractor = new System.Windows.Forms.ComboBox();
            this.cbxExperiment = new System.Windows.Forms.ComboBox();
            this.gbxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "БД отпечатков";
            // 
            // tbxResources
            // 
            this.tbxResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResources.Location = new System.Drawing.Point(201, 15);
            this.tbxResources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxResources.Name = "tbxResources";
            this.tbxResources.Size = new System.Drawing.Size(607, 22);
            this.tbxResources.TabIndex = 15;
            this.tbxResources.Text = "D:\\Migue\\Code\\FingerprintRecognition\\CodeProject\\Fingerprint databases\\FVC2004\\DB" +
    "1_A";
            // 
            // btnFindResources
            // 
            this.btnFindResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindResources.Location = new System.Drawing.Point(817, 11);
            this.btnFindResources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindResources.Name = "btnFindResources";
            this.btnFindResources.Size = new System.Drawing.Size(37, 28);
            this.btnFindResources.TabIndex = 14;
            this.btnFindResources.Text = "...";
            this.btnFindResources.UseVisualStyleBackColor = true;
            this.btnFindResources.Click += new System.EventHandler(this.btnFindResources_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Fingerprints\\Resources\\FVC2004";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnVisualMatch
            // 
            this.btnVisualMatch.Location = new System.Drawing.Point(717, 437);
            this.btnVisualMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualMatch.Name = "btnVisualMatch";
            this.btnVisualMatch.Size = new System.Drawing.Size(113, 28);
            this.btnVisualMatch.TabIndex = 34;
            this.btnVisualMatch.Text = "Сравнение";
            this.btnVisualMatch.UseVisualStyleBackColor = true;
            this.btnVisualMatch.Click += new System.EventHandler(this.btnVisualMatch_Click);
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressValue.AutoSize = true;
            this.lblProgressValue.Location = new System.Drawing.Point(813, 383);
            this.lblProgressValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(28, 17);
            this.lblProgressValue.TabIndex = 27;
            this.lblProgressValue.Text = "0%";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(503, 437);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(195, 28);
            this.btnExecute.TabIndex = 28;
            this.btnExecute.Text = "Выполнить исследование";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(153, 377);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(643, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 383);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 17);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Прогресс";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 19);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(304, 243);
            this.propertyGrid1.TabIndex = 0;
            // 
            // gbxProperties
            // 
            this.gbxProperties.Controls.Add(this.propertyGrid1);
            this.gbxProperties.Location = new System.Drawing.Point(523, 68);
            this.gbxProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProperties.Name = "gbxProperties";
            this.gbxProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProperties.Size = new System.Drawing.Size(312, 266);
            this.gbxProperties.TabIndex = 31;
            this.gbxProperties.TabStop = false;
            this.gbxProperties.Text = "Свойства";
            // 
            // lblMinutiaExtractor
            // 
            this.lblMinutiaExtractor.AutoSize = true;
            this.lblMinutiaExtractor.Location = new System.Drawing.Point(109, 126);
            this.lblMinutiaExtractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutiaExtractor.Name = "lblMinutiaExtractor";
            this.lblMinutiaExtractor.Size = new System.Drawing.Size(80, 17);
            this.lblMinutiaExtractor.TabIndex = 18;
            this.lblMinutiaExtractor.Text = "Отпечаток";
            // 
            // lblOrientationImageExtractor
            // 
            this.lblOrientationImageExtractor.AutoSize = true;
            this.lblOrientationImageExtractor.Location = new System.Drawing.Point(63, 174);
            this.lblOrientationImageExtractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrientationImageExtractor.Name = "lblOrientationImageExtractor";
            this.lblOrientationImageExtractor.Size = new System.Drawing.Size(129, 17);
            this.lblOrientationImageExtractor.TabIndex = 20;
            this.lblOrientationImageExtractor.Text = "Ориентированное";
            // 
            // lblSkeletonImageExtractor
            // 
            this.lblSkeletonImageExtractor.AutoSize = true;
            this.lblSkeletonImageExtractor.Location = new System.Drawing.Point(88, 215);
            this.lblSkeletonImageExtractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkeletonImageExtractor.Name = "lblSkeletonImageExtractor";
            this.lblSkeletonImageExtractor.Size = new System.Drawing.Size(102, 17);
            this.lblSkeletonImageExtractor.TabIndex = 22;
            this.lblSkeletonImageExtractor.Text = "Скелетизация";
            // 
            // lblMatcher
            // 
            this.lblMatcher.AutoSize = true;
            this.lblMatcher.Location = new System.Drawing.Point(25, 263);
            this.lblMatcher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatcher.Name = "lblMatcher";
            this.lblMatcher.Size = new System.Drawing.Size(175, 17);
            this.lblMatcher.TabIndex = 24;
            this.lblMatcher.Text = "Алгоритм распознования";
            // 
            // lblFeatureProvider
            // 
            this.lblFeatureProvider.AutoSize = true;
            this.lblFeatureProvider.Location = new System.Drawing.Point(0, 314);
            this.lblFeatureProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureProvider.Name = "lblFeatureProvider";
            this.lblFeatureProvider.Size = new System.Drawing.Size(218, 17);
            this.lblFeatureProvider.TabIndex = 30;
            this.lblFeatureProvider.Text = "Алгоритм хранения\\извлечения";
            // 
            // lblExperiment
            // 
            this.lblExperiment.AutoSize = true;
            this.lblExperiment.Location = new System.Drawing.Point(93, 71);
            this.lblExperiment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperiment.Name = "lblExperiment";
            this.lblExperiment.Size = new System.Drawing.Size(95, 17);
            this.lblExperiment.TabIndex = 33;
            this.lblExperiment.Text = "Эксперимент";
            // 
            // cbxFeatureProvider
            // 
            this.cbxFeatureProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureProvider.FormattingEnabled = true;
            this.cbxFeatureProvider.Location = new System.Drawing.Point(245, 308);
            this.cbxFeatureProvider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFeatureProvider.Name = "cbxFeatureProvider";
            this.cbxFeatureProvider.Size = new System.Drawing.Size(275, 24);
            this.cbxFeatureProvider.TabIndex = 29;
            this.cbxFeatureProvider.SelectedValueChanged += new System.EventHandler(this.cbxFeatureProvider_SelectedValueChanged);
            this.cbxFeatureProvider.Enter += new System.EventHandler(this.cbxFeatureProvider_Enter);
            // 
            // cbxMatcher
            // 
            this.cbxMatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatcher.FormattingEnabled = true;
            this.cbxMatcher.Location = new System.Drawing.Point(223, 260);
            this.cbxMatcher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMatcher.Name = "cbxMatcher";
            this.cbxMatcher.Size = new System.Drawing.Size(297, 24);
            this.cbxMatcher.TabIndex = 23;
            this.cbxMatcher.SelectedValueChanged += new System.EventHandler(this.cbxMatcher_SelectedValueChanged);
            this.cbxMatcher.Enter += new System.EventHandler(this.cbxMatcher_Enter);
            // 
            // cbxSkeletonImageExtractor
            // 
            this.cbxSkeletonImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkeletonImageExtractor.FormattingEnabled = true;
            this.cbxSkeletonImageExtractor.Location = new System.Drawing.Point(223, 212);
            this.cbxSkeletonImageExtractor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSkeletonImageExtractor.Name = "cbxSkeletonImageExtractor";
            this.cbxSkeletonImageExtractor.Size = new System.Drawing.Size(297, 24);
            this.cbxSkeletonImageExtractor.Sorted = true;
            this.cbxSkeletonImageExtractor.TabIndex = 21;
            this.cbxSkeletonImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxSkeletonImageExtractor_SelectedValueChanged);
            this.cbxSkeletonImageExtractor.Enter += new System.EventHandler(this.cbxSkeletonImageExtractor_Enter);
            // 
            // cbxOrientationImageExtractor
            // 
            this.cbxOrientationImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientationImageExtractor.FormattingEnabled = true;
            this.cbxOrientationImageExtractor.Location = new System.Drawing.Point(223, 164);
            this.cbxOrientationImageExtractor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOrientationImageExtractor.Name = "cbxOrientationImageExtractor";
            this.cbxOrientationImageExtractor.Size = new System.Drawing.Size(297, 24);
            this.cbxOrientationImageExtractor.Sorted = true;
            this.cbxOrientationImageExtractor.TabIndex = 19;
            this.cbxOrientationImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxOrientationImageExtractor_SelectedValueChanged);
            this.cbxOrientationImageExtractor.Enter += new System.EventHandler(this.cbxOrientationImageExtractor_Enter);
            // 
            // cbxMinutiaExtractor
            // 
            this.cbxMinutiaExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutiaExtractor.FormattingEnabled = true;
            this.cbxMinutiaExtractor.Location = new System.Drawing.Point(223, 116);
            this.cbxMinutiaExtractor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMinutiaExtractor.Name = "cbxMinutiaExtractor";
            this.cbxMinutiaExtractor.Size = new System.Drawing.Size(297, 24);
            this.cbxMinutiaExtractor.Sorted = true;
            this.cbxMinutiaExtractor.TabIndex = 17;
            this.cbxMinutiaExtractor.SelectedValueChanged += new System.EventHandler(this.cbxMinutiaExtractor_SelectedValueChanged);
            this.cbxMinutiaExtractor.Enter += new System.EventHandler(this.cbxMinutiaExtractor_Enter);
            // 
            // cbxExperiment
            // 
            this.cbxExperiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExperiment.FormattingEnabled = true;
            this.cbxExperiment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxExperiment.Location = new System.Drawing.Point(223, 68);
            this.cbxExperiment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxExperiment.Name = "cbxExperiment";
            this.cbxExperiment.Size = new System.Drawing.Size(297, 24);
            this.cbxExperiment.Sorted = true;
            this.cbxExperiment.TabIndex = 32;
            this.cbxExperiment.SelectedValueChanged += new System.EventHandler(this.cbxExperiment_SelectedValueChanged);
            // 
            // FMExperimenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.btnVisualMatch);
            this.Controls.Add(this.lblExperiment);
            this.Controls.Add(this.cbxExperiment);
            this.Controls.Add(this.gbxProperties);
            this.Controls.Add(this.lblFeatureProvider);
            this.Controls.Add(this.cbxFeatureProvider);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblProgressValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMatcher);
            this.Controls.Add(this.cbxMatcher);
            this.Controls.Add(this.lblSkeletonImageExtractor);
            this.Controls.Add(this.cbxSkeletonImageExtractor);
            this.Controls.Add(this.lblOrientationImageExtractor);
            this.Controls.Add(this.cbxOrientationImageExtractor);
            this.Controls.Add(this.lblMinutiaExtractor);
            this.Controls.Add(this.cbxMinutiaExtractor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxResources);
            this.Controls.Add(this.btnFindResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FMExperimenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отпечатки пальцев";
            this.gbxProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResources;
        private System.Windows.Forms.Button btnFindResources;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVisualMatch;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox gbxProperties;
        private System.Windows.Forms.Label lblMinutiaExtractor;
        private System.Windows.Forms.Label lblOrientationImageExtractor;
        private System.Windows.Forms.Label lblSkeletonImageExtractor;
        private System.Windows.Forms.Label lblMatcher;
        private System.Windows.Forms.Label lblFeatureProvider;
        private System.Windows.Forms.Label lblExperiment;
        private System.Windows.Forms.ComboBox cbxFeatureProvider;
        private System.Windows.Forms.ComboBox cbxMatcher;
        private System.Windows.Forms.ComboBox cbxSkeletonImageExtractor;
        private System.Windows.Forms.ComboBox cbxOrientationImageExtractor;
        private System.Windows.Forms.ComboBox cbxMinutiaExtractor;
        private System.Windows.Forms.ComboBox cbxExperiment;
    }
}