namespace Polling
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.picComm = new System.Windows.Forms.PictureBox();
            this.chkComm = new System.Windows.Forms.CheckBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timLampOff = new System.Windows.Forms.Timer(this.components);
            this.timCommMon = new System.Windows.Forms.Timer(this.components);
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "포트번호";
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(415, 27);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(87, 21);
            this.txtPortNum.TabIndex = 12;
            this.txtPortNum.Text = "5";
            // 
            // picComm
            // 
            this.picComm.Image = global::Polling.Properties.Resources.LampOff;
            this.picComm.Location = new System.Drawing.Point(515, 33);
            this.picComm.Name = "picComm";
            this.picComm.Size = new System.Drawing.Size(10, 10);
            this.picComm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picComm.TabIndex = 13;
            this.picComm.TabStop = false;
            // 
            // chkComm
            // 
            this.chkComm.AutoSize = true;
            this.chkComm.Location = new System.Drawing.Point(417, 54);
            this.chkComm.Name = "chkComm";
            this.chkComm.Size = new System.Drawing.Size(72, 16);
            this.chkComm.TabIndex = 14;
            this.chkComm.Text = "통신실행";
            this.chkComm.UseVisualStyleBackColor = true;
            this.chkComm.CheckedChanged += new System.EventHandler(this.chkComm_CheckedChanged);
            // 
            // timLampOff
            // 
            this.timLampOff.Enabled = true;
            this.timLampOff.Tick += new System.EventHandler(this.timLampOff_Tick);
            // 
            // timCommMon
            // 
            this.timCommMon.Enabled = true;
            this.timCommMon.Interval = 50;
            this.timCommMon.Tick += new System.EventHandler(this.timCommMon_Tick);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(15, 261);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(338, 21);
            this.txtSend.TabIndex = 16;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(391, 210);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(134, 72);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtDialog
            // 
            this.txtDialog.Location = new System.Drawing.Point(15, 12);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDialog.Size = new System.Drawing.Size(338, 243);
            this.txtDialog.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(391, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 43);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 381);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.chkComm);
            this.Controls.Add(this.picComm);
            this.Controls.Add(this.txtPortNum);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.PictureBox picComm;
        private System.Windows.Forms.CheckBox chkComm;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timLampOff;
        private System.Windows.Forms.Timer timCommMon;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Button btnReset;
    }
}

