namespace SNT_MMUnicode
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.SNT_MMUnicode = this.Factory.CreateRibbonTab();
            this.Convert = this.Factory.CreateRibbonGroup();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ZGToUni = this.Factory.CreateRibbonButton();
            this.btnSavePdf = this.Factory.CreateRibbonButton();
            this.btnXPS = this.Factory.CreateRibbonButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SNT_MMUnicode.SuspendLayout();
            this.Convert.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // SNT_MMUnicode
            // 
            this.SNT_MMUnicode.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.SNT_MMUnicode.Groups.Add(this.Convert);
            this.SNT_MMUnicode.Groups.Add(this.group1);
            this.SNT_MMUnicode.Label = "SNT_MMUnicode";
            this.SNT_MMUnicode.Name = "SNT_MMUnicode";
            // 
            // Convert
            // 
            this.Convert.Items.Add(this.ZGToUni);
            this.Convert.Label = "Convert";
            this.Convert.Name = "Convert";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSavePdf);
            this.group1.Items.Add(this.btnXPS);
            this.group1.Label = "Save";
            this.group1.Name = "group1";
            // 
            // ZGToUni
            // 
            this.ZGToUni.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ZGToUni.Image = global::SNT_MMUnicode.Properties.Resources.Unicode;
            this.ZGToUni.Label = "ZGToUni";
            this.ZGToUni.Name = "ZGToUni";
            this.ZGToUni.ShowImage = true;
            this.ZGToUni.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ZGToUni_Click);
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSavePdf.Image = global::SNT_MMUnicode.Properties.Resources.pdf1;
            this.btnSavePdf.Label = "Save as Pdf";
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.ShowImage = true;
            this.btnSavePdf.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPdf_Click);
            // 
            // btnXPS
            // 
            this.btnXPS.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnXPS.Image = global::SNT_MMUnicode.Properties.Resources.XPS;
            this.btnXPS.Label = "Save as XPS";
            this.btnXPS.Name = "btnXPS";
            this.btnXPS.ShowImage = true;
            this.btnXPS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnXPS_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.SNT_MMUnicode);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.SNT_MMUnicode.ResumeLayout(false);
            this.SNT_MMUnicode.PerformLayout();
            this.Convert.ResumeLayout(false);
            this.Convert.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab SNT_MMUnicode;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Convert;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ZGToUni;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSavePdf;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnXPS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
