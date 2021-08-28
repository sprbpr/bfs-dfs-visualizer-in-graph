namespace BFSDFSVisualizer
{
    partial class ThirdPage
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
            this.Start = new System.Windows.Forms.Label();
            this.StartText = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(300, 283);
            this.Start.MinimumSize = new System.Drawing.Size(200, 100);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(215, 100);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start at:";
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartText
            // 
            this.StartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartText.Location = new System.Drawing.Point(600, 300);
            this.StartText.MinimumSize = new System.Drawing.Size(200, 100);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(200, 68);
            this.StartText.TabIndex = 4;
            this.StartText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(300, 500);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(600, 100);
            this.Go.TabIndex = 5;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(200, 100);
            this.Title.MinimumSize = new System.Drawing.Size(800, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 100);
            this.Title.TabIndex = 6;
            this.Title.Text = "Which Node is First?";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThirdPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.StartText);
            this.Controls.Add(this.Start);
            this.Name = "ThirdPage";
            this.Text = "BFS & DFS Visualizer";
            this.Load += new System.EventHandler(this.ThirdPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;       // The title of the third page.
        private System.Windows.Forms.Label Start;       // The start as label.
        private System.Windows.Forms.TextBox StartText; // The input text of the start at label.
        private System.Windows.Forms.Button Go;         // The go button.
    }
}