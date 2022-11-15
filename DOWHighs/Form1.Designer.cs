namespace DOWHighs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.closingValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allDatesRadioButton = new System.Windows.Forms.RadioButton();
            this.firstDateRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.djiaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.djiaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.closingValueTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.allDatesRadioButton);
            this.panel1.Controls.Add(this.firstDateRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 101);
            this.panel1.TabIndex = 0;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(903, 53);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(150, 42);
            this.clearFilterButton.TabIndex = 5;
            this.clearFilterButton.Text = "Clear Filter";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(903, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 42);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // closingValueTextBox
            // 
            this.closingValueTextBox.Location = new System.Drawing.Point(623, 33);
            this.closingValueTextBox.Name = "closingValueTextBox";
            this.closingValueTextBox.Size = new System.Drawing.Size(263, 39);
            this.closingValueTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting Closing Value:";
            // 
            // allDatesRadioButton
            // 
            this.allDatesRadioButton.AutoSize = true;
            this.allDatesRadioButton.Checked = true;
            this.allDatesRadioButton.Location = new System.Drawing.Point(220, 53);
            this.allDatesRadioButton.Name = "allDatesRadioButton";
            this.allDatesRadioButton.Size = new System.Drawing.Size(139, 36);
            this.allDatesRadioButton.TabIndex = 2;
            this.allDatesRadioButton.TabStop = true;
            this.allDatesRadioButton.Text = "All Dates";
            this.allDatesRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstDateRadioButton
            // 
            this.firstDateRadioButton.AutoSize = true;
            this.firstDateRadioButton.Checked = true;
            this.firstDateRadioButton.Location = new System.Drawing.Point(220, 11);
            this.firstDateRadioButton.Name = "firstDateRadioButton";
            this.firstDateRadioButton.Size = new System.Drawing.Size(146, 36);
            this.firstDateRadioButton.TabIndex = 1;
            this.firstDateRadioButton.TabStop = true;
            this.firstDateRadioButton.Text = "First Date";
            this.firstDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Results For:";
            // 
            // djiaDataGridView
            // 
            this.djiaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.djiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.djiaDataGridView.Location = new System.Drawing.Point(25, 141);
            this.djiaDataGridView.Name = "djiaDataGridView";
            this.djiaDataGridView.RowHeadersWidth = 82;
            this.djiaDataGridView.RowTemplate.Height = 41;
            this.djiaDataGridView.Size = new System.Drawing.Size(1072, 352);
            this.djiaDataGridView.TabIndex = 6;
            this.djiaDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.djiaDataGridView_ColumnHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 517);
            this.Controls.Add(this.djiaDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dow Jones International Average Highs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.djiaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button clearFilterButton;
        private Button searchButton;
        private TextBox closingValueTextBox;
        private Label label2;
        private RadioButton allDatesRadioButton;
        private RadioButton firstDateRadioButton;
        private Label label1;
        private DataGridView djiaDataGridView;
    }
}