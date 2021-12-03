namespace TimeCalculator
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
            this.listView = new System.Windows.Forms.ListView();
            this.dateText = new System.Windows.Forms.Label();
            this.inputHourStart = new System.Windows.Forms.TextBox();
            this.inputMinStart = new System.Windows.Forms.TextBox();
            this.timeColon1 = new System.Windows.Forms.Label();
            this.timeText1 = new System.Windows.Forms.Label();
            this.inputHourEnd = new System.Windows.Forms.TextBox();
            this.inputMinEnd = new System.Windows.Forms.TextBox();
            this.timeColon2 = new System.Windows.Forms.Label();
            this.timeText2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.label_total_text = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(202, 327);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(248, 43);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(31, 15);
            this.dateText.TabIndex = 4;
            this.dateText.Text = "Day:";
            // 
            // inputHourStart
            // 
            this.inputHourStart.Location = new System.Drawing.Point(250, 138);
            this.inputHourStart.MaxLength = 2;
            this.inputHourStart.Name = "inputHourStart";
            this.inputHourStart.Size = new System.Drawing.Size(24, 20);
            this.inputHourStart.TabIndex = 1;
            this.inputHourStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputMinStart
            // 
            this.inputMinStart.Location = new System.Drawing.Point(296, 138);
            this.inputMinStart.MaxLength = 2;
            this.inputMinStart.Name = "inputMinStart";
            this.inputMinStart.Size = new System.Drawing.Size(24, 20);
            this.inputMinStart.TabIndex = 2;
            this.inputMinStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeColon1
            // 
            this.timeColon1.AutoSize = true;
            this.timeColon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeColon1.Location = new System.Drawing.Point(280, 139);
            this.timeColon1.Name = "timeColon1";
            this.timeColon1.Size = new System.Drawing.Size(10, 15);
            this.timeColon1.TabIndex = 7;
            this.timeColon1.Text = ":";
            this.timeColon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeText1
            // 
            this.timeText1.AutoSize = true;
            this.timeText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText1.Location = new System.Drawing.Point(247, 105);
            this.timeText1.Name = "timeText1";
            this.timeText1.Size = new System.Drawing.Size(54, 30);
            this.timeText1.TabIndex = 8;
            this.timeText1.Text = "Start\r\n(hh:mm)";
            // 
            // inputHourEnd
            // 
            this.inputHourEnd.Location = new System.Drawing.Point(250, 218);
            this.inputHourEnd.MaxLength = 2;
            this.inputHourEnd.Name = "inputHourEnd";
            this.inputHourEnd.Size = new System.Drawing.Size(24, 20);
            this.inputHourEnd.TabIndex = 3;
            this.inputHourEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputMinEnd
            // 
            this.inputMinEnd.Location = new System.Drawing.Point(296, 218);
            this.inputMinEnd.MaxLength = 2;
            this.inputMinEnd.Name = "inputMinEnd";
            this.inputMinEnd.Size = new System.Drawing.Size(24, 20);
            this.inputMinEnd.TabIndex = 4;
            this.inputMinEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeColon2
            // 
            this.timeColon2.AutoSize = true;
            this.timeColon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeColon2.Location = new System.Drawing.Point(280, 219);
            this.timeColon2.Name = "timeColon2";
            this.timeColon2.Size = new System.Drawing.Size(10, 15);
            this.timeColon2.TabIndex = 11;
            this.timeColon2.Text = ":";
            this.timeColon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeText2
            // 
            this.timeText2.AutoSize = true;
            this.timeText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText2.Location = new System.Drawing.Point(247, 185);
            this.timeText2.Name = "timeText2";
            this.timeText2.Size = new System.Drawing.Size(54, 30);
            this.timeText2.TabIndex = 12;
            this.timeText2.Text = "End\r\n(hh:mm)";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(250, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboDay.Location = new System.Drawing.Point(250, 59);
            this.comboDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(80, 21);
            this.comboDay.TabIndex = 0;
            // 
            // label_total_text
            // 
            this.label_total_text.AutoSize = true;
            this.label_total_text.Location = new System.Drawing.Point(12, 342);
            this.label_total_text.Name = "label_total_text";
            this.label_total_text.Size = new System.Drawing.Size(34, 13);
            this.label_total_text.TabIndex = 13;
            this.label_total_text.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(156, 342);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(58, 13);
            this.label_total.TabIndex = 14;
            this.label_total.Text = "0 hrs 0 min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_total_text);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.timeText2);
            this.Controls.Add(this.timeColon2);
            this.Controls.Add(this.inputMinEnd);
            this.Controls.Add(this.inputHourEnd);
            this.Controls.Add(this.timeText1);
            this.Controls.Add(this.timeColon1);
            this.Controls.Add(this.inputMinStart);
            this.Controls.Add(this.inputHourStart);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.TextBox inputHourStart;
        private System.Windows.Forms.TextBox inputMinStart;
        private System.Windows.Forms.Label timeColon1;
        private System.Windows.Forms.Label timeText1;
        private System.Windows.Forms.TextBox inputHourEnd;
        private System.Windows.Forms.TextBox inputMinEnd;
        private System.Windows.Forms.Label timeColon2;
        private System.Windows.Forms.Label timeText2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.Label label_total_text;
        private System.Windows.Forms.Label label_total;
    }
}

