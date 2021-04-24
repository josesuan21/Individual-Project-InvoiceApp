namespace Invoice_Application_Project
{
	partial class StatisticReport_Form
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticReport_Form));
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.serviceNameTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.label_Statistics = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.popularAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label_PopularAreas = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.incomeCurrentYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceName_TotalTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.ServiceName_TotalTableAdapter();
			this.popular_AreaTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.Popular_AreaTableAdapter();
			this.income_CurrentYearTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.Income_CurrentYearTableAdapter();
			this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.loyalCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.loyalCustomersTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.LoyalCustomersTableAdapter();
			this.panel_MostUsedService = new System.Windows.Forms.Panel();
			this.panel_PopularAreas = new System.Windows.Forms.Panel();
			this.panel_LolayCustomers = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel_Income = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceNameTotalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popularAreaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeCurrentYearBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loyalCustomersBindingSource)).BeginInit();
			this.panel_MostUsedService.SuspendLayout();
			this.panel_PopularAreas.SuspendLayout();
			this.panel_LolayCustomers.SuspendLayout();
			this.panel_Income.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart1.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
			this.chart1.BorderlineWidth = 0;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.DataSource = this.serviceNameTotalBindingSource;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(4, 30);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 0;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series1.XValueMember = "serviceName";
			series1.YValueMembers = "Total Service Used";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(351, 299);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// serviceNameTotalBindingSource
			// 
			this.serviceNameTotalBindingSource.DataMember = "ServiceName_Total";
			this.serviceNameTotalBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label_Statistics
			// 
			this.label_Statistics.AutoSize = true;
			this.label_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Statistics.Location = new System.Drawing.Point(0, 0);
			this.label_Statistics.Name = "label_Statistics";
			this.label_Statistics.Size = new System.Drawing.Size(174, 25);
			this.label_Statistics.TabIndex = 1;
			this.label_Statistics.Text = "Statistic Report";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Most Used Services";
			// 
			// chart2
			// 
			this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			this.chart2.DataSource = this.popularAreaBindingSource;
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(4, 27);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series2.Legend = "Legend1";
			series2.Name = "PostCode";
			series2.XValueMember = "postCode";
			series2.YValueMembers = "Total";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(363, 299);
			this.chart2.TabIndex = 3;
			this.chart2.Text = "chart2";
			// 
			// popularAreaBindingSource
			// 
			this.popularAreaBindingSource.DataMember = "Popular_Area";
			this.popularAreaBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// label_PopularAreas
			// 
			this.label_PopularAreas.AutoSize = true;
			this.label_PopularAreas.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_PopularAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_PopularAreas.Location = new System.Drawing.Point(0, 0);
			this.label_PopularAreas.Name = "label_PopularAreas";
			this.label_PopularAreas.Size = new System.Drawing.Size(142, 24);
			this.label_PopularAreas.TabIndex = 4;
			this.label_PopularAreas.Text = "Popular Areas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Current Yearly Income";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Loyal Customers";
			// 
			// chart3
			// 
			this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			this.chart3.DataSource = this.incomeCurrentYearBindingSource;
			legend3.Name = "Legend1";
			this.chart3.Legends.Add(legend3);
			this.chart3.Location = new System.Drawing.Point(4, 24);
			this.chart3.Name = "chart3";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Legend = "Legend1";
			series3.Name = "Income";
			series3.XValueMember = "date";
			series3.YValueMembers = "Total Income";
			this.chart3.Series.Add(series3);
			this.chart3.Size = new System.Drawing.Size(1088, 226);
			this.chart3.TabIndex = 9;
			this.chart3.Text = "chart3";
			// 
			// incomeCurrentYearBindingSource
			// 
			this.incomeCurrentYearBindingSource.DataMember = "Income_CurrentYear";
			this.incomeCurrentYearBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// serviceName_TotalTableAdapter
			// 
			this.serviceName_TotalTableAdapter.ClearBeforeFill = true;
			// 
			// popular_AreaTableAdapter
			// 
			this.popular_AreaTableAdapter.ClearBeforeFill = true;
			// 
			// income_CurrentYearTableAdapter
			// 
			this.income_CurrentYearTableAdapter.ClearBeforeFill = true;
			// 
			// chart4
			// 
			this.chart4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea4.Name = "ChartArea1";
			this.chart4.ChartAreas.Add(chartArea4);
			this.chart4.DataSource = this.loyalCustomersBindingSource;
			legend4.Name = "Legend1";
			this.chart4.Legends.Add(legend4);
			this.chart4.Location = new System.Drawing.Point(4, 24);
			this.chart4.Name = "chart4";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series4.IsValueShownAsLabel = true;
			series4.Legend = "Legend1";
			series4.Name = "Customer(ID)";
			series4.XValueMember = "Customer Name(ID)";
			series4.YValueMembers = "TotalServiceMade";
			this.chart4.Series.Add(series4);
			this.chart4.Size = new System.Drawing.Size(347, 305);
			this.chart4.TabIndex = 10;
			this.chart4.Text = "chart4";
			// 
			// loyalCustomersBindingSource
			// 
			this.loyalCustomersBindingSource.DataMember = "LoyalCustomers";
			this.loyalCustomersBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// loyalCustomersTableAdapter
			// 
			this.loyalCustomersTableAdapter.ClearBeforeFill = true;
			// 
			// panel_MostUsedService
			// 
			this.panel_MostUsedService.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel_MostUsedService.Controls.Add(this.chart1);
			this.panel_MostUsedService.Controls.Add(this.label1);
			this.panel_MostUsedService.Location = new System.Drawing.Point(43, 40);
			this.panel_MostUsedService.Name = "panel_MostUsedService";
			this.panel_MostUsedService.Size = new System.Drawing.Size(358, 339);
			this.panel_MostUsedService.TabIndex = 11;
			// 
			// panel_PopularAreas
			// 
			this.panel_PopularAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_PopularAreas.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel_PopularAreas.Controls.Add(this.label_PopularAreas);
			this.panel_PopularAreas.Controls.Add(this.chart2);
			this.panel_PopularAreas.Location = new System.Drawing.Point(408, 40);
			this.panel_PopularAreas.Name = "panel_PopularAreas";
			this.panel_PopularAreas.Size = new System.Drawing.Size(370, 339);
			this.panel_PopularAreas.TabIndex = 12;
			// 
			// panel_LolayCustomers
			// 
			this.panel_LolayCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_LolayCustomers.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel_LolayCustomers.Controls.Add(this.label2);
			this.panel_LolayCustomers.Controls.Add(this.chart4);
			this.panel_LolayCustomers.Controls.Add(this.label4);
			this.panel_LolayCustomers.Location = new System.Drawing.Point(784, 40);
			this.panel_LolayCustomers.Name = "panel_LolayCustomers";
			this.panel_LolayCustomers.Size = new System.Drawing.Size(354, 339);
			this.panel_LolayCustomers.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(282, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Name (ID)";
			// 
			// panel_Income
			// 
			this.panel_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_Income.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel_Income.Controls.Add(this.chart3);
			this.panel_Income.Controls.Add(this.label3);
			this.panel_Income.Location = new System.Drawing.Point(43, 394);
			this.panel_Income.Name = "panel_Income";
			this.panel_Income.Size = new System.Drawing.Size(1095, 256);
			this.panel_Income.TabIndex = 14;
			// 
			// StatisticReport_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1184, 656);
			this.Controls.Add(this.panel_Income);
			this.Controls.Add(this.panel_LolayCustomers);
			this.Controls.Add(this.panel_PopularAreas);
			this.Controls.Add(this.panel_MostUsedService);
			this.Controls.Add(this.label_Statistics);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1200, 695);
			this.Name = "StatisticReport_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistic Report";
			this.Load += new System.EventHandler(this.StatisticReport_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceNameTotalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popularAreaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeCurrentYearBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loyalCustomersBindingSource)).EndInit();
			this.panel_MostUsedService.ResumeLayout(false);
			this.panel_MostUsedService.PerformLayout();
			this.panel_PopularAreas.ResumeLayout(false);
			this.panel_PopularAreas.PerformLayout();
			this.panel_LolayCustomers.ResumeLayout(false);
			this.panel_LolayCustomers.PerformLayout();
			this.panel_Income.ResumeLayout(false);
			this.panel_Income.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource serviceNameTotalBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.ServiceName_TotalTableAdapter serviceName_TotalTableAdapter;
		private System.Windows.Forms.Label label_Statistics;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.BindingSource popularAreaBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.Popular_AreaTableAdapter popular_AreaTableAdapter;
		private System.Windows.Forms.Label label_PopularAreas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.BindingSource incomeCurrentYearBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.Income_CurrentYearTableAdapter income_CurrentYearTableAdapter;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
		private System.Windows.Forms.BindingSource loyalCustomersBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.LoyalCustomersTableAdapter loyalCustomersTableAdapter;
		private System.Windows.Forms.Panel panel_MostUsedService;
		private System.Windows.Forms.Panel panel_PopularAreas;
		private System.Windows.Forms.Panel panel_LolayCustomers;
		private System.Windows.Forms.Panel panel_Income;
		private System.Windows.Forms.Label label2;
	}
}