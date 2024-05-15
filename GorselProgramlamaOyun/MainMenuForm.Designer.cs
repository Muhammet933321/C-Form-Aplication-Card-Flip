namespace GorselProgramlamaOyun
{
    partial class MainMenuForm
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
            PlayEasyBtn = new Button();
            ExitBtn = new Button();
            PlayMideumBtn = new Button();
            PlayHardBtn = new Button();
            SuspendLayout();
            // 
            // PlayEasyBtn
            // 
            PlayEasyBtn.Location = new Point(12, 108);
            PlayEasyBtn.Name = "PlayEasyBtn";
            PlayEasyBtn.Size = new Size(113, 40);
            PlayEasyBtn.TabIndex = 0;
            PlayEasyBtn.Text = "Play Easy";
            PlayEasyBtn.UseVisualStyleBackColor = true;
            PlayEasyBtn.Click += PlayEasyBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(166, 232);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(113, 40);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // PlayMideumBtn
            // 
            PlayMideumBtn.Location = new Point(166, 108);
            PlayMideumBtn.Name = "PlayMideumBtn";
            PlayMideumBtn.Size = new Size(113, 40);
            PlayMideumBtn.TabIndex = 3;
            PlayMideumBtn.Text = "Play Mideum";
            PlayMideumBtn.UseVisualStyleBackColor = true;
            PlayMideumBtn.Click += PlayMideumBtn_Click;
            // 
            // PlayHardBtn
            // 
            PlayHardBtn.Location = new Point(327, 108);
            PlayHardBtn.Name = "PlayHardBtn";
            PlayHardBtn.Size = new Size(113, 40);
            PlayHardBtn.TabIndex = 4;
            PlayHardBtn.Text = "Play Hard";
            PlayHardBtn.UseVisualStyleBackColor = true;
            PlayHardBtn.Click += PlayHardBtn_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 443);
            Controls.Add(PlayHardBtn);
            Controls.Add(PlayMideumBtn);
            Controls.Add(ExitBtn);
            Controls.Add(PlayEasyBtn);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button PlayEasyBtn;
        private Button ExitBtn;
        private Button PlayMideumBtn;
        private Button PlayHardBtn;
    }
}