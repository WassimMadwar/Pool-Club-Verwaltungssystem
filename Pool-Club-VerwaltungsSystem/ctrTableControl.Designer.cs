namespace PoolClub
{
    partial class ctrTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_Table = new System.Windows.Forms.GroupBox();
            this.rb_Billiard = new System.Windows.Forms.RadioButton();
            this.rb_Snooker = new System.Windows.Forms.RadioButton();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.pa_TableArt = new System.Windows.Forms.Panel();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grp_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Table
            // 
            this.grp_Table.BackColor = System.Drawing.Color.MintCream;
            this.grp_Table.Controls.Add(this.rb_Billiard);
            this.grp_Table.Controls.Add(this.rb_Snooker);
            this.grp_Table.Controls.Add(this.lbl_Time);
            this.grp_Table.Controls.Add(this.pa_TableArt);
            this.grp_Table.Controls.Add(this.btn_End);
            this.grp_Table.Controls.Add(this.btn_StartStop);
            this.grp_Table.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Table.ForeColor = System.Drawing.Color.Black;
            this.grp_Table.Location = new System.Drawing.Point(3, 3);
            this.grp_Table.Name = "grp_Table";
            this.grp_Table.Size = new System.Drawing.Size(371, 277);
            this.grp_Table.TabIndex = 7;
            this.grp_Table.TabStop = false;
            this.grp_Table.Text = "Tabel 1";
            // 
            // rb_Billiard
            // 
            this.rb_Billiard.AutoSize = true;
            this.rb_Billiard.ForeColor = System.Drawing.Color.Black;
            this.rb_Billiard.Location = new System.Drawing.Point(254, 61);
            this.rb_Billiard.Name = "rb_Billiard";
            this.rb_Billiard.Size = new System.Drawing.Size(121, 33);
            this.rb_Billiard.TabIndex = 11;
            this.rb_Billiard.TabStop = true;
            this.rb_Billiard.Text = "Billiard";
            this.rb_Billiard.UseVisualStyleBackColor = true;
            this.rb_Billiard.CheckedChanged += new System.EventHandler(this.rb_Billiard_CheckedChanged);
            // 
            // rb_Snooker
            // 
            this.rb_Snooker.AutoSize = true;
            this.rb_Snooker.ForeColor = System.Drawing.Color.Black;
            this.rb_Snooker.Location = new System.Drawing.Point(254, 25);
            this.rb_Snooker.Name = "rb_Snooker";
            this.rb_Snooker.Size = new System.Drawing.Size(136, 33);
            this.rb_Snooker.TabIndex = 10;
            this.rb_Snooker.TabStop = true;
            this.rb_Snooker.Text = "Snooker";
            this.rb_Snooker.UseVisualStyleBackColor = true;
            this.rb_Snooker.CheckedChanged += new System.EventHandler(this.rb_Snooker_CheckedChanged);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Time.ForeColor = System.Drawing.Color.Black;
            this.lbl_Time.Location = new System.Drawing.Point(65, 219);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(134, 51);
            this.lbl_Time.TabIndex = 9;
            this.lbl_Time.Text = "00:00:00";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pa_TableArt
            // 
            this.pa_TableArt.BackgroundImage = global::PoolClub.Properties.Resources.TableEmpty;
            this.pa_TableArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pa_TableArt.Location = new System.Drawing.Point(10, 25);
            this.pa_TableArt.Name = "pa_TableArt";
            this.pa_TableArt.Size = new System.Drawing.Size(231, 187);
            this.pa_TableArt.TabIndex = 6;
            // 
            // btn_End
            // 
            this.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_End.ForeColor = System.Drawing.Color.Black;
            this.btn_End.Location = new System.Drawing.Point(254, 174);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(106, 38);
            this.btn_End.TabIndex = 8;
            this.btn_End.Text = "End";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_StartStop.ForeColor = System.Drawing.Color.Black;
            this.btn_StartStop.Location = new System.Drawing.Point(254, 114);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(106, 38);
            this.btn_StartStop.TabIndex = 7;
            this.btn_StartStop.Text = "Start";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.grp_Table);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrTableControl";
            this.Size = new System.Drawing.Size(377, 283);
            this.Load += new System.EventHandler(this.ctrTableControl_Load);
            this.grp_Table.ResumeLayout(false);
            this.grp_Table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Table;
        private System.Windows.Forms.RadioButton rb_Billiard;
        private System.Windows.Forms.RadioButton rb_Snooker;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Panel pa_TableArt;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.Timer timer1;
    }
}
