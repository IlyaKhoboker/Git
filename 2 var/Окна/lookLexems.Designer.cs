
namespace Lexems
{
    partial class LookLexems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookLexems));
            this.back_btn = new System.Windows.Forms.Button();
            this.table_lexems = new System.Windows.Forms.TableLayoutPanel();
            this.DataUpload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.back_btn.Location = new System.Drawing.Point(17, 16);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(185, 35);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Исходный файл";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // table_lexems
            // 
            this.table_lexems.AutoScroll = true;
            this.table_lexems.AutoSize = true;
            this.table_lexems.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table_lexems.ColumnCount = 3;
            this.table_lexems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_lexems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_lexems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.table_lexems.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_lexems.ForeColor = System.Drawing.Color.Black;
            this.table_lexems.Location = new System.Drawing.Point(17, 58);
            this.table_lexems.MaximumSize = new System.Drawing.Size(868, 488);
            this.table_lexems.Name = "table_lexems";
            this.table_lexems.RowCount = 3;
            this.table_lexems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_lexems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_lexems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_lexems.Size = new System.Drawing.Size(868, 488);
            this.table_lexems.TabIndex = 3;
            this.table_lexems.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // DataUpload
            // 
            this.DataUpload.AutoSize = true;
            this.DataUpload.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataUpload.ForeColor = System.Drawing.Color.Gray;
            this.DataUpload.Location = new System.Drawing.Point(209, 22);
            this.DataUpload.Name = "DataUpload";
            this.DataUpload.Size = new System.Drawing.Size(241, 23);
            this.DataUpload.TabIndex = 4;
            this.DataUpload.Text = "Данные успешно загружены";
            // 
            // LookLexems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(897, 558);
            this.Controls.Add(this.DataUpload);
            this.Controls.Add(this.table_lexems);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LookLexems";
            this.Text = "Таблица лексем";
            this.Load += new System.EventHandler(this.lookLexems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TableLayoutPanel table_lexems;
        private System.Windows.Forms.Label DataUpload;
    }
}