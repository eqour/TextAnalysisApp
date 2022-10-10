namespace TextAnalysisApp.View.Forms
{
    partial class MainForm
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
            this.analyzeButton = new System.Windows.Forms.Button();
            this.analyzersListBox = new System.Windows.Forms.CheckedListBox();
            this.analysisParametersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.analyzerParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.analyzersGroupBox = new System.Windows.Forms.GroupBox();
            this.analysisResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadFileButton = new System.Windows.Forms.Button();
            this.analyzerParametersGroupBox.SuspendLayout();
            this.analyzersGroupBox.SuspendLayout();
            this.analysisResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // analyzeButton
            // 
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Location = new System.Drawing.Point(271, 12);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(250, 23);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Проанализировать текст\r\n";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // analyzersListBox
            // 
            this.analyzersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyzersListBox.FormattingEnabled = true;
            this.analyzersListBox.HorizontalScrollbar = true;
            this.analyzersListBox.Location = new System.Drawing.Point(3, 16);
            this.analyzersListBox.Name = "analyzersListBox";
            this.analyzersListBox.Size = new System.Drawing.Size(244, 381);
            this.analyzersListBox.TabIndex = 1;
            this.analyzersListBox.SelectedIndexChanged += new System.EventHandler(this.analysesListBox_SelectedIndexChanged);
            // 
            // analysisParametersPanel
            // 
            this.analysisParametersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisParametersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.analysisParametersPanel.Location = new System.Drawing.Point(3, 16);
            this.analysisParametersPanel.Name = "analysisParametersPanel";
            this.analysisParametersPanel.Size = new System.Drawing.Size(244, 381);
            this.analysisParametersPanel.TabIndex = 2;
            // 
            // analyzerParametersGroupBox
            // 
            this.analyzerParametersGroupBox.Controls.Add(this.analysisParametersPanel);
            this.analyzerParametersGroupBox.Location = new System.Drawing.Point(271, 57);
            this.analyzerParametersGroupBox.Name = "analyzerParametersGroupBox";
            this.analyzerParametersGroupBox.Size = new System.Drawing.Size(250, 400);
            this.analyzerParametersGroupBox.TabIndex = 3;
            this.analyzerParametersGroupBox.TabStop = false;
            this.analyzerParametersGroupBox.Text = "Параметры анализатора";
            // 
            // analyzersGroupBox
            // 
            this.analyzersGroupBox.Controls.Add(this.analyzersListBox);
            this.analyzersGroupBox.Location = new System.Drawing.Point(12, 57);
            this.analyzersGroupBox.Name = "analyzersGroupBox";
            this.analyzersGroupBox.Size = new System.Drawing.Size(250, 400);
            this.analyzersGroupBox.TabIndex = 4;
            this.analyzersGroupBox.TabStop = false;
            this.analyzersGroupBox.Text = "Анализаторы";
            // 
            // analysisResultsGroupBox
            // 
            this.analysisResultsGroupBox.Controls.Add(this.resultsListView);
            this.analysisResultsGroupBox.Location = new System.Drawing.Point(531, 57);
            this.analysisResultsGroupBox.Name = "analysisResultsGroupBox";
            this.analysisResultsGroupBox.Size = new System.Drawing.Size(250, 400);
            this.analysisResultsGroupBox.TabIndex = 5;
            this.analysisResultsGroupBox.TabStop = false;
            this.analysisResultsGroupBox.Text = "Результаты";
            // 
            // resultsListView
            // 
            this.resultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.resultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsListView.HideSelection = false;
            this.resultsListView.Location = new System.Drawing.Point(3, 16);
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(244, 381);
            this.resultsListView.TabIndex = 0;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Характеристика";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 120;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(12, 12);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(250, 23);
            this.loadFileButton.TabIndex = 6;
            this.loadFileButton.Text = "Загрузить текст из файла";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 465);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.analysisResultsGroupBox);
            this.Controls.Add(this.analyzersGroupBox);
            this.Controls.Add(this.analyzerParametersGroupBox);
            this.Controls.Add(this.analyzeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Анализатор текстовых файлов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.analyzerParametersGroupBox.ResumeLayout(false);
            this.analyzersGroupBox.ResumeLayout(false);
            this.analysisResultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.CheckedListBox analyzersListBox;
        private System.Windows.Forms.FlowLayoutPanel analysisParametersPanel;
        private System.Windows.Forms.GroupBox analyzerParametersGroupBox;
        private System.Windows.Forms.GroupBox analyzersGroupBox;
        private System.Windows.Forms.GroupBox analysisResultsGroupBox;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button loadFileButton;
    }
}