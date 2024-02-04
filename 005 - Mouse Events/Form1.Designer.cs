
namespace _005___Mouse_Events
{
    partial class Form1
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
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblCoords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(130, 35);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(502, 136);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome User";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcomeUser.Click += new System.EventHandler(this.lblWelcomeUser_Click);
            this.lblWelcomeUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblWelcomeUser_MouseClick);
            this.lblWelcomeUser.MouseEnter += new System.EventHandler(this.lblWelcomeUser_MouseEnter);
            this.lblWelcomeUser.MouseLeave += new System.EventHandler(this.lblWelcomeUser_MouseLeave);
            this.lblWelcomeUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblWelcomeUser_MouseMove);
            // 
            // lblResponse
            // 
            this.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(127, 228);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(505, 98);
            this.lblResponse.TabIndex = 1;
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoords
            // 
            this.lblCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoords.Location = new System.Drawing.Point(295, 9);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(185, 23);
            this.lblCoords.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCoords);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblWelcomeUser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblCoords;
    }
}

