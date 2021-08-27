namespace BFSDFSVisualizer
{
    partial class FirstPage
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
            this.Node = new System.Windows.Forms.Label();
            this.NodeText = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Node
            // 
            this.Node.AutoSize = true;
            this.Node.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Node.Location = new System.Drawing.Point(300, 283);
            this.Node.MinimumSize = new System.Drawing.Size(200, 100);
            this.Node.Name = "Node";
            this.Node.Size = new System.Drawing.Size(200, 100);
            this.Node.TabIndex = 0;
            this.Node.Text = "Node:";
            this.Node.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NodeText
            // 
            this.NodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodeText.Location = new System.Drawing.Point(600, 300);
            this.NodeText.MinimumSize = new System.Drawing.Size(200, 100);
            this.NodeText.Name = "NodeText";
            this.NodeText.Size = new System.Drawing.Size(200, 68);
            this.NodeText.TabIndex = 2;
            this.NodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(300, 500);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(600, 100);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(200, 100);
            this.Title.MinimumSize = new System.Drawing.Size(800, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 100);
            this.Title.TabIndex = 5;
            this.Title.Text = "Write Node\'s Number";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.NodeText);
            this.Controls.Add(this.Node);
            this.Name = "FirstPage";
            this.Text = "Discrete Mathematics Project";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;       // The title of the first page.
        private System.Windows.Forms.Label Node;        // The label of the node.
        private System.Windows.Forms.TextBox NodeText;  // The input text of the node.
        private System.Windows.Forms.Button Next;       // The next button.
    }
}

