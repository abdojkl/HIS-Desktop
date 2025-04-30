
namespace PatientRecordManagement.Dialogs
{
    partial class Frm_Patient_Visits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Patient_Visits));
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chartBlood = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.chartWT = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.diastolic = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.systolic = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.temp = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.weight = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.page_Visit1 = new PatientRecordManagement.Pages.Page_Visit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = true;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = true;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock.DockingOptions.DockLeft = true;
            this.bunifuFormDock.DockingOptions.DockRight = true;
            this.bunifuFormDock.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock.DockingOptions.DockTopRight = true;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // AppBar
            // 
            this.AppBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.AppBar.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.AppBar.ControlBoxColorActive = System.Drawing.Color.White;
            this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBar.ForeColor = System.Drawing.Color.White;
            this.AppBar.Icon = ((System.Drawing.Image)(resources.GetObject("AppBar.Icon")));
            this.AppBar.Location = new System.Drawing.Point(0, 0);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(1300, 46);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "Patient Visits";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.page_Visit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1288, 684);
            this.splitContainer1.SplitterDistance = 840;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chartBlood);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chartWT);
            this.splitContainer2.Size = new System.Drawing.Size(444, 684);
            this.splitContainer2.SplitterDistance = 324;
            this.splitContainer2.TabIndex = 0;
            // 
            // chartBlood
            // 
            this.chartBlood.AnimationDuration = 1000;
            this.chartBlood.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chartBlood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartBlood.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chartBlood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBlood.Labels = null;
            this.chartBlood.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chartBlood.LegendDisplay = true;
            this.chartBlood.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartBlood.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chartBlood.LegendFullWidth = true;
            this.chartBlood.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartBlood.LegendRevese = false;
            this.chartBlood.LegendRTL = false;
            this.chartBlood.Location = new System.Drawing.Point(0, 0);
            this.chartBlood.Name = "chartBlood";
            this.chartBlood.ShowXAxis = true;
            this.chartBlood.ShowYAxis = true;
            this.chartBlood.Size = new System.Drawing.Size(444, 324);
            this.chartBlood.TabIndex = 0;
            this.chartBlood.Title = "Blood Pressure Readings";
            this.chartBlood.TitleLineHeight = 1.2D;
            this.chartBlood.TitlePadding = 10;
            this.chartBlood.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartBlood.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBlood.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBlood.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.chartBlood.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chartBlood.TooltipsEnabled = true;
            this.chartBlood.XAxesBeginAtZero = true;
            this.chartBlood.XAxesDrawTicks = true;
            this.chartBlood.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBlood.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartBlood.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBlood.XAxesGridLines = true;
            this.chartBlood.XAxesLabel = "";
            this.chartBlood.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBlood.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartBlood.XAxesLineWidth = 1;
            this.chartBlood.XAxesStacked = false;
            this.chartBlood.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBlood.XAxesZeroLineWidth = 1;
            this.chartBlood.YAxesBeginAtZero = true;
            this.chartBlood.YAxesDrawTicks = true;
            this.chartBlood.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBlood.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartBlood.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBlood.YAxesGridLines = true;
            this.chartBlood.YAxesLabel = "";
            this.chartBlood.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBlood.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartBlood.YAxesLineWidth = 1;
            this.chartBlood.YAxesStacked = false;
            this.chartBlood.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBlood.YAxesZeroLineWidth = 1;
            // 
            // chartWT
            // 
            this.chartWT.AnimationDuration = 1000;
            this.chartWT.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chartWT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartWT.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chartWT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartWT.Labels = null;
            this.chartWT.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chartWT.LegendDisplay = true;
            this.chartWT.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartWT.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chartWT.LegendFullWidth = true;
            this.chartWT.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartWT.LegendRevese = false;
            this.chartWT.LegendRTL = false;
            this.chartWT.Location = new System.Drawing.Point(0, 0);
            this.chartWT.Name = "chartWT";
            this.chartWT.ShowXAxis = true;
            this.chartWT.ShowYAxis = true;
            this.chartWT.Size = new System.Drawing.Size(444, 356);
            this.chartWT.TabIndex = 1;
            this.chartWT.Title = "Temperature & Weight";
            this.chartWT.TitleLineHeight = 1.2D;
            this.chartWT.TitlePadding = 10;
            this.chartWT.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartWT.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartWT.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartWT.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.chartWT.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chartWT.TooltipsEnabled = true;
            this.chartWT.XAxesBeginAtZero = true;
            this.chartWT.XAxesDrawTicks = true;
            this.chartWT.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartWT.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartWT.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartWT.XAxesGridLines = true;
            this.chartWT.XAxesLabel = "";
            this.chartWT.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartWT.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartWT.XAxesLineWidth = 1;
            this.chartWT.XAxesStacked = false;
            this.chartWT.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartWT.XAxesZeroLineWidth = 1;
            this.chartWT.YAxesBeginAtZero = true;
            this.chartWT.YAxesDrawTicks = true;
            this.chartWT.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartWT.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartWT.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartWT.YAxesGridLines = true;
            this.chartWT.YAxesLabel = "";
            this.chartWT.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartWT.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartWT.YAxesLineWidth = 1;
            this.chartWT.YAxesStacked = false;
            this.chartWT.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartWT.YAxesZeroLineWidth = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // diastolic
            // 
            this.diastolic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.diastolic.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.diastolic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.diastolic.BorderDash = null;
            this.diastolic.BorderDashOffset = 0D;
            this.diastolic.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.diastolic.BorderWidth = 3;
            this.diastolic.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.diastolic.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("diastolic.Data")));
            this.diastolic.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Origin;
            this.diastolic.Label = "Diastolic";
            this.diastolic.LineTension = 0.4D;
            this.diastolic.Order = 0;
            this.diastolic.PointBackgroundColor = System.Drawing.Color.Empty;
            this.diastolic.PointBorderColor = System.Drawing.Color.Empty;
            this.diastolic.PointBorderWidth = 1;
            this.diastolic.PointHitRadius = 1;
            this.diastolic.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.diastolic.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.diastolic.PointHoverBorderWidth = 4;
            this.diastolic.PointHoverRadius = 1;
            this.diastolic.PointRadius = 3;
            this.diastolic.PointRotation = 0;
            this.diastolic.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.diastolic.ShowLine = true;
            this.diastolic.SpanGaps = false;
            this.diastolic.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.diastolic.TargetCanvas = this.chartBlood;
            // 
            // systolic
            // 
            this.systolic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.systolic.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.systolic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(144)))), ((int)(((byte)(30)))));
            this.systolic.BorderDash = null;
            this.systolic.BorderDashOffset = 0D;
            this.systolic.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.systolic.BorderWidth = 3;
            this.systolic.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.systolic.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("systolic.Data")));
            this.systolic.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.systolic.Label = "Systolic";
            this.systolic.LineTension = 0.4D;
            this.systolic.Order = 0;
            this.systolic.PointBackgroundColor = System.Drawing.Color.Empty;
            this.systolic.PointBorderColor = System.Drawing.Color.Empty;
            this.systolic.PointBorderWidth = 1;
            this.systolic.PointHitRadius = 1;
            this.systolic.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.systolic.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.systolic.PointHoverBorderWidth = 4;
            this.systolic.PointHoverRadius = 1;
            this.systolic.PointRadius = 3;
            this.systolic.PointRotation = 0;
            this.systolic.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.systolic.ShowLine = true;
            this.systolic.SpanGaps = false;
            this.systolic.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.systolic.TargetCanvas = this.chartBlood;
            // 
            // temp
            // 
            this.temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.temp.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.temp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(144)))), ((int)(((byte)(30)))));
            this.temp.BorderDash = null;
            this.temp.BorderDashOffset = 0D;
            this.temp.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.temp.BorderWidth = 3;
            this.temp.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.temp.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("temp.Data")));
            this.temp.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Origin;
            this.temp.Label = "Temp (C)";
            this.temp.LineTension = 0.4D;
            this.temp.Order = 0;
            this.temp.PointBackgroundColor = System.Drawing.Color.Empty;
            this.temp.PointBorderColor = System.Drawing.Color.Empty;
            this.temp.PointBorderWidth = 1;
            this.temp.PointHitRadius = 1;
            this.temp.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.temp.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.temp.PointHoverBorderWidth = 4;
            this.temp.PointHoverRadius = 1;
            this.temp.PointRadius = 3;
            this.temp.PointRotation = 0;
            this.temp.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.temp.ShowLine = true;
            this.temp.SpanGaps = false;
            this.temp.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.temp.TargetCanvas = this.chartWT;
            // 
            // weight
            // 
            this.weight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(144)))), ((int)(((byte)(30)))));
            this.weight.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.weight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.weight.BorderDash = null;
            this.weight.BorderDashOffset = 0D;
            this.weight.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.weight.BorderWidth = 3;
            this.weight.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.weight.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("weight.Data")));
            this.weight.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.weight.Label = "Weight (Kg)";
            this.weight.LineTension = 0.4D;
            this.weight.Order = 0;
            this.weight.PointBackgroundColor = System.Drawing.Color.Empty;
            this.weight.PointBorderColor = System.Drawing.Color.Empty;
            this.weight.PointBorderWidth = 1;
            this.weight.PointHitRadius = 1;
            this.weight.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.weight.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.weight.PointHoverBorderWidth = 4;
            this.weight.PointHoverRadius = 1;
            this.weight.PointRadius = 3;
            this.weight.PointRotation = 0;
            this.weight.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.weight.ShowLine = true;
            this.weight.SpanGaps = false;
            this.weight.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.weight.TargetCanvas = this.chartWT;
            // 
            // page_Visit1
            // 
            this.page_Visit1.AllowAdd = true;
            this.page_Visit1.AllowDelete = true;
            this.page_Visit1.AllowEdit = true;
            this.page_Visit1.AllowSearch = true;
            this.page_Visit1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Visit1.BeforeDelete = null;
            this.page_Visit1.DataLimit = 0;
            this.page_Visit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Visit1.Location = new System.Drawing.Point(0, 0);
            this.page_Visit1.Name = "page_Visit1";
            this.page_Visit1.Size = new System.Drawing.Size(840, 684);
            this.page_Visit1.TabIndex = 0;
            this.page_Visit1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.page_Visit1.SelectionChanged += new PatientRecordManagement.Pages.Page_Visit.JengaEventHandler(this.page_Visit1_SelectionChanged);
            // 
            // Frm_Patient_Visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 744);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.AppBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Patient_Visits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Patient_Visits";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        public Bunifu.Utils.BunifuAppBar AppBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Pages.Page_Visit page_Visit1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chartBlood;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chartWT;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart diastolic;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart systolic;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart temp;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart weight;
    }
}