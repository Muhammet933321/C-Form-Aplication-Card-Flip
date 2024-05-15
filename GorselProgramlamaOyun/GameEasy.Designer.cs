namespace GorselProgramlamaOyun
{
    partial class GameEasy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            TimeTxt = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(436, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 85);
            button1.TabIndex = 0;
            button1.Text = "MainMenu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 119);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Time : ";
            // 
            // TimeTxt
            // 
            TimeTxt.AutoSize = true;
            TimeTxt.Location = new Point(495, 119);
            TimeTxt.Name = "TimeTxt";
            TimeTxt.Size = new Size(17, 20);
            TimeTxt.TabIndex = 2;
            TimeTxt.Text = "0";
            // 
            // GameEasy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 383);
            Controls.Add(TimeTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "GameEasy";
            Text = "GameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer GameTimer;
        private Label label1;
        private Label TimeTxt;
    }
}
