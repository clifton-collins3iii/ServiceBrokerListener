namespace SBTest
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
            this.txtMsgCount = new System.Windows.Forms.TextBox();
            this.btnMsgCountReset = new System.Windows.Forms.Button();
            this.tlayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnectSignalR = new System.Windows.Forms.Button();
            this.lblE911MessageCount = new System.Windows.Forms.Label();
            this.rtfE911Messages = new System.Windows.Forms.RichTextBox();
            this.lblE911Message = new System.Windows.Forms.Label();
            this.txtSignalRServerURL = new System.Windows.Forms.TextBox();
            this.txtSignalRStatus = new System.Windows.Forms.TextBox();
            this.btnDisconnectSignalR = new System.Windows.Forms.Button();
            this.tlayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMsgCount
            // 
            this.txtMsgCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMsgCount.Location = new System.Drawing.Point(83, 39);
            this.txtMsgCount.Name = "txtMsgCount";
            this.txtMsgCount.Size = new System.Drawing.Size(155, 20);
            this.txtMsgCount.TabIndex = 1;
            this.txtMsgCount.Text = "0";
            this.txtMsgCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMsgCountReset
            // 
            this.btnMsgCountReset.Location = new System.Drawing.Point(443, 39);
            this.btnMsgCountReset.Name = "btnMsgCountReset";
            this.btnMsgCountReset.Size = new System.Drawing.Size(130, 24);
            this.btnMsgCountReset.TabIndex = 2;
            this.btnMsgCountReset.Text = "Reset count";
            this.btnMsgCountReset.UseVisualStyleBackColor = true;
            this.btnMsgCountReset.Click += new System.EventHandler(this.btnMsgCountReset_Click);
            // 
            // tlayoutMain
            // 
            this.tlayoutMain.ColumnCount = 3;
            this.tlayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlayoutMain.Controls.Add(this.btnConnectSignalR, 0, 0);
            this.tlayoutMain.Controls.Add(this.lblE911MessageCount, 0, 1);
            this.tlayoutMain.Controls.Add(this.txtMsgCount, 1, 1);
            this.tlayoutMain.Controls.Add(this.rtfE911Messages, 1, 3);
            this.tlayoutMain.Controls.Add(this.btnMsgCountReset, 2, 1);
            this.tlayoutMain.Controls.Add(this.lblE911Message, 0, 3);
            this.tlayoutMain.Controls.Add(this.txtSignalRServerURL, 1, 0);
            this.tlayoutMain.Controls.Add(this.txtSignalRStatus, 2, 0);
            this.tlayoutMain.Controls.Add(this.btnDisconnectSignalR, 0, 4);
            this.tlayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tlayoutMain.Name = "tlayoutMain";
            this.tlayoutMain.RowCount = 5;
            this.tlayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.314104F));
            this.tlayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.59499F));
            this.tlayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlayoutMain.Size = new System.Drawing.Size(800, 450);
            this.tlayoutMain.TabIndex = 4;
            // 
            // btnConnectSignalR
            // 
            this.btnConnectSignalR.Location = new System.Drawing.Point(3, 3);
            this.btnConnectSignalR.Name = "btnConnectSignalR";
            this.btnConnectSignalR.Size = new System.Drawing.Size(74, 24);
            this.btnConnectSignalR.TabIndex = 9;
            this.btnConnectSignalR.Text = "Connect";
            this.btnConnectSignalR.UseVisualStyleBackColor = true;
            this.btnConnectSignalR.Click += new System.EventHandler(this.btnConnectSignalR_Click);
            // 
            // lblE911MessageCount
            // 
            this.lblE911MessageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblE911MessageCount.AutoSize = true;
            this.lblE911MessageCount.Location = new System.Drawing.Point(19, 36);
            this.lblE911MessageCount.Name = "lblE911MessageCount";
            this.lblE911MessageCount.Size = new System.Drawing.Size(58, 26);
            this.lblE911MessageCount.TabIndex = 5;
            this.lblE911MessageCount.Text = "E911 Msg. count";
            this.lblE911MessageCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtfE911Messages
            // 
            this.tlayoutMain.SetColumnSpan(this.rtfE911Messages, 2);
            this.rtfE911Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfE911Messages.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfE911Messages.Location = new System.Drawing.Point(83, 86);
            this.rtfE911Messages.Name = "rtfE911Messages";
            this.rtfE911Messages.Size = new System.Drawing.Size(714, 326);
            this.rtfE911Messages.TabIndex = 0;
            this.rtfE911Messages.Text = "";
            // 
            // lblE911Message
            // 
            this.lblE911Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblE911Message.AutoSize = true;
            this.lblE911Message.Location = new System.Drawing.Point(22, 83);
            this.lblE911Message.Name = "lblE911Message";
            this.lblE911Message.Size = new System.Drawing.Size(55, 26);
            this.lblE911Message.TabIndex = 6;
            this.lblE911Message.Text = "E911 Messages";
            this.lblE911Message.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSignalRServerURL
            // 
            this.txtSignalRServerURL.Location = new System.Drawing.Point(83, 3);
            this.txtSignalRServerURL.Name = "txtSignalRServerURL";
            this.txtSignalRServerURL.Size = new System.Drawing.Size(294, 20);
            this.txtSignalRServerURL.TabIndex = 7;
            this.txtSignalRServerURL.Text = "http://cliftonpc:8008/signalr";
            // 
            // txtSignalRStatus
            // 
            this.txtSignalRStatus.Location = new System.Drawing.Point(443, 3);
            this.txtSignalRStatus.Name = "txtSignalRStatus";
            this.txtSignalRStatus.Size = new System.Drawing.Size(202, 20);
            this.txtSignalRStatus.TabIndex = 8;
            this.txtSignalRStatus.Text = "Unknown";
            // 
            // btnDisconnectSignalR
            // 
            this.btnDisconnectSignalR.Location = new System.Drawing.Point(3, 418);
            this.btnDisconnectSignalR.Name = "btnDisconnectSignalR";
            this.btnDisconnectSignalR.Size = new System.Drawing.Size(74, 24);
            this.btnDisconnectSignalR.TabIndex = 10;
            this.btnDisconnectSignalR.Text = "Disconnect";
            this.btnDisconnectSignalR.UseVisualStyleBackColor = true;
            this.btnDisconnectSignalR.Click += new System.EventHandler(this.btnDisconnectSignalR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlayoutMain);
            this.Name = "Form1";
            this.Text = "Server Broker test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlayoutMain.ResumeLayout(false);
            this.tlayoutMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMsgCountReset;
        private System.Windows.Forms.TableLayoutPanel tlayoutMain;
        private System.Windows.Forms.Label lblE911MessageCount;
        private System.Windows.Forms.RichTextBox rtfE911Messages;
        private System.Windows.Forms.Label lblE911Message;
        public System.Windows.Forms.TextBox txtMsgCount;
        public System.Windows.Forms.TextBox txtSignalRServerURL;
        private System.Windows.Forms.TextBox txtSignalRStatus;
        private System.Windows.Forms.Button btnConnectSignalR;
        private System.Windows.Forms.Button btnDisconnectSignalR;
    }
}

