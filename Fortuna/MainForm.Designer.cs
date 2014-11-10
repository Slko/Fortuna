namespace Fortuna
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusDescriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateDataCheckBox = new System.Windows.Forms.CheckBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.updatePeriodLabel = new System.Windows.Forms.Label();
            this.updatePeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.msLabel = new System.Windows.Forms.Label();
            this.betsGridView = new System.Windows.Forms.DataGridView();
            this.numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDescriptionLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.gameProgressBar = new System.Windows.Forms.ProgressBar();
            this.updateProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.updatePeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDescriptionLabel
            // 
            this.statusDescriptionLabel.AutoSize = true;
            this.statusDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.statusDescriptionLabel.Name = "statusDescriptionLabel";
            this.statusDescriptionLabel.Size = new System.Drawing.Size(64, 13);
            this.statusDescriptionLabel.TabIndex = 0;
            this.statusDescriptionLabel.Text = "Состояние:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(137, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(79, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Не подключен";
            // 
            // updateDataCheckBox
            // 
            this.updateDataCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateDataCheckBox.AutoSize = true;
            this.updateDataCheckBox.Checked = true;
            this.updateDataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateDataCheckBox.Location = new System.Drawing.Point(304, 333);
            this.updateDataCheckBox.Name = "updateDataCheckBox";
            this.updateDataCheckBox.Size = new System.Drawing.Size(149, 17);
            this.updateDataCheckBox.TabIndex = 2;
            this.updateDataCheckBox.Text = "Получать новые данные";
            this.updateDataCheckBox.UseVisualStyleBackColor = true;
            this.updateDataCheckBox.CheckedChanged += new System.EventHandler(this.updateDataCheckBox_CheckedChanged);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // updatePeriodLabel
            // 
            this.updatePeriodLabel.AutoSize = true;
            this.updatePeriodLabel.Location = new System.Drawing.Point(12, 31);
            this.updatePeriodLabel.Name = "updatePeriodLabel";
            this.updatePeriodLabel.Size = new System.Drawing.Size(122, 13);
            this.updatePeriodLabel.TabIndex = 3;
            this.updatePeriodLabel.Text = "Интервал обновления:";
            // 
            // updatePeriodNumericUpDown
            // 
            this.updatePeriodNumericUpDown.Location = new System.Drawing.Point(140, 29);
            this.updatePeriodNumericUpDown.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.updatePeriodNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.updatePeriodNumericUpDown.Name = "updatePeriodNumericUpDown";
            this.updatePeriodNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.updatePeriodNumericUpDown.TabIndex = 4;
            this.updatePeriodNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updatePeriodNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updatePeriodNumericUpDown.ValueChanged += new System.EventHandler(this.updatePeriodNumericUpDown_ValueChanged);
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(200, 31);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(21, 13);
            this.msLabel.TabIndex = 5;
            this.msLabel.Text = "мс";
            // 
            // betsGridView
            // 
            this.betsGridView.AllowUserToAddRows = false;
            this.betsGridView.AllowUserToDeleteRows = false;
            this.betsGridView.AllowUserToResizeColumns = false;
            this.betsGridView.AllowUserToResizeRows = false;
            this.betsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.betsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numbers,
            this.Bets});
            this.betsGridView.Location = new System.Drawing.Point(12, 69);
            this.betsGridView.MultiSelect = false;
            this.betsGridView.Name = "betsGridView";
            this.betsGridView.ReadOnly = true;
            this.betsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.betsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.betsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.betsGridView.Size = new System.Drawing.Size(441, 229);
            this.betsGridView.TabIndex = 6;
            // 
            // numbers
            // 
            this.numbers.HeaderText = "Сектор";
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            // 
            // Bets
            // 
            this.Bets.HeaderText = "Ставка";
            this.Bets.Name = "Bets";
            this.Bets.ReadOnly = true;
            // 
            // roundDescriptionLabel
            // 
            this.roundDescriptionLabel.AutoSize = true;
            this.roundDescriptionLabel.Location = new System.Drawing.Point(12, 53);
            this.roundDescriptionLabel.Name = "roundDescriptionLabel";
            this.roundDescriptionLabel.Size = new System.Drawing.Size(43, 13);
            this.roundDescriptionLabel.TabIndex = 7;
            this.roundDescriptionLabel.Text = "Тираж:";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(61, 53);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(27, 13);
            this.roundLabel.TabIndex = 8;
            this.roundLabel.Text = "N/A";
            // 
            // gameProgressBar
            // 
            this.gameProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameProgressBar.Location = new System.Drawing.Point(15, 303);
            this.gameProgressBar.Name = "gameProgressBar";
            this.gameProgressBar.Size = new System.Drawing.Size(438, 23);
            this.gameProgressBar.Step = 1;
            this.gameProgressBar.TabIndex = 9;
            // 
            // updateProgressBarTimer
            // 
            this.updateProgressBarTimer.Enabled = true;
            this.updateProgressBarTimer.Interval = 1000;
            this.updateProgressBarTimer.Tick += new System.EventHandler(this.updateProgressBarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 359);
            this.Controls.Add(this.gameProgressBar);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.roundDescriptionLabel);
            this.Controls.Add(this.betsGridView);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.updatePeriodNumericUpDown);
            this.Controls.Add(this.updatePeriodLabel);
            this.Controls.Add(this.updateDataCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusDescriptionLabel);
            this.Name = "MainForm";
            this.Text = "Fortuna";
            ((System.ComponentModel.ISupportInitialize)(this.updatePeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusDescriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox updateDataCheckBox;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label updatePeriodLabel;
        private System.Windows.Forms.NumericUpDown updatePeriodNumericUpDown;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.DataGridView betsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bets;
        private System.Windows.Forms.Label roundDescriptionLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ProgressBar gameProgressBar;
        private System.Windows.Forms.Timer updateProgressBarTimer;
    }
}

