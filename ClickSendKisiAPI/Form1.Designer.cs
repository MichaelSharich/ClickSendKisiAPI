namespace ClickSendKisiAPI
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
            this.btn_GetEvents = new System.Windows.Forms.Button();
            this.LB_Events = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_GetEvents
            // 
            this.btn_GetEvents.Location = new System.Drawing.Point(413, 84);
            this.btn_GetEvents.Name = "btn_GetEvents";
            this.btn_GetEvents.Size = new System.Drawing.Size(163, 66);
            this.btn_GetEvents.TabIndex = 0;
            this.btn_GetEvents.Text = "Get Events";
            this.btn_GetEvents.UseVisualStyleBackColor = true;
            this.btn_GetEvents.Click += new System.EventHandler(this.btn_GetEvents_Click);
            // 
            // LB_Events
            // 
            this.LB_Events.FormattingEnabled = true;
            this.LB_Events.ItemHeight = 20;
            this.LB_Events.Location = new System.Drawing.Point(108, 181);
            this.LB_Events.Name = "LB_Events";
            this.LB_Events.Size = new System.Drawing.Size(794, 324);
            this.LB_Events.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 580);
            this.Controls.Add(this.LB_Events);
            this.Controls.Add(this.btn_GetEvents);
            this.Name = "Form1";
            this.Text = "ClickSendKisiAPI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetEvents;
        private System.Windows.Forms.ListBox LB_Events;
    }
}

