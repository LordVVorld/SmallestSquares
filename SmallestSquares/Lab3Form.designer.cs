
namespace SmallestSquares
{
    partial class Lab3Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lab0Menu = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointsGrid = new System.Windows.Forms.DataGridView();
            this.xCords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yCords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.импортироватьТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнаяГенерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab0Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lab0Menu
            // 
            this.lab0Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchButton,
            this.импортироватьТочкиToolStripMenuItem,
            this.exitButton});
            this.lab0Menu.Location = new System.Drawing.Point(0, 0);
            this.lab0Menu.Name = "lab0Menu";
            this.lab0Menu.Size = new System.Drawing.Size(1073, 24);
            this.lab0Menu.TabIndex = 11;
            // 
            // launchButton
            // 
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(57, 20);
            this.launchButton.Text = "Запуск";
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 20);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.CloseButton_click);
            // 
            // formulaeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.formulaeChart.ChartAreas.Add(chartArea1);
            this.formulaeChart.Location = new System.Drawing.Point(215, 27);
            this.formulaeChart.Name = "formulaeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Points";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Line";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "SqrLine";
            this.formulaeChart.Series.Add(series1);
            this.formulaeChart.Series.Add(series2);
            this.formulaeChart.Series.Add(series3);
            this.formulaeChart.Size = new System.Drawing.Size(846, 329);
            this.formulaeChart.TabIndex = 12;
            // 
            // pointsGrid
            // 
            this.pointsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCords,
            this.yCords});
            this.pointsGrid.Location = new System.Drawing.Point(12, 27);
            this.pointsGrid.Name = "pointsGrid";
            this.pointsGrid.Size = new System.Drawing.Size(193, 130);
            this.pointsGrid.TabIndex = 13;
            // 
            // xCords
            // 
            this.xCords.HeaderText = "x";
            this.xCords.Name = "xCords";
            this.xCords.Width = 75;
            // 
            // yCords
            // 
            this.yCords.HeaderText = "y";
            this.yCords.Name = "yCords";
            this.yCords.Width = 75;
            // 
            // импортироватьТочкиToolStripMenuItem
            // 
            this.импортироватьТочкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleSheetsToolStripMenuItem,
            this.mSExcelToolStripMenuItem,
            this.случайнаяГенерацияToolStripMenuItem});
            this.импортироватьТочкиToolStripMenuItem.Name = "импортироватьТочкиToolStripMenuItem";
            this.импортироватьТочкиToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.импортироватьТочкиToolStripMenuItem.Text = "Импортировать точки";
            // 
            // googleSheetsToolStripMenuItem
            // 
            this.googleSheetsToolStripMenuItem.Name = "googleSheetsToolStripMenuItem";
            this.googleSheetsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.googleSheetsToolStripMenuItem.Text = "Google Sheets";
            // 
            // mSExcelToolStripMenuItem
            // 
            this.mSExcelToolStripMenuItem.Name = "mSExcelToolStripMenuItem";
            this.mSExcelToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.mSExcelToolStripMenuItem.Text = "MS Excel";
            // 
            // случайнаяГенерацияToolStripMenuItem
            // 
            this.случайнаяГенерацияToolStripMenuItem.Name = "случайнаяГенерацияToolStripMenuItem";
            this.случайнаяГенерацияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.случайнаяГенерацияToolStripMenuItem.Text = "Случайная генерация";
            // 
            // Lab3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 361);
            this.Controls.Add(this.pointsGrid);
            this.Controls.Add(this.formulaeChart);
            this.Controls.Add(this.lab0Menu);
            this.MainMenuStrip = this.lab0Menu;
            this.Name = "Lab3Form";
            this.Text = "Наименьшие квадраты";
            this.lab0Menu.ResumeLayout(false);
            this.lab0Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip lab0Menu;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart formulaeChart;
        private System.Windows.Forms.DataGridView pointsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCords;
        private System.Windows.Forms.DataGridViewTextBoxColumn yCords;
        private System.Windows.Forms.ToolStripMenuItem импортироватьТочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайнаяГенерацияToolStripMenuItem;
    }
}

