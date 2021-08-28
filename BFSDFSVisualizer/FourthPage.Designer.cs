namespace BFSDFSVisualizer
{
    partial class FourthPage
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
            this.BFS = new System.Windows.Forms.Button();
            this.DFS = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BFS
            // 
            this.BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS.Location = new System.Drawing.Point(300, 300);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(600, 100);
            this.BFS.TabIndex = 6;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // DFS
            // 
            this.DFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS.Location = new System.Drawing.Point(300, 500);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(600, 100);
            this.DFS.TabIndex = 7;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(200, 100);
            this.Title.MinimumSize = new System.Drawing.Size(800, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 100);
            this.Title.TabIndex = 8;
            this.Title.Text = "Choose Algorithm";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FourthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Name = "FourthPage";
            this.Text = "BFS & DFS Visualizer";
            this.Load += new System.EventHandler(this.FourthPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;   // The title of the fourth page.
        private System.Windows.Forms.Button BFS;    // The BFS button.
        private System.Windows.Forms.Button DFS;    // The DFS button.
    }
}