
namespace Lexems
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.choose_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.table_btn = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.TextBox();
            this.file_view = new System.Windows.Forms.TextBox();
            this.wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choose_btn
            // 
            this.choose_btn.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_btn.Location = new System.Drawing.Point(344, 70);
            this.choose_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(123, 34);
            this.choose_btn.TabIndex = 1;
            this.choose_btn.Text = "Выбрать файл";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(10, 401);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(76, 36);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // table_btn
            // 
            this.table_btn.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_btn.Location = new System.Drawing.Point(10, 10);
            this.table_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.table_btn.Name = "table_btn";
            this.table_btn.Size = new System.Drawing.Size(157, 34);
            this.table_btn.TabIndex = 6;
            this.table_btn.Text = "Таблица лексем";
            this.table_btn.UseVisualStyleBackColor = true;
            this.table_btn.Click += new System.EventHandler(this.lexems_btn_Click);
            // 
            // file_path
            // 
            this.file_path.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_path.Location = new System.Drawing.Point(12, 70);
            this.file_path.Name = "file_path";
            this.file_path.ReadOnly = true;
            this.file_path.Size = new System.Drawing.Size(327, 34);
            this.file_path.TabIndex = 7;
            // 
            // file_view
            // 
            this.file_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_view.Location = new System.Drawing.Point(10, 130);
            this.file_view.Multiline = true;
            this.file_view.Name = "file_view";
            this.file_view.ReadOnly = true;
            this.file_view.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.file_view.Size = new System.Drawing.Size(456, 265);
            this.file_view.TabIndex = 8;
            // 
            // wait
            // 
            this.wait.AutoSize = true;
            this.wait.ForeColor = System.Drawing.Color.Silver;
            this.wait.Location = new System.Drawing.Point(172, 16);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(204, 23);
            this.wait.TabIndex = 9;
            this.wait.Text = "Пожалуйста, подождите";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(478, 449);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.file_view);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.table_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.choose_btn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Выбор файла";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button table_btn;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.TextBox file_view;
        private System.Windows.Forms.Label wait;
    }
}