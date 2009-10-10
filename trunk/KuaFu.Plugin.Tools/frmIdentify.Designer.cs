namespace KuaFu.Plugin.Tools
{
    partial class frmIdentify
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
            this.lsv_Identify = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lsv_Identify
            // 
            this.lsv_Identify.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue});
            this.lsv_Identify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_Identify.Location = new System.Drawing.Point(0, 0);
            this.lsv_Identify.Name = "lsv_Identify";
            this.lsv_Identify.Size = new System.Drawing.Size(279, 263);
            this.lsv_Identify.TabIndex = 0;
            this.lsv_Identify.UseCompatibleStateImageBehavior = false;
            this.lsv_Identify.View = System.Windows.Forms.View.Details;
            this.lsv_Identify.SelectedIndexChanged += new System.EventHandler(this.lsv_Identify_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "字段名";
            this.colName.Width = 183;
            // 
            // colValue
            // 
            this.colValue.Text = "值";
            this.colValue.Width = 177;
            // 
            // frmIdentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 263);
            this.Controls.Add(this.lsv_Identify);
            this.Name = "frmIdentify";
            this.Text = "frmIdentify";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv_Identify;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colValue;

    }
}