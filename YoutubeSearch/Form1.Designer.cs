namespace YoutubeSearch
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnSearch = new Button();
            txtSearch = new TextBox();
            videoDrawingBindingSource = new BindingSource(components);
            dataGridView = new DataGridView();
            videoBindingSource = new BindingSource(components);
            thumbnailDataGridViewImageColumn = new DataGridViewImageColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)videoDrawingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(600, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(575, 23);
            txtSearch.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { thumbnailDataGridViewImageColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, urlDataGridViewTextBoxColumn });
            dataGridView.DataSource = videoBindingSource;
            dataGridView.Location = new Point(12, 42);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(663, 396);
            dataGridView.TabIndex = 1;
            // 
            // videoBindingSource
            // 
            videoBindingSource.DataSource = typeof(Video);
            // 
            // thumbnailDataGridViewImageColumn
            // 
            thumbnailDataGridViewImageColumn.DataPropertyName = "Thumbnail";
            thumbnailDataGridViewImageColumn.HeaderText = "Thumbnail";
            thumbnailDataGridViewImageColumn.Name = "thumbnailDataGridViewImageColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            urlDataGridViewTextBoxColumn.HeaderText = "Url";
            urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView);
            Controls.Add(btnSearch);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoutubeSearch";
            ((System.ComponentModel.ISupportInitialize)videoDrawingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private BindingSource videoDrawingBindingSource;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private BindingSource videoBindingSource;
        private DataGridViewImageColumn thumbnailDataGridViewImageColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}