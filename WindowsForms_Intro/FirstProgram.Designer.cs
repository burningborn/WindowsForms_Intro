
namespace WindowsForms_Intro
{
    partial class FirstProgram
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CocaCola = new System.Windows.Forms.Label();
            this.JohnnyWalker = new System.Windows.Forms.Label();
            this.JackDaniels = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Surprise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CocaCola
            // 
            this.CocaCola.AutoSize = true;
            this.CocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CocaCola.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CocaCola.Location = new System.Drawing.Point(103, 37);
            this.CocaCola.Name = "CocaCola";
            this.CocaCola.Size = new System.Drawing.Size(81, 17);
            this.CocaCola.TabIndex = 2;
            this.CocaCola.Text = "Coca Cola";
            // 
            // JohnnyWalker
            // 
            this.JohnnyWalker.AutoSize = true;
            this.JohnnyWalker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JohnnyWalker.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.JohnnyWalker.Location = new System.Drawing.Point(389, 37);
            this.JohnnyWalker.Name = "JohnnyWalker";
            this.JohnnyWalker.Size = new System.Drawing.Size(115, 17);
            this.JohnnyWalker.TabIndex = 3;
            this.JohnnyWalker.Text = "Johnny Walker";
            // 
            // JackDaniels
            // 
            this.JackDaniels.AutoSize = true;
            this.JackDaniels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JackDaniels.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.JackDaniels.Location = new System.Drawing.Point(657, 37);
            this.JackDaniels.Name = "JackDaniels";
            this.JackDaniels.Size = new System.Drawing.Size(100, 17);
            this.JackDaniels.TabIndex = 4;
            this.JackDaniels.Text = "Jack Daniels";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(550, 111);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(196, 150);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Surprise
            // 
            this.Surprise.Location = new System.Drawing.Point(140, 111);
            this.Surprise.Name = "Surprise";
            this.Surprise.Size = new System.Drawing.Size(199, 150);
            this.Surprise.TabIndex = 1;
            this.Surprise.Text = "Surprise";
            this.Surprise.UseVisualStyleBackColor = true;
            this.Surprise.Click += new System.EventHandler(this.Surprise_Click);
            // 
            // FirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 588);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.JackDaniels);
            this.Controls.Add(this.JohnnyWalker);
            this.Controls.Add(this.CocaCola);
            this.Controls.Add(this.Surprise);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FirstProgram";
            this.Text = "FirstDesktopProgramm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstProgram_FormClosing);
            this.Load += new System.EventHandler(this.FirstProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CocaCola;
        private System.Windows.Forms.Label JohnnyWalker;
        private System.Windows.Forms.Label JackDaniels;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Surprise;
    }
}

