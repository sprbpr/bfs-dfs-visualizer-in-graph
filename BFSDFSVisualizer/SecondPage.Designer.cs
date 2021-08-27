namespace BFSDFSVisualizer
{
    partial class SecondPage
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
            this.Node1 = new System.Windows.Forms.Label();
            this.Node1Text = new System.Windows.Forms.TextBox();
            this.Node2 = new System.Windows.Forms.Label();
            this.Node2Text = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Node1
            // 
            this.Node1.AutoSize = true;
            this.Node1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Node1.Location = new System.Drawing.Point(300, 283);
            this.Node1.MinimumSize = new System.Drawing.Size(200, 100);
            this.Node1.Name = "Node1";
            this.Node1.Size = new System.Drawing.Size(215, 100);
            this.Node1.TabIndex = 1;
            this.Node1.Text = "Node 1:";
            this.Node1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Node1Text
            // 
            this.Node1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Node1Text.Location = new System.Drawing.Point(600, 300);
            this.Node1Text.MinimumSize = new System.Drawing.Size(200, 100);
            this.Node1Text.Name = "Node1Text";
            this.Node1Text.Size = new System.Drawing.Size(200, 68);
            this.Node1Text.TabIndex = 3;
            this.Node1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Node2
            // 
            this.Node2.AutoSize = true;
            this.Node2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Node2.Location = new System.Drawing.Point(300, 483);
            this.Node2.MinimumSize = new System.Drawing.Size(200, 100);
            this.Node2.Name = "Node2";
            this.Node2.Size = new System.Drawing.Size(215, 100);
            this.Node2.TabIndex = 4;
            this.Node2.Text = "Node 2:";
            this.Node2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Node2Text
            // 
            this.Node2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Node2Text.Location = new System.Drawing.Point(600, 500);
            this.Node2Text.MinimumSize = new System.Drawing.Size(200, 100);
            this.Node2Text.Name = "Node2Text";
            this.Node2Text.Size = new System.Drawing.Size(200, 68);
            this.Node2Text.TabIndex = 5;
            this.Node2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(300, 700);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(600, 100);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(300, 900);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(600, 100);
            this.Go.TabIndex = 7;
            this.Go.Text = "Next";
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
            this.Title.TabIndex = 8;
            this.Title.Text = "Write Connected Nodes";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1129);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Node2Text);
            this.Controls.Add(this.Node2);
            this.Controls.Add(this.Node1Text);
            this.Controls.Add(this.Node1);
            this.Name = "SecondPage";
            this.Text = "Discrete Mathematics Project";
            this.Load += new System.EventHandler(this.SecondPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;       // The title of the second page.
        private System.Windows.Forms.Label Node1;       // The Node1 label.
        private System.Windows.Forms.TextBox Node1Text; // The input text of Node1.
        private System.Windows.Forms.Label Node2;       // The Node2 label.
        private System.Windows.Forms.TextBox Node2Text; // The input text of Node2.
        private System.Windows.Forms.Button Save;       // The save button.
        private System.Windows.Forms.Button Go;         // The next button.
    }
}