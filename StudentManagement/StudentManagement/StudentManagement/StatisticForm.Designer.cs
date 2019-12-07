namespace StudentManagement.StudentManagement
{
    partial class StatisticForm
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
            this.grdStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStatistic
            // 
            this.grdStatistic.AllowUserToAddRows = false;
            this.grdStatistic.AllowUserToDeleteRows = false;
            this.grdStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStatistic.Location = new System.Drawing.Point(0, 0);
            this.grdStatistic.Name = "grdStatistic";
            this.grdStatistic.ReadOnly = true;
            this.grdStatistic.RowHeadersWidth = 51;
            this.grdStatistic.RowTemplate.Height = 24;
            this.grdStatistic.Size = new System.Drawing.Size(800, 450);
            this.grdStatistic.TabIndex = 0;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdStatistic);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStatistic;
    }
}