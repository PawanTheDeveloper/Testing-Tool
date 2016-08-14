/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 11/08/2009
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.UserCredentialsComboBox = new System.Windows.Forms.ComboBox();
			this.DeleteHostButton = new System.Windows.Forms.Button();
			this.FixLocalHostButton = new System.Windows.Forms.Button();
			this.AutoHostAddButton = new System.Windows.Forms.Button();
			this.HostPasswordTextBox = new System.Windows.Forms.TextBox();
			this.HostPasswordLabel = new System.Windows.Forms.Label();
			this.HostUserNameTextBox = new System.Windows.Forms.TextBox();
			this.HostUserNameLabel = new System.Windows.Forms.Label();
			this.etchostEditGroup = new System.Windows.Forms.GroupBox();
			this.FixHostsButton = new System.Windows.Forms.Button();
			this.SortHostsButton = new System.Windows.Forms.Button();
			this.label34 = new System.Windows.Forms.Label();
			this.OpenHostFile = new System.Windows.Forms.Button();
			this.RefreshHostButton = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.CommentsTextBox = new System.Windows.Forms.TextBox();
			this.PasteHostDetailsButton = new System.Windows.Forms.Button();
			this.PasteIPButton = new System.Windows.Forms.Button();
			this.CopyDetailsButton = new System.Windows.Forms.Button();
			this.CopyIPButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.HostNameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.ZipToolPathTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.OpenConfigXMLButton = new System.Windows.Forms.Button();
			this.LoadConfigButton = new System.Windows.Forms.Button();
			this.SaveConfigAsButton = new System.Windows.Forms.Button();
			this.HostSpecificSettingsCheckBox = new System.Windows.Forms.CheckBox();
			this.SaveConfigurationButton = new System.Windows.Forms.Button();
			this.ValidateConfigButton = new System.Windows.Forms.Button();
			this.RefreshConfigButton = new System.Windows.Forms.Button();
			this.StafpathTextBox = new System.Windows.Forms.TextBox();
			this.StafPathLabel = new System.Windows.Forms.Label();
			this.JMeterPathTextBox = new System.Windows.Forms.TextBox();
			this.JMeter = new System.Windows.Forms.Label();
			this.IEPathTextBox = new System.Windows.Forms.TextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.CommandPathTextBox = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.LogsPathTextBox = new System.Windows.Forms.TextBox();
			this.LogsPathLabel = new System.Windows.Forms.Label();
			this.WinSCP_Path_textbox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Putty_Path_textbox = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.VNC__Path_textbox = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.FireFoxPathTextBox = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.WC_InstanceName_texBox = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.CacheMonitorButton = new System.Windows.Forms.Button();
			this.YantraVersionGroupBox = new System.Windows.Forms.GroupBox();
			this.YantraVersion8andLess = new System.Windows.Forms.RadioButton();
			this.YantraVersion9Type = new System.Windows.Forms.RadioButton();
			this.AppServer_Port_ComboBox = new System.Windows.Forms.ComboBox();
			this.AppServerGroupBox = new System.Windows.Forms.GroupBox();
			this.WebSphereCheckBox = new System.Windows.Forms.RadioButton();
			this.WebLogicCheckBox = new System.Windows.Forms.RadioButton();
			this.JBossCheckBox = new System.Windows.Forms.RadioButton();
			this.AdditionalHostAddButton = new System.Windows.Forms.Button();
			this.label24 = new System.Windows.Forms.Label();
			this.HostNameComboBox = new System.Windows.Forms.ComboBox();
			this.HostName2TextBox = new System.Windows.Forms.TextBox();
			this.HostName2Label = new System.Windows.Forms.Label();
			this.LocalCommandGroupBox = new System.Windows.Forms.GroupBox();
			this.IPConfigButton = new System.Windows.Forms.Button();
			this.StartJmeterButton = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.AppServerConsoleButton = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.FTPClientButton = new System.Windows.Forms.Button();
			this.AutoCredential_CheckBox = new System.Windows.Forms.CheckBox();
			this.FTPBrowserButton = new System.Windows.Forms.Button();
			this.SMB_Button = new System.Windows.Forms.Button();
			this.WinSCP_Button = new System.Windows.Forms.Button();
			this.HostSpecificCheckBox = new System.Windows.Forms.CheckBox();
			this.RemoteDesktop_button = new System.Windows.Forms.Button();
			this.Telnet_button = new System.Windows.Forms.Button();
			this.Putty_button = new System.Windows.Forms.Button();
			this.VNC_button = new System.Windows.Forms.Button();
			this.MachineCheckGroupBox = new System.Windows.Forms.GroupBox();
			this.MachineCheckSTAFButton = new System.Windows.Forms.Button();
			this.HttpCheckPortTextBox = new System.Windows.Forms.TextBox();
			this.HttpsCheckPortTextBox = new System.Windows.Forms.TextBox();
			this.HttpsCheckButton = new System.Windows.Forms.Button();
			this.HttpCheckButton = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.LaunchSFSButton = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.otherBrowsersComboBox = new System.Windows.Forms.ComboBox();
			this.otherBrowserRadioButton = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label30 = new System.Windows.Forms.Label();
			this.UrlGoButton = new System.Windows.Forms.Button();
			this.Default_URL_TextBox = new System.Windows.Forms.TextBox();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.WC_openinIERB = new System.Windows.Forms.RadioButton();
			this.WC_openinFFRB = new System.Windows.Forms.RadioButton();
			this.WC_openinTBRB = new System.Windows.Forms.RadioButton();
			this.SEOTypeUrlCheckBox = new System.Windows.Forms.CheckBox();
			this.StoreName_ComboBox = new System.Windows.Forms.ComboBox();
			this.CatalogIDComboBox = new System.Windows.Forms.ComboBox();
			this.WC_StoreID_ComboBox = new System.Windows.Forms.ComboBox();
			this.OtherPagesGroupBox = new System.Windows.Forms.GroupBox();
			this.button22 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.InfoCenterVisitButton = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.MachineTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.Remote_OS_GroupBox = new System.Windows.Forms.GroupBox();
			this.Remote_OS_AIX = new System.Windows.Forms.RadioButton();
			this.Remote_OS_XLinux = new System.Windows.Forms.RadioButton();
			this.Remote_OS_Windows = new System.Windows.Forms.RadioButton();
			this.ToolkitRadioButton = new System.Windows.Forms.RadioButton();
			this.RunTimeRadioButton = new System.Windows.Forms.RadioButton();
			this.label37 = new System.Windows.Forms.Label();
			this.LaunchStoreByName = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.button14 = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.groupBox21 = new System.Windows.Forms.GroupBox();
			this.WCLinks_CMCButton = new System.Windows.Forms.Button();
			this.groupBox20 = new System.Windows.Forms.GroupBox();
			this.WCLink_AcceleratorButton = new System.Windows.Forms.Button();
			this.WorkspaceAdminConsoleLinkButton = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.label14 = new System.Windows.Forms.Label();
			this.PasteScreenshotButton = new System.Windows.Forms.Button();
			this.label36 = new System.Windows.Forms.Label();
			this.ScreenShot_Length = new System.Windows.Forms.TextBox();
			this.ScreenShotDirectory = new System.Windows.Forms.TextBox();
			this.CopyScreenshotButton = new System.Windows.Forms.Button();
			this.ScreenShot_y1 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.ScreenShotSaveButton = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.EditScreenShotButton = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.ScreenShot_Width = new System.Windows.Forms.TextBox();
			this.ScreenShotPrefixTextBox = new System.Windows.Forms.TextBox();
			this.OpenScreenshotButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.ScreenShot_x1 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.ClipRingTreeView = new System.Windows.Forms.TreeView();
			this.LogsTAB = new System.Windows.Forms.TabPage();
			this.OpenTodayLogButton = new System.Windows.Forms.Button();
			this.LogFolders = new System.Windows.Forms.ListBox();
			this.LogFiles = new System.Windows.Forms.ListBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.RefreshLogsButton = new System.Windows.Forms.Button();
			this.CopyLogPathButton = new System.Windows.Forms.Button();
			this.NewTextLogButton = new System.Windows.Forms.Button();
			this.ProcessTextTab = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.ProcessTextRTB1 = new System.Windows.Forms.RichTextBox();
			this.ProcessTextRTB2 = new System.Windows.Forms.RichTextBox();
			this.ProcessText_IncrementCountersButton = new System.Windows.Forms.Button();
			this.IncrementValuesButton = new System.Windows.Forms.Button();
			this.RemoveNullParamXMLButton = new System.Windows.Forms.Button();
			this.ProcessTextFixLabel = new System.Windows.Forms.Label();
			this.ProcessTextFixTextBox = new System.Windows.Forms.TextBox();
			this.ToOneLineButton = new System.Windows.Forms.Button();
			this.FormatXMLButton = new System.Windows.Forms.Button();
			this.OneWordPerLineButton = new System.Windows.Forms.Button();
			this.ProcessText_ToJavaStringButton = new System.Windows.Forms.Button();
			this.ProcessText_RemoveLeadingWhiteSpaces = new System.Windows.Forms.Button();
			this.AddSuffixButton = new System.Windows.Forms.Button();
			this.AddPrefixButton = new System.Windows.Forms.Button();
			this.GetParamFromURLButton = new System.Windows.Forms.Button();
			this.WebPosterTab = new System.Windows.Forms.TabPage();
			this.SContainerHttpPost = new System.Windows.Forms.SplitContainer();
			this.HTTPPost_PasteParamDataButton = new System.Windows.Forms.Button();
			this.HTTPPost_ClearParamButton = new System.Windows.Forms.Button();
			this.HTTPPost_DeleteParamButton = new System.Windows.Forms.Button();
			this.label56 = new System.Windows.Forms.Label();
			this.HTTPPostURLTextBox = new System.Windows.Forms.TextBox();
			this.HTTPPostRunButton = new System.Windows.Forms.Button();
			this.HTTPPostAddParamToListButton = new System.Windows.Forms.Button();
			this.HTTPPostValueTextBox = new System.Windows.Forms.TextBox();
			this.HTTPPostParameterTextBox = new System.Windows.Forms.TextBox();
			this.label55 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.HTTPPostParamListBox = new System.Windows.Forms.ListBox();
			this.HTTPPostResultBrowser = new System.Windows.Forms.WebBrowser();
			this.APIRunnerTab = new System.Windows.Forms.TabPage();
			this.APIRunner_ClearResultsButton = new System.Windows.Forms.Button();
			this.APIRunner_APIResetButton = new System.Windows.Forms.Button();
			this.APIRunner_SaveAPIButton = new System.Windows.Forms.Button();
			this.API_RunnerThreadCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.APIRunner_RepeatCountersCheckBox = new System.Windows.Forms.CheckBox();
			this.APIRunner_ResultsTreeView = new System.Windows.Forms.TreeView();
			this.APIRunner_ProgressBar = new System.Windows.Forms.ProgressBar();
			this.APIRunner_IncrementCounter_N = new System.Windows.Forms.NumericUpDown();
			this.label67 = new System.Windows.Forms.Label();
			this.APIRunner_IncrementCountersCheckBox = new System.Windows.Forms.CheckBox();
			this.label66 = new System.Windows.Forms.Label();
			this.APIRunner_IncrementCriteriaTextBox = new System.Windows.Forms.TextBox();
			this.APIRunner_IsCounterTemplate = new System.Windows.Forms.CheckBox();
			this.label65 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.label63 = new System.Windows.Forms.Label();
			this.APIRunner_RunAPIButton = new System.Windows.Forms.Button();
			this.label62 = new System.Windows.Forms.Label();
			this.APIRunner_APINamesComboBox = new System.Windows.Forms.ComboBox();
			this.label60 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.APIRunner_PasswordTextbox = new System.Windows.Forms.TextBox();
			this.APIRunner_UserNameTextBox = new System.Windows.Forms.TextBox();
			this.APIRunner_APITemplateTextBox = new System.Windows.Forms.TextBox();
			this.APIRunner_APIXMLTextBox = new System.Windows.Forms.TextBox();
			this.ArchivingToolsTab = new System.Windows.Forms.TabPage();
			this.ExtractGroupBox = new System.Windows.Forms.GroupBox();
			this.ExtractArchiveResetButton = new System.Windows.Forms.Button();
			this.ExtractArchiveDeleteExcludedFileButton = new System.Windows.Forms.Button();
			this.ExtractArchiveDeleteRemoveTermButton = new System.Windows.Forms.Button();
			this.ExtractArchiveAddExcludedFileButton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.ExtractArchiveExcludedFilesComboBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ExtractArchiveAddExcludedFileTextBox = new System.Windows.Forms.TextBox();
			this.ExtractArchiveAddRemoveTermButton = new System.Windows.Forms.Button();
			this.label57 = new System.Windows.Forms.Label();
			this.ExtractArchiveRemoveTermsComboBox = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.ExtractArchiveAddRemoveTermTextBox = new System.Windows.Forms.TextBox();
			this.MaxNestingLabel = new System.Windows.Forms.Label();
			this.ExtractArchiveMaxNestingTextBox = new System.Windows.Forms.TextBox();
			this.RecursivelyExtractArchiveCheckBox = new System.Windows.Forms.CheckBox();
			this.BrowseArchiveFileButton = new System.Windows.Forms.Button();
			this.ArchiveExtractButton = new System.Windows.Forms.Button();
			this.ExtractArchivePathLabel = new System.Windows.Forms.Label();
			this.ExtractArchivePathTextBox = new System.Windows.Forms.TextBox();
			this.STAFFS = new System.Windows.Forms.TabPage();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label41 = new System.Windows.Forms.Label();
			this.button33 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label42 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.button35 = new System.Windows.Forms.Button();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.button39 = new System.Windows.Forms.Button();
			this.button40 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.button44 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.button49 = new System.Windows.Forms.Button();
			this.button50 = new System.Windows.Forms.Button();
			this.button51 = new System.Windows.Forms.Button();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.button52 = new System.Windows.Forms.Button();
			this.button53 = new System.Windows.Forms.Button();
			this.button54 = new System.Windows.Forms.Button();
			this.button55 = new System.Windows.Forms.Button();
			this.button56 = new System.Windows.Forms.Button();
			this.button57 = new System.Windows.Forms.Button();
			this.button58 = new System.Windows.Forms.Button();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.label44 = new System.Windows.Forms.Label();
			this.button59 = new System.Windows.Forms.Button();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.label46 = new System.Windows.Forms.Label();
			this.button60 = new System.Windows.Forms.Button();
			this.label47 = new System.Windows.Forms.Label();
			this.textBox30 = new System.Windows.Forms.TextBox();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.label48 = new System.Windows.Forms.Label();
			this.textBox31 = new System.Windows.Forms.TextBox();
			this.button61 = new System.Windows.Forms.Button();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.textBox32 = new System.Windows.Forms.TextBox();
			this.textBox33 = new System.Windows.Forms.TextBox();
			this.button62 = new System.Windows.Forms.Button();
			this.button63 = new System.Windows.Forms.Button();
			this.button64 = new System.Windows.Forms.Button();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.button65 = new System.Windows.Forms.Button();
			this.button66 = new System.Windows.Forms.Button();
			this.button67 = new System.Windows.Forms.Button();
			this.button68 = new System.Windows.Forms.Button();
			this.button69 = new System.Windows.Forms.Button();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.button70 = new System.Windows.Forms.Button();
			this.button71 = new System.Windows.Forms.Button();
			this.button72 = new System.Windows.Forms.Button();
			this.button73 = new System.Windows.Forms.Button();
			this.button74 = new System.Windows.Forms.Button();
			this.button75 = new System.Windows.Forms.Button();
			this.button76 = new System.Windows.Forms.Button();
			this.button77 = new System.Windows.Forms.Button();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.button78 = new System.Windows.Forms.Button();
			this.button79 = new System.Windows.Forms.Button();
			this.button80 = new System.Windows.Forms.Button();
			this.button81 = new System.Windows.Forms.Button();
			this.button82 = new System.Windows.Forms.Button();
			this.button83 = new System.Windows.Forms.Button();
			this.button84 = new System.Windows.Forms.Button();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.label50 = new System.Windows.Forms.Label();
			this.button85 = new System.Windows.Forms.Button();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.label51 = new System.Windows.Forms.Label();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.label52 = new System.Windows.Forms.Label();
			this.button86 = new System.Windows.Forms.Button();
			this.label53 = new System.Windows.Forms.Label();
			this.textBox37 = new System.Windows.Forms.TextBox();
			this.AutoTimeIncrementTimer = new System.Windows.Forms.Timer(this.components);
			this.TeamSessionTimer = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.etchostEditGroup.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.YantraVersionGroupBox.SuspendLayout();
			this.AppServerGroupBox.SuspendLayout();
			this.LocalCommandGroupBox.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.MachineCheckGroupBox.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.OtherPagesGroupBox.SuspendLayout();
			this.MachineTypeGroupBox.SuspendLayout();
			this.Remote_OS_GroupBox.SuspendLayout();
			this.groupBox21.SuspendLayout();
			this.groupBox20.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.LogsTAB.SuspendLayout();
			this.ProcessTextTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.WebPosterTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SContainerHttpPost)).BeginInit();
			this.SContainerHttpPost.Panel1.SuspendLayout();
			this.SContainerHttpPost.Panel2.SuspendLayout();
			this.SContainerHttpPost.SuspendLayout();
			this.APIRunnerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.API_RunnerThreadCountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APIRunner_IncrementCounter_N)).BeginInit();
			this.ArchivingToolsTab.SuspendLayout();
			this.ExtractGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.toolStripMenuItem1,
									this.viewToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1265, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addHostToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
			this.toolStripMenuItem1.Text = "Actions";
			// 
			// addHostToolStripMenuItem
			// 
			this.addHostToolStripMenuItem.Name = "addHostToolStripMenuItem";
			this.addHostToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.addHostToolStripMenuItem.Text = "Add Host ";
			this.addHostToolStripMenuItem.Click += new System.EventHandler(this.AddHostToolStripMenuItemClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 743);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.UserCredentialsComboBox);
			this.tabPage1.Controls.Add(this.DeleteHostButton);
			this.tabPage1.Controls.Add(this.FixLocalHostButton);
			this.tabPage1.Controls.Add(this.AutoHostAddButton);
			this.tabPage1.Controls.Add(this.HostPasswordTextBox);
			this.tabPage1.Controls.Add(this.HostPasswordLabel);
			this.tabPage1.Controls.Add(this.HostUserNameTextBox);
			this.tabPage1.Controls.Add(this.HostUserNameLabel);
			this.tabPage1.Controls.Add(this.etchostEditGroup);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(1257, 693);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Add Host Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// UserCredentialsComboBox
			// 
			this.UserCredentialsComboBox.FormattingEnabled = true;
			this.UserCredentialsComboBox.Location = new System.Drawing.Point(184, 352);
			this.UserCredentialsComboBox.Name = "UserCredentialsComboBox";
			this.UserCredentialsComboBox.Size = new System.Drawing.Size(135, 21);
			this.UserCredentialsComboBox.TabIndex = 39;
			this.UserCredentialsComboBox.SelectedIndexChanged += new System.EventHandler(this.UserCredentialsComboBoxSelectedIndexChanged);
			// 
			// DeleteHostButton
			// 
			this.DeleteHostButton.Location = new System.Drawing.Point(754, 172);
			this.DeleteHostButton.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteHostButton.Name = "DeleteHostButton";
			this.DeleteHostButton.Size = new System.Drawing.Size(116, 22);
			this.DeleteHostButton.TabIndex = 38;
			this.DeleteHostButton.Text = "Delete Host";
			this.DeleteHostButton.UseVisualStyleBackColor = true;
			this.DeleteHostButton.Click += new System.EventHandler(this.DeleteHostButtonClick);
			// 
			// FixLocalHostButton
			// 
			this.FixLocalHostButton.Location = new System.Drawing.Point(754, 141);
			this.FixLocalHostButton.Margin = new System.Windows.Forms.Padding(2);
			this.FixLocalHostButton.Name = "FixLocalHostButton";
			this.FixLocalHostButton.Size = new System.Drawing.Size(116, 22);
			this.FixLocalHostButton.TabIndex = 37;
			this.FixLocalHostButton.Text = "Fix LocalHost";
			this.FixLocalHostButton.UseVisualStyleBackColor = true;
			// 
			// AutoHostAddButton
			// 
			this.AutoHostAddButton.Location = new System.Drawing.Point(754, 110);
			this.AutoHostAddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AutoHostAddButton.Name = "AutoHostAddButton";
			this.AutoHostAddButton.Size = new System.Drawing.Size(116, 22);
			this.AutoHostAddButton.TabIndex = 30;
			this.AutoHostAddButton.Text = "Find and Add Host";
			this.AutoHostAddButton.UseVisualStyleBackColor = true;
			this.AutoHostAddButton.Click += new System.EventHandler(this.AutoHostAddButtonClick);
			// 
			// HostPasswordTextBox
			// 
			this.HostPasswordTextBox.Location = new System.Drawing.Point(84, 381);
			this.HostPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.HostPasswordTextBox.Name = "HostPasswordTextBox";
			this.HostPasswordTextBox.Size = new System.Drawing.Size(93, 20);
			this.HostPasswordTextBox.TabIndex = 35;
			this.HostPasswordTextBox.Text = "yantra";
			// 
			// HostPasswordLabel
			// 
			this.HostPasswordLabel.Location = new System.Drawing.Point(14, 384);
			this.HostPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HostPasswordLabel.Name = "HostPasswordLabel";
			this.HostPasswordLabel.Size = new System.Drawing.Size(66, 20);
			this.HostPasswordLabel.TabIndex = 36;
			this.HostPasswordLabel.Text = "Password:";
			// 
			// HostUserNameTextBox
			// 
			this.HostUserNameTextBox.Location = new System.Drawing.Point(84, 353);
			this.HostUserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.HostUserNameTextBox.Name = "HostUserNameTextBox";
			this.HostUserNameTextBox.Size = new System.Drawing.Size(93, 20);
			this.HostUserNameTextBox.TabIndex = 33;
			this.HostUserNameTextBox.Text = "yantra";
			// 
			// HostUserNameLabel
			// 
			this.HostUserNameLabel.Location = new System.Drawing.Point(14, 356);
			this.HostUserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HostUserNameLabel.Name = "HostUserNameLabel";
			this.HostUserNameLabel.Size = new System.Drawing.Size(66, 20);
			this.HostUserNameLabel.TabIndex = 34;
			this.HostUserNameLabel.Text = "User Name:";
			// 
			// etchostEditGroup
			// 
			this.etchostEditGroup.Controls.Add(this.FixHostsButton);
			this.etchostEditGroup.Controls.Add(this.SortHostsButton);
			this.etchostEditGroup.Controls.Add(this.label34);
			this.etchostEditGroup.Controls.Add(this.OpenHostFile);
			this.etchostEditGroup.Controls.Add(this.RefreshHostButton);
			this.etchostEditGroup.Controls.Add(this.comboBox1);
			this.etchostEditGroup.Location = new System.Drawing.Point(13, 84);
			this.etchostEditGroup.Name = "etchostEditGroup";
			this.etchostEditGroup.Size = new System.Drawing.Size(264, 144);
			this.etchostEditGroup.TabIndex = 32;
			this.etchostEditGroup.TabStop = false;
			this.etchostEditGroup.Text = "Hosts Utility";
			// 
			// FixHostsButton
			// 
			this.FixHostsButton.Location = new System.Drawing.Point(119, 95);
			this.FixHostsButton.Name = "FixHostsButton";
			this.FixHostsButton.Size = new System.Drawing.Size(102, 28);
			this.FixHostsButton.TabIndex = 33;
			this.FixHostsButton.Text = "Fix Hosts";
			this.FixHostsButton.UseVisualStyleBackColor = true;
			this.FixHostsButton.Click += new System.EventHandler(this.FixHostsButtonClick);
			// 
			// SortHostsButton
			// 
			this.SortHostsButton.Location = new System.Drawing.Point(11, 95);
			this.SortHostsButton.Name = "SortHostsButton";
			this.SortHostsButton.Size = new System.Drawing.Size(102, 28);
			this.SortHostsButton.TabIndex = 32;
			this.SortHostsButton.Text = "Sort Hosts";
			this.SortHostsButton.UseVisualStyleBackColor = true;
			this.SortHostsButton.Click += new System.EventHandler(this.SortHostsButtonClick);
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(5, 22);
			this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(62, 15);
			this.label34.TabIndex = 29;
			this.label34.Text = "Select Host";
			// 
			// OpenHostFile
			// 
			this.OpenHostFile.Location = new System.Drawing.Point(119, 61);
			this.OpenHostFile.Name = "OpenHostFile";
			this.OpenHostFile.Size = new System.Drawing.Size(102, 28);
			this.OpenHostFile.TabIndex = 31;
			this.OpenHostFile.Text = "Manual Edit";
			this.OpenHostFile.UseVisualStyleBackColor = true;
			this.OpenHostFile.Click += new System.EventHandler(this.OpenHostFileClick);
			// 
			// RefreshHostButton
			// 
			this.RefreshHostButton.Location = new System.Drawing.Point(11, 61);
			this.RefreshHostButton.Name = "RefreshHostButton";
			this.RefreshHostButton.Size = new System.Drawing.Size(102, 28);
			this.RefreshHostButton.TabIndex = 30;
			this.RefreshHostButton.Text = "Refresh Hosts";
			this.RefreshHostButton.UseVisualStyleBackColor = true;
			this.RefreshHostButton.Click += new System.EventHandler(this.RefreshHostButtonClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(71, 18);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(150, 21);
			this.comboBox1.TabIndex = 27;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.CommentsTextBox);
			this.groupBox2.Controls.Add(this.PasteHostDetailsButton);
			this.groupBox2.Controls.Add(this.PasteIPButton);
			this.groupBox2.Controls.Add(this.CopyDetailsButton);
			this.groupBox2.Controls.Add(this.CopyIPButton);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.HostNameTextBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(339, 84);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(388, 351);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Host";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(40, 169);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 20);
			this.label10.TabIndex = 31;
			this.label10.Text = "Comments:";
			// 
			// CommentsTextBox
			// 
			this.CommentsTextBox.Location = new System.Drawing.Point(109, 169);
			this.CommentsTextBox.Multiline = true;
			this.CommentsTextBox.Name = "CommentsTextBox";
			this.CommentsTextBox.Size = new System.Drawing.Size(236, 78);
			this.CommentsTextBox.TabIndex = 30;
			// 
			// PasteHostDetailsButton
			// 
			this.PasteHostDetailsButton.Location = new System.Drawing.Point(142, 267);
			this.PasteHostDetailsButton.Margin = new System.Windows.Forms.Padding(2);
			this.PasteHostDetailsButton.Name = "PasteHostDetailsButton";
			this.PasteHostDetailsButton.Size = new System.Drawing.Size(93, 20);
			this.PasteHostDetailsButton.TabIndex = 29;
			this.PasteHostDetailsButton.Text = "Paste Details";
			this.PasteHostDetailsButton.UseVisualStyleBackColor = true;
			this.PasteHostDetailsButton.Click += new System.EventHandler(this.PasteHostDetailsButtonClick);
			// 
			// PasteIPButton
			// 
			this.PasteIPButton.Location = new System.Drawing.Point(38, 267);
			this.PasteIPButton.Margin = new System.Windows.Forms.Padding(2);
			this.PasteIPButton.Name = "PasteIPButton";
			this.PasteIPButton.Size = new System.Drawing.Size(65, 20);
			this.PasteIPButton.TabIndex = 28;
			this.PasteIPButton.Text = "Paste IP";
			this.PasteIPButton.UseVisualStyleBackColor = true;
			this.PasteIPButton.Click += new System.EventHandler(this.PasteIPButtonClick);
			// 
			// CopyDetailsButton
			// 
			this.CopyDetailsButton.Location = new System.Drawing.Point(142, 291);
			this.CopyDetailsButton.Margin = new System.Windows.Forms.Padding(2);
			this.CopyDetailsButton.Name = "CopyDetailsButton";
			this.CopyDetailsButton.Size = new System.Drawing.Size(93, 20);
			this.CopyDetailsButton.TabIndex = 27;
			this.CopyDetailsButton.Text = "Copy Details";
			this.CopyDetailsButton.UseVisualStyleBackColor = true;
			this.CopyDetailsButton.Click += new System.EventHandler(this.Button33Click);
			// 
			// CopyIPButton
			// 
			this.CopyIPButton.Location = new System.Drawing.Point(38, 291);
			this.CopyIPButton.Margin = new System.Windows.Forms.Padding(2);
			this.CopyIPButton.Name = "CopyIPButton";
			this.CopyIPButton.Size = new System.Drawing.Size(65, 20);
			this.CopyIPButton.TabIndex = 26;
			this.CopyIPButton.Text = "Copy IP";
			this.CopyIPButton.UseVisualStyleBackColor = true;
			this.CopyIPButton.Click += new System.EventHandler(this.CopyIPButtonClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 291);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 20);
			this.button1.TabIndex = 25;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(38, 73);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 20);
			this.label6.TabIndex = 24;
			this.label6.Text = "Alias (opt):";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(109, 75);
			this.textBox6.Margin = new System.Windows.Forms.Padding(2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(236, 20);
			this.textBox6.TabIndex = 14;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(302, 128);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(43, 20);
			this.textBox5.TabIndex = 18;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(239, 128);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(42, 20);
			this.textBox4.TabIndex = 17;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(172, 128);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(44, 20);
			this.textBox3.TabIndex = 16;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(109, 128);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(38, 20);
			this.textBox2.TabIndex = 15;
			// 
			// HostNameTextBox
			// 
			this.HostNameTextBox.Location = new System.Drawing.Point(109, 28);
			this.HostNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.HostNameTextBox.Name = "HostNameTextBox";
			this.HostNameTextBox.Size = new System.Drawing.Size(236, 20);
			this.HostNameTextBox.TabIndex = 13;
			this.HostNameTextBox.Text = "localhost";
			this.HostNameTextBox.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(284, 126);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 19);
			this.label5.TabIndex = 22;
			this.label5.Text = ".";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(218, 126);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 19);
			this.label4.TabIndex = 21;
			this.label4.Text = ".";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(151, 127);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 19);
			this.label3.TabIndex = 20;
			this.label3.Text = ".";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 126);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "Host IP:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Host Name:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.LogsTAB);
			this.tabControl1.Controls.Add(this.ProcessTextTab);
			this.tabControl1.Controls.Add(this.WebPosterTab);
			this.tabControl1.Controls.Add(this.APIRunnerTab);
			this.tabControl1.Controls.Add(this.ArchivingToolsTab);
			this.tabControl1.Controls.Add(this.STAFFS);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1265, 719);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.ZipToolPathTextBox);
			this.tabPage5.Controls.Add(this.label11);
			this.tabPage5.Controls.Add(this.OpenConfigXMLButton);
			this.tabPage5.Controls.Add(this.LoadConfigButton);
			this.tabPage5.Controls.Add(this.SaveConfigAsButton);
			this.tabPage5.Controls.Add(this.HostSpecificSettingsCheckBox);
			this.tabPage5.Controls.Add(this.SaveConfigurationButton);
			this.tabPage5.Controls.Add(this.ValidateConfigButton);
			this.tabPage5.Controls.Add(this.RefreshConfigButton);
			this.tabPage5.Controls.Add(this.StafpathTextBox);
			this.tabPage5.Controls.Add(this.StafPathLabel);
			this.tabPage5.Controls.Add(this.JMeterPathTextBox);
			this.tabPage5.Controls.Add(this.JMeter);
			this.tabPage5.Controls.Add(this.IEPathTextBox);
			this.tabPage5.Controls.Add(this.label54);
			this.tabPage5.Controls.Add(this.CommandPathTextBox);
			this.tabPage5.Controls.Add(this.label38);
			this.tabPage5.Controls.Add(this.LogsPathTextBox);
			this.tabPage5.Controls.Add(this.LogsPathLabel);
			this.tabPage5.Controls.Add(this.WinSCP_Path_textbox);
			this.tabPage5.Controls.Add(this.label12);
			this.tabPage5.Controls.Add(this.Putty_Path_textbox);
			this.tabPage5.Controls.Add(this.label33);
			this.tabPage5.Controls.Add(this.VNC__Path_textbox);
			this.tabPage5.Controls.Add(this.label32);
			this.tabPage5.Controls.Add(this.FireFoxPathTextBox);
			this.tabPage5.Controls.Add(this.label31);
			this.tabPage5.Controls.Add(this.textBox26);
			this.tabPage5.Controls.Add(this.label29);
			this.tabPage5.Controls.Add(this.WC_InstanceName_texBox);
			this.tabPage5.Controls.Add(this.label28);
			this.tabPage5.Controls.Add(this.textBox20);
			this.tabPage5.Controls.Add(this.label22);
			this.tabPage5.Controls.Add(this.textBox19);
			this.tabPage5.Controls.Add(this.label21);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage5.Size = new System.Drawing.Size(1257, 693);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Config";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// ZipToolPathTextBox
			// 
			this.ZipToolPathTextBox.Location = new System.Drawing.Point(165, 335);
			this.ZipToolPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ZipToolPathTextBox.Name = "ZipToolPathTextBox";
			this.ZipToolPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.ZipToolPathTextBox.TabIndex = 34;
			this.ZipToolPathTextBox.Text = "\"C:\\Program Files (x86)\\7-Zip\\7z.exe \"";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(99, 335);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 18);
			this.label11.TabIndex = 33;
			this.label11.Text = "7Zip Path:";
			// 
			// OpenConfigXMLButton
			// 
			this.OpenConfigXMLButton.Location = new System.Drawing.Point(959, 134);
			this.OpenConfigXMLButton.Name = "OpenConfigXMLButton";
			this.OpenConfigXMLButton.Size = new System.Drawing.Size(125, 23);
			this.OpenConfigXMLButton.TabIndex = 32;
			this.OpenConfigXMLButton.Text = "Open Config XML";
			this.OpenConfigXMLButton.UseVisualStyleBackColor = true;
			this.OpenConfigXMLButton.Click += new System.EventHandler(this.OpenConfigXMLButtonClick);
			// 
			// LoadConfigButton
			// 
			this.LoadConfigButton.Location = new System.Drawing.Point(959, 106);
			this.LoadConfigButton.Name = "LoadConfigButton";
			this.LoadConfigButton.Size = new System.Drawing.Size(125, 23);
			this.LoadConfigButton.TabIndex = 31;
			this.LoadConfigButton.Text = "Load Config";
			this.LoadConfigButton.UseVisualStyleBackColor = true;
			this.LoadConfigButton.Click += new System.EventHandler(this.LoadConfigButtonClick);
			// 
			// SaveConfigAsButton
			// 
			this.SaveConfigAsButton.Location = new System.Drawing.Point(959, 77);
			this.SaveConfigAsButton.Name = "SaveConfigAsButton";
			this.SaveConfigAsButton.Size = new System.Drawing.Size(125, 23);
			this.SaveConfigAsButton.TabIndex = 30;
			this.SaveConfigAsButton.Text = "Save Config as";
			this.SaveConfigAsButton.UseVisualStyleBackColor = true;
			this.SaveConfigAsButton.Click += new System.EventHandler(this.SaveConfigAsButtonClick);
			// 
			// HostSpecificSettingsCheckBox
			// 
			this.HostSpecificSettingsCheckBox.Checked = true;
			this.HostSpecificSettingsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HostSpecificSettingsCheckBox.Location = new System.Drawing.Point(828, 106);
			this.HostSpecificSettingsCheckBox.Name = "HostSpecificSettingsCheckBox";
			this.HostSpecificSettingsCheckBox.Size = new System.Drawing.Size(125, 24);
			this.HostSpecificSettingsCheckBox.TabIndex = 29;
			this.HostSpecificSettingsCheckBox.Text = "HostSpecificSettings";
			this.HostSpecificSettingsCheckBox.UseVisualStyleBackColor = true;
			// 
			// SaveConfigurationButton
			// 
			this.SaveConfigurationButton.Location = new System.Drawing.Point(828, 77);
			this.SaveConfigurationButton.Name = "SaveConfigurationButton";
			this.SaveConfigurationButton.Size = new System.Drawing.Size(125, 23);
			this.SaveConfigurationButton.TabIndex = 28;
			this.SaveConfigurationButton.Text = "Save Config";
			this.SaveConfigurationButton.UseVisualStyleBackColor = true;
			this.SaveConfigurationButton.Click += new System.EventHandler(this.SaveConfigurationButtonClick);
			// 
			// ValidateConfigButton
			// 
			this.ValidateConfigButton.Location = new System.Drawing.Point(828, 48);
			this.ValidateConfigButton.Name = "ValidateConfigButton";
			this.ValidateConfigButton.Size = new System.Drawing.Size(125, 23);
			this.ValidateConfigButton.TabIndex = 27;
			this.ValidateConfigButton.Text = "Validate Config";
			this.ValidateConfigButton.UseVisualStyleBackColor = true;
			this.ValidateConfigButton.Click += new System.EventHandler(this.ValidateConfigButtonClick);
			// 
			// RefreshConfigButton
			// 
			this.RefreshConfigButton.Location = new System.Drawing.Point(828, 19);
			this.RefreshConfigButton.Name = "RefreshConfigButton";
			this.RefreshConfigButton.Size = new System.Drawing.Size(125, 23);
			this.RefreshConfigButton.TabIndex = 26;
			this.RefreshConfigButton.Text = "Refresh Config";
			this.RefreshConfigButton.UseVisualStyleBackColor = true;
			this.RefreshConfigButton.Click += new System.EventHandler(this.RefreshConfigButtonClick);
			// 
			// StafpathTextBox
			// 
			this.StafpathTextBox.Location = new System.Drawing.Point(165, 311);
			this.StafpathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.StafpathTextBox.Name = "StafpathTextBox";
			this.StafpathTextBox.Size = new System.Drawing.Size(595, 20);
			this.StafpathTextBox.TabIndex = 25;
			this.StafpathTextBox.Text = "\"C:\\STAF\\bin\\Staf.exe \"";
			// 
			// StafPathLabel
			// 
			this.StafPathLabel.Location = new System.Drawing.Point(99, 311);
			this.StafPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.StafPathLabel.Name = "StafPathLabel";
			this.StafPathLabel.Size = new System.Drawing.Size(62, 18);
			this.StafPathLabel.TabIndex = 24;
			this.StafPathLabel.Text = "Staf Path:";
			// 
			// JMeterPathTextBox
			// 
			this.JMeterPathTextBox.Location = new System.Drawing.Point(165, 287);
			this.JMeterPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.JMeterPathTextBox.Name = "JMeterPathTextBox";
			this.JMeterPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.JMeterPathTextBox.TabIndex = 23;
			this.JMeterPathTextBox.Text = "\"C:\\jakarta-jmeter-r882651\\bin\\jmeter.bat \"";
			// 
			// JMeter
			// 
			this.JMeter.Location = new System.Drawing.Point(85, 287);
			this.JMeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.JMeter.Name = "JMeter";
			this.JMeter.Size = new System.Drawing.Size(70, 18);
			this.JMeter.TabIndex = 22;
			this.JMeter.Text = "JMeter Path:";
			// 
			// IEPathTextBox
			// 
			this.IEPathTextBox.Location = new System.Drawing.Point(165, 21);
			this.IEPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.IEPathTextBox.Name = "IEPathTextBox";
			this.IEPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.IEPathTextBox.TabIndex = 21;
			this.IEPathTextBox.Text = "\"c:\\Program Files\\Internet Explorer\\iexplore.exe \"";
			// 
			// label54
			// 
			this.label54.Location = new System.Drawing.Point(99, 21);
			this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(56, 18);
			this.label54.TabIndex = 20;
			this.label54.Text = "IE8 Path:";
			// 
			// CommandPathTextBox
			// 
			this.CommandPathTextBox.Location = new System.Drawing.Point(165, 167);
			this.CommandPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.CommandPathTextBox.Name = "CommandPathTextBox";
			this.CommandPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.CommandPathTextBox.TabIndex = 19;
			this.CommandPathTextBox.Text = "C:\\TesterLogs\\Commands";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(25, 167);
			this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(135, 18);
			this.label38.TabIndex = 18;
			this.label38.Text = "Command Templates Path:";
			// 
			// LogsPathTextBox
			// 
			this.LogsPathTextBox.Location = new System.Drawing.Point(165, 143);
			this.LogsPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.LogsPathTextBox.Name = "LogsPathTextBox";
			this.LogsPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.LogsPathTextBox.TabIndex = 17;
			this.LogsPathTextBox.Text = "C:\\TesterLogs\\";
			// 
			// LogsPathLabel
			// 
			this.LogsPathLabel.Location = new System.Drawing.Point(99, 143);
			this.LogsPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LogsPathLabel.Name = "LogsPathLabel";
			this.LogsPathLabel.Size = new System.Drawing.Size(62, 18);
			this.LogsPathLabel.TabIndex = 16;
			this.LogsPathLabel.Text = "LogsPath:";
			// 
			// WinSCP_Path_textbox
			// 
			this.WinSCP_Path_textbox.Location = new System.Drawing.Point(165, 119);
			this.WinSCP_Path_textbox.Margin = new System.Windows.Forms.Padding(2);
			this.WinSCP_Path_textbox.Name = "WinSCP_Path_textbox";
			this.WinSCP_Path_textbox.Size = new System.Drawing.Size(595, 20);
			this.WinSCP_Path_textbox.TabIndex = 15;
			this.WinSCP_Path_textbox.Text = "\"C:\\Program Files\\WinSCP\\WinSCP.exe \"";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(99, 119);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 18);
			this.label12.TabIndex = 14;
			this.label12.Text = "WinSCP Path:";
			// 
			// Putty_Path_textbox
			// 
			this.Putty_Path_textbox.Location = new System.Drawing.Point(165, 95);
			this.Putty_Path_textbox.Margin = new System.Windows.Forms.Padding(2);
			this.Putty_Path_textbox.Name = "Putty_Path_textbox";
			this.Putty_Path_textbox.Size = new System.Drawing.Size(595, 20);
			this.Putty_Path_textbox.TabIndex = 13;
			this.Putty_Path_textbox.Text = "\"C:\\Program Files\\PuTTY\\putty.exe \"";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(99, 95);
			this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(62, 18);
			this.label33.TabIndex = 12;
			this.label33.Text = "Putty Path:";
			// 
			// VNC__Path_textbox
			// 
			this.VNC__Path_textbox.Location = new System.Drawing.Point(165, 72);
			this.VNC__Path_textbox.Margin = new System.Windows.Forms.Padding(2);
			this.VNC__Path_textbox.Name = "VNC__Path_textbox";
			this.VNC__Path_textbox.Size = new System.Drawing.Size(595, 20);
			this.VNC__Path_textbox.TabIndex = 11;
			this.VNC__Path_textbox.Text = "\"C:\\Program Files\\RealVNC\\VNC4\\vncviewer.exe \"";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(105, 72);
			this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(56, 18);
			this.label32.TabIndex = 10;
			this.label32.Text = "VNC Path:";
			// 
			// FireFoxPathTextBox
			// 
			this.FireFoxPathTextBox.Location = new System.Drawing.Point(165, 45);
			this.FireFoxPathTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.FireFoxPathTextBox.Name = "FireFoxPathTextBox";
			this.FireFoxPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.FireFoxPathTextBox.TabIndex = 9;
			this.FireFoxPathTextBox.Text = "\"c:\\Program Files\\Mozilla Firefox\\firefox.exe \"";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(91, 45);
			this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(70, 18);
			this.label31.TabIndex = 8;
			this.label31.Text = "FireFox Path:";
			// 
			// textBox26
			// 
			this.textBox26.Location = new System.Drawing.Point(165, 263);
			this.textBox26.Margin = new System.Windows.Forms.Padding(2);
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new System.Drawing.Size(595, 20);
			this.textBox26.TabIndex = 7;
			this.textBox26.Text = "c:\\Websphere";
			this.textBox26.Visible = false;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(50, 263);
			this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(110, 18);
			this.label29.TabIndex = 6;
			this.label29.Text = "Websphere Directory:";
			this.label29.Visible = false;
			// 
			// WC_InstanceName_texBox
			// 
			this.WC_InstanceName_texBox.Location = new System.Drawing.Point(165, 239);
			this.WC_InstanceName_texBox.Margin = new System.Windows.Forms.Padding(2);
			this.WC_InstanceName_texBox.Name = "WC_InstanceName_texBox";
			this.WC_InstanceName_texBox.Size = new System.Drawing.Size(595, 20);
			this.WC_InstanceName_texBox.TabIndex = 5;
			this.WC_InstanceName_texBox.Text = "demo";
			this.WC_InstanceName_texBox.Visible = false;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(91, 239);
			this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(70, 18);
			this.label28.TabIndex = 4;
			this.label28.Text = "WC Instance:";
			this.label28.Visible = false;
			// 
			// textBox20
			// 
			this.textBox20.Location = new System.Drawing.Point(165, 214);
			this.textBox20.Margin = new System.Windows.Forms.Padding(2);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(595, 20);
			this.textBox20.TabIndex = 3;
			this.textBox20.Text = "config1mgr";
			this.textBox20.Visible = false;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(105, 214);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(56, 18);
			this.label22.TabIndex = 2;
			this.label22.Text = "Password:";
			this.label22.Visible = false;
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(165, 190);
			this.textBox19.Margin = new System.Windows.Forms.Padding(2);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(595, 20);
			this.textBox19.TabIndex = 1;
			this.textBox19.Text = "configadmin";
			this.textBox19.Visible = false;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(112, 190);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(49, 18);
			this.label21.TabIndex = 0;
			this.label21.Text = "wcsuser:";
			this.label21.Visible = false;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.CacheMonitorButton);
			this.tabPage6.Controls.Add(this.YantraVersionGroupBox);
			this.tabPage6.Controls.Add(this.AppServer_Port_ComboBox);
			this.tabPage6.Controls.Add(this.AppServerGroupBox);
			this.tabPage6.Controls.Add(this.AdditionalHostAddButton);
			this.tabPage6.Controls.Add(this.label24);
			this.tabPage6.Controls.Add(this.HostNameComboBox);
			this.tabPage6.Controls.Add(this.HostName2TextBox);
			this.tabPage6.Controls.Add(this.HostName2Label);
			this.tabPage6.Controls.Add(this.LocalCommandGroupBox);
			this.tabPage6.Controls.Add(this.groupBox6);
			this.tabPage6.Controls.Add(this.groupBox5);
			this.tabPage6.Controls.Add(this.groupBox4);
			this.tabPage6.Controls.Add(this.groupBox1);
			this.tabPage6.Controls.Add(this.label30);
			this.tabPage6.Controls.Add(this.UrlGoButton);
			this.tabPage6.Controls.Add(this.Default_URL_TextBox);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage6.Size = new System.Drawing.Size(1257, 693);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Links";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// CacheMonitorButton
			// 
			this.CacheMonitorButton.Location = new System.Drawing.Point(329, 383);
			this.CacheMonitorButton.Margin = new System.Windows.Forms.Padding(2);
			this.CacheMonitorButton.Name = "CacheMonitorButton";
			this.CacheMonitorButton.Size = new System.Drawing.Size(118, 24);
			this.CacheMonitorButton.TabIndex = 40;
			this.CacheMonitorButton.Text = "CacheMonitor";
			this.CacheMonitorButton.UseVisualStyleBackColor = true;
			this.CacheMonitorButton.Click += new System.EventHandler(this.CacheMonitorButtonClick);
			// 
			// YantraVersionGroupBox
			// 
			this.YantraVersionGroupBox.Controls.Add(this.YantraVersion8andLess);
			this.YantraVersionGroupBox.Controls.Add(this.YantraVersion9Type);
			this.YantraVersionGroupBox.Location = new System.Drawing.Point(2, 205);
			this.YantraVersionGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.YantraVersionGroupBox.Name = "YantraVersionGroupBox";
			this.YantraVersionGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.YantraVersionGroupBox.Size = new System.Drawing.Size(144, 126);
			this.YantraVersionGroupBox.TabIndex = 66;
			this.YantraVersionGroupBox.TabStop = false;
			this.YantraVersionGroupBox.Text = "Select Yantra Version";
			// 
			// YantraVersion8andLess
			// 
			this.YantraVersion8andLess.Location = new System.Drawing.Point(4, 32);
			this.YantraVersion8andLess.Margin = new System.Windows.Forms.Padding(2);
			this.YantraVersion8andLess.Name = "YantraVersion8andLess";
			this.YantraVersion8andLess.Size = new System.Drawing.Size(115, 20);
			this.YantraVersion8andLess.TabIndex = 40;
			this.YantraVersion8andLess.Text = "<= 8";
			this.YantraVersion8andLess.UseVisualStyleBackColor = true;
			// 
			// YantraVersion9Type
			// 
			this.YantraVersion9Type.Checked = true;
			this.YantraVersion9Type.Location = new System.Drawing.Point(4, 57);
			this.YantraVersion9Type.Margin = new System.Windows.Forms.Padding(2);
			this.YantraVersion9Type.Name = "YantraVersion9Type";
			this.YantraVersion9Type.Size = new System.Drawing.Size(115, 20);
			this.YantraVersion9Type.TabIndex = 39;
			this.YantraVersion9Type.TabStop = true;
			this.YantraVersion9Type.Text = ">= 9";
			this.YantraVersion9Type.UseVisualStyleBackColor = true;
			// 
			// AppServer_Port_ComboBox
			// 
			this.AppServer_Port_ComboBox.FormattingEnabled = true;
			this.AppServer_Port_ComboBox.Location = new System.Drawing.Point(559, 89);
			this.AppServer_Port_ComboBox.Name = "AppServer_Port_ComboBox";
			this.AppServer_Port_ComboBox.Size = new System.Drawing.Size(64, 21);
			this.AppServer_Port_ComboBox.TabIndex = 65;
			this.AppServer_Port_ComboBox.Text = "7001";
			this.AppServer_Port_ComboBox.TextChanged += new System.EventHandler(this.AppServer_Port_ComboBoxTextChanged);
			// 
			// AppServerGroupBox
			// 
			this.AppServerGroupBox.Controls.Add(this.WebSphereCheckBox);
			this.AppServerGroupBox.Controls.Add(this.WebLogicCheckBox);
			this.AppServerGroupBox.Controls.Add(this.JBossCheckBox);
			this.AppServerGroupBox.Location = new System.Drawing.Point(156, 43);
			this.AppServerGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.AppServerGroupBox.Name = "AppServerGroupBox";
			this.AppServerGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.AppServerGroupBox.Size = new System.Drawing.Size(121, 125);
			this.AppServerGroupBox.TabIndex = 41;
			this.AppServerGroupBox.TabStop = false;
			this.AppServerGroupBox.Text = "Select AppServer";
			// 
			// WebSphereCheckBox
			// 
			this.WebSphereCheckBox.Location = new System.Drawing.Point(4, 32);
			this.WebSphereCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.WebSphereCheckBox.Name = "WebSphereCheckBox";
			this.WebSphereCheckBox.Size = new System.Drawing.Size(115, 20);
			this.WebSphereCheckBox.TabIndex = 40;
			this.WebSphereCheckBox.Text = "WebSphere";
			this.WebSphereCheckBox.UseVisualStyleBackColor = true;
			// 
			// WebLogicCheckBox
			// 
			this.WebLogicCheckBox.Checked = true;
			this.WebLogicCheckBox.Location = new System.Drawing.Point(4, 57);
			this.WebLogicCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.WebLogicCheckBox.Name = "WebLogicCheckBox";
			this.WebLogicCheckBox.Size = new System.Drawing.Size(115, 20);
			this.WebLogicCheckBox.TabIndex = 39;
			this.WebLogicCheckBox.TabStop = true;
			this.WebLogicCheckBox.Text = "WebLogic";
			this.WebLogicCheckBox.UseVisualStyleBackColor = true;
			// 
			// JBossCheckBox
			// 
			this.JBossCheckBox.Location = new System.Drawing.Point(4, 81);
			this.JBossCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.JBossCheckBox.Name = "JBossCheckBox";
			this.JBossCheckBox.Size = new System.Drawing.Size(108, 20);
			this.JBossCheckBox.TabIndex = 33;
			this.JBossCheckBox.Text = "JBoss";
			this.JBossCheckBox.UseVisualStyleBackColor = true;
			// 
			// AdditionalHostAddButton
			// 
			this.AdditionalHostAddButton.Location = new System.Drawing.Point(719, 35);
			this.AdditionalHostAddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AdditionalHostAddButton.Name = "AdditionalHostAddButton";
			this.AdditionalHostAddButton.Size = new System.Drawing.Size(151, 23);
			this.AdditionalHostAddButton.TabIndex = 64;
			this.AdditionalHostAddButton.Text = "ADD host without IP";
			this.AdditionalHostAddButton.UseVisualStyleBackColor = true;
			this.AdditionalHostAddButton.Click += new System.EventHandler(this.AdditionalHostAddButtonClick);
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(469, 91);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(85, 21);
			this.label24.TabIndex = 9;
			this.label24.Text = "App Server Port:";
			// 
			// HostNameComboBox
			// 
			this.HostNameComboBox.FormattingEnabled = true;
			this.HostNameComboBox.Location = new System.Drawing.Point(538, 58);
			this.HostNameComboBox.Name = "HostNameComboBox";
			this.HostNameComboBox.Size = new System.Drawing.Size(177, 21);
			this.HostNameComboBox.TabIndex = 53;
			this.HostNameComboBox.SelectedIndexChanged += new System.EventHandler(this.HostNameComboBoxSelectedIndexChanged);
			// 
			// HostName2TextBox
			// 
			this.HostName2TextBox.Location = new System.Drawing.Point(538, 35);
			this.HostName2TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.HostName2TextBox.Name = "HostName2TextBox";
			this.HostName2TextBox.Size = new System.Drawing.Size(177, 20);
			this.HostName2TextBox.TabIndex = 50;
			this.HostName2TextBox.Text = "localhost";
			this.HostName2TextBox.TextChanged += new System.EventHandler(this.HostName2TextBoxTextChanged);
			// 
			// HostName2Label
			// 
			this.HostName2Label.Location = new System.Drawing.Point(467, 38);
			this.HostName2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HostName2Label.Name = "HostName2Label";
			this.HostName2Label.Size = new System.Drawing.Size(66, 20);
			this.HostName2Label.TabIndex = 51;
			this.HostName2Label.Text = "Host Name:";
			// 
			// LocalCommandGroupBox
			// 
			this.LocalCommandGroupBox.Controls.Add(this.IPConfigButton);
			this.LocalCommandGroupBox.Controls.Add(this.StartJmeterButton);
			this.LocalCommandGroupBox.Location = new System.Drawing.Point(287, 269);
			this.LocalCommandGroupBox.Name = "LocalCommandGroupBox";
			this.LocalCommandGroupBox.Size = new System.Drawing.Size(169, 83);
			this.LocalCommandGroupBox.TabIndex = 49;
			this.LocalCommandGroupBox.TabStop = false;
			this.LocalCommandGroupBox.Text = "Local Commands";
			// 
			// IPConfigButton
			// 
			this.IPConfigButton.Location = new System.Drawing.Point(19, 48);
			this.IPConfigButton.Name = "IPConfigButton";
			this.IPConfigButton.Size = new System.Drawing.Size(118, 23);
			this.IPConfigButton.TabIndex = 49;
			this.IPConfigButton.Text = "IPConfig";
			this.IPConfigButton.UseVisualStyleBackColor = true;
			this.IPConfigButton.Click += new System.EventHandler(this.Button87Click);
			// 
			// StartJmeterButton
			// 
			this.StartJmeterButton.Location = new System.Drawing.Point(19, 19);
			this.StartJmeterButton.Name = "StartJmeterButton";
			this.StartJmeterButton.Size = new System.Drawing.Size(118, 23);
			this.StartJmeterButton.TabIndex = 48;
			this.StartJmeterButton.Text = "StartJmeter";
			this.StartJmeterButton.UseVisualStyleBackColor = true;
			this.StartJmeterButton.Click += new System.EventHandler(this.StartJmeterButtonClick);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.AppServerConsoleButton);
			this.groupBox6.Controls.Add(this.button15);
			this.groupBox6.Location = new System.Drawing.Point(287, 162);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox6.Size = new System.Drawing.Size(171, 94);
			this.groupBox6.TabIndex = 44;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "IE Only Pages";
			// 
			// AppServerConsoleButton
			// 
			this.AppServerConsoleButton.Location = new System.Drawing.Point(4, 52);
			this.AppServerConsoleButton.Margin = new System.Windows.Forms.Padding(2);
			this.AppServerConsoleButton.Name = "AppServerConsoleButton";
			this.AppServerConsoleButton.Size = new System.Drawing.Size(156, 24);
			this.AppServerConsoleButton.TabIndex = 6;
			this.AppServerConsoleButton.Text = "AppServer Console";
			this.AppServerConsoleButton.UseVisualStyleBackColor = true;
			this.AppServerConsoleButton.Click += new System.EventHandler(this.Button18Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(4, 24);
			this.button15.Margin = new System.Windows.Forms.Padding(2);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(156, 24);
			this.button15.TabIndex = 3;
			this.button15.Text = "SMFCS";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.FTPClientButton);
			this.groupBox5.Controls.Add(this.AutoCredential_CheckBox);
			this.groupBox5.Controls.Add(this.FTPBrowserButton);
			this.groupBox5.Controls.Add(this.SMB_Button);
			this.groupBox5.Controls.Add(this.WinSCP_Button);
			this.groupBox5.Controls.Add(this.HostSpecificCheckBox);
			this.groupBox5.Controls.Add(this.RemoteDesktop_button);
			this.groupBox5.Controls.Add(this.Telnet_button);
			this.groupBox5.Controls.Add(this.Putty_button);
			this.groupBox5.Controls.Add(this.VNC_button);
			this.groupBox5.Controls.Add(this.MachineCheckGroupBox);
			this.groupBox5.Location = new System.Drawing.Point(471, 138);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(429, 307);
			this.groupBox5.TabIndex = 43;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Utilities";
			// 
			// FTPClientButton
			// 
			this.FTPClientButton.Location = new System.Drawing.Point(7, 249);
			this.FTPClientButton.Name = "FTPClientButton";
			this.FTPClientButton.Size = new System.Drawing.Size(118, 23);
			this.FTPClientButton.TabIndex = 46;
			this.FTPClientButton.Text = "FTP client";
			this.FTPClientButton.UseVisualStyleBackColor = true;
			// 
			// AutoCredential_CheckBox
			// 
			this.AutoCredential_CheckBox.Checked = true;
			this.AutoCredential_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoCredential_CheckBox.Location = new System.Drawing.Point(112, 35);
			this.AutoCredential_CheckBox.Name = "AutoCredential_CheckBox";
			this.AutoCredential_CheckBox.Size = new System.Drawing.Size(104, 24);
			this.AutoCredential_CheckBox.TabIndex = 62;
			this.AutoCredential_CheckBox.Text = "Auto Credential";
			this.AutoCredential_CheckBox.UseVisualStyleBackColor = true;
			// 
			// FTPBrowserButton
			// 
			this.FTPBrowserButton.Location = new System.Drawing.Point(7, 278);
			this.FTPBrowserButton.Name = "FTPBrowserButton";
			this.FTPBrowserButton.Size = new System.Drawing.Size(118, 23);
			this.FTPBrowserButton.TabIndex = 45;
			this.FTPBrowserButton.Text = "FTP(Default)";
			this.FTPBrowserButton.UseVisualStyleBackColor = true;
			this.FTPBrowserButton.Click += new System.EventHandler(this.FTPBrowserButtonClick);
			// 
			// SMB_Button
			// 
			this.SMB_Button.Location = new System.Drawing.Point(7, 220);
			this.SMB_Button.Name = "SMB_Button";
			this.SMB_Button.Size = new System.Drawing.Size(118, 23);
			this.SMB_Button.TabIndex = 43;
			this.SMB_Button.Text = "Browse SMB Shares";
			this.SMB_Button.UseVisualStyleBackColor = true;
			this.SMB_Button.Click += new System.EventHandler(this.Button6Click);
			// 
			// WinSCP_Button
			// 
			this.WinSCP_Button.Location = new System.Drawing.Point(7, 191);
			this.WinSCP_Button.Name = "WinSCP_Button";
			this.WinSCP_Button.Size = new System.Drawing.Size(118, 23);
			this.WinSCP_Button.TabIndex = 42;
			this.WinSCP_Button.Text = "Win SCP";
			this.WinSCP_Button.UseVisualStyleBackColor = true;
			this.WinSCP_Button.Click += new System.EventHandler(this.Button5Click);
			// 
			// HostSpecificCheckBox
			// 
			this.HostSpecificCheckBox.Checked = true;
			this.HostSpecificCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HostSpecificCheckBox.Location = new System.Drawing.Point(14, 35);
			this.HostSpecificCheckBox.Name = "HostSpecificCheckBox";
			this.HostSpecificCheckBox.Size = new System.Drawing.Size(104, 24);
			this.HostSpecificCheckBox.TabIndex = 58;
			this.HostSpecificCheckBox.Text = "Use Hostname";
			this.HostSpecificCheckBox.UseVisualStyleBackColor = true;
			// 
			// RemoteDesktop_button
			// 
			this.RemoteDesktop_button.Location = new System.Drawing.Point(7, 162);
			this.RemoteDesktop_button.Margin = new System.Windows.Forms.Padding(2);
			this.RemoteDesktop_button.Name = "RemoteDesktop_button";
			this.RemoteDesktop_button.Size = new System.Drawing.Size(118, 24);
			this.RemoteDesktop_button.TabIndex = 30;
			this.RemoteDesktop_button.Text = "Remote Desktop";
			this.RemoteDesktop_button.UseVisualStyleBackColor = true;
			this.RemoteDesktop_button.Click += new System.EventHandler(this.Button24Click);
			// 
			// Telnet_button
			// 
			this.Telnet_button.Location = new System.Drawing.Point(7, 133);
			this.Telnet_button.Margin = new System.Windows.Forms.Padding(2);
			this.Telnet_button.Name = "Telnet_button";
			this.Telnet_button.Size = new System.Drawing.Size(118, 24);
			this.Telnet_button.TabIndex = 34;
			this.Telnet_button.Text = "Telnet";
			this.Telnet_button.UseVisualStyleBackColor = true;
			this.Telnet_button.Click += new System.EventHandler(this.Button27Click);
			// 
			// Putty_button
			// 
			this.Putty_button.Location = new System.Drawing.Point(7, 104);
			this.Putty_button.Margin = new System.Windows.Forms.Padding(2);
			this.Putty_button.Name = "Putty_button";
			this.Putty_button.Size = new System.Drawing.Size(118, 24);
			this.Putty_button.TabIndex = 41;
			this.Putty_button.Text = "Putty";
			this.Putty_button.UseVisualStyleBackColor = true;
			this.Putty_button.Click += new System.EventHandler(this.Button31Click);
			// 
			// VNC_button
			// 
			this.VNC_button.Location = new System.Drawing.Point(7, 75);
			this.VNC_button.Margin = new System.Windows.Forms.Padding(2);
			this.VNC_button.Name = "VNC_button";
			this.VNC_button.Size = new System.Drawing.Size(118, 24);
			this.VNC_button.TabIndex = 31;
			this.VNC_button.Text = "VNC viewer";
			this.VNC_button.UseVisualStyleBackColor = true;
			this.VNC_button.Click += new System.EventHandler(this.Button29Click);
			// 
			// MachineCheckGroupBox
			// 
			this.MachineCheckGroupBox.Controls.Add(this.MachineCheckSTAFButton);
			this.MachineCheckGroupBox.Controls.Add(this.HttpCheckPortTextBox);
			this.MachineCheckGroupBox.Controls.Add(this.HttpsCheckPortTextBox);
			this.MachineCheckGroupBox.Controls.Add(this.HttpsCheckButton);
			this.MachineCheckGroupBox.Controls.Add(this.HttpCheckButton);
			this.MachineCheckGroupBox.Controls.Add(this.button28);
			this.MachineCheckGroupBox.Location = new System.Drawing.Point(183, 116);
			this.MachineCheckGroupBox.Name = "MachineCheckGroupBox";
			this.MachineCheckGroupBox.Size = new System.Drawing.Size(230, 178);
			this.MachineCheckGroupBox.TabIndex = 45;
			this.MachineCheckGroupBox.TabStop = false;
			this.MachineCheckGroupBox.Text = "Machine Checks";
			// 
			// MachineCheckSTAFButton
			// 
			this.MachineCheckSTAFButton.Location = new System.Drawing.Point(5, 100);
			this.MachineCheckSTAFButton.Margin = new System.Windows.Forms.Padding(2);
			this.MachineCheckSTAFButton.Name = "MachineCheckSTAFButton";
			this.MachineCheckSTAFButton.Size = new System.Drawing.Size(118, 24);
			this.MachineCheckSTAFButton.TabIndex = 40;
			this.MachineCheckSTAFButton.Text = "STAFCheck";
			this.MachineCheckSTAFButton.UseVisualStyleBackColor = true;
			this.MachineCheckSTAFButton.Click += new System.EventHandler(this.MachineCheckSTAFButtonClick);
			// 
			// HttpCheckPortTextBox
			// 
			this.HttpCheckPortTextBox.Location = new System.Drawing.Point(145, 44);
			this.HttpCheckPortTextBox.Name = "HttpCheckPortTextBox";
			this.HttpCheckPortTextBox.Size = new System.Drawing.Size(72, 20);
			this.HttpCheckPortTextBox.TabIndex = 39;
			this.HttpCheckPortTextBox.Text = "80";
			// 
			// HttpsCheckPortTextBox
			// 
			this.HttpsCheckPortTextBox.Location = new System.Drawing.Point(145, 75);
			this.HttpsCheckPortTextBox.Name = "HttpsCheckPortTextBox";
			this.HttpsCheckPortTextBox.Size = new System.Drawing.Size(72, 20);
			this.HttpsCheckPortTextBox.TabIndex = 38;
			this.HttpsCheckPortTextBox.Text = "443";
			// 
			// HttpsCheckButton
			// 
			this.HttpsCheckButton.Location = new System.Drawing.Point(5, 72);
			this.HttpsCheckButton.Margin = new System.Windows.Forms.Padding(2);
			this.HttpsCheckButton.Name = "HttpsCheckButton";
			this.HttpsCheckButton.Size = new System.Drawing.Size(118, 24);
			this.HttpsCheckButton.TabIndex = 37;
			this.HttpsCheckButton.Text = "HttpsCheck";
			this.HttpsCheckButton.UseVisualStyleBackColor = true;
			this.HttpsCheckButton.Click += new System.EventHandler(this.HttpsCheckButtonClick);
			// 
			// HttpCheckButton
			// 
			this.HttpCheckButton.Location = new System.Drawing.Point(5, 44);
			this.HttpCheckButton.Margin = new System.Windows.Forms.Padding(2);
			this.HttpCheckButton.Name = "HttpCheckButton";
			this.HttpCheckButton.Size = new System.Drawing.Size(118, 24);
			this.HttpCheckButton.TabIndex = 36;
			this.HttpCheckButton.Text = "HttpCheck";
			this.HttpCheckButton.UseVisualStyleBackColor = true;
			this.HttpCheckButton.Click += new System.EventHandler(this.HttpCheckButtonClick);
			// 
			// button28
			// 
			this.button28.Location = new System.Drawing.Point(5, 16);
			this.button28.Margin = new System.Windows.Forms.Padding(2);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(118, 24);
			this.button28.TabIndex = 35;
			this.button28.Text = "Ping";
			this.button28.UseVisualStyleBackColor = true;
			this.button28.Click += new System.EventHandler(this.Button28Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.LaunchSFSButton);
			this.groupBox4.Controls.Add(this.button21);
			this.groupBox4.Controls.Add(this.button16);
			this.groupBox4.Location = new System.Drawing.Point(291, 43);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(167, 119);
			this.groupBox4.TabIndex = 42;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Pages";
			// 
			// LaunchSFSButton
			// 
			this.LaunchSFSButton.Location = new System.Drawing.Point(17, 81);
			this.LaunchSFSButton.Margin = new System.Windows.Forms.Padding(2);
			this.LaunchSFSButton.Name = "LaunchSFSButton";
			this.LaunchSFSButton.Size = new System.Drawing.Size(118, 24);
			this.LaunchSFSButton.TabIndex = 12;
			this.LaunchSFSButton.Text = "SFS";
			this.LaunchSFSButton.UseVisualStyleBackColor = true;
			this.LaunchSFSButton.Click += new System.EventHandler(this.LaunchSFSButtonClick);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(17, 51);
			this.button21.Margin = new System.Windows.Forms.Padding(2);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(118, 24);
			this.button21.TabIndex = 11;
			this.button21.Text = "API Tester";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.Button21Click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(17, 23);
			this.button16.Margin = new System.Windows.Forms.Padding(2);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(118, 24);
			this.button16.TabIndex = 4;
			this.button16.Text = "SBC";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.otherBrowsersComboBox);
			this.groupBox1.Controls.Add(this.otherBrowserRadioButton);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(6, 43);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(144, 154);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Browser";
			// 
			// otherBrowsersComboBox
			// 
			this.otherBrowsersComboBox.Enabled = false;
			this.otherBrowsersComboBox.FormattingEnabled = true;
			this.otherBrowsersComboBox.Location = new System.Drawing.Point(57, 105);
			this.otherBrowsersComboBox.Name = "otherBrowsersComboBox";
			this.otherBrowsersComboBox.Size = new System.Drawing.Size(83, 21);
			this.otherBrowsersComboBox.TabIndex = 54;
			// 
			// otherBrowserRadioButton
			// 
			this.otherBrowserRadioButton.Enabled = false;
			this.otherBrowserRadioButton.Location = new System.Drawing.Point(4, 107);
			this.otherBrowserRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this.otherBrowserRadioButton.Name = "otherBrowserRadioButton";
			this.otherBrowserRadioButton.Size = new System.Drawing.Size(80, 20);
			this.otherBrowserRadioButton.TabIndex = 41;
			this.otherBrowserRadioButton.Text = "Other";
			this.otherBrowserRadioButton.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(4, 32);
			this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(115, 20);
			this.radioButton3.TabIndex = 40;
			this.radioButton3.Text = "Open in IE";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(4, 57);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(115, 20);
			this.radioButton2.TabIndex = 39;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Open in Firefox";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(4, 81);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(136, 20);
			this.radioButton1.TabIndex = 33;
			this.radioButton1.Text = "Open in TesterBuddy";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(15, 358);
			this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(33, 22);
			this.label30.TabIndex = 38;
			this.label30.Text = "URL";
			// 
			// UrlGoButton
			// 
			this.UrlGoButton.Location = new System.Drawing.Point(211, 357);
			this.UrlGoButton.Margin = new System.Windows.Forms.Padding(2);
			this.UrlGoButton.Name = "UrlGoButton";
			this.UrlGoButton.Size = new System.Drawing.Size(35, 23);
			this.UrlGoButton.TabIndex = 37;
			this.UrlGoButton.Text = "GO";
			this.UrlGoButton.UseVisualStyleBackColor = true;
			this.UrlGoButton.Click += new System.EventHandler(this.Button30Click);
			// 
			// Default_URL_TextBox
			// 
			this.Default_URL_TextBox.Location = new System.Drawing.Point(53, 358);
			this.Default_URL_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.Default_URL_TextBox.Name = "Default_URL_TextBox";
			this.Default_URL_TextBox.Size = new System.Drawing.Size(152, 20);
			this.Default_URL_TextBox.TabIndex = 36;
			this.Default_URL_TextBox.Text = "http://www.w3.ibm.com";
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.groupBox3);
			this.tabPage7.Controls.Add(this.SEOTypeUrlCheckBox);
			this.tabPage7.Controls.Add(this.StoreName_ComboBox);
			this.tabPage7.Controls.Add(this.CatalogIDComboBox);
			this.tabPage7.Controls.Add(this.WC_StoreID_ComboBox);
			this.tabPage7.Controls.Add(this.OtherPagesGroupBox);
			this.tabPage7.Controls.Add(this.MachineTypeGroupBox);
			this.tabPage7.Controls.Add(this.label37);
			this.tabPage7.Controls.Add(this.LaunchStoreByName);
			this.tabPage7.Controls.Add(this.label27);
			this.tabPage7.Controls.Add(this.button14);
			this.tabPage7.Controls.Add(this.label23);
			this.tabPage7.Controls.Add(this.groupBox21);
			this.tabPage7.Controls.Add(this.groupBox20);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage7.Size = new System.Drawing.Size(1257, 693);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "WC links";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.WC_openinIERB);
			this.groupBox3.Controls.Add(this.WC_openinFFRB);
			this.groupBox3.Controls.Add(this.WC_openinTBRB);
			this.groupBox3.Location = new System.Drawing.Point(20, 162);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(144, 125);
			this.groupBox3.TabIndex = 75;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Select Browser";
			// 
			// WC_openinIERB
			// 
			this.WC_openinIERB.Location = new System.Drawing.Point(4, 32);
			this.WC_openinIERB.Margin = new System.Windows.Forms.Padding(2);
			this.WC_openinIERB.Name = "WC_openinIERB";
			this.WC_openinIERB.Size = new System.Drawing.Size(115, 20);
			this.WC_openinIERB.TabIndex = 40;
			this.WC_openinIERB.Text = "Open in IE";
			this.WC_openinIERB.UseVisualStyleBackColor = true;
			this.WC_openinIERB.CheckedChanged += new System.EventHandler(this.WC_openinIERBCheckedChanged);
			// 
			// WC_openinFFRB
			// 
			this.WC_openinFFRB.Checked = true;
			this.WC_openinFFRB.Location = new System.Drawing.Point(4, 57);
			this.WC_openinFFRB.Margin = new System.Windows.Forms.Padding(2);
			this.WC_openinFFRB.Name = "WC_openinFFRB";
			this.WC_openinFFRB.Size = new System.Drawing.Size(115, 20);
			this.WC_openinFFRB.TabIndex = 39;
			this.WC_openinFFRB.TabStop = true;
			this.WC_openinFFRB.Text = "Open in Firefox";
			this.WC_openinFFRB.UseVisualStyleBackColor = true;
			this.WC_openinFFRB.CheckedChanged += new System.EventHandler(this.WC_openinFFRBCheckedChanged);
			// 
			// WC_openinTBRB
			// 
			this.WC_openinTBRB.Location = new System.Drawing.Point(4, 81);
			this.WC_openinTBRB.Margin = new System.Windows.Forms.Padding(2);
			this.WC_openinTBRB.Name = "WC_openinTBRB";
			this.WC_openinTBRB.Size = new System.Drawing.Size(136, 20);
			this.WC_openinTBRB.TabIndex = 33;
			this.WC_openinTBRB.Text = "Open in TesterBuddy";
			this.WC_openinTBRB.UseVisualStyleBackColor = true;
			this.WC_openinTBRB.CheckedChanged += new System.EventHandler(this.WC_openinTBRBCheckedChanged);
			// 
			// SEOTypeUrlCheckBox
			// 
			this.SEOTypeUrlCheckBox.Location = new System.Drawing.Point(784, 12);
			this.SEOTypeUrlCheckBox.Name = "SEOTypeUrlCheckBox";
			this.SEOTypeUrlCheckBox.Size = new System.Drawing.Size(104, 24);
			this.SEOTypeUrlCheckBox.TabIndex = 74;
			this.SEOTypeUrlCheckBox.Text = "SEO Url";
			this.SEOTypeUrlCheckBox.UseVisualStyleBackColor = true;
			// 
			// StoreName_ComboBox
			// 
			this.StoreName_ComboBox.FormattingEnabled = true;
			this.StoreName_ComboBox.Items.AddRange(new object[] {
									"Madisons"});
			this.StoreName_ComboBox.Location = new System.Drawing.Point(516, 16);
			this.StoreName_ComboBox.Name = "StoreName_ComboBox";
			this.StoreName_ComboBox.Size = new System.Drawing.Size(132, 21);
			this.StoreName_ComboBox.TabIndex = 73;
			// 
			// CatalogIDComboBox
			// 
			this.CatalogIDComboBox.FormattingEnabled = true;
			this.CatalogIDComboBox.Items.AddRange(new object[] {
									"10001"});
			this.CatalogIDComboBox.Location = new System.Drawing.Point(238, 16);
			this.CatalogIDComboBox.Name = "CatalogIDComboBox";
			this.CatalogIDComboBox.Size = new System.Drawing.Size(80, 21);
			this.CatalogIDComboBox.TabIndex = 72;
			// 
			// WC_StoreID_ComboBox
			// 
			this.WC_StoreID_ComboBox.FormattingEnabled = true;
			this.WC_StoreID_ComboBox.Items.AddRange(new object[] {
									"10152"});
			this.WC_StoreID_ComboBox.Location = new System.Drawing.Point(81, 17);
			this.WC_StoreID_ComboBox.Name = "WC_StoreID_ComboBox";
			this.WC_StoreID_ComboBox.Size = new System.Drawing.Size(80, 21);
			this.WC_StoreID_ComboBox.TabIndex = 71;
			// 
			// OtherPagesGroupBox
			// 
			this.OtherPagesGroupBox.Controls.Add(this.button22);
			this.OtherPagesGroupBox.Controls.Add(this.button20);
			this.OtherPagesGroupBox.Controls.Add(this.InfoCenterVisitButton);
			this.OtherPagesGroupBox.Controls.Add(this.button23);
			this.OtherPagesGroupBox.Location = new System.Drawing.Point(326, 253);
			this.OtherPagesGroupBox.Name = "OtherPagesGroupBox";
			this.OtherPagesGroupBox.Size = new System.Drawing.Size(175, 138);
			this.OtherPagesGroupBox.TabIndex = 70;
			this.OtherPagesGroupBox.TabStop = false;
			this.OtherPagesGroupBox.Text = "Other";
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(17, 14);
			this.button22.Margin = new System.Windows.Forms.Padding(2);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(118, 24);
			this.button22.TabIndex = 12;
			this.button22.Text = "DB Info";
			this.button22.UseVisualStyleBackColor = true;
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(17, 42);
			this.button20.Margin = new System.Windows.Forms.Padding(2);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(118, 24);
			this.button20.TabIndex = 10;
			this.button20.Text = "Artec";
			this.button20.UseVisualStyleBackColor = true;
			// 
			// InfoCenterVisitButton
			// 
			this.InfoCenterVisitButton.Location = new System.Drawing.Point(17, 70);
			this.InfoCenterVisitButton.Margin = new System.Windows.Forms.Padding(2);
			this.InfoCenterVisitButton.Name = "InfoCenterVisitButton";
			this.InfoCenterVisitButton.Size = new System.Drawing.Size(118, 24);
			this.InfoCenterVisitButton.TabIndex = 14;
			this.InfoCenterVisitButton.Text = "Info Center";
			this.InfoCenterVisitButton.UseVisualStyleBackColor = true;
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(17, 98);
			this.button23.Margin = new System.Windows.Forms.Padding(2);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(118, 24);
			this.button23.TabIndex = 13;
			this.button23.Text = "Coremetrics";
			this.button23.UseVisualStyleBackColor = true;
			// 
			// MachineTypeGroupBox
			// 
			this.MachineTypeGroupBox.Controls.Add(this.Remote_OS_GroupBox);
			this.MachineTypeGroupBox.Controls.Add(this.ToolkitRadioButton);
			this.MachineTypeGroupBox.Controls.Add(this.RunTimeRadioButton);
			this.MachineTypeGroupBox.Location = new System.Drawing.Point(20, 64);
			this.MachineTypeGroupBox.Name = "MachineTypeGroupBox";
			this.MachineTypeGroupBox.Size = new System.Drawing.Size(274, 79);
			this.MachineTypeGroupBox.TabIndex = 69;
			this.MachineTypeGroupBox.TabStop = false;
			this.MachineTypeGroupBox.Text = "Machine Type";
			// 
			// Remote_OS_GroupBox
			// 
			this.Remote_OS_GroupBox.Controls.Add(this.Remote_OS_AIX);
			this.Remote_OS_GroupBox.Controls.Add(this.Remote_OS_XLinux);
			this.Remote_OS_GroupBox.Controls.Add(this.Remote_OS_Windows);
			this.Remote_OS_GroupBox.Location = new System.Drawing.Point(72, 19);
			this.Remote_OS_GroupBox.Name = "Remote_OS_GroupBox";
			this.Remote_OS_GroupBox.Size = new System.Drawing.Size(193, 51);
			this.Remote_OS_GroupBox.TabIndex = 25;
			this.Remote_OS_GroupBox.TabStop = false;
			this.Remote_OS_GroupBox.Text = "OS";
			// 
			// Remote_OS_AIX
			// 
			this.Remote_OS_AIX.Location = new System.Drawing.Point(134, 21);
			this.Remote_OS_AIX.Name = "Remote_OS_AIX";
			this.Remote_OS_AIX.Size = new System.Drawing.Size(48, 24);
			this.Remote_OS_AIX.TabIndex = 2;
			this.Remote_OS_AIX.TabStop = true;
			this.Remote_OS_AIX.Text = "AIX";
			this.Remote_OS_AIX.UseVisualStyleBackColor = true;
			// 
			// Remote_OS_XLinux
			// 
			this.Remote_OS_XLinux.Location = new System.Drawing.Point(72, 21);
			this.Remote_OS_XLinux.Name = "Remote_OS_XLinux";
			this.Remote_OS_XLinux.Size = new System.Drawing.Size(67, 24);
			this.Remote_OS_XLinux.TabIndex = 1;
			this.Remote_OS_XLinux.TabStop = true;
			this.Remote_OS_XLinux.Text = "XLinux";
			this.Remote_OS_XLinux.UseVisualStyleBackColor = true;
			// 
			// Remote_OS_Windows
			// 
			this.Remote_OS_Windows.Location = new System.Drawing.Point(6, 21);
			this.Remote_OS_Windows.Name = "Remote_OS_Windows";
			this.Remote_OS_Windows.Size = new System.Drawing.Size(71, 24);
			this.Remote_OS_Windows.TabIndex = 0;
			this.Remote_OS_Windows.TabStop = true;
			this.Remote_OS_Windows.Text = "Windows";
			this.Remote_OS_Windows.UseVisualStyleBackColor = true;
			// 
			// ToolkitRadioButton
			// 
			this.ToolkitRadioButton.Location = new System.Drawing.Point(6, 51);
			this.ToolkitRadioButton.Name = "ToolkitRadioButton";
			this.ToolkitRadioButton.Size = new System.Drawing.Size(77, 19);
			this.ToolkitRadioButton.TabIndex = 1;
			this.ToolkitRadioButton.Text = "Toolkit";
			this.ToolkitRadioButton.UseVisualStyleBackColor = true;
			// 
			// RunTimeRadioButton
			// 
			this.RunTimeRadioButton.Checked = true;
			this.RunTimeRadioButton.Location = new System.Drawing.Point(6, 19);
			this.RunTimeRadioButton.Name = "RunTimeRadioButton";
			this.RunTimeRadioButton.Size = new System.Drawing.Size(104, 24);
			this.RunTimeRadioButton.TabIndex = 0;
			this.RunTimeRadioButton.TabStop = true;
			this.RunTimeRadioButton.Text = "Runtime";
			this.RunTimeRadioButton.UseVisualStyleBackColor = true;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(470, 17);
			this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(56, 21);
			this.label37.TabIndex = 68;
			this.label37.Text = "Name:";
			// 
			// LaunchStoreByName
			// 
			this.LaunchStoreByName.Location = new System.Drawing.Point(661, 12);
			this.LaunchStoreByName.Margin = new System.Windows.Forms.Padding(2);
			this.LaunchStoreByName.Name = "LaunchStoreByName";
			this.LaunchStoreByName.Size = new System.Drawing.Size(118, 24);
			this.LaunchStoreByName.TabIndex = 67;
			this.LaunchStoreByName.Text = "Launch Store";
			this.LaunchStoreByName.UseVisualStyleBackColor = true;
			this.LaunchStoreByName.Click += new System.EventHandler(this.LaunchStoreByNameClick);
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(166, 22);
			this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(63, 21);
			this.label27.TabIndex = 66;
			this.label27.Text = "Catalog ID:";
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(326, 16);
			this.button14.Margin = new System.Windows.Forms.Padding(2);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(118, 24);
			this.button14.TabIndex = 65;
			this.button14.Text = "Launch Store";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(20, 20);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(56, 17);
			this.label23.TabIndex = 64;
			this.label23.Text = "Store ID:";
			// 
			// groupBox21
			// 
			this.groupBox21.Controls.Add(this.WCLinks_CMCButton);
			this.groupBox21.Location = new System.Drawing.Point(516, 104);
			this.groupBox21.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox21.Name = "groupBox21";
			this.groupBox21.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox21.Size = new System.Drawing.Size(167, 68);
			this.groupBox21.TabIndex = 46;
			this.groupBox21.TabStop = false;
			this.groupBox21.Text = "Tooling";
			// 
			// WCLinks_CMCButton
			// 
			this.WCLinks_CMCButton.Location = new System.Drawing.Point(17, 23);
			this.WCLinks_CMCButton.Margin = new System.Windows.Forms.Padding(2);
			this.WCLinks_CMCButton.Name = "WCLinks_CMCButton";
			this.WCLinks_CMCButton.Size = new System.Drawing.Size(118, 24);
			this.WCLinks_CMCButton.TabIndex = 4;
			this.WCLinks_CMCButton.Text = "CMC";
			this.WCLinks_CMCButton.UseVisualStyleBackColor = true;
			this.WCLinks_CMCButton.Click += new System.EventHandler(this.WCLinks_CMCButtonClick);
			// 
			// groupBox20
			// 
			this.groupBox20.Controls.Add(this.WCLink_AcceleratorButton);
			this.groupBox20.Controls.Add(this.WorkspaceAdminConsoleLinkButton);
			this.groupBox20.Controls.Add(this.button19);
			this.groupBox20.Controls.Add(this.button17);
			this.groupBox20.Location = new System.Drawing.Point(326, 64);
			this.groupBox20.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox20.Name = "groupBox20";
			this.groupBox20.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox20.Size = new System.Drawing.Size(175, 184);
			this.groupBox20.TabIndex = 45;
			this.groupBox20.TabStop = false;
			this.groupBox20.Text = "IE Only Pages";
			// 
			// WCLink_AcceleratorButton
			// 
			this.WCLink_AcceleratorButton.Location = new System.Drawing.Point(4, 26);
			this.WCLink_AcceleratorButton.Margin = new System.Windows.Forms.Padding(2);
			this.WCLink_AcceleratorButton.Name = "WCLink_AcceleratorButton";
			this.WCLink_AcceleratorButton.Size = new System.Drawing.Size(156, 24);
			this.WCLink_AcceleratorButton.TabIndex = 14;
			this.WCLink_AcceleratorButton.Text = "Accelerator";
			this.WCLink_AcceleratorButton.UseVisualStyleBackColor = true;
			this.WCLink_AcceleratorButton.Click += new System.EventHandler(this.WCLink_AcceleratorButtonClick);
			// 
			// WorkspaceAdminConsoleLinkButton
			// 
			this.WorkspaceAdminConsoleLinkButton.Location = new System.Drawing.Point(4, 109);
			this.WorkspaceAdminConsoleLinkButton.Margin = new System.Windows.Forms.Padding(2);
			this.WorkspaceAdminConsoleLinkButton.Name = "WorkspaceAdminConsoleLinkButton";
			this.WorkspaceAdminConsoleLinkButton.Size = new System.Drawing.Size(156, 24);
			this.WorkspaceAdminConsoleLinkButton.TabIndex = 13;
			this.WorkspaceAdminConsoleLinkButton.Text = "Workspace Adm. Console";
			this.WorkspaceAdminConsoleLinkButton.UseVisualStyleBackColor = true;
			this.WorkspaceAdminConsoleLinkButton.Click += new System.EventHandler(this.WorkspaceAdminConsoleLinkButtonClick);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(4, 81);
			this.button19.Margin = new System.Windows.Forms.Padding(2);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(156, 24);
			this.button19.TabIndex = 12;
			this.button19.Text = "Org Adm. Console";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(4, 54);
			this.button17.Margin = new System.Windows.Forms.Padding(2);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(156, 24);
			this.button17.TabIndex = 11;
			this.button17.Text = "Admin Console";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.panel1);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage8.Size = new System.Drawing.Size(1257, 693);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Browser";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.webBrowser1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1253, 689);
			this.panel1.TabIndex = 1;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1253, 689);
			this.webBrowser1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.splitContainer3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1257, 693);
			this.tabPage3.TabIndex = 8;
			this.tabPage3.Text = "ScreenShots";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(3, 3);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.label14);
			this.splitContainer3.Panel1.Controls.Add(this.PasteScreenshotButton);
			this.splitContainer3.Panel1.Controls.Add(this.label36);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShot_Length);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShotDirectory);
			this.splitContainer3.Panel1.Controls.Add(this.CopyScreenshotButton);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShot_y1);
			this.splitContainer3.Panel1.Controls.Add(this.label17);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShotSaveButton);
			this.splitContainer3.Panel1.Controls.Add(this.label13);
			this.splitContainer3.Panel1.Controls.Add(this.EditScreenShotButton);
			this.splitContainer3.Panel1.Controls.Add(this.label16);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShot_Width);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShotPrefixTextBox);
			this.splitContainer3.Panel1.Controls.Add(this.OpenScreenshotButton);
			this.splitContainer3.Panel1.Controls.Add(this.button3);
			this.splitContainer3.Panel1.Controls.Add(this.ScreenShot_x1);
			this.splitContainer3.Panel1.Controls.Add(this.label15);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer3.Size = new System.Drawing.Size(1251, 687);
			this.splitContainer3.SplitterDistance = 124;
			this.splitContainer3.TabIndex = 21;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(435, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 19);
			this.label14.TabIndex = 7;
			this.label14.Text = "Y Start";
			// 
			// PasteScreenshotButton
			// 
			this.PasteScreenshotButton.Location = new System.Drawing.Point(975, 69);
			this.PasteScreenshotButton.Name = "PasteScreenshotButton";
			this.PasteScreenshotButton.Size = new System.Drawing.Size(103, 32);
			this.PasteScreenshotButton.TabIndex = 20;
			this.PasteScreenshotButton.Text = "Paste Screenshot";
			this.PasteScreenshotButton.UseVisualStyleBackColor = true;
			this.PasteScreenshotButton.Click += new System.EventHandler(this.PasteScreenshotButtonClick);
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(304, 86);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(87, 20);
			this.label36.TabIndex = 16;
			this.label36.Text = "FileNamePrefix:";
			// 
			// ScreenShot_Length
			// 
			this.ScreenShot_Length.Location = new System.Drawing.Point(483, 37);
			this.ScreenShot_Length.Name = "ScreenShot_Length";
			this.ScreenShot_Length.Size = new System.Drawing.Size(42, 20);
			this.ScreenShot_Length.TabIndex = 4;
			this.ScreenShot_Length.Text = "1440";
			// 
			// ScreenShotDirectory
			// 
			this.ScreenShotDirectory.Location = new System.Drawing.Point(393, 60);
			this.ScreenShotDirectory.Name = "ScreenShotDirectory";
			this.ScreenShotDirectory.Size = new System.Drawing.Size(345, 20);
			this.ScreenShotDirectory.TabIndex = 11;
			this.ScreenShotDirectory.Text = "c:\\";
			// 
			// CopyScreenshotButton
			// 
			this.CopyScreenshotButton.Location = new System.Drawing.Point(871, 69);
			this.CopyScreenshotButton.Name = "CopyScreenshotButton";
			this.CopyScreenshotButton.Size = new System.Drawing.Size(98, 32);
			this.CopyScreenshotButton.TabIndex = 19;
			this.CopyScreenshotButton.Text = "Copy Screenshot";
			this.CopyScreenshotButton.UseVisualStyleBackColor = true;
			this.CopyScreenshotButton.Click += new System.EventHandler(this.CopyScreenshotButtonClick);
			// 
			// ScreenShot_y1
			// 
			this.ScreenShot_y1.Location = new System.Drawing.Point(438, 37);
			this.ScreenShot_y1.Name = "ScreenShot_y1";
			this.ScreenShot_y1.Size = new System.Drawing.Size(42, 20);
			this.ScreenShot_y1.TabIndex = 3;
			this.ScreenShot_y1.Text = "0";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(313, 60);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 38);
			this.label17.TabIndex = 13;
			this.label17.Text = "Directory";
			// 
			// ScreenShotSaveButton
			// 
			this.ScreenShotSaveButton.Location = new System.Drawing.Point(43, 63);
			this.ScreenShotSaveButton.Name = "ScreenShotSaveButton";
			this.ScreenShotSaveButton.Size = new System.Drawing.Size(98, 32);
			this.ScreenShotSaveButton.TabIndex = 10;
			this.ScreenShotSaveButton.Text = "Save";
			this.ScreenShotSaveButton.UseVisualStyleBackColor = true;
			this.ScreenShotSaveButton.Click += new System.EventHandler(this.ScreenShotSaveButtonClick);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(390, 15);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 19);
			this.label13.TabIndex = 6;
			this.label13.Text = "X Start";
			// 
			// EditScreenShotButton
			// 
			this.EditScreenShotButton.Location = new System.Drawing.Point(147, 63);
			this.EditScreenShotButton.Name = "EditScreenShotButton";
			this.EditScreenShotButton.Size = new System.Drawing.Size(98, 32);
			this.EditScreenShotButton.TabIndex = 18;
			this.EditScreenShotButton.Text = "Edit Screenshot";
			this.EditScreenShotButton.UseVisualStyleBackColor = true;
			this.EditScreenShotButton.Click += new System.EventHandler(this.EditScreenShotButtonClick);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(528, 15);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(42, 19);
			this.label16.TabIndex = 9;
			this.label16.Text = "Width";
			// 
			// ScreenShot_Width
			// 
			this.ScreenShot_Width.Location = new System.Drawing.Point(528, 37);
			this.ScreenShot_Width.Name = "ScreenShot_Width";
			this.ScreenShot_Width.Size = new System.Drawing.Size(42, 20);
			this.ScreenShot_Width.TabIndex = 5;
			this.ScreenShot_Width.Text = "1050";
			// 
			// ScreenShotPrefixTextBox
			// 
			this.ScreenShotPrefixTextBox.Location = new System.Drawing.Point(393, 86);
			this.ScreenShotPrefixTextBox.Name = "ScreenShotPrefixTextBox";
			this.ScreenShotPrefixTextBox.Size = new System.Drawing.Size(345, 20);
			this.ScreenShotPrefixTextBox.TabIndex = 15;
			this.ScreenShotPrefixTextBox.Text = "ScreenShot_";
			// 
			// OpenScreenshotButton
			// 
			this.OpenScreenshotButton.Location = new System.Drawing.Point(147, 25);
			this.OpenScreenshotButton.Name = "OpenScreenshotButton";
			this.OpenScreenshotButton.Size = new System.Drawing.Size(98, 32);
			this.OpenScreenshotButton.TabIndex = 17;
			this.OpenScreenshotButton.Text = "Open Screenshot";
			this.OpenScreenshotButton.UseVisualStyleBackColor = true;
			this.OpenScreenshotButton.Click += new System.EventHandler(this.OpenScreenshotButtonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(43, 25);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 32);
			this.button3.TabIndex = 1;
			this.button3.Text = "Capture";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// ScreenShot_x1
			// 
			this.ScreenShot_x1.Location = new System.Drawing.Point(393, 37);
			this.ScreenShot_x1.Name = "ScreenShot_x1";
			this.ScreenShot_x1.Size = new System.Drawing.Size(42, 20);
			this.ScreenShot_x1.TabIndex = 2;
			this.ScreenShot_x1.Text = "0";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(480, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(45, 19);
			this.label15.TabIndex = 8;
			this.label15.Text = "Length";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1251, 559);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDoubleClick);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.ClipRingTreeView);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1257, 693);
			this.tabPage4.TabIndex = 9;
			this.tabPage4.Text = "Clip Ring";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// ClipRingTreeView
			// 
			this.ClipRingTreeView.Location = new System.Drawing.Point(8, 15);
			this.ClipRingTreeView.Name = "ClipRingTreeView";
			this.ClipRingTreeView.Size = new System.Drawing.Size(726, 509);
			this.ClipRingTreeView.TabIndex = 0;
			this.ClipRingTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ClipRingTreeViewAfterSelect);
			this.ClipRingTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClipRingTreeViewKeyDown);
			// 
			// LogsTAB
			// 
			this.LogsTAB.Controls.Add(this.OpenTodayLogButton);
			this.LogsTAB.Controls.Add(this.LogFolders);
			this.LogsTAB.Controls.Add(this.LogFiles);
			this.LogsTAB.Controls.Add(this.label35);
			this.LogsTAB.Controls.Add(this.label20);
			this.LogsTAB.Controls.Add(this.RefreshLogsButton);
			this.LogsTAB.Controls.Add(this.CopyLogPathButton);
			this.LogsTAB.Controls.Add(this.NewTextLogButton);
			this.LogsTAB.Location = new System.Drawing.Point(4, 22);
			this.LogsTAB.Name = "LogsTAB";
			this.LogsTAB.Padding = new System.Windows.Forms.Padding(3);
			this.LogsTAB.Size = new System.Drawing.Size(1257, 693);
			this.LogsTAB.TabIndex = 10;
			this.LogsTAB.Text = "Logs";
			this.LogsTAB.UseVisualStyleBackColor = true;
			// 
			// OpenTodayLogButton
			// 
			this.OpenTodayLogButton.Location = new System.Drawing.Point(589, 147);
			this.OpenTodayLogButton.Name = "OpenTodayLogButton";
			this.OpenTodayLogButton.Size = new System.Drawing.Size(160, 37);
			this.OpenTodayLogButton.TabIndex = 10;
			this.OpenTodayLogButton.Text = "Open Today\'s Log Folder";
			this.OpenTodayLogButton.UseVisualStyleBackColor = true;
			this.OpenTodayLogButton.Click += new System.EventHandler(this.OpenTodayLogButtonClick);
			// 
			// LogFolders
			// 
			this.LogFolders.FormattingEnabled = true;
			this.LogFolders.Location = new System.Drawing.Point(8, 332);
			this.LogFolders.Name = "LogFolders";
			this.LogFolders.Size = new System.Drawing.Size(559, 238);
			this.LogFolders.TabIndex = 9;
			this.LogFolders.SelectedIndexChanged += new System.EventHandler(this.LogFoldersSelectedIndexChanged);
			this.LogFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LogFoldersMouseDoubleClick);
			// 
			// LogFiles
			// 
			this.LogFiles.FormattingEnabled = true;
			this.LogFiles.Location = new System.Drawing.Point(8, 46);
			this.LogFiles.Name = "LogFiles";
			this.LogFiles.Size = new System.Drawing.Size(559, 238);
			this.LogFiles.TabIndex = 8;
			this.LogFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogFilesKeyDown);
			this.LogFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LogFilesMouseDoubleClick);
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(8, 24);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(63, 19);
			this.label35.TabIndex = 7;
			this.label35.Text = "Files:";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 310);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(63, 19);
			this.label20.TabIndex = 6;
			this.label20.Text = "Folders:";
			// 
			// RefreshLogsButton
			// 
			this.RefreshLogsButton.Location = new System.Drawing.Point(589, 104);
			this.RefreshLogsButton.Name = "RefreshLogsButton";
			this.RefreshLogsButton.Size = new System.Drawing.Size(160, 37);
			this.RefreshLogsButton.TabIndex = 3;
			this.RefreshLogsButton.Text = "Refresh Logs";
			this.RefreshLogsButton.UseVisualStyleBackColor = true;
			this.RefreshLogsButton.Click += new System.EventHandler(this.RefreshClick);
			// 
			// CopyLogPathButton
			// 
			this.CopyLogPathButton.Location = new System.Drawing.Point(589, 61);
			this.CopyLogPathButton.Name = "CopyLogPathButton";
			this.CopyLogPathButton.Size = new System.Drawing.Size(160, 37);
			this.CopyLogPathButton.TabIndex = 2;
			this.CopyLogPathButton.Text = "Copy File Path";
			this.CopyLogPathButton.UseVisualStyleBackColor = true;
			this.CopyLogPathButton.Click += new System.EventHandler(this.CopyLogPathButtonClick);
			// 
			// NewTextLogButton
			// 
			this.NewTextLogButton.Location = new System.Drawing.Point(589, 18);
			this.NewTextLogButton.Name = "NewTextLogButton";
			this.NewTextLogButton.Size = new System.Drawing.Size(160, 37);
			this.NewTextLogButton.TabIndex = 1;
			this.NewTextLogButton.Text = "New Text Log %";
			this.NewTextLogButton.UseVisualStyleBackColor = true;
			this.NewTextLogButton.Click += new System.EventHandler(this.NewTextLogButtonClick);
			// 
			// ProcessTextTab
			// 
			this.ProcessTextTab.Controls.Add(this.splitContainer1);
			this.ProcessTextTab.Location = new System.Drawing.Point(4, 22);
			this.ProcessTextTab.Name = "ProcessTextTab";
			this.ProcessTextTab.Padding = new System.Windows.Forms.Padding(3);
			this.ProcessTextTab.Size = new System.Drawing.Size(1257, 693);
			this.ProcessTextTab.TabIndex = 11;
			this.ProcessTextTab.Text = "Process Text";
			this.ProcessTextTab.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ProcessText_IncrementCountersButton);
			this.splitContainer1.Panel2.Controls.Add(this.IncrementValuesButton);
			this.splitContainer1.Panel2.Controls.Add(this.RemoveNullParamXMLButton);
			this.splitContainer1.Panel2.Controls.Add(this.ProcessTextFixLabel);
			this.splitContainer1.Panel2.Controls.Add(this.ProcessTextFixTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.ToOneLineButton);
			this.splitContainer1.Panel2.Controls.Add(this.FormatXMLButton);
			this.splitContainer1.Panel2.Controls.Add(this.OneWordPerLineButton);
			this.splitContainer1.Panel2.Controls.Add(this.ProcessText_ToJavaStringButton);
			this.splitContainer1.Panel2.Controls.Add(this.ProcessText_RemoveLeadingWhiteSpaces);
			this.splitContainer1.Panel2.Controls.Add(this.AddSuffixButton);
			this.splitContainer1.Panel2.Controls.Add(this.AddPrefixButton);
			this.splitContainer1.Panel2.Controls.Add(this.GetParamFromURLButton);
			this.splitContainer1.Size = new System.Drawing.Size(1251, 687);
			this.splitContainer1.SplitterDistance = 936;
			this.splitContainer1.TabIndex = 10;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.ProcessTextRTB1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.ProcessTextRTB2);
			this.splitContainer2.Size = new System.Drawing.Size(936, 687);
			this.splitContainer2.SplitterDistance = 480;
			this.splitContainer2.TabIndex = 2;
			// 
			// ProcessTextRTB1
			// 
			this.ProcessTextRTB1.AcceptsTab = true;
			this.ProcessTextRTB1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProcessTextRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessTextRTB1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ProcessTextRTB1.Location = new System.Drawing.Point(0, 0);
			this.ProcessTextRTB1.Name = "ProcessTextRTB1";
			this.ProcessTextRTB1.Size = new System.Drawing.Size(480, 687);
			this.ProcessTextRTB1.TabIndex = 0;
			this.ProcessTextRTB1.Text = "";
			this.ProcessTextRTB1.WordWrap = false;
			// 
			// ProcessTextRTB2
			// 
			this.ProcessTextRTB2.AcceptsTab = true;
			this.ProcessTextRTB2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProcessTextRTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessTextRTB2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ProcessTextRTB2.Location = new System.Drawing.Point(0, 0);
			this.ProcessTextRTB2.Name = "ProcessTextRTB2";
			this.ProcessTextRTB2.Size = new System.Drawing.Size(452, 687);
			this.ProcessTextRTB2.TabIndex = 1;
			this.ProcessTextRTB2.Text = "";
			this.ProcessTextRTB2.WordWrap = false;
			// 
			// ProcessText_IncrementCountersButton
			// 
			this.ProcessText_IncrementCountersButton.Location = new System.Drawing.Point(14, 453);
			this.ProcessText_IncrementCountersButton.Name = "ProcessText_IncrementCountersButton";
			this.ProcessText_IncrementCountersButton.Size = new System.Drawing.Size(197, 29);
			this.ProcessText_IncrementCountersButton.TabIndex = 14;
			this.ProcessText_IncrementCountersButton.Text = "Increment Counters";
			this.ProcessText_IncrementCountersButton.UseVisualStyleBackColor = true;
			this.ProcessText_IncrementCountersButton.Click += new System.EventHandler(this.ProcessText_IncrementCountersButtonClick);
			// 
			// IncrementValuesButton
			// 
			this.IncrementValuesButton.Location = new System.Drawing.Point(14, 263);
			this.IncrementValuesButton.Name = "IncrementValuesButton";
			this.IncrementValuesButton.Size = new System.Drawing.Size(197, 29);
			this.IncrementValuesButton.TabIndex = 13;
			this.IncrementValuesButton.Text = "Incrment Values";
			this.IncrementValuesButton.UseVisualStyleBackColor = true;
			this.IncrementValuesButton.Click += new System.EventHandler(this.IncrementValuesButtonClick);
			// 
			// RemoveNullParamXMLButton
			// 
			this.RemoveNullParamXMLButton.Location = new System.Drawing.Point(14, 400);
			this.RemoveNullParamXMLButton.Name = "RemoveNullParamXMLButton";
			this.RemoveNullParamXMLButton.Size = new System.Drawing.Size(197, 29);
			this.RemoveNullParamXMLButton.TabIndex = 12;
			this.RemoveNullParamXMLButton.Text = "Remove Null Value Params From XML";
			this.RemoveNullParamXMLButton.UseVisualStyleBackColor = true;
			this.RemoveNullParamXMLButton.Click += new System.EventHandler(this.RemoveNullParamXMLButtonClick);
			// 
			// ProcessTextFixLabel
			// 
			this.ProcessTextFixLabel.AutoSize = true;
			this.ProcessTextFixLabel.Location = new System.Drawing.Point(11, 180);
			this.ProcessTextFixLabel.Name = "ProcessTextFixLabel";
			this.ProcessTextFixLabel.Size = new System.Drawing.Size(113, 13);
			this.ProcessTextFixLabel.TabIndex = 11;
			this.ProcessTextFixLabel.Text = "Prefix / Suffix / Criteria";
			// 
			// ProcessTextFixTextBox
			// 
			this.ProcessTextFixTextBox.Location = new System.Drawing.Point(14, 201);
			this.ProcessTextFixTextBox.Multiline = true;
			this.ProcessTextFixTextBox.Name = "ProcessTextFixTextBox";
			this.ProcessTextFixTextBox.Size = new System.Drawing.Size(197, 51);
			this.ProcessTextFixTextBox.TabIndex = 10;
			// 
			// ToOneLineButton
			// 
			this.ToOneLineButton.Location = new System.Drawing.Point(14, 5);
			this.ToOneLineButton.Name = "ToOneLineButton";
			this.ToOneLineButton.Size = new System.Drawing.Size(197, 29);
			this.ToOneLineButton.TabIndex = 2;
			this.ToOneLineButton.Text = "To One Line";
			this.ToOneLineButton.UseVisualStyleBackColor = true;
			this.ToOneLineButton.Click += new System.EventHandler(this.ToOneLineButtonClick);
			// 
			// FormatXMLButton
			// 
			this.FormatXMLButton.Location = new System.Drawing.Point(14, 366);
			this.FormatXMLButton.Name = "FormatXMLButton";
			this.FormatXMLButton.Size = new System.Drawing.Size(197, 29);
			this.FormatXMLButton.TabIndex = 9;
			this.FormatXMLButton.Text = "Format XML";
			this.FormatXMLButton.UseVisualStyleBackColor = true;
			this.FormatXMLButton.Click += new System.EventHandler(this.FormatXMLButton_Click);
			// 
			// OneWordPerLineButton
			// 
			this.OneWordPerLineButton.Location = new System.Drawing.Point(14, 40);
			this.OneWordPerLineButton.Name = "OneWordPerLineButton";
			this.OneWordPerLineButton.Size = new System.Drawing.Size(197, 29);
			this.OneWordPerLineButton.TabIndex = 3;
			this.OneWordPerLineButton.Text = "One Word Per Line";
			this.OneWordPerLineButton.UseVisualStyleBackColor = true;
			this.OneWordPerLineButton.Click += new System.EventHandler(this.OneWordPerLineButtonClick);
			// 
			// ProcessText_ToJavaStringButton
			// 
			this.ProcessText_ToJavaStringButton.Location = new System.Drawing.Point(14, 331);
			this.ProcessText_ToJavaStringButton.Name = "ProcessText_ToJavaStringButton";
			this.ProcessText_ToJavaStringButton.Size = new System.Drawing.Size(197, 29);
			this.ProcessText_ToJavaStringButton.TabIndex = 8;
			this.ProcessText_ToJavaStringButton.Text = "To Java String";
			this.ProcessText_ToJavaStringButton.UseVisualStyleBackColor = true;
			this.ProcessText_ToJavaStringButton.Click += new System.EventHandler(this.ProcessText_ToJavaStringButtonClick);
			// 
			// ProcessText_RemoveLeadingWhiteSpaces
			// 
			this.ProcessText_RemoveLeadingWhiteSpaces.Location = new System.Drawing.Point(14, 75);
			this.ProcessText_RemoveLeadingWhiteSpaces.Name = "ProcessText_RemoveLeadingWhiteSpaces";
			this.ProcessText_RemoveLeadingWhiteSpaces.Size = new System.Drawing.Size(197, 29);
			this.ProcessText_RemoveLeadingWhiteSpaces.TabIndex = 4;
			this.ProcessText_RemoveLeadingWhiteSpaces.Text = "Remove Leading White Spaces";
			this.ProcessText_RemoveLeadingWhiteSpaces.UseVisualStyleBackColor = true;
			this.ProcessText_RemoveLeadingWhiteSpaces.Click += new System.EventHandler(this.ProcessText_RemoveLeadingWhiteSpacesClick);
			// 
			// AddSuffixButton
			// 
			this.AddSuffixButton.Location = new System.Drawing.Point(14, 145);
			this.AddSuffixButton.Name = "AddSuffixButton";
			this.AddSuffixButton.Size = new System.Drawing.Size(197, 29);
			this.AddSuffixButton.TabIndex = 7;
			this.AddSuffixButton.Text = "Add Suffix";
			this.AddSuffixButton.UseVisualStyleBackColor = true;
			this.AddSuffixButton.Click += new System.EventHandler(this.AddSuffixButton_Click);
			// 
			// AddPrefixButton
			// 
			this.AddPrefixButton.Location = new System.Drawing.Point(14, 110);
			this.AddPrefixButton.Name = "AddPrefixButton";
			this.AddPrefixButton.Size = new System.Drawing.Size(197, 29);
			this.AddPrefixButton.TabIndex = 5;
			this.AddPrefixButton.Text = "Add Prefix";
			this.AddPrefixButton.UseVisualStyleBackColor = true;
			this.AddPrefixButton.Click += new System.EventHandler(this.AddPrefixButtonClick);
			// 
			// GetParamFromURLButton
			// 
			this.GetParamFromURLButton.Location = new System.Drawing.Point(14, 296);
			this.GetParamFromURLButton.Name = "GetParamFromURLButton";
			this.GetParamFromURLButton.Size = new System.Drawing.Size(197, 29);
			this.GetParamFromURLButton.TabIndex = 6;
			this.GetParamFromURLButton.Text = "GetParamFromURL";
			this.GetParamFromURLButton.UseVisualStyleBackColor = true;
			this.GetParamFromURLButton.Click += new System.EventHandler(this.GetParamFromURLButtonClick);
			// 
			// WebPosterTab
			// 
			this.WebPosterTab.Controls.Add(this.SContainerHttpPost);
			this.WebPosterTab.Location = new System.Drawing.Point(4, 22);
			this.WebPosterTab.Name = "WebPosterTab";
			this.WebPosterTab.Padding = new System.Windows.Forms.Padding(3);
			this.WebPosterTab.Size = new System.Drawing.Size(1257, 693);
			this.WebPosterTab.TabIndex = 17;
			this.WebPosterTab.Text = "HTTP Post";
			this.WebPosterTab.UseVisualStyleBackColor = true;
			// 
			// SContainerHttpPost
			// 
			this.SContainerHttpPost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SContainerHttpPost.Location = new System.Drawing.Point(3, 3);
			this.SContainerHttpPost.Name = "SContainerHttpPost";
			// 
			// SContainerHttpPost.Panel1
			// 
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_PasteParamDataButton);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_ClearParamButton);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_DeleteParamButton);
			this.SContainerHttpPost.Panel1.Controls.Add(this.label56);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostURLTextBox);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostRunButton);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostAddParamToListButton);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostValueTextBox);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostParameterTextBox);
			this.SContainerHttpPost.Panel1.Controls.Add(this.label55);
			this.SContainerHttpPost.Panel1.Controls.Add(this.label26);
			this.SContainerHttpPost.Panel1.Controls.Add(this.label25);
			this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostParamListBox);
			// 
			// SContainerHttpPost.Panel2
			// 
			this.SContainerHttpPost.Panel2.Controls.Add(this.HTTPPostResultBrowser);
			this.SContainerHttpPost.Size = new System.Drawing.Size(1251, 687);
			this.SContainerHttpPost.SplitterDistance = 416;
			this.SContainerHttpPost.TabIndex = 0;
			// 
			// HTTPPost_PasteParamDataButton
			// 
			this.HTTPPost_PasteParamDataButton.Location = new System.Drawing.Point(5, 623);
			this.HTTPPost_PasteParamDataButton.Name = "HTTPPost_PasteParamDataButton";
			this.HTTPPost_PasteParamDataButton.Size = new System.Drawing.Size(109, 23);
			this.HTTPPost_PasteParamDataButton.TabIndex = 12;
			this.HTTPPost_PasteParamDataButton.Text = "Paste Param Data";
			this.HTTPPost_PasteParamDataButton.UseVisualStyleBackColor = true;
			this.HTTPPost_PasteParamDataButton.Click += new System.EventHandler(this.HTTPPost_PasteParamDataButtonClick);
			// 
			// HTTPPost_ClearParamButton
			// 
			this.HTTPPost_ClearParamButton.Location = new System.Drawing.Point(254, 594);
			this.HTTPPost_ClearParamButton.Name = "HTTPPost_ClearParamButton";
			this.HTTPPost_ClearParamButton.Size = new System.Drawing.Size(95, 23);
			this.HTTPPost_ClearParamButton.TabIndex = 11;
			this.HTTPPost_ClearParamButton.Text = "Clear Params";
			this.HTTPPost_ClearParamButton.UseVisualStyleBackColor = true;
			this.HTTPPost_ClearParamButton.Click += new System.EventHandler(this.HTTPPost_ClearParamButtonClick);
			// 
			// HTTPPost_DeleteParamButton
			// 
			this.HTTPPost_DeleteParamButton.Location = new System.Drawing.Point(120, 594);
			this.HTTPPost_DeleteParamButton.Name = "HTTPPost_DeleteParamButton";
			this.HTTPPost_DeleteParamButton.Size = new System.Drawing.Size(128, 23);
			this.HTTPPost_DeleteParamButton.TabIndex = 10;
			this.HTTPPost_DeleteParamButton.Text = "Delete Param From List";
			this.HTTPPost_DeleteParamButton.UseVisualStyleBackColor = true;
			this.HTTPPost_DeleteParamButton.Click += new System.EventHandler(this.HTTPPost_DeleteParamButtonClick);
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(5, 22);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(157, 23);
			this.label56.TabIndex = 9;
			this.label56.Text = "HTTP Url";
			// 
			// HTTPPostURLTextBox
			// 
			this.HTTPPostURLTextBox.Location = new System.Drawing.Point(5, 48);
			this.HTTPPostURLTextBox.Multiline = true;
			this.HTTPPostURLTextBox.Name = "HTTPPostURLTextBox";
			this.HTTPPostURLTextBox.Size = new System.Drawing.Size(344, 78);
			this.HTTPPostURLTextBox.TabIndex = 8;
			this.HTTPPostURLTextBox.Text = "http://localhost";
			// 
			// HTTPPostRunButton
			// 
			this.HTTPPostRunButton.Location = new System.Drawing.Point(267, 131);
			this.HTTPPostRunButton.Name = "HTTPPostRunButton";
			this.HTTPPostRunButton.Size = new System.Drawing.Size(82, 23);
			this.HTTPPostRunButton.TabIndex = 7;
			this.HTTPPostRunButton.Text = "Run";
			this.HTTPPostRunButton.UseVisualStyleBackColor = true;
			this.HTTPPostRunButton.Click += new System.EventHandler(this.HTTPPostRunButtonClick);
			// 
			// HTTPPostAddParamToListButton
			// 
			this.HTTPPostAddParamToListButton.Location = new System.Drawing.Point(5, 594);
			this.HTTPPostAddParamToListButton.Name = "HTTPPostAddParamToListButton";
			this.HTTPPostAddParamToListButton.Size = new System.Drawing.Size(109, 23);
			this.HTTPPostAddParamToListButton.TabIndex = 6;
			this.HTTPPostAddParamToListButton.Text = "Add Param To List";
			this.HTTPPostAddParamToListButton.UseVisualStyleBackColor = true;
			this.HTTPPostAddParamToListButton.Click += new System.EventHandler(this.HTTPPostAddParamToListButtonClick);
			// 
			// HTTPPostValueTextBox
			// 
			this.HTTPPostValueTextBox.Location = new System.Drawing.Point(51, 453);
			this.HTTPPostValueTextBox.Multiline = true;
			this.HTTPPostValueTextBox.Name = "HTTPPostValueTextBox";
			this.HTTPPostValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.HTTPPostValueTextBox.Size = new System.Drawing.Size(298, 135);
			this.HTTPPostValueTextBox.TabIndex = 5;
			// 
			// HTTPPostParameterTextBox
			// 
			this.HTTPPostParameterTextBox.Location = new System.Drawing.Point(51, 430);
			this.HTTPPostParameterTextBox.Name = "HTTPPostParameterTextBox";
			this.HTTPPostParameterTextBox.Size = new System.Drawing.Size(298, 20);
			this.HTTPPostParameterTextBox.TabIndex = 4;
			// 
			// label55
			// 
			this.label55.Location = new System.Drawing.Point(5, 457);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(100, 23);
			this.label55.TabIndex = 3;
			this.label55.Text = "Value";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(5, 433);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 23);
			this.label26.TabIndex = 2;
			this.label26.Text = "Param";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(5, 156);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(157, 23);
			this.label25.TabIndex = 1;
			this.label25.Text = "HTTP Post Parameters List";
			// 
			// HTTPPostParamListBox
			// 
			this.HTTPPostParamListBox.FormattingEnabled = true;
			this.HTTPPostParamListBox.HorizontalScrollbar = true;
			this.HTTPPostParamListBox.Location = new System.Drawing.Point(5, 179);
			this.HTTPPostParamListBox.Name = "HTTPPostParamListBox";
			this.HTTPPostParamListBox.ScrollAlwaysVisible = true;
			this.HTTPPostParamListBox.Size = new System.Drawing.Size(344, 251);
			this.HTTPPostParamListBox.TabIndex = 0;
			this.HTTPPostParamListBox.SelectedIndexChanged += new System.EventHandler(this.HTTPPostParamListBoxSelectedIndexChanged);
			this.HTTPPostParamListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HTTPPostParamListBoxKeyDown);
			// 
			// HTTPPostResultBrowser
			// 
			this.HTTPPostResultBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HTTPPostResultBrowser.Location = new System.Drawing.Point(0, 0);
			this.HTTPPostResultBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.HTTPPostResultBrowser.Name = "HTTPPostResultBrowser";
			this.HTTPPostResultBrowser.Size = new System.Drawing.Size(831, 687);
			this.HTTPPostResultBrowser.TabIndex = 0;
			// 
			// APIRunnerTab
			// 
			this.APIRunnerTab.Controls.Add(this.APIRunner_ClearResultsButton);
			this.APIRunnerTab.Controls.Add(this.APIRunner_APIResetButton);
			this.APIRunnerTab.Controls.Add(this.APIRunner_SaveAPIButton);
			this.APIRunnerTab.Controls.Add(this.API_RunnerThreadCountNumericUpDown);
			this.APIRunnerTab.Controls.Add(this.label7);
			this.APIRunnerTab.Controls.Add(this.APIRunner_RepeatCountersCheckBox);
			this.APIRunnerTab.Controls.Add(this.APIRunner_ResultsTreeView);
			this.APIRunnerTab.Controls.Add(this.APIRunner_ProgressBar);
			this.APIRunnerTab.Controls.Add(this.APIRunner_IncrementCounter_N);
			this.APIRunnerTab.Controls.Add(this.label67);
			this.APIRunnerTab.Controls.Add(this.APIRunner_IncrementCountersCheckBox);
			this.APIRunnerTab.Controls.Add(this.label66);
			this.APIRunnerTab.Controls.Add(this.APIRunner_IncrementCriteriaTextBox);
			this.APIRunnerTab.Controls.Add(this.APIRunner_IsCounterTemplate);
			this.APIRunnerTab.Controls.Add(this.label65);
			this.APIRunnerTab.Controls.Add(this.label64);
			this.APIRunnerTab.Controls.Add(this.label63);
			this.APIRunnerTab.Controls.Add(this.APIRunner_RunAPIButton);
			this.APIRunnerTab.Controls.Add(this.label62);
			this.APIRunnerTab.Controls.Add(this.APIRunner_APINamesComboBox);
			this.APIRunnerTab.Controls.Add(this.label60);
			this.APIRunnerTab.Controls.Add(this.label59);
			this.APIRunnerTab.Controls.Add(this.APIRunner_PasswordTextbox);
			this.APIRunnerTab.Controls.Add(this.APIRunner_UserNameTextBox);
			this.APIRunnerTab.Controls.Add(this.APIRunner_APITemplateTextBox);
			this.APIRunnerTab.Controls.Add(this.APIRunner_APIXMLTextBox);
			this.APIRunnerTab.Location = new System.Drawing.Point(4, 22);
			this.APIRunnerTab.Name = "APIRunnerTab";
			this.APIRunnerTab.Padding = new System.Windows.Forms.Padding(3);
			this.APIRunnerTab.Size = new System.Drawing.Size(1257, 693);
			this.APIRunnerTab.TabIndex = 18;
			this.APIRunnerTab.Text = "API Runner";
			this.APIRunnerTab.UseVisualStyleBackColor = true;
			// 
			// APIRunner_ClearResultsButton
			// 
			this.APIRunner_ClearResultsButton.Location = new System.Drawing.Point(1105, 449);
			this.APIRunner_ClearResultsButton.Name = "APIRunner_ClearResultsButton";
			this.APIRunner_ClearResultsButton.Size = new System.Drawing.Size(84, 23);
			this.APIRunner_ClearResultsButton.TabIndex = 109;
			this.APIRunner_ClearResultsButton.Text = "Clear Results";
			this.APIRunner_ClearResultsButton.UseVisualStyleBackColor = true;
			this.APIRunner_ClearResultsButton.Click += new System.EventHandler(this.APIRunner_ClearResultsButtonClick);
			// 
			// APIRunner_APIResetButton
			// 
			this.APIRunner_APIResetButton.Enabled = false;
			this.APIRunner_APIResetButton.Location = new System.Drawing.Point(594, 88);
			this.APIRunner_APIResetButton.Name = "APIRunner_APIResetButton";
			this.APIRunner_APIResetButton.Size = new System.Drawing.Size(75, 23);
			this.APIRunner_APIResetButton.TabIndex = 108;
			this.APIRunner_APIResetButton.Text = "Reset";
			this.APIRunner_APIResetButton.UseVisualStyleBackColor = true;
			this.APIRunner_APIResetButton.Click += new System.EventHandler(this.APIRunner_APIResetButtonClick);
			// 
			// APIRunner_SaveAPIButton
			// 
			this.APIRunner_SaveAPIButton.Location = new System.Drawing.Point(594, 61);
			this.APIRunner_SaveAPIButton.Name = "APIRunner_SaveAPIButton";
			this.APIRunner_SaveAPIButton.Size = new System.Drawing.Size(75, 23);
			this.APIRunner_SaveAPIButton.TabIndex = 107;
			this.APIRunner_SaveAPIButton.Text = "Save";
			this.APIRunner_SaveAPIButton.UseVisualStyleBackColor = true;
			this.APIRunner_SaveAPIButton.Click += new System.EventHandler(this.APIRunner_SaveAPIButtonClick);
			// 
			// API_RunnerThreadCountNumericUpDown
			// 
			this.API_RunnerThreadCountNumericUpDown.Enabled = false;
			this.API_RunnerThreadCountNumericUpDown.Location = new System.Drawing.Point(926, 88);
			this.API_RunnerThreadCountNumericUpDown.Maximum = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.API_RunnerThreadCountNumericUpDown.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.API_RunnerThreadCountNumericUpDown.Name = "API_RunnerThreadCountNumericUpDown";
			this.API_RunnerThreadCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.API_RunnerThreadCountNumericUpDown.TabIndex = 105;
			this.API_RunnerThreadCountNumericUpDown.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(875, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 23);
			this.label7.TabIndex = 106;
			this.label7.Text = "Threads=";
			// 
			// APIRunner_RepeatCountersCheckBox
			// 
			this.APIRunner_RepeatCountersCheckBox.Location = new System.Drawing.Point(777, 85);
			this.APIRunner_RepeatCountersCheckBox.Name = "APIRunner_RepeatCountersCheckBox";
			this.APIRunner_RepeatCountersCheckBox.Size = new System.Drawing.Size(121, 24);
			this.APIRunner_RepeatCountersCheckBox.TabIndex = 104;
			this.APIRunner_RepeatCountersCheckBox.Text = "Repeat";
			this.APIRunner_RepeatCountersCheckBox.UseVisualStyleBackColor = true;
			this.APIRunner_RepeatCountersCheckBox.CheckedChanged += new System.EventHandler(this.APIRunner_RepeatCountersCheckBoxCheckedChanged);
			// 
			// APIRunner_ResultsTreeView
			// 
			this.APIRunner_ResultsTreeView.Location = new System.Drawing.Point(67, 449);
			this.APIRunner_ResultsTreeView.Name = "APIRunner_ResultsTreeView";
			this.APIRunner_ResultsTreeView.Size = new System.Drawing.Size(1032, 193);
			this.APIRunner_ResultsTreeView.TabIndex = 103;
			this.APIRunner_ResultsTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIRunner_ResultsTreeViewKeyDown);
			// 
			// APIRunner_ProgressBar
			// 
			this.APIRunner_ProgressBar.Location = new System.Drawing.Point(67, 648);
			this.APIRunner_ProgressBar.Name = "APIRunner_ProgressBar";
			this.APIRunner_ProgressBar.Size = new System.Drawing.Size(1032, 23);
			this.APIRunner_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.APIRunner_ProgressBar.TabIndex = 19;
			// 
			// APIRunner_IncrementCounter_N
			// 
			this.APIRunner_IncrementCounter_N.Location = new System.Drawing.Point(926, 57);
			this.APIRunner_IncrementCounter_N.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.APIRunner_IncrementCounter_N.Name = "APIRunner_IncrementCounter_N";
			this.APIRunner_IncrementCounter_N.Size = new System.Drawing.Size(120, 20);
			this.APIRunner_IncrementCounter_N.TabIndex = 5;
			// 
			// label67
			// 
			this.label67.Location = new System.Drawing.Point(904, 58);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(32, 23);
			this.label67.TabIndex = 17;
			this.label67.Text = "n=";
			// 
			// APIRunner_IncrementCountersCheckBox
			// 
			this.APIRunner_IncrementCountersCheckBox.Location = new System.Drawing.Point(777, 55);
			this.APIRunner_IncrementCountersCheckBox.Name = "APIRunner_IncrementCountersCheckBox";
			this.APIRunner_IncrementCountersCheckBox.Size = new System.Drawing.Size(121, 24);
			this.APIRunner_IncrementCountersCheckBox.TabIndex = 4;
			this.APIRunner_IncrementCountersCheckBox.Text = "Increment Counters";
			this.APIRunner_IncrementCountersCheckBox.UseVisualStyleBackColor = true;
			this.APIRunner_IncrementCountersCheckBox.CheckedChanged += new System.EventHandler(this.APIRunner_IncrementCountersCheckBoxCheckedChanged);
			// 
			// label66
			// 
			this.label66.Location = new System.Drawing.Point(759, 124);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(126, 23);
			this.label66.TabIndex = 15;
			this.label66.Text = "Increment Criteria:";
			// 
			// APIRunner_IncrementCriteriaTextBox
			// 
			this.APIRunner_IncrementCriteriaTextBox.Location = new System.Drawing.Point(759, 150);
			this.APIRunner_IncrementCriteriaTextBox.Multiline = true;
			this.APIRunner_IncrementCriteriaTextBox.Name = "APIRunner_IncrementCriteriaTextBox";
			this.APIRunner_IncrementCriteriaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIRunner_IncrementCriteriaTextBox.Size = new System.Drawing.Size(340, 276);
			this.APIRunner_IncrementCriteriaTextBox.TabIndex = 17;
			// 
			// APIRunner_IsCounterTemplate
			// 
			this.APIRunner_IsCounterTemplate.Location = new System.Drawing.Point(777, 25);
			this.APIRunner_IsCounterTemplate.Name = "APIRunner_IsCounterTemplate";
			this.APIRunner_IsCounterTemplate.Size = new System.Drawing.Size(121, 24);
			this.APIRunner_IsCounterTemplate.TabIndex = 13;
			this.APIRunner_IsCounterTemplate.Text = "Is Counter Template";
			this.APIRunner_IsCounterTemplate.UseVisualStyleBackColor = true;
			this.APIRunner_IsCounterTemplate.Visible = false;
			// 
			// label65
			// 
			this.label65.Location = new System.Drawing.Point(67, 434);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(76, 18);
			this.label65.TabIndex = 12;
			this.label65.Text = "Result:";
			// 
			// label64
			// 
			this.label64.Location = new System.Drawing.Point(413, 124);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(76, 23);
			this.label64.TabIndex = 11;
			this.label64.Text = "Template:";
			// 
			// label63
			// 
			this.label63.Location = new System.Drawing.Point(67, 124);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(76, 23);
			this.label63.TabIndex = 10;
			this.label63.Text = "Input XML:";
			// 
			// APIRunner_RunAPIButton
			// 
			this.APIRunner_RunAPIButton.Location = new System.Drawing.Point(594, 35);
			this.APIRunner_RunAPIButton.Name = "APIRunner_RunAPIButton";
			this.APIRunner_RunAPIButton.Size = new System.Drawing.Size(75, 23);
			this.APIRunner_RunAPIButton.TabIndex = 6;
			this.APIRunner_RunAPIButton.Text = "Run";
			this.APIRunner_RunAPIButton.UseVisualStyleBackColor = true;
			this.APIRunner_RunAPIButton.Click += new System.EventHandler(this.APIRunner_RunAPIButtonClick);
			// 
			// label62
			// 
			this.label62.Location = new System.Drawing.Point(67, 39);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(76, 23);
			this.label62.TabIndex = 102;
			this.label62.Text = "API:";
			// 
			// APIRunner_APINamesComboBox
			// 
			this.APIRunner_APINamesComboBox.FormattingEnabled = true;
			this.APIRunner_APINamesComboBox.Location = new System.Drawing.Point(162, 36);
			this.APIRunner_APINamesComboBox.Name = "APIRunner_APINamesComboBox";
			this.APIRunner_APINamesComboBox.Size = new System.Drawing.Size(369, 21);
			this.APIRunner_APINamesComboBox.TabIndex = 1;
			this.APIRunner_APINamesComboBox.SelectedIndexChanged += new System.EventHandler(this.APIRunner_APINamesComboBoxSelectedIndexChanged);
			// 
			// label60
			// 
			this.label60.Location = new System.Drawing.Point(67, 86);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(76, 23);
			this.label60.TabIndex = 101;
			this.label60.Text = "Password:";
			// 
			// label59
			// 
			this.label59.Location = new System.Drawing.Point(67, 66);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(76, 23);
			this.label59.TabIndex = 100;
			this.label59.Text = "User Name:";
			// 
			// APIRunner_PasswordTextbox
			// 
			this.APIRunner_PasswordTextbox.Location = new System.Drawing.Point(162, 89);
			this.APIRunner_PasswordTextbox.Name = "APIRunner_PasswordTextbox";
			this.APIRunner_PasswordTextbox.Size = new System.Drawing.Size(369, 20);
			this.APIRunner_PasswordTextbox.TabIndex = 3;
			this.APIRunner_PasswordTextbox.Text = "password";
			// 
			// APIRunner_UserNameTextBox
			// 
			this.APIRunner_UserNameTextBox.Location = new System.Drawing.Point(162, 63);
			this.APIRunner_UserNameTextBox.Name = "APIRunner_UserNameTextBox";
			this.APIRunner_UserNameTextBox.Size = new System.Drawing.Size(369, 20);
			this.APIRunner_UserNameTextBox.TabIndex = 2;
			this.APIRunner_UserNameTextBox.Text = "admin";
			// 
			// APIRunner_APITemplateTextBox
			// 
			this.APIRunner_APITemplateTextBox.Location = new System.Drawing.Point(413, 150);
			this.APIRunner_APITemplateTextBox.MaxLength = 65535;
			this.APIRunner_APITemplateTextBox.Multiline = true;
			this.APIRunner_APITemplateTextBox.Name = "APIRunner_APITemplateTextBox";
			this.APIRunner_APITemplateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIRunner_APITemplateTextBox.Size = new System.Drawing.Size(340, 276);
			this.APIRunner_APITemplateTextBox.TabIndex = 16;
			this.APIRunner_APITemplateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIRunner_APITemplateTextBoxKeyDown);
			// 
			// APIRunner_APIXMLTextBox
			// 
			this.APIRunner_APIXMLTextBox.Location = new System.Drawing.Point(67, 150);
			this.APIRunner_APIXMLTextBox.MaxLength = 65535;
			this.APIRunner_APIXMLTextBox.Multiline = true;
			this.APIRunner_APIXMLTextBox.Name = "APIRunner_APIXMLTextBox";
			this.APIRunner_APIXMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIRunner_APIXMLTextBox.Size = new System.Drawing.Size(340, 276);
			this.APIRunner_APIXMLTextBox.TabIndex = 15;
			this.APIRunner_APIXMLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIRunner_APIXMLTextBoxKeyDown);
			// 
			// ArchivingToolsTab
			// 
			this.ArchivingToolsTab.Controls.Add(this.ExtractGroupBox);
			this.ArchivingToolsTab.Location = new System.Drawing.Point(4, 22);
			this.ArchivingToolsTab.Name = "ArchivingToolsTab";
			this.ArchivingToolsTab.Size = new System.Drawing.Size(1257, 693);
			this.ArchivingToolsTab.TabIndex = 0;
			this.ArchivingToolsTab.Text = "Archiving Tools";
			this.ArchivingToolsTab.UseVisualStyleBackColor = true;
			// 
			// ExtractGroupBox
			// 
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveResetButton);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveDeleteExcludedFileButton);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveDeleteRemoveTermButton);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveAddExcludedFileButton);
			this.ExtractGroupBox.Controls.Add(this.label8);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveExcludedFilesComboBox);
			this.ExtractGroupBox.Controls.Add(this.label9);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveAddExcludedFileTextBox);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveAddRemoveTermButton);
			this.ExtractGroupBox.Controls.Add(this.label57);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveRemoveTermsComboBox);
			this.ExtractGroupBox.Controls.Add(this.label19);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveAddRemoveTermTextBox);
			this.ExtractGroupBox.Controls.Add(this.MaxNestingLabel);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchiveMaxNestingTextBox);
			this.ExtractGroupBox.Controls.Add(this.RecursivelyExtractArchiveCheckBox);
			this.ExtractGroupBox.Controls.Add(this.BrowseArchiveFileButton);
			this.ExtractGroupBox.Controls.Add(this.ArchiveExtractButton);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchivePathLabel);
			this.ExtractGroupBox.Controls.Add(this.ExtractArchivePathTextBox);
			this.ExtractGroupBox.Location = new System.Drawing.Point(17, 15);
			this.ExtractGroupBox.Name = "ExtractGroupBox";
			this.ExtractGroupBox.Size = new System.Drawing.Size(401, 664);
			this.ExtractGroupBox.TabIndex = 0;
			this.ExtractGroupBox.TabStop = false;
			this.ExtractGroupBox.Text = "Extract Tools";
			// 
			// ExtractArchiveResetButton
			// 
			this.ExtractArchiveResetButton.Location = new System.Drawing.Point(206, 73);
			this.ExtractArchiveResetButton.Name = "ExtractArchiveResetButton";
			this.ExtractArchiveResetButton.Size = new System.Drawing.Size(75, 23);
			this.ExtractArchiveResetButton.TabIndex = 19;
			this.ExtractArchiveResetButton.Text = "Reset";
			this.ExtractArchiveResetButton.UseVisualStyleBackColor = true;
			this.ExtractArchiveResetButton.Click += new System.EventHandler(this.ExtractArchiveResetButtonClick);
			// 
			// ExtractArchiveDeleteExcludedFileButton
			// 
			this.ExtractArchiveDeleteExcludedFileButton.Location = new System.Drawing.Point(295, 213);
			this.ExtractArchiveDeleteExcludedFileButton.Name = "ExtractArchiveDeleteExcludedFileButton";
			this.ExtractArchiveDeleteExcludedFileButton.Size = new System.Drawing.Size(75, 23);
			this.ExtractArchiveDeleteExcludedFileButton.TabIndex = 18;
			this.ExtractArchiveDeleteExcludedFileButton.Text = "Delete";
			this.ExtractArchiveDeleteExcludedFileButton.UseVisualStyleBackColor = true;
			this.ExtractArchiveDeleteExcludedFileButton.Click += new System.EventHandler(this.ExtractArchiveDeleteExcludedFileButtonClick);
			// 
			// ExtractArchiveDeleteRemoveTermButton
			// 
			this.ExtractArchiveDeleteRemoveTermButton.Location = new System.Drawing.Point(295, 143);
			this.ExtractArchiveDeleteRemoveTermButton.Name = "ExtractArchiveDeleteRemoveTermButton";
			this.ExtractArchiveDeleteRemoveTermButton.Size = new System.Drawing.Size(75, 23);
			this.ExtractArchiveDeleteRemoveTermButton.TabIndex = 17;
			this.ExtractArchiveDeleteRemoveTermButton.Text = "Delete";
			this.ExtractArchiveDeleteRemoveTermButton.UseVisualStyleBackColor = true;
			this.ExtractArchiveDeleteRemoveTermButton.Click += new System.EventHandler(this.ExtractArchiveDeleteRemoveTermButtonClick);
			// 
			// ExtractArchiveAddExcludedFileButton
			// 
			this.ExtractArchiveAddExcludedFileButton.Location = new System.Drawing.Point(295, 184);
			this.ExtractArchiveAddExcludedFileButton.Name = "ExtractArchiveAddExcludedFileButton";
			this.ExtractArchiveAddExcludedFileButton.Size = new System.Drawing.Size(75, 23);
			this.ExtractArchiveAddExcludedFileButton.TabIndex = 16;
			this.ExtractArchiveAddExcludedFileButton.Text = "Add";
			this.ExtractArchiveAddExcludedFileButton.UseVisualStyleBackColor = true;
			this.ExtractArchiveAddExcludedFileButton.Click += new System.EventHandler(this.ExtractArchiveAddExcludedFileButtonClick);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Excluded File Types";
			// 
			// ExtractArchiveExcludedFilesComboBox
			// 
			this.ExtractArchiveExcludedFilesComboBox.FormattingEnabled = true;
			this.ExtractArchiveExcludedFilesComboBox.Location = new System.Drawing.Point(133, 213);
			this.ExtractArchiveExcludedFilesComboBox.Name = "ExtractArchiveExcludedFilesComboBox";
			this.ExtractArchiveExcludedFilesComboBox.Size = new System.Drawing.Size(148, 21);
			this.ExtractArchiveExcludedFilesComboBox.TabIndex = 14;
			this.ExtractArchiveExcludedFilesComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtractArchiveExcludedFilesComboBoxKeyDown);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 185);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "Exclude File Type";
			// 
			// ExtractArchiveAddExcludedFileTextBox
			// 
			this.ExtractArchiveAddExcludedFileTextBox.Location = new System.Drawing.Point(133, 184);
			this.ExtractArchiveAddExcludedFileTextBox.Name = "ExtractArchiveAddExcludedFileTextBox";
			this.ExtractArchiveAddExcludedFileTextBox.Size = new System.Drawing.Size(148, 20);
			this.ExtractArchiveAddExcludedFileTextBox.TabIndex = 12;
			// 
			// ExtractArchiveAddRemoveTermButton
			// 
			this.ExtractArchiveAddRemoveTermButton.Location = new System.Drawing.Point(295, 117);
			this.ExtractArchiveAddRemoveTermButton.Name = "ExtractArchiveAddRemoveTermButton";
			this.ExtractArchiveAddRemoveTermButton.Size = new System.Drawing.Size(75, 23);
			this.ExtractArchiveAddRemoveTermButton.TabIndex = 11;
			this.ExtractArchiveAddRemoveTermButton.Text = "Add";
			this.ExtractArchiveAddRemoveTermButton.UseVisualStyleBackColor = true;
			this.ExtractArchiveAddRemoveTermButton.Click += new System.EventHandler(this.ExtractArchiveAddRemoveTermButtonClick);
			// 
			// label57
			// 
			this.label57.Location = new System.Drawing.Point(6, 143);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(109, 23);
			this.label57.TabIndex = 10;
			this.label57.Text = "Removed Terms";
			// 
			// ExtractArchiveRemoveTermsComboBox
			// 
			this.ExtractArchiveRemoveTermsComboBox.FormattingEnabled = true;
			this.ExtractArchiveRemoveTermsComboBox.Location = new System.Drawing.Point(133, 146);
			this.ExtractArchiveRemoveTermsComboBox.Name = "ExtractArchiveRemoveTermsComboBox";
			this.ExtractArchiveRemoveTermsComboBox.Size = new System.Drawing.Size(148, 21);
			this.ExtractArchiveRemoveTermsComboBox.TabIndex = 9;
			this.ExtractArchiveRemoveTermsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtractArchiveRemoveTermsComboBoxKeyDown);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(6, 117);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(109, 23);
			this.label19.TabIndex = 8;
			this.label19.Text = "ADD Remove Term";
			// 
			// ExtractArchiveAddRemoveTermTextBox
			// 
			this.ExtractArchiveAddRemoveTermTextBox.Location = new System.Drawing.Point(133, 117);
			this.ExtractArchiveAddRemoveTermTextBox.Name = "ExtractArchiveAddRemoveTermTextBox";
			this.ExtractArchiveAddRemoveTermTextBox.Size = new System.Drawing.Size(148, 20);
			this.ExtractArchiveAddRemoveTermTextBox.TabIndex = 7;
			// 
			// MaxNestingLabel
			// 
			this.MaxNestingLabel.Location = new System.Drawing.Point(6, 46);
			this.MaxNestingLabel.Name = "MaxNestingLabel";
			this.MaxNestingLabel.Size = new System.Drawing.Size(75, 23);
			this.MaxNestingLabel.TabIndex = 6;
			this.MaxNestingLabel.Text = "Max Nesting";
			// 
			// ExtractArchiveMaxNestingTextBox
			// 
			this.ExtractArchiveMaxNestingTextBox.Location = new System.Drawing.Point(87, 46);
			this.ExtractArchiveMaxNestingTextBox.Name = "ExtractArchiveMaxNestingTextBox";
			this.ExtractArchiveMaxNestingTextBox.Size = new System.Drawing.Size(276, 20);
			this.ExtractArchiveMaxNestingTextBox.TabIndex = 5;
			// 
			// RecursivelyExtractArchiveCheckBox
			// 
			this.RecursivelyExtractArchiveCheckBox.Location = new System.Drawing.Point(15, 72);
			this.RecursivelyExtractArchiveCheckBox.Name = "RecursivelyExtractArchiveCheckBox";
			this.RecursivelyExtractArchiveCheckBox.Size = new System.Drawing.Size(163, 24);
			this.RecursivelyExtractArchiveCheckBox.TabIndex = 4;
			this.RecursivelyExtractArchiveCheckBox.Text = "Recursively Extract Archive";
			this.RecursivelyExtractArchiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// BrowseArchiveFileButton
			// 
			this.BrowseArchiveFileButton.Location = new System.Drawing.Point(370, 20);
			this.BrowseArchiveFileButton.Name = "BrowseArchiveFileButton";
			this.BrowseArchiveFileButton.Size = new System.Drawing.Size(25, 23);
			this.BrowseArchiveFileButton.TabIndex = 3;
			this.BrowseArchiveFileButton.Text = "..";
			this.BrowseArchiveFileButton.UseVisualStyleBackColor = true;
			this.BrowseArchiveFileButton.Click += new System.EventHandler(this.BrowseArchiveFileButtonClick);
			// 
			// ArchiveExtractButton
			// 
			this.ArchiveExtractButton.Location = new System.Drawing.Point(288, 73);
			this.ArchiveExtractButton.Name = "ArchiveExtractButton";
			this.ArchiveExtractButton.Size = new System.Drawing.Size(75, 23);
			this.ArchiveExtractButton.TabIndex = 2;
			this.ArchiveExtractButton.Text = "Extract";
			this.ArchiveExtractButton.UseVisualStyleBackColor = true;
			this.ArchiveExtractButton.Click += new System.EventHandler(this.ArchiveExtractButtonClick);
			// 
			// ExtractArchivePathLabel
			// 
			this.ExtractArchivePathLabel.Location = new System.Drawing.Point(15, 20);
			this.ExtractArchivePathLabel.Name = "ExtractArchivePathLabel";
			this.ExtractArchivePathLabel.Size = new System.Drawing.Size(48, 23);
			this.ExtractArchivePathLabel.TabIndex = 1;
			this.ExtractArchivePathLabel.Text = "Path:";
			// 
			// ExtractArchivePathTextBox
			// 
			this.ExtractArchivePathTextBox.Location = new System.Drawing.Point(69, 20);
			this.ExtractArchivePathTextBox.Name = "ExtractArchivePathTextBox";
			this.ExtractArchivePathTextBox.Size = new System.Drawing.Size(294, 20);
			this.ExtractArchivePathTextBox.TabIndex = 0;
			// 
			// STAFFS
			// 
			this.STAFFS.Location = new System.Drawing.Point(4, 22);
			this.STAFFS.Name = "STAFFS";
			this.STAFFS.Padding = new System.Windows.Forms.Padding(3);
			this.STAFFS.Size = new System.Drawing.Size(1257, 693);
			this.STAFFS.TabIndex = 19;
			this.STAFFS.Text = "STAF FS";
			this.STAFFS.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1265, 719);
			this.panel2.TabIndex = 2;
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(5, 22);
			this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(62, 15);
			this.label41.TabIndex = 29;
			this.label41.Text = "Select Host";
			// 
			// button33
			// 
			this.button33.Location = new System.Drawing.Point(119, 61);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(102, 28);
			this.button33.TabIndex = 31;
			this.button33.Text = "Manual Edit";
			this.button33.UseVisualStyleBackColor = true;
			// 
			// button34
			// 
			this.button34.Location = new System.Drawing.Point(11, 61);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(102, 28);
			this.button34.TabIndex = 30;
			this.button34.Text = "Refresh Hosts";
			this.button34.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(71, 18);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(150, 21);
			this.comboBox2.TabIndex = 27;
			// 
			// groupBox8
			// 
			this.groupBox8.Location = new System.Drawing.Point(30, 356);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(194, 94);
			this.groupBox8.TabIndex = 49;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Machine Type";
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(482, 9);
			this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(56, 21);
			this.label42.TabIndex = 48;
			this.label42.Text = "Name:";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(542, 9);
			this.textBox13.Margin = new System.Windows.Forms.Padding(2);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(84, 20);
			this.textBox13.TabIndex = 47;
			this.textBox13.Text = "Madisons";
			// 
			// button35
			// 
			this.button35.Location = new System.Drawing.Point(630, 6);
			this.button35.Margin = new System.Windows.Forms.Padding(2);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(118, 24);
			this.button35.TabIndex = 46;
			this.button35.Text = "Launch Store";
			this.button35.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.textBox14);
			this.groupBox9.Controls.Add(this.textBox15);
			this.groupBox9.Controls.Add(this.button36);
			this.groupBox9.Controls.Add(this.button37);
			this.groupBox9.Controls.Add(this.button38);
			this.groupBox9.Location = new System.Drawing.Point(466, 216);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(264, 178);
			this.groupBox9.TabIndex = 45;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Machine Checks";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(164, 46);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(72, 20);
			this.textBox14.TabIndex = 39;
			this.textBox14.Text = "80";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(164, 77);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(72, 20);
			this.textBox15.TabIndex = 38;
			this.textBox15.Text = "443";
			// 
			// button36
			// 
			this.button36.Location = new System.Drawing.Point(24, 74);
			this.button36.Margin = new System.Windows.Forms.Padding(2);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(118, 24);
			this.button36.TabIndex = 37;
			this.button36.Text = "HttpsCheck";
			this.button36.UseVisualStyleBackColor = true;
			// 
			// button37
			// 
			this.button37.Location = new System.Drawing.Point(24, 46);
			this.button37.Margin = new System.Windows.Forms.Padding(2);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(118, 24);
			this.button37.TabIndex = 36;
			this.button37.Text = "HttpCheck";
			this.button37.UseVisualStyleBackColor = true;
			// 
			// button38
			// 
			this.button38.Location = new System.Drawing.Point(24, 18);
			this.button38.Margin = new System.Windows.Forms.Padding(2);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(118, 24);
			this.button38.TabIndex = 35;
			this.button38.Text = "Ping";
			this.button38.UseVisualStyleBackColor = true;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.button39);
			this.groupBox10.Controls.Add(this.button40);
			this.groupBox10.Controls.Add(this.button41);
			this.groupBox10.Controls.Add(this.button42);
			this.groupBox10.Controls.Add(this.button43);
			this.groupBox10.Controls.Add(this.textBox16);
			this.groupBox10.Controls.Add(this.label43);
			this.groupBox10.Location = new System.Drawing.Point(6, 50);
			this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox10.Size = new System.Drawing.Size(219, 202);
			this.groupBox10.TabIndex = 44;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "IE Only Pages";
			// 
			// button39
			// 
			this.button39.Location = new System.Drawing.Point(4, 138);
			this.button39.Margin = new System.Windows.Forms.Padding(2);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(152, 24);
			this.button39.TabIndex = 10;
			this.button39.Text = "Workspace Adm. Console";
			this.button39.UseVisualStyleBackColor = true;
			// 
			// button40
			// 
			this.button40.Location = new System.Drawing.Point(4, 110);
			this.button40.Margin = new System.Windows.Forms.Padding(2);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(152, 24);
			this.button40.TabIndex = 7;
			this.button40.Text = "Org Adm. Console";
			this.button40.UseVisualStyleBackColor = true;
			// 
			// button41
			// 
			this.button41.Location = new System.Drawing.Point(4, 80);
			this.button41.Margin = new System.Windows.Forms.Padding(2);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(152, 24);
			this.button41.TabIndex = 6;
			this.button41.Text = "IBM Adm. Console";
			this.button41.UseVisualStyleBackColor = true;
			// 
			// button42
			// 
			this.button42.Location = new System.Drawing.Point(4, 52);
			this.button42.Margin = new System.Windows.Forms.Padding(2);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(152, 24);
			this.button42.TabIndex = 5;
			this.button42.Text = "Admin Console";
			this.button42.UseVisualStyleBackColor = true;
			// 
			// button43
			// 
			this.button43.Location = new System.Drawing.Point(4, 24);
			this.button43.Margin = new System.Windows.Forms.Padding(2);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(152, 24);
			this.button43.TabIndex = 3;
			this.button43.Text = "Accelerator";
			this.button43.UseVisualStyleBackColor = true;
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(160, 80);
			this.textBox16.Margin = new System.Windows.Forms.Padding(2);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(41, 20);
			this.textBox16.TabIndex = 8;
			this.textBox16.Text = "9102";
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(160, 58);
			this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(30, 21);
			this.label43.TabIndex = 9;
			this.label43.Text = "Port:";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.button44);
			this.groupBox11.Controls.Add(this.button45);
			this.groupBox11.Controls.Add(this.button46);
			this.groupBox11.Controls.Add(this.button47);
			this.groupBox11.Controls.Add(this.button48);
			this.groupBox11.Controls.Add(this.button49);
			this.groupBox11.Controls.Add(this.button50);
			this.groupBox11.Controls.Add(this.button51);
			this.groupBox11.Location = new System.Drawing.Point(287, 274);
			this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox11.Size = new System.Drawing.Size(158, 288);
			this.groupBox11.TabIndex = 43;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Utilities";
			// 
			// button44
			// 
			this.button44.Location = new System.Drawing.Point(21, 234);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(118, 23);
			this.button44.TabIndex = 46;
			this.button44.Text = "FTP client";
			this.button44.UseVisualStyleBackColor = true;
			// 
			// button45
			// 
			this.button45.Location = new System.Drawing.Point(21, 205);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(118, 23);
			this.button45.TabIndex = 44;
			this.button45.Text = "Listner";
			this.button45.UseVisualStyleBackColor = true;
			// 
			// button46
			// 
			this.button46.Location = new System.Drawing.Point(21, 176);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(118, 23);
			this.button46.TabIndex = 43;
			this.button46.Text = "Browse SMB Shares";
			this.button46.UseVisualStyleBackColor = true;
			// 
			// button47
			// 
			this.button47.Location = new System.Drawing.Point(21, 147);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(118, 23);
			this.button47.TabIndex = 42;
			this.button47.Text = "Win SCP";
			this.button47.UseVisualStyleBackColor = true;
			// 
			// button48
			// 
			this.button48.Location = new System.Drawing.Point(21, 118);
			this.button48.Margin = new System.Windows.Forms.Padding(2);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(118, 24);
			this.button48.TabIndex = 30;
			this.button48.Text = "Remote Desktop";
			this.button48.UseVisualStyleBackColor = true;
			// 
			// button49
			// 
			this.button49.Location = new System.Drawing.Point(21, 89);
			this.button49.Margin = new System.Windows.Forms.Padding(2);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(118, 24);
			this.button49.TabIndex = 34;
			this.button49.Text = "Telnet";
			this.button49.UseVisualStyleBackColor = true;
			// 
			// button50
			// 
			this.button50.Location = new System.Drawing.Point(21, 60);
			this.button50.Margin = new System.Windows.Forms.Padding(2);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(118, 24);
			this.button50.TabIndex = 41;
			this.button50.Text = "Putty";
			this.button50.UseVisualStyleBackColor = true;
			// 
			// button51
			// 
			this.button51.Location = new System.Drawing.Point(21, 31);
			this.button51.Margin = new System.Windows.Forms.Padding(2);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(118, 24);
			this.button51.TabIndex = 31;
			this.button51.Text = "VNC viewer";
			this.button51.UseVisualStyleBackColor = true;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.button52);
			this.groupBox12.Controls.Add(this.button53);
			this.groupBox12.Controls.Add(this.button54);
			this.groupBox12.Controls.Add(this.button55);
			this.groupBox12.Controls.Add(this.button56);
			this.groupBox12.Controls.Add(this.button57);
			this.groupBox12.Controls.Add(this.button58);
			this.groupBox12.Location = new System.Drawing.Point(287, 40);
			this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox12.Size = new System.Drawing.Size(158, 230);
			this.groupBox12.TabIndex = 42;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Pages";
			// 
			// button52
			// 
			this.button52.Location = new System.Drawing.Point(17, 193);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(118, 23);
			this.button52.TabIndex = 45;
			this.button52.Text = "FTP(Default)";
			this.button52.UseVisualStyleBackColor = true;
			// 
			// button53
			// 
			this.button53.Location = new System.Drawing.Point(17, 164);
			this.button53.Margin = new System.Windows.Forms.Padding(2);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(118, 24);
			this.button53.TabIndex = 14;
			this.button53.Text = "Info Center";
			this.button53.UseVisualStyleBackColor = true;
			// 
			// button54
			// 
			this.button54.Location = new System.Drawing.Point(17, 136);
			this.button54.Margin = new System.Windows.Forms.Padding(2);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(118, 24);
			this.button54.TabIndex = 13;
			this.button54.Text = "Coremetrics";
			this.button54.UseVisualStyleBackColor = true;
			// 
			// button55
			// 
			this.button55.Location = new System.Drawing.Point(17, 108);
			this.button55.Margin = new System.Windows.Forms.Padding(2);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(118, 24);
			this.button55.TabIndex = 12;
			this.button55.Text = "DB Info";
			this.button55.UseVisualStyleBackColor = true;
			// 
			// button56
			// 
			this.button56.Location = new System.Drawing.Point(17, 79);
			this.button56.Margin = new System.Windows.Forms.Padding(2);
			this.button56.Name = "button56";
			this.button56.Size = new System.Drawing.Size(118, 24);
			this.button56.TabIndex = 11;
			this.button56.Text = "DB Query";
			this.button56.UseVisualStyleBackColor = true;
			// 
			// button57
			// 
			this.button57.Location = new System.Drawing.Point(17, 23);
			this.button57.Margin = new System.Windows.Forms.Padding(2);
			this.button57.Name = "button57";
			this.button57.Size = new System.Drawing.Size(118, 24);
			this.button57.TabIndex = 4;
			this.button57.Text = "Lob Tools";
			this.button57.UseVisualStyleBackColor = true;
			// 
			// button58
			// 
			this.button58.Location = new System.Drawing.Point(17, 51);
			this.button58.Margin = new System.Windows.Forms.Padding(2);
			this.button58.Name = "button58";
			this.button58.Size = new System.Drawing.Size(118, 24);
			this.button58.TabIndex = 10;
			this.button58.Text = "Artec";
			this.button58.UseVisualStyleBackColor = true;
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.radioButton4);
			this.groupBox13.Controls.Add(this.radioButton5);
			this.groupBox13.Controls.Add(this.radioButton6);
			this.groupBox13.Location = new System.Drawing.Point(452, 42);
			this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox13.Size = new System.Drawing.Size(166, 141);
			this.groupBox13.TabIndex = 40;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Select Browser";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(4, 32);
			this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(143, 20);
			this.radioButton4.TabIndex = 40;
			this.radioButton4.Text = "Open in Default (use IE)";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(4, 57);
			this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(95, 20);
			this.radioButton5.TabIndex = 39;
			this.radioButton5.Text = "Open in Firefox";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.Location = new System.Drawing.Point(4, 81);
			this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(152, 20);
			this.radioButton6.TabIndex = 33;
			this.radioButton6.Text = "Open in TesterBuddy";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(10, 275);
			this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(33, 22);
			this.label44.TabIndex = 38;
			this.label44.Text = "URL";
			// 
			// button59
			// 
			this.button59.Location = new System.Drawing.Point(206, 274);
			this.button59.Margin = new System.Windows.Forms.Padding(2);
			this.button59.Name = "button59";
			this.button59.Size = new System.Drawing.Size(35, 23);
			this.button59.TabIndex = 37;
			this.button59.Text = "GO";
			this.button59.UseVisualStyleBackColor = true;
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(48, 275);
			this.textBox17.Margin = new System.Windows.Forms.Padding(2);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(152, 20);
			this.textBox17.TabIndex = 36;
			this.textBox17.Text = "www.w3.ibm.com";
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(178, 14);
			this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(63, 21);
			this.label45.TabIndex = 29;
			this.label45.Text = "Catalog ID:";
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(246, 12);
			this.textBox18.Margin = new System.Windows.Forms.Padding(2);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(84, 20);
			this.textBox18.TabIndex = 28;
			this.textBox18.Text = "<na>";
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label46.Location = new System.Drawing.Point(4, 487);
			this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(351, 25);
			this.label46.TabIndex = 27;
			this.label46.Text = "Note: Host name is taken from Add Host tab.";
			// 
			// button60
			// 
			this.button60.Location = new System.Drawing.Point(338, 8);
			this.button60.Margin = new System.Windows.Forms.Padding(2);
			this.button60.Name = "button60";
			this.button60.Size = new System.Drawing.Size(118, 24);
			this.button60.TabIndex = 2;
			this.button60.Text = "Launch Store";
			this.button60.UseVisualStyleBackColor = true;
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(30, 17);
			this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(56, 21);
			this.label47.TabIndex = 1;
			this.label47.Text = "Store ID:";
			// 
			// textBox30
			// 
			this.textBox30.Location = new System.Drawing.Point(90, 15);
			this.textBox30.Margin = new System.Windows.Forms.Padding(2);
			this.textBox30.Name = "textBox30";
			this.textBox30.Size = new System.Drawing.Size(84, 20);
			this.textBox30.TabIndex = 0;
			this.textBox30.Text = "555";
			// 
			// groupBox14
			// 
			this.groupBox14.Location = new System.Drawing.Point(30, 356);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(194, 94);
			this.groupBox14.TabIndex = 49;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Machine Type";
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(482, 9);
			this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(56, 21);
			this.label48.TabIndex = 48;
			this.label48.Text = "Name:";
			// 
			// textBox31
			// 
			this.textBox31.Location = new System.Drawing.Point(542, 9);
			this.textBox31.Margin = new System.Windows.Forms.Padding(2);
			this.textBox31.Name = "textBox31";
			this.textBox31.Size = new System.Drawing.Size(84, 20);
			this.textBox31.TabIndex = 47;
			this.textBox31.Text = "Madisons";
			// 
			// button61
			// 
			this.button61.Location = new System.Drawing.Point(630, 6);
			this.button61.Margin = new System.Windows.Forms.Padding(2);
			this.button61.Name = "button61";
			this.button61.Size = new System.Drawing.Size(118, 24);
			this.button61.TabIndex = 46;
			this.button61.Text = "Launch Store";
			this.button61.UseVisualStyleBackColor = true;
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.textBox32);
			this.groupBox15.Controls.Add(this.textBox33);
			this.groupBox15.Controls.Add(this.button62);
			this.groupBox15.Controls.Add(this.button63);
			this.groupBox15.Controls.Add(this.button64);
			this.groupBox15.Location = new System.Drawing.Point(466, 216);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(264, 178);
			this.groupBox15.TabIndex = 45;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Machine Checks";
			// 
			// textBox32
			// 
			this.textBox32.Location = new System.Drawing.Point(164, 46);
			this.textBox32.Name = "textBox32";
			this.textBox32.Size = new System.Drawing.Size(72, 20);
			this.textBox32.TabIndex = 39;
			this.textBox32.Text = "80";
			// 
			// textBox33
			// 
			this.textBox33.Location = new System.Drawing.Point(164, 77);
			this.textBox33.Name = "textBox33";
			this.textBox33.Size = new System.Drawing.Size(72, 20);
			this.textBox33.TabIndex = 38;
			this.textBox33.Text = "443";
			// 
			// button62
			// 
			this.button62.Location = new System.Drawing.Point(24, 74);
			this.button62.Margin = new System.Windows.Forms.Padding(2);
			this.button62.Name = "button62";
			this.button62.Size = new System.Drawing.Size(118, 24);
			this.button62.TabIndex = 37;
			this.button62.Text = "HttpsCheck";
			this.button62.UseVisualStyleBackColor = true;
			// 
			// button63
			// 
			this.button63.Location = new System.Drawing.Point(24, 46);
			this.button63.Margin = new System.Windows.Forms.Padding(2);
			this.button63.Name = "button63";
			this.button63.Size = new System.Drawing.Size(118, 24);
			this.button63.TabIndex = 36;
			this.button63.Text = "HttpCheck";
			this.button63.UseVisualStyleBackColor = true;
			// 
			// button64
			// 
			this.button64.Location = new System.Drawing.Point(24, 18);
			this.button64.Margin = new System.Windows.Forms.Padding(2);
			this.button64.Name = "button64";
			this.button64.Size = new System.Drawing.Size(118, 24);
			this.button64.TabIndex = 35;
			this.button64.Text = "Ping";
			this.button64.UseVisualStyleBackColor = true;
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.button65);
			this.groupBox16.Controls.Add(this.button66);
			this.groupBox16.Controls.Add(this.button67);
			this.groupBox16.Controls.Add(this.button68);
			this.groupBox16.Controls.Add(this.button69);
			this.groupBox16.Controls.Add(this.textBox34);
			this.groupBox16.Controls.Add(this.label49);
			this.groupBox16.Location = new System.Drawing.Point(6, 50);
			this.groupBox16.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox16.Size = new System.Drawing.Size(219, 202);
			this.groupBox16.TabIndex = 44;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "IE Only Pages";
			// 
			// button65
			// 
			this.button65.Location = new System.Drawing.Point(4, 138);
			this.button65.Margin = new System.Windows.Forms.Padding(2);
			this.button65.Name = "button65";
			this.button65.Size = new System.Drawing.Size(152, 24);
			this.button65.TabIndex = 10;
			this.button65.Text = "Workspace Adm. Console";
			this.button65.UseVisualStyleBackColor = true;
			// 
			// button66
			// 
			this.button66.Location = new System.Drawing.Point(4, 110);
			this.button66.Margin = new System.Windows.Forms.Padding(2);
			this.button66.Name = "button66";
			this.button66.Size = new System.Drawing.Size(152, 24);
			this.button66.TabIndex = 7;
			this.button66.Text = "Org Adm. Console";
			this.button66.UseVisualStyleBackColor = true;
			// 
			// button67
			// 
			this.button67.Location = new System.Drawing.Point(4, 80);
			this.button67.Margin = new System.Windows.Forms.Padding(2);
			this.button67.Name = "button67";
			this.button67.Size = new System.Drawing.Size(152, 24);
			this.button67.TabIndex = 6;
			this.button67.Text = "IBM Adm. Console";
			this.button67.UseVisualStyleBackColor = true;
			// 
			// button68
			// 
			this.button68.Location = new System.Drawing.Point(4, 52);
			this.button68.Margin = new System.Windows.Forms.Padding(2);
			this.button68.Name = "button68";
			this.button68.Size = new System.Drawing.Size(152, 24);
			this.button68.TabIndex = 5;
			this.button68.Text = "Admin Console";
			this.button68.UseVisualStyleBackColor = true;
			// 
			// button69
			// 
			this.button69.Location = new System.Drawing.Point(4, 24);
			this.button69.Margin = new System.Windows.Forms.Padding(2);
			this.button69.Name = "button69";
			this.button69.Size = new System.Drawing.Size(152, 24);
			this.button69.TabIndex = 3;
			this.button69.Text = "Accelerator";
			this.button69.UseVisualStyleBackColor = true;
			// 
			// textBox34
			// 
			this.textBox34.Location = new System.Drawing.Point(160, 80);
			this.textBox34.Margin = new System.Windows.Forms.Padding(2);
			this.textBox34.Name = "textBox34";
			this.textBox34.Size = new System.Drawing.Size(41, 20);
			this.textBox34.TabIndex = 8;
			this.textBox34.Text = "9102";
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(160, 58);
			this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(30, 21);
			this.label49.TabIndex = 9;
			this.label49.Text = "Port:";
			// 
			// groupBox17
			// 
			this.groupBox17.Controls.Add(this.button70);
			this.groupBox17.Controls.Add(this.button71);
			this.groupBox17.Controls.Add(this.button72);
			this.groupBox17.Controls.Add(this.button73);
			this.groupBox17.Controls.Add(this.button74);
			this.groupBox17.Controls.Add(this.button75);
			this.groupBox17.Controls.Add(this.button76);
			this.groupBox17.Controls.Add(this.button77);
			this.groupBox17.Location = new System.Drawing.Point(287, 274);
			this.groupBox17.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox17.Size = new System.Drawing.Size(158, 288);
			this.groupBox17.TabIndex = 43;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Utilities";
			// 
			// button70
			// 
			this.button70.Location = new System.Drawing.Point(21, 234);
			this.button70.Name = "button70";
			this.button70.Size = new System.Drawing.Size(118, 23);
			this.button70.TabIndex = 46;
			this.button70.Text = "FTP client";
			this.button70.UseVisualStyleBackColor = true;
			// 
			// button71
			// 
			this.button71.Location = new System.Drawing.Point(21, 205);
			this.button71.Name = "button71";
			this.button71.Size = new System.Drawing.Size(118, 23);
			this.button71.TabIndex = 44;
			this.button71.Text = "Listner";
			this.button71.UseVisualStyleBackColor = true;
			// 
			// button72
			// 
			this.button72.Location = new System.Drawing.Point(21, 176);
			this.button72.Name = "button72";
			this.button72.Size = new System.Drawing.Size(118, 23);
			this.button72.TabIndex = 43;
			this.button72.Text = "Browse SMB Shares";
			this.button72.UseVisualStyleBackColor = true;
			// 
			// button73
			// 
			this.button73.Location = new System.Drawing.Point(21, 147);
			this.button73.Name = "button73";
			this.button73.Size = new System.Drawing.Size(118, 23);
			this.button73.TabIndex = 42;
			this.button73.Text = "Win SCP";
			this.button73.UseVisualStyleBackColor = true;
			// 
			// button74
			// 
			this.button74.Location = new System.Drawing.Point(21, 118);
			this.button74.Margin = new System.Windows.Forms.Padding(2);
			this.button74.Name = "button74";
			this.button74.Size = new System.Drawing.Size(118, 24);
			this.button74.TabIndex = 30;
			this.button74.Text = "Remote Desktop";
			this.button74.UseVisualStyleBackColor = true;
			// 
			// button75
			// 
			this.button75.Location = new System.Drawing.Point(21, 89);
			this.button75.Margin = new System.Windows.Forms.Padding(2);
			this.button75.Name = "button75";
			this.button75.Size = new System.Drawing.Size(118, 24);
			this.button75.TabIndex = 34;
			this.button75.Text = "Telnet";
			this.button75.UseVisualStyleBackColor = true;
			// 
			// button76
			// 
			this.button76.Location = new System.Drawing.Point(21, 60);
			this.button76.Margin = new System.Windows.Forms.Padding(2);
			this.button76.Name = "button76";
			this.button76.Size = new System.Drawing.Size(118, 24);
			this.button76.TabIndex = 41;
			this.button76.Text = "Putty";
			this.button76.UseVisualStyleBackColor = true;
			// 
			// button77
			// 
			this.button77.Location = new System.Drawing.Point(21, 31);
			this.button77.Margin = new System.Windows.Forms.Padding(2);
			this.button77.Name = "button77";
			this.button77.Size = new System.Drawing.Size(118, 24);
			this.button77.TabIndex = 31;
			this.button77.Text = "VNC viewer";
			this.button77.UseVisualStyleBackColor = true;
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.button78);
			this.groupBox18.Controls.Add(this.button79);
			this.groupBox18.Controls.Add(this.button80);
			this.groupBox18.Controls.Add(this.button81);
			this.groupBox18.Controls.Add(this.button82);
			this.groupBox18.Controls.Add(this.button83);
			this.groupBox18.Controls.Add(this.button84);
			this.groupBox18.Location = new System.Drawing.Point(287, 40);
			this.groupBox18.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox18.Size = new System.Drawing.Size(158, 230);
			this.groupBox18.TabIndex = 42;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Pages";
			// 
			// button78
			// 
			this.button78.Location = new System.Drawing.Point(17, 193);
			this.button78.Name = "button78";
			this.button78.Size = new System.Drawing.Size(118, 23);
			this.button78.TabIndex = 45;
			this.button78.Text = "FTP(Default)";
			this.button78.UseVisualStyleBackColor = true;
			// 
			// button79
			// 
			this.button79.Location = new System.Drawing.Point(17, 164);
			this.button79.Margin = new System.Windows.Forms.Padding(2);
			this.button79.Name = "button79";
			this.button79.Size = new System.Drawing.Size(118, 24);
			this.button79.TabIndex = 14;
			this.button79.Text = "Info Center";
			this.button79.UseVisualStyleBackColor = true;
			// 
			// button80
			// 
			this.button80.Location = new System.Drawing.Point(17, 136);
			this.button80.Margin = new System.Windows.Forms.Padding(2);
			this.button80.Name = "button80";
			this.button80.Size = new System.Drawing.Size(118, 24);
			this.button80.TabIndex = 13;
			this.button80.Text = "Coremetrics";
			this.button80.UseVisualStyleBackColor = true;
			// 
			// button81
			// 
			this.button81.Location = new System.Drawing.Point(17, 108);
			this.button81.Margin = new System.Windows.Forms.Padding(2);
			this.button81.Name = "button81";
			this.button81.Size = new System.Drawing.Size(118, 24);
			this.button81.TabIndex = 12;
			this.button81.Text = "DB Info";
			this.button81.UseVisualStyleBackColor = true;
			// 
			// button82
			// 
			this.button82.Location = new System.Drawing.Point(17, 79);
			this.button82.Margin = new System.Windows.Forms.Padding(2);
			this.button82.Name = "button82";
			this.button82.Size = new System.Drawing.Size(118, 24);
			this.button82.TabIndex = 11;
			this.button82.Text = "DB Query";
			this.button82.UseVisualStyleBackColor = true;
			// 
			// button83
			// 
			this.button83.Location = new System.Drawing.Point(17, 23);
			this.button83.Margin = new System.Windows.Forms.Padding(2);
			this.button83.Name = "button83";
			this.button83.Size = new System.Drawing.Size(118, 24);
			this.button83.TabIndex = 4;
			this.button83.Text = "Lob Tools";
			this.button83.UseVisualStyleBackColor = true;
			// 
			// button84
			// 
			this.button84.Location = new System.Drawing.Point(17, 51);
			this.button84.Margin = new System.Windows.Forms.Padding(2);
			this.button84.Name = "button84";
			this.button84.Size = new System.Drawing.Size(118, 24);
			this.button84.TabIndex = 10;
			this.button84.Text = "Artec";
			this.button84.UseVisualStyleBackColor = true;
			// 
			// groupBox19
			// 
			this.groupBox19.Controls.Add(this.radioButton7);
			this.groupBox19.Controls.Add(this.radioButton8);
			this.groupBox19.Controls.Add(this.radioButton9);
			this.groupBox19.Location = new System.Drawing.Point(452, 42);
			this.groupBox19.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox19.Size = new System.Drawing.Size(166, 141);
			this.groupBox19.TabIndex = 40;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Select Browser";
			// 
			// radioButton7
			// 
			this.radioButton7.Location = new System.Drawing.Point(4, 32);
			this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(143, 20);
			this.radioButton7.TabIndex = 40;
			this.radioButton7.Text = "Open in Default (use IE)";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.Location = new System.Drawing.Point(4, 57);
			this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(95, 20);
			this.radioButton8.TabIndex = 39;
			this.radioButton8.Text = "Open in Firefox";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.Location = new System.Drawing.Point(4, 81);
			this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(152, 20);
			this.radioButton9.TabIndex = 33;
			this.radioButton9.Text = "Open in TesterBuddy";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(10, 275);
			this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(33, 22);
			this.label50.TabIndex = 38;
			this.label50.Text = "URL";
			// 
			// button85
			// 
			this.button85.Location = new System.Drawing.Point(206, 274);
			this.button85.Margin = new System.Windows.Forms.Padding(2);
			this.button85.Name = "button85";
			this.button85.Size = new System.Drawing.Size(35, 23);
			this.button85.TabIndex = 37;
			this.button85.Text = "GO";
			this.button85.UseVisualStyleBackColor = true;
			// 
			// textBox35
			// 
			this.textBox35.Location = new System.Drawing.Point(48, 275);
			this.textBox35.Margin = new System.Windows.Forms.Padding(2);
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(152, 20);
			this.textBox35.TabIndex = 36;
			this.textBox35.Text = "www.w3.ibm.com";
			// 
			// label51
			// 
			this.label51.Location = new System.Drawing.Point(178, 14);
			this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(63, 21);
			this.label51.TabIndex = 29;
			this.label51.Text = "Catalog ID:";
			// 
			// textBox36
			// 
			this.textBox36.Location = new System.Drawing.Point(246, 12);
			this.textBox36.Margin = new System.Windows.Forms.Padding(2);
			this.textBox36.Name = "textBox36";
			this.textBox36.Size = new System.Drawing.Size(84, 20);
			this.textBox36.TabIndex = 28;
			this.textBox36.Text = "<na>";
			// 
			// label52
			// 
			this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label52.Location = new System.Drawing.Point(4, 487);
			this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(351, 25);
			this.label52.TabIndex = 27;
			this.label52.Text = "Note: Host name is taken from Add Host tab.";
			// 
			// button86
			// 
			this.button86.Location = new System.Drawing.Point(338, 8);
			this.button86.Margin = new System.Windows.Forms.Padding(2);
			this.button86.Name = "button86";
			this.button86.Size = new System.Drawing.Size(118, 24);
			this.button86.TabIndex = 2;
			this.button86.Text = "Launch Store";
			this.button86.UseVisualStyleBackColor = true;
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(30, 17);
			this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(56, 21);
			this.label53.TabIndex = 1;
			this.label53.Text = "Store ID:";
			// 
			// textBox37
			// 
			this.textBox37.Location = new System.Drawing.Point(90, 15);
			this.textBox37.Margin = new System.Windows.Forms.Padding(2);
			this.textBox37.Name = "textBox37";
			this.textBox37.Size = new System.Drawing.Size(84, 20);
			this.textBox37.TabIndex = 0;
			this.textBox37.Text = "555";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 765);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Tester Buddy Sterling";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.etchostEditGroup.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.YantraVersionGroupBox.ResumeLayout(false);
			this.AppServerGroupBox.ResumeLayout(false);
			this.LocalCommandGroupBox.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.MachineCheckGroupBox.ResumeLayout(false);
			this.MachineCheckGroupBox.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.OtherPagesGroupBox.ResumeLayout(false);
			this.MachineTypeGroupBox.ResumeLayout(false);
			this.Remote_OS_GroupBox.ResumeLayout(false);
			this.groupBox21.ResumeLayout(false);
			this.groupBox20.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.LogsTAB.ResumeLayout(false);
			this.ProcessTextTab.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.WebPosterTab.ResumeLayout(false);
			this.SContainerHttpPost.Panel1.ResumeLayout(false);
			this.SContainerHttpPost.Panel1.PerformLayout();
			this.SContainerHttpPost.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SContainerHttpPost)).EndInit();
			this.SContainerHttpPost.ResumeLayout(false);
			this.APIRunnerTab.ResumeLayout(false);
			this.APIRunnerTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.API_RunnerThreadCountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APIRunner_IncrementCounter_N)).EndInit();
			this.ArchivingToolsTab.ResumeLayout(false);
			this.ExtractGroupBox.ResumeLayout(false);
			this.ExtractGroupBox.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox15.PerformLayout();
			this.groupBox16.ResumeLayout(false);
			this.groupBox16.PerformLayout();
			this.groupBox17.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button ExtractArchiveResetButton;
		private System.Windows.Forms.Button ExtractArchiveDeleteRemoveTermButton;
		private System.Windows.Forms.Button ExtractArchiveDeleteExcludedFileButton;
		private System.Windows.Forms.TextBox ExtractArchiveAddExcludedFileTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox ExtractArchiveExcludedFilesComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ExtractArchiveAddExcludedFileButton;
		private System.Windows.Forms.Button APIRunner_ClearResultsButton;
		private System.Windows.Forms.Button APIRunner_APIResetButton;
		private System.Windows.Forms.Button APIRunner_SaveAPIButton;
		private System.Windows.Forms.NumericUpDown API_RunnerThreadCountNumericUpDown;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox APIRunner_RepeatCountersCheckBox;
		private System.Windows.Forms.TreeView APIRunner_ResultsTreeView;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage STAFFS;
		private System.Windows.Forms.Button MachineCheckSTAFButton;
		private System.Windows.Forms.ProgressBar APIRunner_ProgressBar;
		private System.Windows.Forms.CheckBox APIRunner_IncrementCountersCheckBox;
		private System.Windows.Forms.NumericUpDown APIRunner_IncrementCounter_N;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.TextBox APIRunner_IncrementCriteriaTextBox;
		private System.Windows.Forms.Label label66;
		private System.Windows.Forms.CheckBox APIRunner_IsCounterTemplate;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.ComboBox APIRunner_APINamesComboBox;
		private System.Windows.Forms.Button APIRunner_RunAPIButton;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.TextBox APIRunner_UserNameTextBox;
		private System.Windows.Forms.TextBox APIRunner_PasswordTextbox;
		private System.Windows.Forms.TextBox APIRunner_APIXMLTextBox;
		private System.Windows.Forms.TextBox APIRunner_APITemplateTextBox;
		private System.Windows.Forms.Button HTTPPost_PasteParamDataButton;
		private System.Windows.Forms.Button LaunchSFSButton;
		private System.Windows.Forms.ComboBox otherBrowsersComboBox;
		private System.Windows.Forms.RadioButton otherBrowserRadioButton;
		private System.Windows.Forms.TextBox ExtractArchiveAddRemoveTermTextBox;
		private System.Windows.Forms.ComboBox ExtractArchiveRemoveTermsComboBox;
		private System.Windows.Forms.Button ExtractArchiveAddRemoveTermButton;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox ExtractArchiveMaxNestingTextBox;
		private System.Windows.Forms.Label MaxNestingLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ZipToolPathTextBox;
		private System.Windows.Forms.CheckBox RecursivelyExtractArchiveCheckBox;
		private System.Windows.Forms.Button BrowseArchiveFileButton;
		private System.Windows.Forms.Button ArchiveExtractButton;
		private System.Windows.Forms.TextBox ExtractArchivePathTextBox;
		private System.Windows.Forms.Label ExtractArchivePathLabel;
		private System.Windows.Forms.GroupBox ExtractGroupBox;
		private System.Windows.Forms.TabPage ArchivingToolsTab;
		private System.Windows.Forms.RadioButton YantraVersion9Type;
		private System.Windows.Forms.RadioButton YantraVersion8andLess;
		private System.Windows.Forms.GroupBox YantraVersionGroupBox;
		private System.Windows.Forms.TextBox CommentsTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox UserCredentialsComboBox;
		private System.Windows.Forms.RadioButton WC_openinTBRB;
		private System.Windows.Forms.RadioButton WC_openinFFRB;
		private System.Windows.Forms.RadioButton WC_openinIERB;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button WCLinks_CMCButton;
		private System.Windows.Forms.GroupBox groupBox21;
		private System.Windows.Forms.Button WCLink_AcceleratorButton;
		private System.Windows.Forms.GroupBox groupBox20;
		private System.Windows.Forms.Button ProcessText_IncrementCountersButton;
		private System.Windows.Forms.Button OpenConfigXMLButton;
		private System.Windows.Forms.TabPage APIRunnerTab;
		private System.Windows.Forms.Button HTTPPost_DeleteParamButton;
		private System.Windows.Forms.Button HTTPPost_ClearParamButton;
		private System.Windows.Forms.Button HTTPPostRunButton;
		private System.Windows.Forms.TextBox HTTPPostURLTextBox;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.WebBrowser HTTPPostResultBrowser;
		private System.Windows.Forms.Button HTTPPostAddParamToListButton;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.TextBox HTTPPostParameterTextBox;
		private System.Windows.Forms.TextBox HTTPPostValueTextBox;
		private System.Windows.Forms.ListBox HTTPPostParamListBox;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.SplitContainer SContainerHttpPost;
		private System.Windows.Forms.TabPage WebPosterTab;
		private System.Windows.Forms.Button LoadConfigButton;
		private System.Windows.Forms.Button SaveConfigAsButton;
		private System.Windows.Forms.ComboBox AppServer_Port_ComboBox;
		private System.Windows.Forms.Button IncrementValuesButton;
		private System.Windows.Forms.Button AppServerConsoleButton;
		private System.Windows.Forms.GroupBox AppServerGroupBox;
		private System.Windows.Forms.RadioButton JBossCheckBox;
		private System.Windows.Forms.RadioButton WebLogicCheckBox;
		private System.Windows.Forms.RadioButton WebSphereCheckBox;
		private System.Windows.Forms.CheckBox HostSpecificSettingsCheckBox;
		private System.Windows.Forms.Button RemoveNullParamXMLButton;
		private System.Windows.Forms.Button SaveConfigurationButton;
		private System.Windows.Forms.Button AdditionalHostAddButton;
		private System.Windows.Forms.CheckBox SEOTypeUrlCheckBox;
		private System.Windows.Forms.Button DeleteHostButton;
		private System.Windows.Forms.Button FixLocalHostButton;
		private System.Windows.Forms.Button AutoHostAddButton;
		private System.Windows.Forms.Button FixHostsButton;
		private System.Windows.Forms.Button SortHostsButton;
		private System.Windows.Forms.CheckBox AutoCredential_CheckBox;
		private System.Windows.Forms.Button ValidateConfigButton;
		private System.Windows.Forms.Button RefreshConfigButton;
		private System.Windows.Forms.ComboBox StoreName_ComboBox;
		private System.Windows.Forms.ComboBox CatalogIDComboBox;
		private System.Windows.Forms.ComboBox WC_StoreID_ComboBox;
		private System.Windows.Forms.CheckBox HostSpecificCheckBox;
		private System.Windows.Forms.TextBox HostNameTextBox;
		private System.Windows.Forms.Button CopyScreenshotButton;
		private System.Windows.Forms.Button PasteScreenshotButton;
		private System.Windows.Forms.Button UrlGoButton;
		private System.Windows.Forms.TextBox Default_URL_TextBox;
		private System.Windows.Forms.TextBox WC_InstanceName_texBox;
		private System.Windows.Forms.TextBox Putty_Path_textbox;
		private System.Windows.Forms.TextBox VNC__Path_textbox;
		private System.Windows.Forms.TextBox WinSCP_Path_textbox;
		private System.Windows.Forms.TextBox FireFoxPathTextBox;
		private System.Windows.Forms.Button ProcessText_ToJavaStringButton;
		private System.Windows.Forms.Label HostPasswordLabel;
		private System.Windows.Forms.TextBox HostPasswordTextBox;
		private System.Windows.Forms.Label HostUserNameLabel;
		private System.Windows.Forms.TextBox HostUserNameTextBox;
		private System.Windows.Forms.Button SMB_Button;
		private System.Windows.Forms.Button WinSCP_Button;
		private System.Windows.Forms.Button RemoteDesktop_button;
		private System.Windows.Forms.Button Telnet_button;
		private System.Windows.Forms.Button Putty_button;
		private System.Windows.Forms.Button VNC_button;
		private System.Windows.Forms.Button ProcessText_RemoveLeadingWhiteSpaces;
		private System.Windows.Forms.GroupBox LocalCommandGroupBox;
		private System.Windows.Forms.GroupBox OtherPagesGroupBox;
		private System.Windows.Forms.Button AddSuffixButton;
		private System.Windows.Forms.ComboBox HostNameComboBox;
		private System.Windows.Forms.Button PasteHostDetailsButton;
		private System.Windows.Forms.RadioButton Remote_OS_Windows;
		private System.Windows.Forms.RadioButton Remote_OS_XLinux;
		private System.Windows.Forms.RadioButton Remote_OS_AIX;
		private System.Windows.Forms.GroupBox Remote_OS_GroupBox;
		private System.Windows.Forms.TextBox StafpathTextBox;
		private System.Windows.Forms.Label StafPathLabel;
		private System.Windows.Forms.Label HostName2Label;
		private System.Windows.Forms.TextBox HostName2TextBox;
		private System.Windows.Forms.Button IPConfigButton;
		private System.Windows.Forms.Button StartJmeterButton;
		private System.Windows.Forms.Label JMeter;
		private System.Windows.Forms.TextBox JMeterPathTextBox;
		private System.Windows.Forms.Button CacheMonitorButton;
		private System.Windows.Forms.Button GetParamFromURLButton;
		private System.Windows.Forms.TextBox IEPathTextBox;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Button EditScreenShotButton;
		private System.Windows.Forms.Timer TeamSessionTimer;
		private System.Windows.Forms.Button OpenScreenshotButton;
		private System.Windows.Forms.Timer AutoTimeIncrementTimer;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Button button86;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.Button button85;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.Button button84;
		private System.Windows.Forms.Button button83;
		private System.Windows.Forms.Button button82;
		private System.Windows.Forms.Button button81;
		private System.Windows.Forms.Button button80;
		private System.Windows.Forms.Button button79;
		private System.Windows.Forms.Button button78;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Button button77;
		private System.Windows.Forms.Button button76;
		private System.Windows.Forms.Button button75;
		private System.Windows.Forms.Button button74;
		private System.Windows.Forms.Button button73;
		private System.Windows.Forms.Button button72;
		private System.Windows.Forms.Button button71;
		private System.Windows.Forms.Button button70;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.Button button69;
		private System.Windows.Forms.Button button68;
		private System.Windows.Forms.Button button67;
		private System.Windows.Forms.Button button66;
		private System.Windows.Forms.Button button65;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.Button button64;
		private System.Windows.Forms.Button button63;
		private System.Windows.Forms.Button button62;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.Button button61;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Button button60;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Button button59;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.Button button58;
		private System.Windows.Forms.Button button57;
		private System.Windows.Forms.Button button56;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.RadioButton RunTimeRadioButton;
		private System.Windows.Forms.RadioButton ToolkitRadioButton;
		private System.Windows.Forms.GroupBox MachineTypeGroupBox;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.GroupBox etchostEditGroup;
		private System.Windows.Forms.Button PasteIPButton;
		private System.Windows.Forms.Button CopyDetailsButton;
		private System.Windows.Forms.Button CopyIPButton;
		private System.Windows.Forms.TextBox CommandPathTextBox;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Button LaunchStoreByName;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button AddPrefixButton;
		private System.Windows.Forms.Button OpenTodayLogButton;
		private System.Windows.Forms.Button OpenHostFile;
		private System.Windows.Forms.Button FTPBrowserButton;
		private System.Windows.Forms.Button FTPClientButton;
		private System.Windows.Forms.Button InfoCenterVisitButton;
		private System.Windows.Forms.Button HttpCheckButton;
		private System.Windows.Forms.Button HttpsCheckButton;
		private System.Windows.Forms.TextBox HttpsCheckPortTextBox;
		private System.Windows.Forms.TextBox HttpCheckPortTextBox;
		private System.Windows.Forms.GroupBox MachineCheckGroupBox;
		private System.Windows.Forms.TextBox ScreenShotPrefixTextBox;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Button WorkspaceAdminConsoleLinkButton;
		private System.Windows.Forms.ListBox LogFiles;
		private System.Windows.Forms.ListBox LogFolders;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button OneWordPerLineButton;
		private System.Windows.Forms.RichTextBox ProcessTextRTB2;
		private System.Windows.Forms.RichTextBox ProcessTextRTB1;
		private System.Windows.Forms.Button ToOneLineButton;
		private System.Windows.Forms.TabPage ProcessTextTab;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label LogsPathLabel;
		private System.Windows.Forms.TextBox LogsPathTextBox;
		private System.Windows.Forms.TabPage LogsTAB;
		private System.Windows.Forms.Button NewTextLogButton;
		private System.Windows.Forms.Button CopyLogPathButton;
		private System.Windows.Forms.Button RefreshLogsButton;
		private System.Windows.Forms.Button RefreshHostButton;
		private System.Windows.Forms.Button ScreenShotSaveButton;
		private System.Windows.Forms.TextBox ScreenShotDirectory;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox ScreenShot_Length;
		private System.Windows.Forms.TextBox ScreenShot_Width;
		private System.Windows.Forms.TextBox ScreenShot_y1;
		private System.Windows.Forms.TextBox ScreenShot_x1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TreeView ClipRingTreeView;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addHostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button FormatXMLButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label ProcessTextFixLabel;
        private System.Windows.Forms.TextBox ProcessTextFixTextBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
