<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ClockStyleData1 As DevComponents.DotNetBar.Controls.ClockStyleData = New DevComponents.DotNetBar.Controls.ClockStyleData()
        Dim ColorData1 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData2 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData3 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData1 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData4 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData5 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData2 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData6 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData3 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData7 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData8 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Me.Bush_exe_Type = New System.Windows.Forms.ComboBox()
        Me.Bush_Mons_Type = New System.Windows.Forms.ComboBox()
        Me.Bush_Champ_Type = New System.Windows.Forms.ComboBox()
        Me.Bush_Rimmington_Type = New System.Windows.Forms.ComboBox()
        Me.Phas_flower = New System.Windows.Forms.ComboBox()
        Me.Phas_herb = New System.Windows.Forms.ComboBox()
        Me.Phas_alotment = New System.Windows.Forms.ComboBox()
        Me.Ardy_flower = New System.Windows.Forms.ComboBox()
        Me.Ardy_herb = New System.Windows.Forms.ComboBox()
        Me.Ardy_alotment = New System.Windows.Forms.ComboBox()
        Me.catherby_flower = New System.Windows.Forms.ComboBox()
        Me.catherby_herb = New System.Windows.Forms.ComboBox()
        Me.catherby_alotment = New System.Windows.Forms.ComboBox()
        Me.Falador_Flower = New System.Windows.Forms.ComboBox()
        Me.Falador_Herb = New System.Windows.Forms.ComboBox()
        Me.Falador_Alotment = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Phas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Phas_flower_time = New Runescapeclock.rune_label()
        Me.Label54 = New Runescapeclock.rune_label()
        Me.Label53 = New Runescapeclock.rune_label()
        Me.Phas_herb_time = New Runescapeclock.rune_label()
        Me.Label52 = New Runescapeclock.rune_label()
        Me.Phas_alotment_plant = New Runescapeclock.rune_button()
        Me.Label48 = New Runescapeclock.rune_label()
        Me.Phas_herb_plant = New Runescapeclock.rune_button()
        Me.Label49 = New Runescapeclock.rune_label()
        Me.Phas_flower_plant = New Runescapeclock.rune_button()
        Me.Phas_alotment_time = New Runescapeclock.rune_label()
        Me.Phas_flower_cancel = New Runescapeclock.rune_button()
        Me.Label51 = New Runescapeclock.rune_label()
        Me.Phas_herb_cancel = New Runescapeclock.rune_button()
        Me.Phas_alotment_cancel = New Runescapeclock.rune_button()
        Me.Falador = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label1 = New Runescapeclock.rune_label()
        Me.Falador_Flower_Time = New Runescapeclock.rune_label()
        Me.Falador_Alotment_Time = New Runescapeclock.rune_label()
        Me.Falador_Herb_Time = New Runescapeclock.rune_label()
        Me.Falador_Alotment_Plant = New Runescapeclock.rune_button()
        Me.Label7 = New Runescapeclock.rune_label()
        Me.Falador_Alotment_Cancel = New Runescapeclock.rune_button()
        Me.Label6 = New Runescapeclock.rune_label()
        Me.Falador_Herb_Cancel = New Runescapeclock.rune_button()
        Me.Label4 = New Runescapeclock.rune_label()
        Me.Falador_Flower_Cancel = New Runescapeclock.rune_button()
        Me.Label2 = New Runescapeclock.rune_label()
        Me.Falador_Flower_Plant = New Runescapeclock.rune_button()
        Me.Label3 = New Runescapeclock.rune_label()
        Me.Falador_Herb_Plant = New Runescapeclock.rune_button()
        Me.Catherby = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Catherby_flower_time = New Runescapeclock.rune_label()
        Me.Label39 = New Runescapeclock.rune_label()
        Me.Label38 = New Runescapeclock.rune_label()
        Me.Catherby_herb_time = New Runescapeclock.rune_label()
        Me.Label37 = New Runescapeclock.rune_label()
        Me.Catherby_alotment_plant = New Runescapeclock.rune_button()
        Me.Label33 = New Runescapeclock.rune_label()
        Me.Catherby_herb_plant = New Runescapeclock.rune_button()
        Me.Label34 = New Runescapeclock.rune_label()
        Me.Catherby_flower_plant = New Runescapeclock.rune_button()
        Me.Catherby_alotment_time = New Runescapeclock.rune_label()
        Me.Catherby_flower_cancel = New Runescapeclock.rune_button()
        Me.Label36 = New Runescapeclock.rune_label()
        Me.Catherby_herb_cancel = New Runescapeclock.rune_button()
        Me.Catherby_alotment_cancel = New Runescapeclock.rune_button()
        Me.Ardy = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Ardy_flower_time = New Runescapeclock.rune_label()
        Me.Label45 = New Runescapeclock.rune_label()
        Me.Label44 = New Runescapeclock.rune_label()
        Me.Ardy_herb_time = New Runescapeclock.rune_label()
        Me.Label43 = New Runescapeclock.rune_label()
        Me.Ardy_Alotment_plant = New Runescapeclock.rune_button()
        Me.Label35 = New Runescapeclock.rune_label()
        Me.Ardy_herb_plant = New Runescapeclock.rune_button()
        Me.Label40 = New Runescapeclock.rune_label()
        Me.Ardy_flower_plant = New Runescapeclock.rune_button()
        Me.Ardy_Alotment_time = New Runescapeclock.rune_label()
        Me.Ardy_flower_cancel = New Runescapeclock.rune_button()
        Me.Label42 = New Runescapeclock.rune_label()
        Me.Ardy_herb_cancel = New Runescapeclock.rune_button()
        Me.Ardy_Alotment_cancel = New Runescapeclock.rune_button()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.Bush = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label85 = New Runescapeclock.rune_label()
        Me.Button7 = New Runescapeclock.rune_button()
        Me.Button8 = New Runescapeclock.rune_button()
        Me.Label86 = New Runescapeclock.rune_label()
        Me.Label83 = New Runescapeclock.rune_label()
        Me.Button5 = New Runescapeclock.rune_button()
        Me.Button6 = New Runescapeclock.rune_button()
        Me.Label84 = New Runescapeclock.rune_label()
        Me.Label81 = New Runescapeclock.rune_label()
        Me.Button3 = New Runescapeclock.rune_button()
        Me.Button4 = New Runescapeclock.rune_button()
        Me.Label82 = New Runescapeclock.rune_label()
        Me.Label79 = New Runescapeclock.rune_label()
        Me.Label17 = New Runescapeclock.rune_label()
        Me.Button1 = New Runescapeclock.rune_button()
        Me.Button2 = New Runescapeclock.rune_button()
        Me.Label5 = New Runescapeclock.rune_label()
        Me.Label19 = New Runescapeclock.rune_label()
        Me.Label80 = New Runescapeclock.rune_label()
        Me.Label18 = New Runescapeclock.rune_label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Fruit_Gnomestong = New System.Windows.Forms.ComboBox()
        Me.Fruit_Gnomemaze = New System.Windows.Forms.ComboBox()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Button60 = New Runescapeclock.rune_button()
        Me.Button59 = New Runescapeclock.rune_button()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Soundswitch = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.AnalogClockControl1 = New DevComponents.DotNetBar.Controls.AnalogClockControl()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.stylecont = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Black = New DevComponents.Editors.ComboItem()
        Me.Blue = New DevComponents.Editors.ComboItem()
        Me.Silver = New DevComponents.Editors.ComboItem()
        Me.Glass = New DevComponents.Editors.ComboItem()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuperTabItem7 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Label69 = New Runescapeclock.rune_label()
        Me.Label65 = New Runescapeclock.rune_label()
        Me.SuperTabItem6 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Label145 = New Runescapeclock.rune_label()
        Me.Label68 = New Runescapeclock.rune_label()
        Me.Label15 = New Runescapeclock.rune_label()
        Me.Label64 = New Runescapeclock.rune_label()
        Me.Label63 = New Runescapeclock.rune_label()
        Me.Label62 = New Runescapeclock.rune_label()
        Me.Label61 = New Runescapeclock.rune_label()
        Me.Label60 = New Runescapeclock.rune_label()
        Me.Label59 = New Runescapeclock.rune_label()
        Me.Label58 = New Runescapeclock.rune_label()
        Me.Label57 = New Runescapeclock.rune_label()
        Me.Label56 = New Runescapeclock.rune_label()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel7 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Label78 = New Runescapeclock.rune_label()
        Me.Label77 = New Runescapeclock.rune_label()
        Me.Label76 = New Runescapeclock.rune_label()
        Me.Label75 = New Runescapeclock.rune_label()
        Me.Label74 = New Runescapeclock.rune_label()
        Me.Label73 = New Runescapeclock.rune_label()
        Me.Label72 = New Runescapeclock.rune_label()
        Me.Label71 = New Runescapeclock.rune_label()
        Me.Shops = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label143 = New Runescapeclock.rune_label()
        Me.Label144 = New Runescapeclock.rune_label()
        Me.Button58 = New Runescapeclock.rune_button()
        Me.Label141 = New Runescapeclock.rune_label()
        Me.Label142 = New Runescapeclock.rune_label()
        Me.Button57 = New Runescapeclock.rune_button()
        Me.Label139 = New Runescapeclock.rune_label()
        Me.Label140 = New Runescapeclock.rune_label()
        Me.Button56 = New Runescapeclock.rune_button()
        Me.Label137 = New Runescapeclock.rune_label()
        Me.Label138 = New Runescapeclock.rune_label()
        Me.Button55 = New Runescapeclock.rune_button()
        Me.Label135 = New Runescapeclock.rune_label()
        Me.Label136 = New Runescapeclock.rune_label()
        Me.Button54 = New Runescapeclock.rune_button()
        Me.Label133 = New Runescapeclock.rune_label()
        Me.Label134 = New Runescapeclock.rune_label()
        Me.Button53 = New Runescapeclock.rune_button()
        Me.Label131 = New Runescapeclock.rune_label()
        Me.Label132 = New Runescapeclock.rune_label()
        Me.Button52 = New Runescapeclock.rune_button()
        Me.Label129 = New Runescapeclock.rune_label()
        Me.Label130 = New Runescapeclock.rune_label()
        Me.Button51 = New Runescapeclock.rune_button()
        Me.Label70 = New Runescapeclock.rune_label()
        Me.Label67 = New Runescapeclock.rune_label()
        Me.Label66 = New Runescapeclock.rune_label()
        Me.Label50 = New Runescapeclock.rune_label()
        Me.Label16 = New Runescapeclock.rune_label()
        Me.Label10 = New Runescapeclock.rune_label()
        Me.Label12 = New Runescapeclock.rune_label()
        Me.Label11 = New Runescapeclock.rune_label()
        Me.wood = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label107 = New Runescapeclock.rune_label()
        Me.Wood_tree = New System.Windows.Forms.ComboBox()
        Me.Button29 = New Runescapeclock.rune_button()
        Me.Wood_Taverley = New System.Windows.Forms.ComboBox()
        Me.Button30 = New Runescapeclock.rune_button()
        Me.Wood_Falador = New System.Windows.Forms.ComboBox()
        Me.Label108 = New Runescapeclock.rune_label()
        Me.Wood_Varrock = New System.Windows.Forms.ComboBox()
        Me.Label109 = New Runescapeclock.rune_label()
        Me.Label31 = New Runescapeclock.rune_label()
        Me.Button31 = New Runescapeclock.rune_button()
        Me.Wood_lumbridge = New System.Windows.Forms.ComboBox()
        Me.Button32 = New Runescapeclock.rune_button()
        Me.Label32 = New Runescapeclock.rune_label()
        Me.Label110 = New Runescapeclock.rune_label()
        Me.Label47 = New Runescapeclock.rune_label()
        Me.Label111 = New Runescapeclock.rune_label()
        Me.Label41 = New Runescapeclock.rune_label()
        Me.Button33 = New Runescapeclock.rune_button()
        Me.Label46 = New Runescapeclock.rune_label()
        Me.Button34 = New Runescapeclock.rune_button()
        Me.Button37 = New Runescapeclock.rune_button()
        Me.Label112 = New Runescapeclock.rune_label()
        Me.Label116 = New Runescapeclock.rune_label()
        Me.Label113 = New Runescapeclock.rune_label()
        Me.Button38 = New Runescapeclock.rune_button()
        Me.Button35 = New Runescapeclock.rune_button()
        Me.Label115 = New Runescapeclock.rune_label()
        Me.Button36 = New Runescapeclock.rune_button()
        Me.Label114 = New Runescapeclock.rune_label()
        Me.fruit = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label103 = New Runescapeclock.rune_label()
        Me.Button25 = New Runescapeclock.rune_button()
        Me.Button26 = New Runescapeclock.rune_button()
        Me.Label104 = New Runescapeclock.rune_label()
        Me.Label105 = New Runescapeclock.rune_label()
        Me.Button27 = New Runescapeclock.rune_button()
        Me.Button28 = New Runescapeclock.rune_button()
        Me.Label106 = New Runescapeclock.rune_label()
        Me.Label95 = New Runescapeclock.rune_label()
        Me.Button17 = New Runescapeclock.rune_button()
        Me.Button18 = New Runescapeclock.rune_button()
        Me.Label96 = New Runescapeclock.rune_label()
        Me.Label97 = New Runescapeclock.rune_label()
        Me.Button19 = New Runescapeclock.rune_button()
        Me.Button20 = New Runescapeclock.rune_button()
        Me.Label98 = New Runescapeclock.rune_label()
        Me.Label99 = New Runescapeclock.rune_label()
        Me.Button21 = New Runescapeclock.rune_button()
        Me.Button22 = New Runescapeclock.rune_button()
        Me.Label100 = New Runescapeclock.rune_label()
        Me.Label101 = New Runescapeclock.rune_label()
        Me.Button23 = New Runescapeclock.rune_button()
        Me.Button24 = New Runescapeclock.rune_button()
        Me.Label102 = New Runescapeclock.rune_label()
        Me.Label28 = New Runescapeclock.rune_label()
        Me.Label26 = New Runescapeclock.rune_label()
        Me.Label29 = New Runescapeclock.rune_label()
        Me.Fruit_herb = New System.Windows.Forms.ComboBox()
        Me.Label30 = New Runescapeclock.rune_label()
        Me.Fruit_lieya = New System.Windows.Forms.ComboBox()
        Me.Fruit_Brimhaven = New System.Windows.Forms.ComboBox()
        Me.Fruit_Catherby = New System.Windows.Forms.ComboBox()
        Me.Label27 = New Runescapeclock.rune_label()
        Me.Label25 = New Runescapeclock.rune_label()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Button49 = New Runescapeclock.rune_button()
        Me.Label55 = New Runescapeclock.rune_label()
        Me.Label127 = New Runescapeclock.rune_label()
        Me.Button50 = New Runescapeclock.rune_button()
        Me.Label128 = New Runescapeclock.rune_label()
        Me.Button47 = New Runescapeclock.rune_button()
        Me.Label125 = New Runescapeclock.rune_label()
        Me.Label14 = New Runescapeclock.rune_label()
        Me.Label20 = New Runescapeclock.rune_label()
        Me.Button48 = New Runescapeclock.rune_button()
        Me.Label126 = New Runescapeclock.rune_label()
        Me.Button45 = New Runescapeclock.rune_button()
        Me.Label8 = New Runescapeclock.rune_label()
        Me.Label123 = New Runescapeclock.rune_label()
        Me.Button46 = New Runescapeclock.rune_button()
        Me.Label124 = New Runescapeclock.rune_label()
        Me.Button43 = New Runescapeclock.rune_button()
        Me.Label121 = New Runescapeclock.rune_label()
        Me.Button44 = New Runescapeclock.rune_button()
        Me.Label122 = New Runescapeclock.rune_label()
        Me.Button41 = New Runescapeclock.rune_button()
        Me.Label119 = New Runescapeclock.rune_label()
        Me.Button42 = New Runescapeclock.rune_button()
        Me.Label120 = New Runescapeclock.rune_label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Button39 = New Runescapeclock.rune_button()
        Me.Label117 = New Runescapeclock.rune_label()
        Me.Button40 = New Runescapeclock.rune_button()
        Me.Label118 = New Runescapeclock.rune_label()
        Me.Label21 = New Runescapeclock.rune_label()
        Me.Label13 = New Runescapeclock.rune_label()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label87 = New Runescapeclock.rune_label()
        Me.Button9 = New Runescapeclock.rune_button()
        Me.Button10 = New Runescapeclock.rune_button()
        Me.Label24 = New Runescapeclock.rune_label()
        Me.Label88 = New Runescapeclock.rune_label()
        Me.Label22 = New Runescapeclock.rune_label()
        Me.Label89 = New Runescapeclock.rune_label()
        Me.Button11 = New Runescapeclock.rune_button()
        Me.Label9 = New Runescapeclock.rune_label()
        Me.Button12 = New Runescapeclock.rune_button()
        Me.Label90 = New Runescapeclock.rune_label()
        Me.Label23 = New Runescapeclock.rune_label()
        Me.Label91 = New Runescapeclock.rune_label()
        Me.Button15 = New Runescapeclock.rune_button()
        Me.Button13 = New Runescapeclock.rune_button()
        Me.Label94 = New Runescapeclock.rune_label()
        Me.Button14 = New Runescapeclock.rune_button()
        Me.Button16 = New Runescapeclock.rune_button()
        Me.Label92 = New Runescapeclock.rune_label()
        Me.Label93 = New Runescapeclock.rune_label()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem8 = New DevComponents.DotNetBar.SuperTabItem()
        Me.Phas.SuspendLayout()
        Me.Falador.SuspendLayout()
        Me.Catherby.SuspendLayout()
        Me.Ardy.SuspendLayout()
        Me.Bush.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.SuperTabControlPanel7.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.wood.SuspendLayout()
        Me.fruit.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuperTabControlPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bush_exe_Type
        '
        Me.Bush_exe_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bush_exe_Type.FormattingEnabled = True
        Me.Bush_exe_Type.Items.AddRange(New Object() {"Redberry", "Cavadaberry", "Dwellberry", "Jangerberry", "Whiteberry", "Poision Ivy"})
        Me.Bush_exe_Type.Location = New System.Drawing.Point(83, 84)
        Me.Bush_exe_Type.Name = "Bush_exe_Type"
        Me.Bush_exe_Type.Size = New System.Drawing.Size(164, 21)
        Me.Bush_exe_Type.TabIndex = 7
        '
        'Bush_Mons_Type
        '
        Me.Bush_Mons_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bush_Mons_Type.FormattingEnabled = True
        Me.Bush_Mons_Type.Items.AddRange(New Object() {"Redberry", "Cavadaberry", "Dwellberry", "Jangerberry", "Whiteberry", "Poision Ivy"})
        Me.Bush_Mons_Type.Location = New System.Drawing.Point(83, 57)
        Me.Bush_Mons_Type.Name = "Bush_Mons_Type"
        Me.Bush_Mons_Type.Size = New System.Drawing.Size(164, 21)
        Me.Bush_Mons_Type.TabIndex = 6
        '
        'Bush_Champ_Type
        '
        Me.Bush_Champ_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bush_Champ_Type.FormattingEnabled = True
        Me.Bush_Champ_Type.Items.AddRange(New Object() {"Redberry", "Cavadaberry", "Dwellberry", "Jangerberry", "Whiteberry", "Poision Ivy"})
        Me.Bush_Champ_Type.Location = New System.Drawing.Point(83, 30)
        Me.Bush_Champ_Type.Name = "Bush_Champ_Type"
        Me.Bush_Champ_Type.Size = New System.Drawing.Size(164, 21)
        Me.Bush_Champ_Type.TabIndex = 5
        '
        'Bush_Rimmington_Type
        '
        Me.Bush_Rimmington_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bush_Rimmington_Type.FormattingEnabled = True
        Me.Bush_Rimmington_Type.Items.AddRange(New Object() {"Redberry", "Cavadaberry", "Dwellberry", "Jangerberry", "Whiteberry", "Poision Ivy"})
        Me.Bush_Rimmington_Type.Location = New System.Drawing.Point(83, 3)
        Me.Bush_Rimmington_Type.Name = "Bush_Rimmington_Type"
        Me.Bush_Rimmington_Type.Size = New System.Drawing.Size(164, 21)
        Me.Bush_Rimmington_Type.TabIndex = 4
        '
        'Phas_flower
        '
        Me.Phas_flower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Phas_flower.FormattingEnabled = True
        Me.Phas_flower.Items.AddRange(New Object() {"Maragold", "Rosemerry", "Nastrium", "Woad", "Limpwort", "White lilly"})
        Me.Phas_flower.Location = New System.Drawing.Point(67, 58)
        Me.Phas_flower.Name = "Phas_flower"
        Me.Phas_flower.Size = New System.Drawing.Size(171, 21)
        Me.Phas_flower.TabIndex = 38
        '
        'Phas_herb
        '
        Me.Phas_herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Phas_herb.FormattingEnabled = True
        Me.Phas_herb.Items.AddRange(New Object() {"Guam", "Marintile", "Tarrowmin", "Haralander", "Gout", "Ranarr", "Spirit weed", "Toadflax", "Irit", "Wergali", "Avantoe", "Kwuarm", "Snapdragon", "Chantidine", "Lantadyme", "Dwarfweed", "Torstole", "Fellstalk"})
        Me.Phas_herb.Location = New System.Drawing.Point(67, 30)
        Me.Phas_herb.Name = "Phas_herb"
        Me.Phas_herb.Size = New System.Drawing.Size(171, 21)
        Me.Phas_herb.TabIndex = 37
        '
        'Phas_alotment
        '
        Me.Phas_alotment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Phas_alotment.FormattingEnabled = True
        Me.Phas_alotment.Items.AddRange(New Object() {"Potato", "Onion", "Cabbage", "Tomato", "Sweetcorn", "Strawberry", "Watermellon"})
        Me.Phas_alotment.Location = New System.Drawing.Point(67, 3)
        Me.Phas_alotment.Name = "Phas_alotment"
        Me.Phas_alotment.Size = New System.Drawing.Size(171, 21)
        Me.Phas_alotment.TabIndex = 36
        '
        'Ardy_flower
        '
        Me.Ardy_flower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ardy_flower.FormattingEnabled = True
        Me.Ardy_flower.Items.AddRange(New Object() {"Maragold", "Rosemerry", "Nastrium", "Woad", "Limpwort", "White lilly"})
        Me.Ardy_flower.Location = New System.Drawing.Point(67, 58)
        Me.Ardy_flower.Name = "Ardy_flower"
        Me.Ardy_flower.Size = New System.Drawing.Size(171, 21)
        Me.Ardy_flower.TabIndex = 35
        '
        'Ardy_herb
        '
        Me.Ardy_herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ardy_herb.FormattingEnabled = True
        Me.Ardy_herb.Items.AddRange(New Object() {"Guam", "Marintile", "Tarrowmin", "Haralander", "Gout", "Ranarr", "Spirit weed", "Toadflax", "Irit", "Wergali", "Avantoe", "Kwuarm", "Snapdragon", "Chantidine", "Lantadyme", "Dwarfweed", "Torstole", "Fellstalk"})
        Me.Ardy_herb.Location = New System.Drawing.Point(67, 30)
        Me.Ardy_herb.Name = "Ardy_herb"
        Me.Ardy_herb.Size = New System.Drawing.Size(171, 21)
        Me.Ardy_herb.TabIndex = 34
        '
        'Ardy_alotment
        '
        Me.Ardy_alotment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ardy_alotment.FormattingEnabled = True
        Me.Ardy_alotment.Items.AddRange(New Object() {"Potato", "Onion", "Cabbage", "Tomato", "Sweetcorn", "Strawberry", "Watermellon"})
        Me.Ardy_alotment.Location = New System.Drawing.Point(67, 3)
        Me.Ardy_alotment.Name = "Ardy_alotment"
        Me.Ardy_alotment.Size = New System.Drawing.Size(171, 21)
        Me.Ardy_alotment.TabIndex = 33
        '
        'catherby_flower
        '
        Me.catherby_flower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.catherby_flower.FormattingEnabled = True
        Me.catherby_flower.Items.AddRange(New Object() {"Maragold", "Rosemerry", "Nastrium", "Woad", "Limpwort", "White lilly"})
        Me.catherby_flower.Location = New System.Drawing.Point(67, 59)
        Me.catherby_flower.Name = "catherby_flower"
        Me.catherby_flower.Size = New System.Drawing.Size(171, 21)
        Me.catherby_flower.TabIndex = 32
        '
        'catherby_herb
        '
        Me.catherby_herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.catherby_herb.FormattingEnabled = True
        Me.catherby_herb.Items.AddRange(New Object() {"Guam", "Marintile", "Tarrowmin", "Haralander", "Gout", "Ranarr", "Spirit weed", "Toadflax", "Irit", "Wergali", "Avantoe", "Kwuarm", "Snapdragon", "Chantidine", "Lantadyme", "Dwarfweed", "Torstole", "Fellstalk"})
        Me.catherby_herb.Location = New System.Drawing.Point(67, 31)
        Me.catherby_herb.Name = "catherby_herb"
        Me.catherby_herb.Size = New System.Drawing.Size(171, 21)
        Me.catherby_herb.TabIndex = 31
        '
        'catherby_alotment
        '
        Me.catherby_alotment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.catherby_alotment.FormattingEnabled = True
        Me.catherby_alotment.Items.AddRange(New Object() {"Potato", "Onion", "Cabbage", "Tomato", "Sweetcorn", "Strawberry", "Watermellon"})
        Me.catherby_alotment.Location = New System.Drawing.Point(67, 4)
        Me.catherby_alotment.Name = "catherby_alotment"
        Me.catherby_alotment.Size = New System.Drawing.Size(171, 21)
        Me.catherby_alotment.TabIndex = 30
        '
        'Falador_Flower
        '
        Me.Falador_Flower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Falador_Flower.FormattingEnabled = True
        Me.Falador_Flower.Items.AddRange(New Object() {"Maragold", "Rosemerry", "Nastrium", "Woad", "Limpwort", "White lilly"})
        Me.Falador_Flower.Location = New System.Drawing.Point(67, 60)
        Me.Falador_Flower.Name = "Falador_Flower"
        Me.Falador_Flower.Size = New System.Drawing.Size(171, 21)
        Me.Falador_Flower.TabIndex = 29
        '
        'Falador_Herb
        '
        Me.Falador_Herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Falador_Herb.FormattingEnabled = True
        Me.Falador_Herb.Items.AddRange(New Object() {"Guam", "Marintile", "Tarrowmin", "Haralander", "Gout", "Ranarr", "Spirit weed", "Toadflax", "Irit", "Wergali", "Avantoe", "Kwuarm", "Snapdragon", "Chantidine", "Lantadyme", "Dwarfweed", "Torstole", "Fellstalk"})
        Me.Falador_Herb.Location = New System.Drawing.Point(67, 32)
        Me.Falador_Herb.Name = "Falador_Herb"
        Me.Falador_Herb.Size = New System.Drawing.Size(171, 21)
        Me.Falador_Herb.TabIndex = 28
        '
        'Falador_Alotment
        '
        Me.Falador_Alotment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Falador_Alotment.FormattingEnabled = True
        Me.Falador_Alotment.Items.AddRange(New Object() {"Potato", "Onion", "Cabbage", "Tomato", "Sweetcorn", "Strawberry", "Watermellon"})
        Me.Falador_Alotment.Location = New System.Drawing.Point(67, 4)
        Me.Falador_Alotment.Name = "Falador_Alotment"
        Me.Falador_Alotment.Size = New System.Drawing.Size(171, 21)
        Me.Falador_Alotment.TabIndex = 27
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'Phas
        '
        Me.Phas.BackColor = System.Drawing.Color.Transparent
        Me.Phas.CanvasColor = System.Drawing.Color.Transparent
        Me.Phas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Phas.Controls.Add(Me.Phas_flower)
        Me.Phas.Controls.Add(Me.Phas_alotment)
        Me.Phas.Controls.Add(Me.Phas_flower_time)
        Me.Phas.Controls.Add(Me.Label54)
        Me.Phas.Controls.Add(Me.Phas_herb)
        Me.Phas.Controls.Add(Me.Label53)
        Me.Phas.Controls.Add(Me.Phas_herb_time)
        Me.Phas.Controls.Add(Me.Label52)
        Me.Phas.Controls.Add(Me.Phas_alotment_plant)
        Me.Phas.Controls.Add(Me.Label48)
        Me.Phas.Controls.Add(Me.Phas_herb_plant)
        Me.Phas.Controls.Add(Me.Label49)
        Me.Phas.Controls.Add(Me.Phas_flower_plant)
        Me.Phas.Controls.Add(Me.Phas_alotment_time)
        Me.Phas.Controls.Add(Me.Phas_flower_cancel)
        Me.Phas.Controls.Add(Me.Label51)
        Me.Phas.Controls.Add(Me.Phas_herb_cancel)
        Me.Phas.Controls.Add(Me.Phas_alotment_cancel)
        Me.Phas.Location = New System.Drawing.Point(3, 351)
        Me.Phas.Name = "Phas"
        Me.Phas.Size = New System.Drawing.Size(598, 110)
        '
        '
        '
        Me.Phas.Style.BackColor = System.Drawing.Color.Transparent
        Me.Phas.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.Phas.Style.BackColorGradientAngle = 90
        Me.Phas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Phas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Phas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Phas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Phas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Phas.Style.Class = ""
        Me.Phas.Style.CornerDiameter = 0
        Me.Phas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Phas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Phas.Style.TextColor = System.Drawing.Color.AntiqueWhite
        Me.Phas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Phas.StyleMouseDown.Class = ""
        Me.Phas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Phas.StyleMouseOver.Class = ""
        Me.Phas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Phas.TabIndex = 4
        Me.Phas.Text = "Port Phasmatys"
        '
        'Phas_flower_time
        '
        Me.Phas_flower_time.AutoSize = True
        Me.Phas_flower_time.BackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_flower_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Phas_flower_time.Location = New System.Drawing.Point(513, 62)
        Me.Phas_flower_time.Name = "Phas_flower_time"
        Me.Phas_flower_time.Size = New System.Drawing.Size(76, 21)
        Me.Phas_flower_time.TabIndex = 19
        Me.Phas_flower_time.Text = "00:00:00:00"
        Me.Phas_flower_time.UseCompatibleTextRendering = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label54.ForeColor = System.Drawing.Color.LightYellow
        Me.Label54.Location = New System.Drawing.Point(3, 7)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(59, 21)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Alotment:"
        Me.Label54.UseCompatibleTextRendering = True
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.LightYellow
        Me.Label53.Location = New System.Drawing.Point(3, 33)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(38, 21)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Herb:"
        Me.Label53.UseCompatibleTextRendering = True
        '
        'Phas_herb_time
        '
        Me.Phas_herb_time.AutoSize = True
        Me.Phas_herb_time.BackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_herb_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Phas_herb_time.Location = New System.Drawing.Point(513, 34)
        Me.Phas_herb_time.Name = "Phas_herb_time"
        Me.Phas_herb_time.Size = New System.Drawing.Size(76, 21)
        Me.Phas_herb_time.TabIndex = 18
        Me.Phas_herb_time.Text = "00:00:00:00"
        Me.Phas_herb_time.UseCompatibleTextRendering = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label52.ForeColor = System.Drawing.Color.LightYellow
        Me.Label52.Location = New System.Drawing.Point(3, 61)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(46, 21)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "Flower:"
        Me.Label52.UseCompatibleTextRendering = True
        '
        'Phas_alotment_plant
        '
        Me.Phas_alotment_plant.BackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_plant.BackgroundImage = CType(resources.GetObject("Phas_alotment_plant.BackgroundImage"), System.Drawing.Image)
        Me.Phas_alotment_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_alotment_plant.FlatAppearance.BorderSize = 0
        Me.Phas_alotment_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_alotment_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_alotment_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_alotment_plant.Location = New System.Drawing.Point(244, 4)
        Me.Phas_alotment_plant.Name = "Phas_alotment_plant"
        Me.Phas_alotment_plant.Size = New System.Drawing.Size(77, 21)
        Me.Phas_alotment_plant.TabIndex = 6
        Me.Phas_alotment_plant.Text = "Planted"
        Me.Phas_alotment_plant.UseCompatibleTextRendering = True
        Me.Phas_alotment_plant.UseVisualStyleBackColor = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label48.ForeColor = System.Drawing.Color.LightYellow
        Me.Label48.Location = New System.Drawing.Point(410, 62)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(95, 21)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Time remaining:"
        Me.Label48.UseCompatibleTextRendering = True
        '
        'Phas_herb_plant
        '
        Me.Phas_herb_plant.BackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_plant.BackgroundImage = CType(resources.GetObject("Phas_herb_plant.BackgroundImage"), System.Drawing.Image)
        Me.Phas_herb_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_herb_plant.FlatAppearance.BorderSize = 0
        Me.Phas_herb_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_herb_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_herb_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_herb_plant.Location = New System.Drawing.Point(244, 31)
        Me.Phas_herb_plant.Name = "Phas_herb_plant"
        Me.Phas_herb_plant.Size = New System.Drawing.Size(77, 21)
        Me.Phas_herb_plant.TabIndex = 7
        Me.Phas_herb_plant.Text = "Planted"
        Me.Phas_herb_plant.UseCompatibleTextRendering = True
        Me.Phas_herb_plant.UseVisualStyleBackColor = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label49.ForeColor = System.Drawing.Color.LightYellow
        Me.Label49.Location = New System.Drawing.Point(410, 33)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(95, 21)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "Time remaining:"
        Me.Label49.UseCompatibleTextRendering = True
        '
        'Phas_flower_plant
        '
        Me.Phas_flower_plant.BackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_plant.BackgroundImage = CType(resources.GetObject("Phas_flower_plant.BackgroundImage"), System.Drawing.Image)
        Me.Phas_flower_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_flower_plant.FlatAppearance.BorderSize = 0
        Me.Phas_flower_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_flower_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_flower_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_flower_plant.Location = New System.Drawing.Point(244, 58)
        Me.Phas_flower_plant.Name = "Phas_flower_plant"
        Me.Phas_flower_plant.Size = New System.Drawing.Size(77, 21)
        Me.Phas_flower_plant.TabIndex = 8
        Me.Phas_flower_plant.Text = "Planted"
        Me.Phas_flower_plant.UseCompatibleTextRendering = True
        Me.Phas_flower_plant.UseVisualStyleBackColor = False
        '
        'Phas_alotment_time
        '
        Me.Phas_alotment_time.AutoSize = True
        Me.Phas_alotment_time.BackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_alotment_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Phas_alotment_time.Location = New System.Drawing.Point(513, 9)
        Me.Phas_alotment_time.Name = "Phas_alotment_time"
        Me.Phas_alotment_time.Size = New System.Drawing.Size(76, 21)
        Me.Phas_alotment_time.TabIndex = 15
        Me.Phas_alotment_time.Text = "00:00:00:00"
        Me.Phas_alotment_time.UseCompatibleTextRendering = True
        '
        'Phas_flower_cancel
        '
        Me.Phas_flower_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_cancel.BackgroundImage = CType(resources.GetObject("Phas_flower_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Phas_flower_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_flower_cancel.FlatAppearance.BorderSize = 0
        Me.Phas_flower_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_flower_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_flower_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_flower_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_flower_cancel.Location = New System.Drawing.Point(327, 59)
        Me.Phas_flower_cancel.Name = "Phas_flower_cancel"
        Me.Phas_flower_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Phas_flower_cancel.TabIndex = 11
        Me.Phas_flower_cancel.Text = "Cancel"
        Me.Phas_flower_cancel.UseCompatibleTextRendering = True
        Me.Phas_flower_cancel.UseVisualStyleBackColor = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label51.ForeColor = System.Drawing.Color.LightYellow
        Me.Label51.Location = New System.Drawing.Point(410, 6)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(95, 21)
        Me.Label51.TabIndex = 14
        Me.Label51.Text = "Time remaining:"
        Me.Label51.UseCompatibleTextRendering = True
        '
        'Phas_herb_cancel
        '
        Me.Phas_herb_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_cancel.BackgroundImage = CType(resources.GetObject("Phas_herb_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Phas_herb_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_herb_cancel.FlatAppearance.BorderSize = 0
        Me.Phas_herb_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_herb_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_herb_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_herb_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_herb_cancel.Location = New System.Drawing.Point(327, 30)
        Me.Phas_herb_cancel.Name = "Phas_herb_cancel"
        Me.Phas_herb_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Phas_herb_cancel.TabIndex = 12
        Me.Phas_herb_cancel.Text = "Cancel"
        Me.Phas_herb_cancel.UseCompatibleTextRendering = True
        Me.Phas_herb_cancel.UseVisualStyleBackColor = False
        '
        'Phas_alotment_cancel
        '
        Me.Phas_alotment_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_cancel.BackgroundImage = CType(resources.GetObject("Phas_alotment_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Phas_alotment_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phas_alotment_cancel.FlatAppearance.BorderSize = 0
        Me.Phas_alotment_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Phas_alotment_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phas_alotment_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Phas_alotment_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phas_alotment_cancel.Location = New System.Drawing.Point(327, 3)
        Me.Phas_alotment_cancel.Name = "Phas_alotment_cancel"
        Me.Phas_alotment_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Phas_alotment_cancel.TabIndex = 13
        Me.Phas_alotment_cancel.Text = "Cancel"
        Me.Phas_alotment_cancel.UseCompatibleTextRendering = True
        Me.Phas_alotment_cancel.UseVisualStyleBackColor = False
        '
        'Falador
        '
        Me.Falador.BackColor = System.Drawing.Color.Transparent
        Me.Falador.CanvasColor = System.Drawing.Color.Transparent
        Me.Falador.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Falador.Controls.Add(Me.Falador_Flower)
        Me.Falador.Controls.Add(Me.Label1)
        Me.Falador.Controls.Add(Me.Falador_Herb)
        Me.Falador.Controls.Add(Me.Falador_Alotment)
        Me.Falador.Controls.Add(Me.Falador_Flower_Time)
        Me.Falador.Controls.Add(Me.Falador_Alotment_Time)
        Me.Falador.Controls.Add(Me.Falador_Herb_Time)
        Me.Falador.Controls.Add(Me.Falador_Alotment_Plant)
        Me.Falador.Controls.Add(Me.Label7)
        Me.Falador.Controls.Add(Me.Falador_Alotment_Cancel)
        Me.Falador.Controls.Add(Me.Label6)
        Me.Falador.Controls.Add(Me.Falador_Herb_Cancel)
        Me.Falador.Controls.Add(Me.Label4)
        Me.Falador.Controls.Add(Me.Falador_Flower_Cancel)
        Me.Falador.Controls.Add(Me.Label2)
        Me.Falador.Controls.Add(Me.Falador_Flower_Plant)
        Me.Falador.Controls.Add(Me.Label3)
        Me.Falador.Controls.Add(Me.Falador_Herb_Plant)
        Me.Falador.Location = New System.Drawing.Point(3, 3)
        Me.Falador.Name = "Falador"
        Me.Falador.Size = New System.Drawing.Size(597, 110)
        '
        '
        '
        Me.Falador.Style.BackColor = System.Drawing.Color.Transparent
        Me.Falador.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.Falador.Style.BackColorGradientAngle = 90
        Me.Falador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Falador.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Falador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Falador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Falador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Falador.Style.Class = ""
        Me.Falador.Style.CornerDiameter = 0
        Me.Falador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Falador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Falador.Style.TextColor = System.Drawing.Color.AntiqueWhite
        Me.Falador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Falador.StyleMouseDown.Class = ""
        Me.Falador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Falador.StyleMouseOver.Class = ""
        Me.Falador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Falador.TabIndex = 1
        Me.Falador.Text = "Falador"
        Me.Falador.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.LightYellow
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alotment:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Falador_Flower_Time
        '
        Me.Falador_Flower_Time.AutoSize = True
        Me.Falador_Flower_Time.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Flower_Time.ForeColor = System.Drawing.Color.LightYellow
        Me.Falador_Flower_Time.Location = New System.Drawing.Point(513, 64)
        Me.Falador_Flower_Time.Name = "Falador_Flower_Time"
        Me.Falador_Flower_Time.Size = New System.Drawing.Size(76, 21)
        Me.Falador_Flower_Time.TabIndex = 19
        Me.Falador_Flower_Time.Text = "00:00:00:00"
        Me.Falador_Flower_Time.UseCompatibleTextRendering = True
        '
        'Falador_Alotment_Time
        '
        Me.Falador_Alotment_Time.AutoSize = True
        Me.Falador_Alotment_Time.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Alotment_Time.ForeColor = System.Drawing.Color.LightYellow
        Me.Falador_Alotment_Time.Location = New System.Drawing.Point(513, 6)
        Me.Falador_Alotment_Time.Name = "Falador_Alotment_Time"
        Me.Falador_Alotment_Time.Size = New System.Drawing.Size(76, 21)
        Me.Falador_Alotment_Time.TabIndex = 20
        Me.Falador_Alotment_Time.Text = "00:00:00:00"
        Me.Falador_Alotment_Time.UseCompatibleTextRendering = True
        '
        'Falador_Herb_Time
        '
        Me.Falador_Herb_Time.AutoSize = True
        Me.Falador_Herb_Time.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Herb_Time.ForeColor = System.Drawing.Color.LightYellow
        Me.Falador_Herb_Time.Location = New System.Drawing.Point(513, 36)
        Me.Falador_Herb_Time.Name = "Falador_Herb_Time"
        Me.Falador_Herb_Time.Size = New System.Drawing.Size(76, 21)
        Me.Falador_Herb_Time.TabIndex = 18
        Me.Falador_Herb_Time.Text = "00:00:00:00"
        Me.Falador_Herb_Time.UseCompatibleTextRendering = True
        '
        'Falador_Alotment_Plant
        '
        Me.Falador_Alotment_Plant.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Plant.BackgroundImage = CType(resources.GetObject("Falador_Alotment_Plant.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Alotment_Plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Alotment_Plant.FlatAppearance.BorderSize = 0
        Me.Falador_Alotment_Plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Alotment_Plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Alotment_Plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Alotment_Plant.Location = New System.Drawing.Point(244, 3)
        Me.Falador_Alotment_Plant.Name = "Falador_Alotment_Plant"
        Me.Falador_Alotment_Plant.Size = New System.Drawing.Size(77, 22)
        Me.Falador_Alotment_Plant.TabIndex = 6
        Me.Falador_Alotment_Plant.Text = "Planted"
        Me.Falador_Alotment_Plant.UseCompatibleTextRendering = True
        Me.Falador_Alotment_Plant.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.LightYellow
        Me.Label7.Location = New System.Drawing.Point(410, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Time remaining:"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Falador_Alotment_Cancel
        '
        Me.Falador_Alotment_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Cancel.BackgroundImage = CType(resources.GetObject("Falador_Alotment_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Alotment_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Alotment_Cancel.FlatAppearance.BorderSize = 0
        Me.Falador_Alotment_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Alotment_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Alotment_Cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Alotment_Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Alotment_Cancel.Location = New System.Drawing.Point(327, 4)
        Me.Falador_Alotment_Cancel.Name = "Falador_Alotment_Cancel"
        Me.Falador_Alotment_Cancel.Size = New System.Drawing.Size(77, 21)
        Me.Falador_Alotment_Cancel.TabIndex = 13
        Me.Falador_Alotment_Cancel.Text = "Cancel"
        Me.Falador_Alotment_Cancel.UseCompatibleTextRendering = True
        Me.Falador_Alotment_Cancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.LightYellow
        Me.Label6.Location = New System.Drawing.Point(410, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Time remaining:"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Falador_Herb_Cancel
        '
        Me.Falador_Herb_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Cancel.BackgroundImage = CType(resources.GetObject("Falador_Herb_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Herb_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Herb_Cancel.FlatAppearance.BorderSize = 0
        Me.Falador_Herb_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Herb_Cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Herb_Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Herb_Cancel.Location = New System.Drawing.Point(327, 32)
        Me.Falador_Herb_Cancel.Name = "Falador_Herb_Cancel"
        Me.Falador_Herb_Cancel.Size = New System.Drawing.Size(77, 21)
        Me.Falador_Herb_Cancel.TabIndex = 12
        Me.Falador_Herb_Cancel.Text = "Cancel"
        Me.Falador_Herb_Cancel.UseCompatibleTextRendering = True
        Me.Falador_Herb_Cancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.LightYellow
        Me.Label4.Location = New System.Drawing.Point(410, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Time remaining:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Falador_Flower_Cancel
        '
        Me.Falador_Flower_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Cancel.BackgroundImage = CType(resources.GetObject("Falador_Flower_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Flower_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Flower_Cancel.FlatAppearance.BorderSize = 0
        Me.Falador_Flower_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Flower_Cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Flower_Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Flower_Cancel.Location = New System.Drawing.Point(327, 61)
        Me.Falador_Flower_Cancel.Name = "Falador_Flower_Cancel"
        Me.Falador_Flower_Cancel.Size = New System.Drawing.Size(77, 21)
        Me.Falador_Flower_Cancel.TabIndex = 11
        Me.Falador_Flower_Cancel.Text = "Cancel"
        Me.Falador_Flower_Cancel.UseCompatibleTextRendering = True
        Me.Falador_Flower_Cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightYellow
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Herb:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Falador_Flower_Plant
        '
        Me.Falador_Flower_Plant.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Plant.BackgroundImage = CType(resources.GetObject("Falador_Flower_Plant.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Flower_Plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Flower_Plant.FlatAppearance.BorderSize = 0
        Me.Falador_Flower_Plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Flower_Plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Flower_Plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Flower_Plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Flower_Plant.Location = New System.Drawing.Point(244, 60)
        Me.Falador_Flower_Plant.Name = "Falador_Flower_Plant"
        Me.Falador_Flower_Plant.Size = New System.Drawing.Size(77, 21)
        Me.Falador_Flower_Plant.TabIndex = 8
        Me.Falador_Flower_Plant.Text = "Planted"
        Me.Falador_Flower_Plant.UseCompatibleTextRendering = True
        Me.Falador_Flower_Plant.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.LightYellow
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Flower:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Falador_Herb_Plant
        '
        Me.Falador_Herb_Plant.BackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Plant.BackgroundImage = CType(resources.GetObject("Falador_Herb_Plant.BackgroundImage"), System.Drawing.Image)
        Me.Falador_Herb_Plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Falador_Herb_Plant.FlatAppearance.BorderSize = 0
        Me.Falador_Herb_Plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Falador_Herb_Plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Falador_Herb_Plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Falador_Herb_Plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Falador_Herb_Plant.Location = New System.Drawing.Point(244, 33)
        Me.Falador_Herb_Plant.Name = "Falador_Herb_Plant"
        Me.Falador_Herb_Plant.Size = New System.Drawing.Size(77, 21)
        Me.Falador_Herb_Plant.TabIndex = 7
        Me.Falador_Herb_Plant.Text = "Planted"
        Me.Falador_Herb_Plant.UseCompatibleTextRendering = True
        Me.Falador_Herb_Plant.UseVisualStyleBackColor = False
        '
        'Catherby
        '
        Me.Catherby.BackColor = System.Drawing.Color.Transparent
        Me.Catherby.CanvasColor = System.Drawing.Color.Transparent
        Me.Catherby.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Catherby.Controls.Add(Me.catherby_flower)
        Me.Catherby.Controls.Add(Me.catherby_alotment)
        Me.Catherby.Controls.Add(Me.Catherby_flower_time)
        Me.Catherby.Controls.Add(Me.Label39)
        Me.Catherby.Controls.Add(Me.catherby_herb)
        Me.Catherby.Controls.Add(Me.Label38)
        Me.Catherby.Controls.Add(Me.Catherby_herb_time)
        Me.Catherby.Controls.Add(Me.Label37)
        Me.Catherby.Controls.Add(Me.Catherby_alotment_plant)
        Me.Catherby.Controls.Add(Me.Label33)
        Me.Catherby.Controls.Add(Me.Catherby_herb_plant)
        Me.Catherby.Controls.Add(Me.Label34)
        Me.Catherby.Controls.Add(Me.Catherby_flower_plant)
        Me.Catherby.Controls.Add(Me.Catherby_alotment_time)
        Me.Catherby.Controls.Add(Me.Catherby_flower_cancel)
        Me.Catherby.Controls.Add(Me.Label36)
        Me.Catherby.Controls.Add(Me.Catherby_herb_cancel)
        Me.Catherby.Controls.Add(Me.Catherby_alotment_cancel)
        Me.Catherby.Location = New System.Drawing.Point(3, 119)
        Me.Catherby.Name = "Catherby"
        Me.Catherby.Size = New System.Drawing.Size(598, 110)
        '
        '
        '
        Me.Catherby.Style.BackColor = System.Drawing.Color.Transparent
        Me.Catherby.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.Catherby.Style.BackColorGradientAngle = 90
        Me.Catherby.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Catherby.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Catherby.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Catherby.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Catherby.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Catherby.Style.Class = ""
        Me.Catherby.Style.CornerDiameter = 0
        Me.Catherby.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Catherby.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Catherby.Style.TextColor = System.Drawing.Color.AntiqueWhite
        Me.Catherby.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Catherby.StyleMouseDown.Class = ""
        Me.Catherby.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Catherby.StyleMouseOver.Class = ""
        Me.Catherby.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Catherby.TabIndex = 2
        Me.Catherby.Text = "Catherby"
        '
        'Catherby_flower_time
        '
        Me.Catherby_flower_time.AutoSize = True
        Me.Catherby_flower_time.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_flower_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Catherby_flower_time.Location = New System.Drawing.Point(513, 63)
        Me.Catherby_flower_time.Name = "Catherby_flower_time"
        Me.Catherby_flower_time.Size = New System.Drawing.Size(76, 21)
        Me.Catherby_flower_time.TabIndex = 19
        Me.Catherby_flower_time.Text = "00:00:00:00"
        Me.Catherby_flower_time.UseCompatibleTextRendering = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.LightYellow
        Me.Label39.Location = New System.Drawing.Point(3, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 21)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Alotment:"
        Me.Label39.UseCompatibleTextRendering = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.LightYellow
        Me.Label38.Location = New System.Drawing.Point(3, 34)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 21)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Herb:"
        Me.Label38.UseCompatibleTextRendering = True
        '
        'Catherby_herb_time
        '
        Me.Catherby_herb_time.AutoSize = True
        Me.Catherby_herb_time.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_herb_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Catherby_herb_time.Location = New System.Drawing.Point(513, 35)
        Me.Catherby_herb_time.Name = "Catherby_herb_time"
        Me.Catherby_herb_time.Size = New System.Drawing.Size(76, 21)
        Me.Catherby_herb_time.TabIndex = 18
        Me.Catherby_herb_time.Text = "00:00:00:00"
        Me.Catherby_herb_time.UseCompatibleTextRendering = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.LightYellow
        Me.Label37.Location = New System.Drawing.Point(3, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(46, 21)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Flower:"
        Me.Label37.UseCompatibleTextRendering = True
        '
        'Catherby_alotment_plant
        '
        Me.Catherby_alotment_plant.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_plant.BackgroundImage = CType(resources.GetObject("Catherby_alotment_plant.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_alotment_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_alotment_plant.FlatAppearance.BorderSize = 0
        Me.Catherby_alotment_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_alotment_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_alotment_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_alotment_plant.Location = New System.Drawing.Point(244, 5)
        Me.Catherby_alotment_plant.Name = "Catherby_alotment_plant"
        Me.Catherby_alotment_plant.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_alotment_plant.TabIndex = 6
        Me.Catherby_alotment_plant.Text = "Planted"
        Me.Catherby_alotment_plant.UseCompatibleTextRendering = True
        Me.Catherby_alotment_plant.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.LightYellow
        Me.Label33.Location = New System.Drawing.Point(410, 63)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(95, 21)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Time remaining:"
        Me.Label33.UseCompatibleTextRendering = True
        '
        'Catherby_herb_plant
        '
        Me.Catherby_herb_plant.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_plant.BackgroundImage = CType(resources.GetObject("Catherby_herb_plant.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_herb_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_herb_plant.FlatAppearance.BorderSize = 0
        Me.Catherby_herb_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_herb_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_herb_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_herb_plant.Location = New System.Drawing.Point(244, 32)
        Me.Catherby_herb_plant.Name = "Catherby_herb_plant"
        Me.Catherby_herb_plant.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_herb_plant.TabIndex = 7
        Me.Catherby_herb_plant.Text = "Planted"
        Me.Catherby_herb_plant.UseCompatibleTextRendering = True
        Me.Catherby_herb_plant.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.LightYellow
        Me.Label34.Location = New System.Drawing.Point(410, 34)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 21)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Time remaining:"
        Me.Label34.UseCompatibleTextRendering = True
        '
        'Catherby_flower_plant
        '
        Me.Catherby_flower_plant.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_plant.BackgroundImage = CType(resources.GetObject("Catherby_flower_plant.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_flower_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_flower_plant.FlatAppearance.BorderSize = 0
        Me.Catherby_flower_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_flower_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_flower_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_flower_plant.Location = New System.Drawing.Point(244, 59)
        Me.Catherby_flower_plant.Name = "Catherby_flower_plant"
        Me.Catherby_flower_plant.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_flower_plant.TabIndex = 8
        Me.Catherby_flower_plant.Text = "Planted"
        Me.Catherby_flower_plant.UseCompatibleTextRendering = True
        Me.Catherby_flower_plant.UseVisualStyleBackColor = False
        '
        'Catherby_alotment_time
        '
        Me.Catherby_alotment_time.AutoSize = True
        Me.Catherby_alotment_time.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_alotment_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Catherby_alotment_time.Location = New System.Drawing.Point(513, 10)
        Me.Catherby_alotment_time.Name = "Catherby_alotment_time"
        Me.Catherby_alotment_time.Size = New System.Drawing.Size(76, 21)
        Me.Catherby_alotment_time.TabIndex = 15
        Me.Catherby_alotment_time.Text = "00:00:00:00"
        Me.Catherby_alotment_time.UseCompatibleTextRendering = True
        '
        'Catherby_flower_cancel
        '
        Me.Catherby_flower_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_cancel.BackgroundImage = CType(resources.GetObject("Catherby_flower_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_flower_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_flower_cancel.FlatAppearance.BorderSize = 0
        Me.Catherby_flower_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_flower_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_flower_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_flower_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_flower_cancel.Location = New System.Drawing.Point(327, 60)
        Me.Catherby_flower_cancel.Name = "Catherby_flower_cancel"
        Me.Catherby_flower_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_flower_cancel.TabIndex = 11
        Me.Catherby_flower_cancel.Text = "Cancel"
        Me.Catherby_flower_cancel.UseCompatibleTextRendering = True
        Me.Catherby_flower_cancel.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.LightYellow
        Me.Label36.Location = New System.Drawing.Point(410, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 21)
        Me.Label36.TabIndex = 14
        Me.Label36.Text = "Time remaining:"
        Me.Label36.UseCompatibleTextRendering = True
        '
        'Catherby_herb_cancel
        '
        Me.Catherby_herb_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_cancel.BackgroundImage = CType(resources.GetObject("Catherby_herb_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_herb_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_herb_cancel.FlatAppearance.BorderSize = 0
        Me.Catherby_herb_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_herb_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_herb_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_herb_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_herb_cancel.Location = New System.Drawing.Point(327, 31)
        Me.Catherby_herb_cancel.Name = "Catherby_herb_cancel"
        Me.Catherby_herb_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_herb_cancel.TabIndex = 12
        Me.Catherby_herb_cancel.Text = "Cancel"
        Me.Catherby_herb_cancel.UseCompatibleTextRendering = True
        Me.Catherby_herb_cancel.UseVisualStyleBackColor = False
        '
        'Catherby_alotment_cancel
        '
        Me.Catherby_alotment_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_cancel.BackgroundImage = CType(resources.GetObject("Catherby_alotment_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Catherby_alotment_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Catherby_alotment_cancel.FlatAppearance.BorderSize = 0
        Me.Catherby_alotment_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Catherby_alotment_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catherby_alotment_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Catherby_alotment_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Catherby_alotment_cancel.Location = New System.Drawing.Point(326, 4)
        Me.Catherby_alotment_cancel.Name = "Catherby_alotment_cancel"
        Me.Catherby_alotment_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Catherby_alotment_cancel.TabIndex = 13
        Me.Catherby_alotment_cancel.Text = "Cancel"
        Me.Catherby_alotment_cancel.UseCompatibleTextRendering = True
        Me.Catherby_alotment_cancel.UseVisualStyleBackColor = False
        '
        'Ardy
        '
        Me.Ardy.BackColor = System.Drawing.Color.Transparent
        Me.Ardy.CanvasColor = System.Drawing.Color.Transparent
        Me.Ardy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Ardy.Controls.Add(Me.Ardy_flower)
        Me.Ardy.Controls.Add(Me.Ardy_alotment)
        Me.Ardy.Controls.Add(Me.Ardy_flower_time)
        Me.Ardy.Controls.Add(Me.Label45)
        Me.Ardy.Controls.Add(Me.Ardy_herb)
        Me.Ardy.Controls.Add(Me.Label44)
        Me.Ardy.Controls.Add(Me.Ardy_herb_time)
        Me.Ardy.Controls.Add(Me.Label43)
        Me.Ardy.Controls.Add(Me.Ardy_Alotment_plant)
        Me.Ardy.Controls.Add(Me.Label35)
        Me.Ardy.Controls.Add(Me.Ardy_herb_plant)
        Me.Ardy.Controls.Add(Me.Label40)
        Me.Ardy.Controls.Add(Me.Ardy_flower_plant)
        Me.Ardy.Controls.Add(Me.Ardy_Alotment_time)
        Me.Ardy.Controls.Add(Me.Ardy_flower_cancel)
        Me.Ardy.Controls.Add(Me.Label42)
        Me.Ardy.Controls.Add(Me.Ardy_herb_cancel)
        Me.Ardy.Controls.Add(Me.Ardy_Alotment_cancel)
        Me.Ardy.Location = New System.Drawing.Point(3, 235)
        Me.Ardy.Name = "Ardy"
        Me.Ardy.Size = New System.Drawing.Size(598, 110)
        '
        '
        '
        Me.Ardy.Style.BackColor = System.Drawing.Color.Transparent
        Me.Ardy.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.Ardy.Style.BackColorGradientAngle = 90
        Me.Ardy.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ardy.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Ardy.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ardy.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ardy.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ardy.Style.Class = ""
        Me.Ardy.Style.CornerDiameter = 0
        Me.Ardy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Ardy.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Ardy.Style.TextColor = System.Drawing.Color.AntiqueWhite
        Me.Ardy.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Ardy.StyleMouseDown.Class = ""
        Me.Ardy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Ardy.StyleMouseOver.Class = ""
        Me.Ardy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Ardy.TabIndex = 3
        Me.Ardy.Text = "North Ardougne"
        '
        'Ardy_flower_time
        '
        Me.Ardy_flower_time.AutoSize = True
        Me.Ardy_flower_time.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_flower_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Ardy_flower_time.Location = New System.Drawing.Point(512, 62)
        Me.Ardy_flower_time.Name = "Ardy_flower_time"
        Me.Ardy_flower_time.Size = New System.Drawing.Size(76, 21)
        Me.Ardy_flower_time.TabIndex = 19
        Me.Ardy_flower_time.Text = "00:00:00:00"
        Me.Ardy_flower_time.UseCompatibleTextRendering = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label45.ForeColor = System.Drawing.Color.LightYellow
        Me.Label45.Location = New System.Drawing.Point(2, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(59, 21)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Alotment:"
        Me.Label45.UseCompatibleTextRendering = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.LightYellow
        Me.Label44.Location = New System.Drawing.Point(2, 33)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(38, 21)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Herb:"
        Me.Label44.UseCompatibleTextRendering = True
        '
        'Ardy_herb_time
        '
        Me.Ardy_herb_time.AutoSize = True
        Me.Ardy_herb_time.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_herb_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Ardy_herb_time.Location = New System.Drawing.Point(512, 34)
        Me.Ardy_herb_time.Name = "Ardy_herb_time"
        Me.Ardy_herb_time.Size = New System.Drawing.Size(76, 21)
        Me.Ardy_herb_time.TabIndex = 18
        Me.Ardy_herb_time.Text = "00:00:00:00"
        Me.Ardy_herb_time.UseCompatibleTextRendering = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.ForeColor = System.Drawing.Color.LightYellow
        Me.Label43.Location = New System.Drawing.Point(2, 61)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 21)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Flower:"
        Me.Label43.UseCompatibleTextRendering = True
        '
        'Ardy_Alotment_plant
        '
        Me.Ardy_Alotment_plant.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_plant.BackgroundImage = CType(resources.GetObject("Ardy_Alotment_plant.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_Alotment_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_Alotment_plant.FlatAppearance.BorderSize = 0
        Me.Ardy_Alotment_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_Alotment_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_Alotment_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_Alotment_plant.Location = New System.Drawing.Point(243, 3)
        Me.Ardy_Alotment_plant.Name = "Ardy_Alotment_plant"
        Me.Ardy_Alotment_plant.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_Alotment_plant.TabIndex = 6
        Me.Ardy_Alotment_plant.Text = "Planted"
        Me.Ardy_Alotment_plant.UseCompatibleTextRendering = True
        Me.Ardy_Alotment_plant.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label35.ForeColor = System.Drawing.Color.LightYellow
        Me.Label35.Location = New System.Drawing.Point(409, 62)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(95, 21)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "Time remaining:"
        Me.Label35.UseCompatibleTextRendering = True
        '
        'Ardy_herb_plant
        '
        Me.Ardy_herb_plant.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_plant.BackgroundImage = CType(resources.GetObject("Ardy_herb_plant.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_herb_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_herb_plant.FlatAppearance.BorderSize = 0
        Me.Ardy_herb_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_herb_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_herb_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_herb_plant.Location = New System.Drawing.Point(243, 31)
        Me.Ardy_herb_plant.Name = "Ardy_herb_plant"
        Me.Ardy_herb_plant.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_herb_plant.TabIndex = 7
        Me.Ardy_herb_plant.Text = "Planted"
        Me.Ardy_herb_plant.UseCompatibleTextRendering = True
        Me.Ardy_herb_plant.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.ForeColor = System.Drawing.Color.LightYellow
        Me.Label40.Location = New System.Drawing.Point(409, 33)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 21)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "Time remaining:"
        Me.Label40.UseCompatibleTextRendering = True
        '
        'Ardy_flower_plant
        '
        Me.Ardy_flower_plant.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_plant.BackgroundImage = CType(resources.GetObject("Ardy_flower_plant.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_flower_plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_flower_plant.FlatAppearance.BorderSize = 0
        Me.Ardy_flower_plant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_plant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_flower_plant.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_flower_plant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_flower_plant.Location = New System.Drawing.Point(243, 58)
        Me.Ardy_flower_plant.Name = "Ardy_flower_plant"
        Me.Ardy_flower_plant.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_flower_plant.TabIndex = 8
        Me.Ardy_flower_plant.Text = "Planted"
        Me.Ardy_flower_plant.UseCompatibleTextRendering = True
        Me.Ardy_flower_plant.UseVisualStyleBackColor = False
        '
        'Ardy_Alotment_time
        '
        Me.Ardy_Alotment_time.AutoSize = True
        Me.Ardy_Alotment_time.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_time.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_Alotment_time.ForeColor = System.Drawing.Color.LightYellow
        Me.Ardy_Alotment_time.Location = New System.Drawing.Point(512, 9)
        Me.Ardy_Alotment_time.Name = "Ardy_Alotment_time"
        Me.Ardy_Alotment_time.Size = New System.Drawing.Size(76, 21)
        Me.Ardy_Alotment_time.TabIndex = 15
        Me.Ardy_Alotment_time.Text = "00:00:00:00"
        Me.Ardy_Alotment_time.UseCompatibleTextRendering = True
        '
        'Ardy_flower_cancel
        '
        Me.Ardy_flower_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_cancel.BackgroundImage = CType(resources.GetObject("Ardy_flower_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_flower_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_flower_cancel.FlatAppearance.BorderSize = 0
        Me.Ardy_flower_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_flower_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_flower_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_flower_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_flower_cancel.Location = New System.Drawing.Point(326, 59)
        Me.Ardy_flower_cancel.Name = "Ardy_flower_cancel"
        Me.Ardy_flower_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_flower_cancel.TabIndex = 11
        Me.Ardy_flower_cancel.Text = "Cancel"
        Me.Ardy_flower_cancel.UseCompatibleTextRendering = True
        Me.Ardy_flower_cancel.UseVisualStyleBackColor = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label42.ForeColor = System.Drawing.Color.LightYellow
        Me.Label42.Location = New System.Drawing.Point(409, 6)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(95, 21)
        Me.Label42.TabIndex = 14
        Me.Label42.Text = "Time remaining:"
        Me.Label42.UseCompatibleTextRendering = True
        '
        'Ardy_herb_cancel
        '
        Me.Ardy_herb_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_cancel.BackgroundImage = CType(resources.GetObject("Ardy_herb_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_herb_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_herb_cancel.FlatAppearance.BorderSize = 0
        Me.Ardy_herb_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_herb_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_herb_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_herb_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_herb_cancel.Location = New System.Drawing.Point(326, 30)
        Me.Ardy_herb_cancel.Name = "Ardy_herb_cancel"
        Me.Ardy_herb_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_herb_cancel.TabIndex = 12
        Me.Ardy_herb_cancel.Text = "Cancel"
        Me.Ardy_herb_cancel.UseCompatibleTextRendering = True
        Me.Ardy_herb_cancel.UseVisualStyleBackColor = False
        '
        'Ardy_Alotment_cancel
        '
        Me.Ardy_Alotment_cancel.BackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_cancel.BackgroundImage = CType(resources.GetObject("Ardy_Alotment_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Ardy_Alotment_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ardy_Alotment_cancel.FlatAppearance.BorderSize = 0
        Me.Ardy_Alotment_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ardy_Alotment_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ardy_Alotment_cancel.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Ardy_Alotment_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ardy_Alotment_cancel.Location = New System.Drawing.Point(326, 3)
        Me.Ardy_Alotment_cancel.Name = "Ardy_Alotment_cancel"
        Me.Ardy_Alotment_cancel.Size = New System.Drawing.Size(77, 21)
        Me.Ardy_Alotment_cancel.TabIndex = 13
        Me.Ardy_Alotment_cancel.Text = "Cancel"
        Me.Ardy_Alotment_cancel.UseCompatibleTextRendering = True
        Me.Ardy_Alotment_cancel.UseVisualStyleBackColor = False
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "SuperTabItem2"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "SuperTabItem3"
        '
        'Bush
        '
        Me.Bush.BackColor = System.Drawing.Color.Transparent
        Me.Bush.CanvasColor = System.Drawing.Color.Transparent
        Me.Bush.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bush.Controls.Add(Me.Label85)
        Me.Bush.Controls.Add(Me.Button7)
        Me.Bush.Controls.Add(Me.Button8)
        Me.Bush.Controls.Add(Me.Label86)
        Me.Bush.Controls.Add(Me.Label83)
        Me.Bush.Controls.Add(Me.Button5)
        Me.Bush.Controls.Add(Me.Button6)
        Me.Bush.Controls.Add(Me.Label84)
        Me.Bush.Controls.Add(Me.Label81)
        Me.Bush.Controls.Add(Me.Button3)
        Me.Bush.Controls.Add(Me.Button4)
        Me.Bush.Controls.Add(Me.Label82)
        Me.Bush.Controls.Add(Me.Label79)
        Me.Bush.Controls.Add(Me.Label17)
        Me.Bush.Controls.Add(Me.Bush_Rimmington_Type)
        Me.Bush.Controls.Add(Me.Button1)
        Me.Bush.Controls.Add(Me.Button2)
        Me.Bush.Controls.Add(Me.Label5)
        Me.Bush.Controls.Add(Me.Label19)
        Me.Bush.Controls.Add(Me.Label80)
        Me.Bush.Controls.Add(Me.Bush_exe_Type)
        Me.Bush.Controls.Add(Me.Label18)
        Me.Bush.Controls.Add(Me.Bush_Champ_Type)
        Me.Bush.Controls.Add(Me.Bush_Mons_Type)
        Me.Bush.Location = New System.Drawing.Point(3, 3)
        Me.Bush.Name = "Bush"
        Me.Bush.Size = New System.Drawing.Size(598, 128)
        '
        '
        '
        Me.Bush.Style.BackColor = System.Drawing.Color.Transparent
        Me.Bush.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.Bush.Style.BackColorGradientAngle = 90
        Me.Bush.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Bush.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Bush.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Bush.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Bush.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Bush.Style.Class = ""
        Me.Bush.Style.CornerDiameter = 4
        Me.Bush.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Bush.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Bush.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bush.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Bush.StyleMouseDown.Class = ""
        Me.Bush.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Bush.StyleMouseOver.Class = ""
        Me.Bush.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Bush.TabIndex = 0
        Me.Bush.Text = "Bush"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label85.ForeColor = System.Drawing.Color.LightYellow
        Me.Label85.Location = New System.Drawing.Point(517, 85)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(76, 21)
        Me.Label85.TabIndex = 36
        Me.Label85.Text = "00:00:00:00"
        Me.Label85.UseCompatibleTextRendering = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.LightYellow
        Me.Button7.Location = New System.Drawing.Point(253, 82)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(77, 22)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Planted"
        Me.Button7.UseCompatibleTextRendering = True
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.LightYellow
        Me.Button8.Location = New System.Drawing.Point(336, 83)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 21)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "Cancel"
        Me.Button8.UseCompatibleTextRendering = True
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label86.ForeColor = System.Drawing.Color.LightYellow
        Me.Label86.Location = New System.Drawing.Point(419, 85)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(95, 21)
        Me.Label86.TabIndex = 35
        Me.Label86.Text = "Time remaining:"
        Me.Label86.UseCompatibleTextRendering = True
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label83.ForeColor = System.Drawing.Color.LightYellow
        Me.Label83.Location = New System.Drawing.Point(517, 58)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(76, 21)
        Me.Label83.TabIndex = 32
        Me.Label83.Text = "00:00:00:00"
        Me.Label83.UseCompatibleTextRendering = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.LightYellow
        Me.Button5.Location = New System.Drawing.Point(253, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 22)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Planted"
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.LightYellow
        Me.Button6.Location = New System.Drawing.Point(336, 56)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 21)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Cancel"
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label84.ForeColor = System.Drawing.Color.LightYellow
        Me.Label84.Location = New System.Drawing.Point(419, 58)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(95, 21)
        Me.Label84.TabIndex = 31
        Me.Label84.Text = "Time remaining:"
        Me.Label84.UseCompatibleTextRendering = True
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label81.ForeColor = System.Drawing.Color.LightYellow
        Me.Label81.Location = New System.Drawing.Point(517, 32)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(76, 21)
        Me.Label81.TabIndex = 28
        Me.Label81.Text = "00:00:00:00"
        Me.Label81.UseCompatibleTextRendering = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.LightYellow
        Me.Button3.Location = New System.Drawing.Point(253, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 22)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Planted"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.LightYellow
        Me.Button4.Location = New System.Drawing.Point(336, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 21)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Cancel"
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label82.ForeColor = System.Drawing.Color.LightYellow
        Me.Label82.Location = New System.Drawing.Point(419, 32)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(95, 21)
        Me.Label82.TabIndex = 27
        Me.Label82.Text = "Time remaining:"
        Me.Label82.UseCompatibleTextRendering = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label79.ForeColor = System.Drawing.Color.LightYellow
        Me.Label79.Location = New System.Drawing.Point(517, 5)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(76, 21)
        Me.Label79.TabIndex = 24
        Me.Label79.Text = "00:00:00:00"
        Me.Label79.UseCompatibleTextRendering = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.LightYellow
        Me.Label17.Location = New System.Drawing.Point(-1, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 21)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Champ Guild:"
        Me.Label17.UseCompatibleTextRendering = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.LightYellow
        Me.Button1.Location = New System.Drawing.Point(253, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 22)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Planted"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.LightYellow
        Me.Button2.Location = New System.Drawing.Point(336, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 21)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Cancel"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.LightYellow
        Me.Label5.Location = New System.Drawing.Point(2, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Rimmington:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.LightYellow
        Me.Label19.Location = New System.Drawing.Point(15, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 21)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Excettera:"
        Me.Label19.UseCompatibleTextRendering = True
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label80.ForeColor = System.Drawing.Color.LightYellow
        Me.Label80.Location = New System.Drawing.Point(419, 5)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(95, 21)
        Me.Label80.TabIndex = 23
        Me.Label80.Text = "Time remaining:"
        Me.Label80.UseCompatibleTextRendering = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.LightYellow
        Me.Label18.Location = New System.Drawing.Point(11, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Monistary:"
        Me.Label18.UseCompatibleTextRendering = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Barley", "Hammerstone", "Asgarnia", "Jute", "Yanillian", "Krandorian", "Wildblood"})
        Me.ComboBox4.Location = New System.Drawing.Point(83, 84)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox4.TabIndex = 11
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Barley", "Hammerstone", "Asgarnia", "Jute", "Yanillian", "Krandorian", "Wildblood"})
        Me.ComboBox3.Location = New System.Drawing.Point(83, 57)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Barley", "Hammerstone", "Asgarnia", "Jute", "Yanillian", "Krandorian", "Wildblood"})
        Me.ComboBox2.Location = New System.Drawing.Point(83, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Barley", "Hammerstone", "Asgarnia", "Jute", "Yanillian", "Krandorian", "Wildblood"})
        Me.ComboBox1.Location = New System.Drawing.Point(83, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Fruit_Gnomestong
        '
        Me.Fruit_Gnomestong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_Gnomestong.FormattingEnabled = True
        Me.Fruit_Gnomestong.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_Gnomestong.Location = New System.Drawing.Point(90, 4)
        Me.Fruit_Gnomestong.Name = "Fruit_Gnomestong"
        Me.Fruit_Gnomestong.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_Gnomestong.TabIndex = 6
        '
        'Fruit_Gnomemaze
        '
        Me.Fruit_Gnomemaze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_Gnomemaze.FormattingEnabled = True
        Me.Fruit_Gnomemaze.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_Gnomemaze.Location = New System.Drawing.Point(90, 31)
        Me.Fruit_Gnomemaze.Name = "Fruit_Gnomemaze"
        Me.Fruit_Gnomemaze.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_Gnomemaze.TabIndex = 7
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel6)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel7)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 6
        Me.SuperTabControl1.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 1
        Me.SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem8, Me.SuperTabItem1, Me.SuperTabItem4, Me.Shops, Me.SuperTabItem5, Me.SuperTabItem6, Me.SuperTabItem7})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel5.Controls.Add(Me.Button60)
        Me.SuperTabControlPanel5.Controls.Add(Me.Button59)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupPanel7)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupPanel6)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupPanel4)
        Me.SuperTabControlPanel5.Controls.Add(Me.AnalogClockControl1)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupPanel2)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 23)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(603, 467)
        Me.SuperTabControlPanel5.TabIndex = 0
        Me.SuperTabControlPanel5.TabItem = Me.SuperTabItem7
        '
        'Button60
        '
        Me.Button60.BackColor = System.Drawing.Color.Transparent
        Me.Button60.BackgroundImage = CType(resources.GetObject("Button60.BackgroundImage"), System.Drawing.Image)
        Me.Button60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button60.FlatAppearance.BorderSize = 0
        Me.Button60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button60.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button60.ForeColor = System.Drawing.Color.LightYellow
        Me.Button60.Location = New System.Drawing.Point(11, 423)
        Me.Button60.Name = "Button60"
        Me.Button60.Size = New System.Drawing.Size(75, 23)
        Me.Button60.TabIndex = 2
        Me.Button60.Text = "Popup"
        Me.Button60.UseCompatibleTextRendering = True
        Me.Button60.UseVisualStyleBackColor = True
        '
        'Button59
        '
        Me.Button59.BackColor = System.Drawing.Color.Transparent
        Me.Button59.BackgroundImage = CType(resources.GetObject("Button59.BackgroundImage"), System.Drawing.Image)
        Me.Button59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button59.FlatAppearance.BorderSize = 0
        Me.Button59.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button59.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button59.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button59.ForeColor = System.Drawing.Color.LightYellow
        Me.Button59.Location = New System.Drawing.Point(89, 423)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(77, 23)
        Me.Button59.TabIndex = 9
        Me.Button59.Text = "Convert"
        Me.Button59.UseCompatibleTextRendering = True
        Me.Button59.UseVisualStyleBackColor = True
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.LinkLabel1)
        Me.GroupPanel7.Controls.Add(Me.ButtonX2)
        Me.GroupPanel7.Controls.Add(Me.LabelX2)
        Me.GroupPanel7.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(207, 98)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.Class = ""
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.Class = ""
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.Class = ""
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 8
        Me.GroupPanel7.Text = "More info"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(47, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(99, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Deathmock.zxq.net"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Runescapeclock.My.Resources.Resources.btn_donate_LG
        Me.ButtonX2.Location = New System.Drawing.Point(50, 46)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(97, 28)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 1
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, -6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(191, 56)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Creator: Deathmock5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Website:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you support me, then please donate!"
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.ListBox1)
        Me.GroupPanel6.Controls.Add(Me.LabelX1)
        Me.GroupPanel6.Location = New System.Drawing.Point(3, 105)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(597, 303)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.Class = ""
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.Class = ""
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.Class = ""
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 7
        Me.GroupPanel6.Text = "Disclaimer"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Items.AddRange(New Object() {"GNU GENERAL PUBLIC LICENSE", "Version 2, June 1991 ", "", "Copyright (C) 1989, 1991 Free Software Foundation, Inc.  ", "59 Temple Place - Suite 330, Boston, MA  02111-1307, USA", "", "Everyone is permitted to copy and distribute verbatim copies", "of this license document, but changing it is not allowed.", "", "Preamble", resources.GetString("ListBox1.Items"), "", resources.GetString("ListBox1.Items1"), "", resources.GetString("ListBox1.Items2"), "", resources.GetString("ListBox1.Items3"), "", "We protect your rights with two steps: (1) copyright the software, and (2) offer " & _
                "you this license which gives you legal permission to copy, distribute and/or mod" & _
                "ify the software. ", "", resources.GetString("ListBox1.Items4"), "", resources.GetString("ListBox1.Items5"), "", "The precise terms and conditions for copying, distribution and modification follo" & _
                "w. ", "", "TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION", resources.GetString("ListBox1.Items6"), "", resources.GetString("ListBox1.Items7"), "", resources.GetString("ListBox1.Items8"), "", "You may charge a fee for the physical act of transferring a copy, and you may at " & _
                "your option offer warranty protection in exchange for a fee. ", "", resources.GetString("ListBox1.Items9"), "", "", "a) You must cause the modified files to carry prominent notices stating that you " & _
                "changed the files and the date of any change. ", "", resources.GetString("ListBox1.Items10"), "", resources.GetString("ListBox1.Items11"), resources.GetString("ListBox1.Items12"), resources.GetString("ListBox1.Items13"), "", resources.GetString("ListBox1.Items14"), "", resources.GetString("ListBox1.Items15"), "", resources.GetString("ListBox1.Items16"), "", resources.GetString("ListBox1.Items17"), "", resources.GetString("ListBox1.Items18"), resources.GetString("ListBox1.Items19"), resources.GetString("ListBox1.Items20"), "", resources.GetString("ListBox1.Items21"), "", resources.GetString("ListBox1.Items22"), "", resources.GetString("ListBox1.Items23"), "", resources.GetString("ListBox1.Items24"), "", resources.GetString("ListBox1.Items25"), "", resources.GetString("ListBox1.Items26"), "", "This section is intended to make thoroughly clear what is believed to be a conseq" & _
                "uence of the rest of this License. ", "", resources.GetString("ListBox1.Items27"), "", resources.GetString("ListBox1.Items28"), "", resources.GetString("ListBox1.Items29"), "", resources.GetString("ListBox1.Items30"), "", "NO WARRANTY", "", resources.GetString("ListBox1.Items31"), "", resources.GetString("ListBox1.Items32"), "", "", "END OF TERMS AND CONDITIONS"})
        Me.ListBox1.Location = New System.Drawing.Point(-3, 94)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(598, 186)
        Me.ListBox1.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(5, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(589, 74)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = resources.GetString("LabelX1.Text")
        Me.LabelX1.WordWrap = True
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Soundswitch)
        Me.GroupPanel4.Location = New System.Drawing.Point(175, 409)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(105, 48)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.Class = ""
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.Class = ""
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.Class = ""
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 6
        Me.GroupPanel4.Text = "Sound Effect"
        '
        'Soundswitch
        '
        '
        '
        '
        Me.Soundswitch.BackgroundStyle.Class = ""
        Me.Soundswitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Soundswitch.Location = New System.Drawing.Point(3, 3)
        Me.Soundswitch.Name = "Soundswitch"
        Me.Soundswitch.Size = New System.Drawing.Size(91, 21)
        Me.Soundswitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Soundswitch.TabIndex = 5
        '
        'AnalogClockControl1
        '
        Me.AnalogClockControl1.AutomaticMode = True
        Me.AnalogClockControl1.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        ColorData1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        ColorData1.BorderWidth = 0.01!
        ColorData1.BrushSBSScale = 1.0!
        ColorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData1.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData1.Color2 = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        ClockStyleData1.BezelColor = ColorData1
        ColorData2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData2.BorderWidth = 0.01!
        ColorData2.BrushSBSScale = 1.0!
        ColorData2.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData2.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockStyleData1.CapColor = ColorData2
        ColorData3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(161, Byte), Integer))
        ColorData3.BorderWidth = 0.01!
        ColorData3.BrushAngle = 45.0!
        ColorData3.BrushSBSScale = 1.0!
        ColorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData3.Color1 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        ColorData3.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ClockStyleData1.FaceColor = ColorData3
        ClockStyleData1.GlassAngle = -20
        ColorData4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData4.BorderWidth = 0.01!
        ColorData4.BrushSBSScale = 1.0!
        ColorData4.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData4.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData1.HandColor = ColorData4
        ClockHandStyleData1.Length = 0.55!
        ClockHandStyleData1.Width = 0.015!
        ClockStyleData1.HourHandStyle = ClockHandStyleData1
        ColorData5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData5.BorderWidth = 0.01!
        ColorData5.BrushSBSScale = 1.0!
        ColorData5.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData5.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ColorData5.Color2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ClockStyleData1.LargeTickColor = ColorData5
        ColorData6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData6.BorderWidth = 0.01!
        ColorData6.BrushSBSScale = 1.0!
        ColorData6.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData6.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData2.HandColor = ColorData6
        ClockHandStyleData2.Length = 0.8!
        ClockHandStyleData2.Width = 0.01!
        ClockStyleData1.MinuteHandStyle = ClockHandStyleData2
        ClockStyleData1.NumberFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        ColorData7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData7.BorderWidth = 0.01!
        ColorData7.BrushSBSScale = 1.0!
        ColorData7.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData7.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData3.HandColor = ColorData7
        ClockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style2
        ClockHandStyleData3.Length = 0.8!
        ClockHandStyleData3.Width = 0.005!
        ClockStyleData1.SecondHandStyle = ClockHandStyleData3
        ColorData8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData8.BorderWidth = 0.01!
        ColorData8.BrushSBSScale = 1.0!
        ColorData8.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData8.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ColorData8.Color2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ClockStyleData1.SmallTickColor = ColorData8
        ClockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        Me.AnalogClockControl1.ClockStyleData = ClockStyleData1
        Me.AnalogClockControl1.Location = New System.Drawing.Point(493, 3)
        Me.AnalogClockControl1.Name = "AnalogClockControl1"
        Me.AnalogClockControl1.Size = New System.Drawing.Size(100, 100)
        Me.AnalogClockControl1.TabIndex = 4
        Me.AnalogClockControl1.Text = "AnalogClockControl1"
        Me.AnalogClockControl1.TimeZone = "W. Central Africa Standard Time"
        Me.AnalogClockControl1.Value = New Date(2012, 3, 31, 12, 9, 29, 135)
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.stylecont)
        Me.GroupPanel2.Controls.Add(Me.ButtonX1)
        Me.GroupPanel2.Location = New System.Drawing.Point(286, 409)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(307, 48)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Style"
        '
        'stylecont
        '
        Me.stylecont.DisplayMember = "Text"
        Me.stylecont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.stylecont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stylecont.FormattingEnabled = True
        Me.stylecont.ItemHeight = 14
        Me.stylecont.Items.AddRange(New Object() {Me.Black, Me.Blue, Me.Silver, Me.Glass})
        Me.stylecont.Location = New System.Drawing.Point(5, 3)
        Me.stylecont.Name = "stylecont"
        Me.stylecont.Size = New System.Drawing.Size(209, 20)
        Me.stylecont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.stylecont.TabIndex = 2
        '
        'Black
        '
        Me.Black.Text = "Black"
        '
        'Blue
        '
        Me.Blue.Text = "Blue"
        '
        'Silver
        '
        Me.Silver.Text = "Silver"
        '
        'Glass
        '
        Me.Glass.Text = "Glass"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(220, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Set"
        '
        'SuperTabItem7
        '
        Me.SuperTabItem7.AttachedControl = Me.SuperTabControlPanel5
        Me.SuperTabItem7.GlobalItem = False
        Me.SuperTabItem7.Name = "SuperTabItem7"
        Me.SuperTabItem7.Text = "OPTIONS"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel4.Controls.Add(Me.Label69)
        Me.SuperTabControlPanel4.Controls.Add(Me.Label65)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem6
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label69.ForeColor = System.Drawing.Color.LightYellow
        Me.Label69.Location = New System.Drawing.Point(184, 72)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(68, 21)
        Me.Label69.TabIndex = 9
        Me.Label69.Text = "Court case:"
        Me.Label69.UseCompatibleTextRendering = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label65.ForeColor = System.Drawing.Color.LightYellow
        Me.Label65.Location = New System.Drawing.Point(290, 72)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(43, 21)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "Trolls:"
        Me.Label65.UseCompatibleTextRendering = True
        '
        'SuperTabItem6
        '
        Me.SuperTabItem6.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem6.GlobalItem = False
        Me.SuperTabItem6.Name = "SuperTabItem6"
        Me.SuperTabItem6.Text = "Monthly"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel3.Controls.Add(Me.Label145)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label68)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label15)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label64)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label63)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label62)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label61)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label60)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label59)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label58)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label57)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label56)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem5
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.BackColor = System.Drawing.Color.Transparent
        Me.Label145.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label145.ForeColor = System.Drawing.Color.LightYellow
        Me.Label145.Location = New System.Drawing.Point(361, 370)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(67, 21)
        Me.Label145.TabIndex = 11
        Me.Label145.Text = "Mature ale"
        Me.Label145.UseCompatibleTextRendering = True
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label68.ForeColor = System.Drawing.Color.LightYellow
        Me.Label68.Location = New System.Drawing.Point(297, 285)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(87, 21)
        Me.Label68.TabIndex = 10
        Me.Label68.Text = "Familurization:"
        Me.Label68.UseCompatibleTextRendering = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.LightYellow
        Me.Label15.Location = New System.Drawing.Point(172, 337)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 21)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Jade Vine:"
        Me.Label15.UseCompatibleTextRendering = True
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label64.ForeColor = System.Drawing.Color.LightYellow
        Me.Label64.Location = New System.Drawing.Point(279, 226)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(43, 21)
        Me.Label64.TabIndex = 9
        Me.Label64.Text = "Circus:"
        Me.Label64.UseCompatibleTextRendering = True
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label63.ForeColor = System.Drawing.Color.LightYellow
        Me.Label63.Location = New System.Drawing.Point(121, 145)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(59, 21)
        Me.Label63.TabIndex = 8
        Me.Label63.Text = "Kingdom:"
        Me.Label63.UseCompatibleTextRendering = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label62.ForeColor = System.Drawing.Color.LightYellow
        Me.Label62.Location = New System.Drawing.Point(106, 101)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(43, 21)
        Me.Label62.TabIndex = 7
        Me.Label62.Text = "Circus:"
        Me.Label62.UseCompatibleTextRendering = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label61.ForeColor = System.Drawing.Color.LightYellow
        Me.Label61.Location = New System.Drawing.Point(185, 74)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(85, 21)
        Me.Label61.TabIndex = 6
        Me.Label61.Text = "Strange rocks:"
        Me.Label61.UseCompatibleTextRendering = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label60.ForeColor = System.Drawing.Color.LightYellow
        Me.Label60.Location = New System.Drawing.Point(369, 101)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(58, 21)
        Me.Label60.TabIndex = 5
        Me.Label60.Text = "Penguins:"
        Me.Label60.UseCompatibleTextRendering = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label59.ForeColor = System.Drawing.Color.LightYellow
        Me.Label59.Location = New System.Drawing.Point(297, 74)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(94, 21)
        Me.Label59.TabIndex = 4
        Me.Label59.Text = "Skeletal horror:"
        Me.Label59.UseCompatibleTextRendering = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label58.ForeColor = System.Drawing.Color.LightYellow
        Me.Label58.Location = New System.Drawing.Point(369, 129)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(47, 21)
        Me.Label58.TabIndex = 3
        Me.Label58.Text = "Phenix:"
        Me.Label58.UseCompatibleTextRendering = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label57.ForeColor = System.Drawing.Color.LightYellow
        Me.Label57.Location = New System.Drawing.Point(234, 129)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(90, 21)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "Hankey points:"
        Me.Label57.UseCompatibleTextRendering = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label56.ForeColor = System.Drawing.Color.LightYellow
        Me.Label56.Location = New System.Drawing.Point(273, 163)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(78, 21)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "Guthix tears:"
        Me.Label56.UseCompatibleTextRendering = True
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "Weekly"
        '
        'SuperTabControlPanel7
        '
        Me.SuperTabControlPanel7.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel7.Controls.Add(Me.Label78)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label77)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label76)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label75)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label74)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label73)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label72)
        Me.SuperTabControlPanel7.Controls.Add(Me.Label71)
        Me.SuperTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel7.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel7.Name = "SuperTabControlPanel7"
        Me.SuperTabControlPanel7.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControlPanel7.TabIndex = 0
        Me.SuperTabControlPanel7.TabItem = Me.Shops
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label78.ForeColor = System.Drawing.Color.LightYellow
        Me.Label78.Location = New System.Drawing.Point(50, 228)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(75, 21)
        Me.Label78.TabIndex = 15
        Me.Label78.Text = "Broad bolts:"
        Me.Label78.UseCompatibleTextRendering = True
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label77.ForeColor = System.Drawing.Color.LightYellow
        Me.Label77.Location = New System.Drawing.Point(32, 196)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(93, 21)
        Me.Label77.TabIndex = 14
        Me.Label77.Text = "Raw bird meat:"
        Me.Label77.UseCompatibleTextRendering = True
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label76.ForeColor = System.Drawing.Color.LightYellow
        Me.Label76.Location = New System.Drawing.Point(53, 169)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(70, 21)
        Me.Label76.TabIndex = 13
        Me.Label76.Text = "Yack hides:"
        Me.Label76.UseCompatibleTextRendering = True
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label75.ForeColor = System.Drawing.Color.LightYellow
        Me.Label75.Location = New System.Drawing.Point(19, 142)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(103, 21)
        Me.Label75.TabIndex = 12
        Me.Label75.Text = "Delmonti pinapls:"
        Me.Label75.UseCompatibleTextRendering = True
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label74.ForeColor = System.Drawing.Color.LightYellow
        Me.Label74.Location = New System.Drawing.Point(86, 114)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(36, 21)
        Me.Label74.TabIndex = 11
        Me.Label74.Text = "Vials:"
        Me.Label74.UseCompatibleTextRendering = True
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label73.ForeColor = System.Drawing.Color.LightYellow
        Me.Label73.Location = New System.Drawing.Point(15, 87)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(116, 21)
        Me.Label73.TabIndex = 10
        Me.Label73.Text = "Eye of newt packs:"
        Me.Label73.UseCompatibleTextRendering = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label72.ForeColor = System.Drawing.Color.LightYellow
        Me.Label72.Location = New System.Drawing.Point(64, 63)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(55, 21)
        Me.Label72.TabIndex = 9
        Me.Label72.Text = "Feathers:"
        Me.Label72.UseCompatibleTextRendering = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label71.ForeColor = System.Drawing.Color.LightYellow
        Me.Label71.Location = New System.Drawing.Point(43, 35)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(90, 21)
        Me.Label71.TabIndex = 8
        Me.Label71.Text = "Bolts of cloth:"
        Me.Label71.UseCompatibleTextRendering = True
        '
        'Shops
        '
        Me.Shops.AttachedControl = Me.SuperTabControlPanel7
        Me.Shops.GlobalItem = False
        Me.Shops.Name = "Shops"
        Me.Shops.Text = "Shops"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.SuperTabControlPanel2.Controls.Add(Me.wood)
        Me.SuperTabControlPanel2.Controls.Add(Me.fruit)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem4
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label143)
        Me.GroupPanel1.Controls.Add(Me.Label144)
        Me.GroupPanel1.Controls.Add(Me.Button58)
        Me.GroupPanel1.Controls.Add(Me.Label141)
        Me.GroupPanel1.Controls.Add(Me.Label142)
        Me.GroupPanel1.Controls.Add(Me.Button57)
        Me.GroupPanel1.Controls.Add(Me.Label139)
        Me.GroupPanel1.Controls.Add(Me.Label140)
        Me.GroupPanel1.Controls.Add(Me.Button56)
        Me.GroupPanel1.Controls.Add(Me.Label137)
        Me.GroupPanel1.Controls.Add(Me.Label138)
        Me.GroupPanel1.Controls.Add(Me.Button55)
        Me.GroupPanel1.Controls.Add(Me.Label135)
        Me.GroupPanel1.Controls.Add(Me.Label136)
        Me.GroupPanel1.Controls.Add(Me.Button54)
        Me.GroupPanel1.Controls.Add(Me.Label133)
        Me.GroupPanel1.Controls.Add(Me.Label134)
        Me.GroupPanel1.Controls.Add(Me.Button53)
        Me.GroupPanel1.Controls.Add(Me.Label131)
        Me.GroupPanel1.Controls.Add(Me.Label132)
        Me.GroupPanel1.Controls.Add(Me.Button52)
        Me.GroupPanel1.Controls.Add(Me.Label129)
        Me.GroupPanel1.Controls.Add(Me.Label130)
        Me.GroupPanel1.Controls.Add(Me.Button51)
        Me.GroupPanel1.Controls.Add(Me.Label70)
        Me.GroupPanel1.Controls.Add(Me.Label67)
        Me.GroupPanel1.Controls.Add(Me.Label66)
        Me.GroupPanel1.Controls.Add(Me.Label50)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 353)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(597, 111)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Other"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.BackColor = System.Drawing.Color.Transparent
        Me.Label143.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label143.ForeColor = System.Drawing.Color.LightYellow
        Me.Label143.Location = New System.Drawing.Point(454, 69)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(38, 21)
        Me.Label143.TabIndex = 102
        Me.Label143.Text = "Next:"
        Me.Label143.UseCompatibleTextRendering = True
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.BackColor = System.Drawing.Color.Transparent
        Me.Label144.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label144.ForeColor = System.Drawing.Color.LightYellow
        Me.Label144.Location = New System.Drawing.Point(495, 69)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(76, 21)
        Me.Label144.TabIndex = 103
        Me.Label144.Text = "00:00:00:00"
        Me.Label144.UseCompatibleTextRendering = True
        '
        'Button58
        '
        Me.Button58.BackColor = System.Drawing.Color.Transparent
        Me.Button58.BackgroundImage = CType(resources.GetObject("Button58.BackgroundImage"), System.Drawing.Image)
        Me.Button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button58.FlatAppearance.BorderSize = 0
        Me.Button58.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button58.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button58.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button58.ForeColor = System.Drawing.Color.LightYellow
        Me.Button58.Location = New System.Drawing.Point(378, 66)
        Me.Button58.Name = "Button58"
        Me.Button58.Size = New System.Drawing.Size(77, 22)
        Me.Button58.TabIndex = 101
        Me.Button58.Text = "Gotem"
        Me.Button58.UseCompatibleTextRendering = True
        Me.Button58.UseVisualStyleBackColor = True
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.BackColor = System.Drawing.Color.Transparent
        Me.Label141.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label141.ForeColor = System.Drawing.Color.LightYellow
        Me.Label141.Location = New System.Drawing.Point(454, 48)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(38, 21)
        Me.Label141.TabIndex = 99
        Me.Label141.Text = "Next:"
        Me.Label141.UseCompatibleTextRendering = True
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.BackColor = System.Drawing.Color.Transparent
        Me.Label142.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label142.ForeColor = System.Drawing.Color.LightYellow
        Me.Label142.Location = New System.Drawing.Point(495, 48)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(76, 21)
        Me.Label142.TabIndex = 100
        Me.Label142.Text = "00:00:00:00"
        Me.Label142.UseCompatibleTextRendering = True
        '
        'Button57
        '
        Me.Button57.BackColor = System.Drawing.Color.Transparent
        Me.Button57.BackgroundImage = CType(resources.GetObject("Button57.BackgroundImage"), System.Drawing.Image)
        Me.Button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button57.FlatAppearance.BorderSize = 0
        Me.Button57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button57.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button57.ForeColor = System.Drawing.Color.LightYellow
        Me.Button57.Location = New System.Drawing.Point(378, 45)
        Me.Button57.Name = "Button57"
        Me.Button57.Size = New System.Drawing.Size(77, 22)
        Me.Button57.TabIndex = 98
        Me.Button57.Text = "Gotem"
        Me.Button57.UseCompatibleTextRendering = True
        Me.Button57.UseVisualStyleBackColor = True
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.BackColor = System.Drawing.Color.Transparent
        Me.Label139.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label139.ForeColor = System.Drawing.Color.LightYellow
        Me.Label139.Location = New System.Drawing.Point(454, 27)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(38, 21)
        Me.Label139.TabIndex = 96
        Me.Label139.Text = "Next:"
        Me.Label139.UseCompatibleTextRendering = True
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.BackColor = System.Drawing.Color.Transparent
        Me.Label140.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label140.ForeColor = System.Drawing.Color.LightYellow
        Me.Label140.Location = New System.Drawing.Point(495, 27)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(76, 21)
        Me.Label140.TabIndex = 97
        Me.Label140.Text = "00:00:00:00"
        Me.Label140.UseCompatibleTextRendering = True
        '
        'Button56
        '
        Me.Button56.BackColor = System.Drawing.Color.Transparent
        Me.Button56.BackgroundImage = CType(resources.GetObject("Button56.BackgroundImage"), System.Drawing.Image)
        Me.Button56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button56.FlatAppearance.BorderSize = 0
        Me.Button56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button56.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button56.ForeColor = System.Drawing.Color.LightYellow
        Me.Button56.Location = New System.Drawing.Point(378, 24)
        Me.Button56.Name = "Button56"
        Me.Button56.Size = New System.Drawing.Size(77, 22)
        Me.Button56.TabIndex = 95
        Me.Button56.Text = "Gotem"
        Me.Button56.UseCompatibleTextRendering = True
        Me.Button56.UseVisualStyleBackColor = True
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.BackColor = System.Drawing.Color.Transparent
        Me.Label137.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label137.ForeColor = System.Drawing.Color.LightYellow
        Me.Label137.Location = New System.Drawing.Point(454, 5)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(38, 21)
        Me.Label137.TabIndex = 93
        Me.Label137.Text = "Next:"
        Me.Label137.UseCompatibleTextRendering = True
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.BackColor = System.Drawing.Color.Transparent
        Me.Label138.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label138.ForeColor = System.Drawing.Color.LightYellow
        Me.Label138.Location = New System.Drawing.Point(495, 5)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(76, 21)
        Me.Label138.TabIndex = 94
        Me.Label138.Text = "00:00:00:00"
        Me.Label138.UseCompatibleTextRendering = True
        '
        'Button55
        '
        Me.Button55.BackColor = System.Drawing.Color.Transparent
        Me.Button55.BackgroundImage = CType(resources.GetObject("Button55.BackgroundImage"), System.Drawing.Image)
        Me.Button55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button55.FlatAppearance.BorderSize = 0
        Me.Button55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button55.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button55.ForeColor = System.Drawing.Color.LightYellow
        Me.Button55.Location = New System.Drawing.Point(378, 2)
        Me.Button55.Name = "Button55"
        Me.Button55.Size = New System.Drawing.Size(77, 22)
        Me.Button55.TabIndex = 92
        Me.Button55.Text = "Gotem"
        Me.Button55.UseCompatibleTextRendering = True
        Me.Button55.UseVisualStyleBackColor = True
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.BackColor = System.Drawing.Color.Transparent
        Me.Label135.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label135.ForeColor = System.Drawing.Color.LightYellow
        Me.Label135.Location = New System.Drawing.Point(166, 69)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(38, 21)
        Me.Label135.TabIndex = 90
        Me.Label135.Text = "Next:"
        Me.Label135.UseCompatibleTextRendering = True
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.BackColor = System.Drawing.Color.Transparent
        Me.Label136.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label136.ForeColor = System.Drawing.Color.LightYellow
        Me.Label136.Location = New System.Drawing.Point(207, 69)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(76, 21)
        Me.Label136.TabIndex = 91
        Me.Label136.Text = "00:00:00:00"
        Me.Label136.UseCompatibleTextRendering = True
        '
        'Button54
        '
        Me.Button54.BackColor = System.Drawing.Color.Transparent
        Me.Button54.BackgroundImage = CType(resources.GetObject("Button54.BackgroundImage"), System.Drawing.Image)
        Me.Button54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button54.FlatAppearance.BorderSize = 0
        Me.Button54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button54.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button54.ForeColor = System.Drawing.Color.LightYellow
        Me.Button54.Location = New System.Drawing.Point(90, 67)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(77, 22)
        Me.Button54.TabIndex = 89
        Me.Button54.Text = "Gotem"
        Me.Button54.UseCompatibleTextRendering = True
        Me.Button54.UseVisualStyleBackColor = True
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.BackColor = System.Drawing.Color.Transparent
        Me.Label133.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label133.ForeColor = System.Drawing.Color.LightYellow
        Me.Label133.Location = New System.Drawing.Point(166, 49)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(38, 21)
        Me.Label133.TabIndex = 87
        Me.Label133.Text = "Next:"
        Me.Label133.UseCompatibleTextRendering = True
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.BackColor = System.Drawing.Color.Transparent
        Me.Label134.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label134.ForeColor = System.Drawing.Color.LightYellow
        Me.Label134.Location = New System.Drawing.Point(207, 49)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(76, 21)
        Me.Label134.TabIndex = 88
        Me.Label134.Text = "00:00:00:00"
        Me.Label134.UseCompatibleTextRendering = True
        '
        'Button53
        '
        Me.Button53.BackColor = System.Drawing.Color.Transparent
        Me.Button53.BackgroundImage = CType(resources.GetObject("Button53.BackgroundImage"), System.Drawing.Image)
        Me.Button53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button53.FlatAppearance.BorderSize = 0
        Me.Button53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button53.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button53.ForeColor = System.Drawing.Color.LightYellow
        Me.Button53.Location = New System.Drawing.Point(90, 46)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(77, 22)
        Me.Button53.TabIndex = 86
        Me.Button53.Text = "Gotem"
        Me.Button53.UseCompatibleTextRendering = True
        Me.Button53.UseVisualStyleBackColor = True
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.BackColor = System.Drawing.Color.Transparent
        Me.Label131.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label131.ForeColor = System.Drawing.Color.LightYellow
        Me.Label131.Location = New System.Drawing.Point(166, 27)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(38, 21)
        Me.Label131.TabIndex = 84
        Me.Label131.Text = "Next:"
        Me.Label131.UseCompatibleTextRendering = True
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.BackColor = System.Drawing.Color.Transparent
        Me.Label132.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label132.ForeColor = System.Drawing.Color.LightYellow
        Me.Label132.Location = New System.Drawing.Point(207, 27)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(76, 21)
        Me.Label132.TabIndex = 85
        Me.Label132.Text = "00:00:00:00"
        Me.Label132.UseCompatibleTextRendering = True
        '
        'Button52
        '
        Me.Button52.BackColor = System.Drawing.Color.Transparent
        Me.Button52.BackgroundImage = CType(resources.GetObject("Button52.BackgroundImage"), System.Drawing.Image)
        Me.Button52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button52.FlatAppearance.BorderSize = 0
        Me.Button52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button52.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button52.ForeColor = System.Drawing.Color.LightYellow
        Me.Button52.Location = New System.Drawing.Point(90, 24)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(77, 22)
        Me.Button52.TabIndex = 83
        Me.Button52.Text = "Gotem"
        Me.Button52.UseCompatibleTextRendering = True
        Me.Button52.UseVisualStyleBackColor = True
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.BackColor = System.Drawing.Color.Transparent
        Me.Label129.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label129.ForeColor = System.Drawing.Color.LightYellow
        Me.Label129.Location = New System.Drawing.Point(166, 5)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(38, 21)
        Me.Label129.TabIndex = 81
        Me.Label129.Text = "Next:"
        Me.Label129.UseCompatibleTextRendering = True
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.BackColor = System.Drawing.Color.Transparent
        Me.Label130.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label130.ForeColor = System.Drawing.Color.LightYellow
        Me.Label130.Location = New System.Drawing.Point(207, 5)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(76, 21)
        Me.Label130.TabIndex = 82
        Me.Label130.Text = "00:00:00:00"
        Me.Label130.UseCompatibleTextRendering = True
        '
        'Button51
        '
        Me.Button51.BackColor = System.Drawing.Color.Transparent
        Me.Button51.BackgroundImage = CType(resources.GetObject("Button51.BackgroundImage"), System.Drawing.Image)
        Me.Button51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button51.FlatAppearance.BorderSize = 0
        Me.Button51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button51.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button51.ForeColor = System.Drawing.Color.LightYellow
        Me.Button51.Location = New System.Drawing.Point(90, 2)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(77, 22)
        Me.Button51.TabIndex = 81
        Me.Button51.Text = "Gotem"
        Me.Button51.UseCompatibleTextRendering = True
        Me.Button51.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label70.ForeColor = System.Drawing.Color.LightYellow
        Me.Label70.Location = New System.Drawing.Point(339, 68)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(35, 21)
        Me.Label70.TabIndex = 10
        Me.Label70.Text = "Sand:"
        Me.Label70.UseCompatibleTextRendering = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label67.ForeColor = System.Drawing.Color.LightYellow
        Me.Label67.Location = New System.Drawing.Point(314, 49)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(60, 21)
        Me.Label67.TabIndex = 9
        Me.Label67.Text = "Evil tree:"
        Me.Label67.UseCompatibleTextRendering = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label66.ForeColor = System.Drawing.Color.LightYellow
        Me.Label66.Location = New System.Drawing.Point(290, 5)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(84, 21)
        Me.Label66.TabIndex = 8
        Me.Label66.Text = "Shooting star:"
        Me.Label66.UseCompatibleTextRendering = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label50.ForeColor = System.Drawing.Color.LightYellow
        Me.Label50.Location = New System.Drawing.Point(341, 27)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 21)
        Me.Label50.TabIndex = 7
        Me.Label50.Text = "Flax:"
        Me.Label50.UseCompatibleTextRendering = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.LightYellow
        Me.Label16.Location = New System.Drawing.Point(19, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Ardy Ess:"
        Me.Label16.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.LightYellow
        Me.Label10.Location = New System.Drawing.Point(8, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Zaffs staffs:"
        Me.Label10.UseCompatibleTextRendering = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.LightYellow
        Me.Label12.Location = New System.Drawing.Point(2, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 21)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Wicked hood:"
        Me.Label12.UseCompatibleTextRendering = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.LightYellow
        Me.Label11.Location = New System.Drawing.Point(46, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Bork:"
        Me.Label11.UseCompatibleTextRendering = True
        '
        'wood
        '
        Me.wood.BackColor = System.Drawing.Color.Transparent
        Me.wood.CanvasColor = System.Drawing.Color.Transparent
        Me.wood.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.wood.Controls.Add(Me.Label107)
        Me.wood.Controls.Add(Me.Wood_tree)
        Me.wood.Controls.Add(Me.Button29)
        Me.wood.Controls.Add(Me.Wood_Taverley)
        Me.wood.Controls.Add(Me.Button30)
        Me.wood.Controls.Add(Me.Wood_Falador)
        Me.wood.Controls.Add(Me.Label108)
        Me.wood.Controls.Add(Me.Wood_Varrock)
        Me.wood.Controls.Add(Me.Label109)
        Me.wood.Controls.Add(Me.Label31)
        Me.wood.Controls.Add(Me.Button31)
        Me.wood.Controls.Add(Me.Wood_lumbridge)
        Me.wood.Controls.Add(Me.Button32)
        Me.wood.Controls.Add(Me.Label32)
        Me.wood.Controls.Add(Me.Label110)
        Me.wood.Controls.Add(Me.Label47)
        Me.wood.Controls.Add(Me.Label111)
        Me.wood.Controls.Add(Me.Label41)
        Me.wood.Controls.Add(Me.Button33)
        Me.wood.Controls.Add(Me.Label46)
        Me.wood.Controls.Add(Me.Button34)
        Me.wood.Controls.Add(Me.Button37)
        Me.wood.Controls.Add(Me.Label112)
        Me.wood.Controls.Add(Me.Label116)
        Me.wood.Controls.Add(Me.Label113)
        Me.wood.Controls.Add(Me.Button38)
        Me.wood.Controls.Add(Me.Button35)
        Me.wood.Controls.Add(Me.Label115)
        Me.wood.Controls.Add(Me.Button36)
        Me.wood.Controls.Add(Me.Label114)
        Me.wood.Location = New System.Drawing.Point(3, 191)
        Me.wood.Name = "wood"
        Me.wood.Size = New System.Drawing.Size(597, 156)
        '
        '
        '
        Me.wood.Style.BackColor = System.Drawing.Color.Transparent
        Me.wood.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.wood.Style.BackColorGradientAngle = 90
        Me.wood.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.wood.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.wood.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.wood.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.wood.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.wood.Style.Class = ""
        Me.wood.Style.CornerDiameter = 4
        Me.wood.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.wood.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.wood.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.wood.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.wood.StyleMouseDown.Class = ""
        Me.wood.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.wood.StyleMouseOver.Class = ""
        Me.wood.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.wood.TabIndex = 1
        Me.wood.Text = "Wood tree"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label107.ForeColor = System.Drawing.Color.LightYellow
        Me.Label107.Location = New System.Drawing.Point(516, 112)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(76, 21)
        Me.Label107.TabIndex = 80
        Me.Label107.Text = "00:00:00:00"
        Me.Label107.UseCompatibleTextRendering = True
        '
        'Wood_tree
        '
        Me.Wood_tree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Wood_tree.FormattingEnabled = True
        Me.Wood_tree.Items.AddRange(New Object() {"Oak", "Willow", "Maple", "Yew", "Magic"})
        Me.Wood_tree.Location = New System.Drawing.Point(90, 111)
        Me.Wood_tree.Name = "Wood_tree"
        Me.Wood_tree.Size = New System.Drawing.Size(156, 21)
        Me.Wood_tree.TabIndex = 20
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Transparent
        Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
        Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button29.FlatAppearance.BorderSize = 0
        Me.Button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button29.ForeColor = System.Drawing.Color.LightYellow
        Me.Button29.Location = New System.Drawing.Point(252, 109)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(77, 22)
        Me.Button29.TabIndex = 77
        Me.Button29.Text = "Planted"
        Me.Button29.UseCompatibleTextRendering = True
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Wood_Taverley
        '
        Me.Wood_Taverley.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Wood_Taverley.FormattingEnabled = True
        Me.Wood_Taverley.Items.AddRange(New Object() {"Oak", "Willow", "Maple", "Yew", "Magic"})
        Me.Wood_Taverley.Location = New System.Drawing.Point(90, 84)
        Me.Wood_Taverley.Name = "Wood_Taverley"
        Me.Wood_Taverley.Size = New System.Drawing.Size(156, 21)
        Me.Wood_Taverley.TabIndex = 19
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.Transparent
        Me.Button30.BackgroundImage = CType(resources.GetObject("Button30.BackgroundImage"), System.Drawing.Image)
        Me.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button30.FlatAppearance.BorderSize = 0
        Me.Button30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button30.ForeColor = System.Drawing.Color.LightYellow
        Me.Button30.Location = New System.Drawing.Point(335, 110)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(77, 21)
        Me.Button30.TabIndex = 78
        Me.Button30.Text = "Cancel"
        Me.Button30.UseCompatibleTextRendering = True
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Wood_Falador
        '
        Me.Wood_Falador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Wood_Falador.FormattingEnabled = True
        Me.Wood_Falador.Items.AddRange(New Object() {"Oak", "Willow", "Maple", "Yew", "Magic"})
        Me.Wood_Falador.Location = New System.Drawing.Point(90, 57)
        Me.Wood_Falador.Name = "Wood_Falador"
        Me.Wood_Falador.Size = New System.Drawing.Size(156, 21)
        Me.Wood_Falador.TabIndex = 18
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label108.ForeColor = System.Drawing.Color.LightYellow
        Me.Label108.Location = New System.Drawing.Point(418, 112)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(95, 21)
        Me.Label108.TabIndex = 79
        Me.Label108.Text = "Time remaining:"
        Me.Label108.UseCompatibleTextRendering = True
        '
        'Wood_Varrock
        '
        Me.Wood_Varrock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Wood_Varrock.FormattingEnabled = True
        Me.Wood_Varrock.Items.AddRange(New Object() {"Oak", "Willow", "Maple", "Yew", "Magic"})
        Me.Wood_Varrock.Location = New System.Drawing.Point(90, 30)
        Me.Wood_Varrock.Name = "Wood_Varrock"
        Me.Wood_Varrock.Size = New System.Drawing.Size(156, 21)
        Me.Wood_Varrock.TabIndex = 17
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label109.ForeColor = System.Drawing.Color.LightYellow
        Me.Label109.Location = New System.Drawing.Point(516, 85)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(76, 21)
        Me.Label109.TabIndex = 76
        Me.Label109.Text = "00:00:00:00"
        Me.Label109.UseCompatibleTextRendering = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.LightYellow
        Me.Label31.Location = New System.Drawing.Point(33, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 21)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Falador:"
        Me.Label31.UseCompatibleTextRendering = True
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.Transparent
        Me.Button31.BackgroundImage = CType(resources.GetObject("Button31.BackgroundImage"), System.Drawing.Image)
        Me.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button31.FlatAppearance.BorderSize = 0
        Me.Button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button31.ForeColor = System.Drawing.Color.LightYellow
        Me.Button31.Location = New System.Drawing.Point(252, 82)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(77, 22)
        Me.Button31.TabIndex = 73
        Me.Button31.Text = "Planted"
        Me.Button31.UseCompatibleTextRendering = True
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Wood_lumbridge
        '
        Me.Wood_lumbridge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Wood_lumbridge.FormattingEnabled = True
        Me.Wood_lumbridge.Items.AddRange(New Object() {"Oak", "Willow", "Maple", "Yew", "Magic"})
        Me.Wood_lumbridge.Location = New System.Drawing.Point(90, 3)
        Me.Wood_lumbridge.Name = "Wood_lumbridge"
        Me.Wood_lumbridge.Size = New System.Drawing.Size(156, 21)
        Me.Wood_lumbridge.TabIndex = 12
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.Transparent
        Me.Button32.BackgroundImage = CType(resources.GetObject("Button32.BackgroundImage"), System.Drawing.Image)
        Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button32.ForeColor = System.Drawing.Color.LightYellow
        Me.Button32.Location = New System.Drawing.Point(335, 83)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(77, 21)
        Me.Button32.TabIndex = 74
        Me.Button32.Text = "Cancel"
        Me.Button32.UseCompatibleTextRendering = True
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.LightYellow
        Me.Label32.Location = New System.Drawing.Point(8, 112)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 21)
        Me.Label32.TabIndex = 16
        Me.Label32.Text = "Tree gnome:"
        Me.Label32.UseCompatibleTextRendering = True
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.BackColor = System.Drawing.Color.Transparent
        Me.Label110.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label110.ForeColor = System.Drawing.Color.LightYellow
        Me.Label110.Location = New System.Drawing.Point(418, 85)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(95, 21)
        Me.Label110.TabIndex = 75
        Me.Label110.Text = "Time remaining:"
        Me.Label110.UseCompatibleTextRendering = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label47.ForeColor = System.Drawing.Color.LightYellow
        Me.Label47.Location = New System.Drawing.Point(17, 2)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(67, 21)
        Me.Label47.TabIndex = 12
        Me.Label47.Text = "Lumbridge:"
        Me.Label47.UseCompatibleTextRendering = True
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.BackColor = System.Drawing.Color.Transparent
        Me.Label111.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label111.ForeColor = System.Drawing.Color.LightYellow
        Me.Label111.Location = New System.Drawing.Point(516, 59)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(76, 21)
        Me.Label111.TabIndex = 72
        Me.Label111.Text = "00:00:00:00"
        Me.Label111.UseCompatibleTextRendering = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.LightYellow
        Me.Label41.Location = New System.Drawing.Point(26, 85)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(57, 21)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "Taverley:"
        Me.Label41.UseCompatibleTextRendering = True
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.Transparent
        Me.Button33.BackgroundImage = CType(resources.GetObject("Button33.BackgroundImage"), System.Drawing.Image)
        Me.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button33.FlatAppearance.BorderSize = 0
        Me.Button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button33.ForeColor = System.Drawing.Color.LightYellow
        Me.Button33.Location = New System.Drawing.Point(252, 56)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(77, 22)
        Me.Button33.TabIndex = 69
        Me.Button33.Text = "Planted"
        Me.Button33.UseCompatibleTextRendering = True
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label46.ForeColor = System.Drawing.Color.LightYellow
        Me.Label46.Location = New System.Drawing.Point(31, 32)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(53, 21)
        Me.Label46.TabIndex = 14
        Me.Label46.Text = "Varrock:"
        Me.Label46.UseCompatibleTextRendering = True
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.Transparent
        Me.Button34.BackgroundImage = CType(resources.GetObject("Button34.BackgroundImage"), System.Drawing.Image)
        Me.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button34.FlatAppearance.BorderSize = 0
        Me.Button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button34.ForeColor = System.Drawing.Color.LightYellow
        Me.Button34.Location = New System.Drawing.Point(335, 57)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(77, 21)
        Me.Button34.TabIndex = 70
        Me.Button34.Text = "Cancel"
        Me.Button34.UseCompatibleTextRendering = True
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.Transparent
        Me.Button37.BackgroundImage = CType(resources.GetObject("Button37.BackgroundImage"), System.Drawing.Image)
        Me.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button37.FlatAppearance.BorderSize = 0
        Me.Button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button37.ForeColor = System.Drawing.Color.LightYellow
        Me.Button37.Location = New System.Drawing.Point(252, 3)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(77, 22)
        Me.Button37.TabIndex = 61
        Me.Button37.Text = "Planted"
        Me.Button37.UseCompatibleTextRendering = True
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.BackColor = System.Drawing.Color.Transparent
        Me.Label112.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label112.ForeColor = System.Drawing.Color.LightYellow
        Me.Label112.Location = New System.Drawing.Point(418, 59)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(95, 21)
        Me.Label112.TabIndex = 71
        Me.Label112.Text = "Time remaining:"
        Me.Label112.UseCompatibleTextRendering = True
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.BackColor = System.Drawing.Color.Transparent
        Me.Label116.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label116.ForeColor = System.Drawing.Color.LightYellow
        Me.Label116.Location = New System.Drawing.Point(418, 6)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(95, 21)
        Me.Label116.TabIndex = 63
        Me.Label116.Text = "Time remaining:"
        Me.Label116.UseCompatibleTextRendering = True
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.BackColor = System.Drawing.Color.Transparent
        Me.Label113.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label113.ForeColor = System.Drawing.Color.LightYellow
        Me.Label113.Location = New System.Drawing.Point(516, 32)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(76, 21)
        Me.Label113.TabIndex = 68
        Me.Label113.Text = "00:00:00:00"
        Me.Label113.UseCompatibleTextRendering = True
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.Transparent
        Me.Button38.BackgroundImage = CType(resources.GetObject("Button38.BackgroundImage"), System.Drawing.Image)
        Me.Button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button38.FlatAppearance.BorderSize = 0
        Me.Button38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button38.ForeColor = System.Drawing.Color.LightYellow
        Me.Button38.Location = New System.Drawing.Point(335, 4)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(77, 21)
        Me.Button38.TabIndex = 62
        Me.Button38.Text = "Cancel"
        Me.Button38.UseCompatibleTextRendering = True
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.Transparent
        Me.Button35.BackgroundImage = CType(resources.GetObject("Button35.BackgroundImage"), System.Drawing.Image)
        Me.Button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button35.FlatAppearance.BorderSize = 0
        Me.Button35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button35.ForeColor = System.Drawing.Color.LightYellow
        Me.Button35.Location = New System.Drawing.Point(252, 29)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(77, 22)
        Me.Button35.TabIndex = 65
        Me.Button35.Text = "Planted"
        Me.Button35.UseCompatibleTextRendering = True
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.BackColor = System.Drawing.Color.Transparent
        Me.Label115.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label115.ForeColor = System.Drawing.Color.LightYellow
        Me.Label115.Location = New System.Drawing.Point(516, 6)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(76, 21)
        Me.Label115.TabIndex = 64
        Me.Label115.Text = "00:00:00:00"
        Me.Label115.UseCompatibleTextRendering = True
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Transparent
        Me.Button36.BackgroundImage = CType(resources.GetObject("Button36.BackgroundImage"), System.Drawing.Image)
        Me.Button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button36.FlatAppearance.BorderSize = 0
        Me.Button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button36.ForeColor = System.Drawing.Color.LightYellow
        Me.Button36.Location = New System.Drawing.Point(335, 30)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(77, 21)
        Me.Button36.TabIndex = 66
        Me.Button36.Text = "Cancel"
        Me.Button36.UseCompatibleTextRendering = True
        Me.Button36.UseVisualStyleBackColor = True
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.BackColor = System.Drawing.Color.Transparent
        Me.Label114.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label114.ForeColor = System.Drawing.Color.LightYellow
        Me.Label114.Location = New System.Drawing.Point(418, 32)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(95, 21)
        Me.Label114.TabIndex = 67
        Me.Label114.Text = "Time remaining:"
        Me.Label114.UseCompatibleTextRendering = True
        '
        'fruit
        '
        Me.fruit.BackColor = System.Drawing.Color.Transparent
        Me.fruit.CanvasColor = System.Drawing.Color.Transparent
        Me.fruit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.fruit.Controls.Add(Me.Label103)
        Me.fruit.Controls.Add(Me.Button25)
        Me.fruit.Controls.Add(Me.Button26)
        Me.fruit.Controls.Add(Me.Label104)
        Me.fruit.Controls.Add(Me.Label105)
        Me.fruit.Controls.Add(Me.Button27)
        Me.fruit.Controls.Add(Me.Button28)
        Me.fruit.Controls.Add(Me.Label106)
        Me.fruit.Controls.Add(Me.Label95)
        Me.fruit.Controls.Add(Me.Button17)
        Me.fruit.Controls.Add(Me.Button18)
        Me.fruit.Controls.Add(Me.Label96)
        Me.fruit.Controls.Add(Me.Label97)
        Me.fruit.Controls.Add(Me.Button19)
        Me.fruit.Controls.Add(Me.Button20)
        Me.fruit.Controls.Add(Me.Label98)
        Me.fruit.Controls.Add(Me.Label99)
        Me.fruit.Controls.Add(Me.Button21)
        Me.fruit.Controls.Add(Me.Button22)
        Me.fruit.Controls.Add(Me.Label100)
        Me.fruit.Controls.Add(Me.Label101)
        Me.fruit.Controls.Add(Me.Button23)
        Me.fruit.Controls.Add(Me.Button24)
        Me.fruit.Controls.Add(Me.Label102)
        Me.fruit.Controls.Add(Me.Label28)
        Me.fruit.Controls.Add(Me.Label26)
        Me.fruit.Controls.Add(Me.Label29)
        Me.fruit.Controls.Add(Me.Fruit_herb)
        Me.fruit.Controls.Add(Me.Label30)
        Me.fruit.Controls.Add(Me.Fruit_lieya)
        Me.fruit.Controls.Add(Me.Fruit_Brimhaven)
        Me.fruit.Controls.Add(Me.Fruit_Catherby)
        Me.fruit.Controls.Add(Me.Fruit_Gnomestong)
        Me.fruit.Controls.Add(Me.Label27)
        Me.fruit.Controls.Add(Me.Label25)
        Me.fruit.Controls.Add(Me.Fruit_Gnomemaze)
        Me.fruit.Location = New System.Drawing.Point(3, 3)
        Me.fruit.Name = "fruit"
        Me.fruit.Size = New System.Drawing.Size(597, 182)
        '
        '
        '
        Me.fruit.Style.BackColor = System.Drawing.Color.Transparent
        Me.fruit.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.fruit.Style.BackColorGradientAngle = 90
        Me.fruit.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fruit.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.fruit.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fruit.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fruit.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fruit.Style.Class = ""
        Me.fruit.Style.CornerDiameter = 4
        Me.fruit.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.fruit.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.fruit.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.fruit.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.fruit.StyleMouseDown.Class = ""
        Me.fruit.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.fruit.StyleMouseOver.Class = ""
        Me.fruit.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fruit.TabIndex = 0
        Me.fruit.Text = "Fruit Tree"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.BackColor = System.Drawing.Color.Transparent
        Me.Label103.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label103.ForeColor = System.Drawing.Color.LightYellow
        Me.Label103.Location = New System.Drawing.Point(516, 141)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(76, 21)
        Me.Label103.TabIndex = 60
        Me.Label103.Text = "00:00:00:00"
        Me.Label103.UseCompatibleTextRendering = True
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.Transparent
        Me.Button25.BackgroundImage = CType(resources.GetObject("Button25.BackgroundImage"), System.Drawing.Image)
        Me.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button25.FlatAppearance.BorderSize = 0
        Me.Button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button25.ForeColor = System.Drawing.Color.LightYellow
        Me.Button25.Location = New System.Drawing.Point(252, 138)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(77, 22)
        Me.Button25.TabIndex = 57
        Me.Button25.Text = "Planted"
        Me.Button25.UseCompatibleTextRendering = True
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.Transparent
        Me.Button26.BackgroundImage = CType(resources.GetObject("Button26.BackgroundImage"), System.Drawing.Image)
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button26.ForeColor = System.Drawing.Color.LightYellow
        Me.Button26.Location = New System.Drawing.Point(335, 139)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(77, 21)
        Me.Button26.TabIndex = 58
        Me.Button26.Text = "Cancel"
        Me.Button26.UseCompatibleTextRendering = True
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.BackColor = System.Drawing.Color.Transparent
        Me.Label104.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label104.ForeColor = System.Drawing.Color.LightYellow
        Me.Label104.Location = New System.Drawing.Point(418, 141)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(95, 21)
        Me.Label104.TabIndex = 59
        Me.Label104.Text = "Time remaining:"
        Me.Label104.UseCompatibleTextRendering = True
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.Transparent
        Me.Label105.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label105.ForeColor = System.Drawing.Color.LightYellow
        Me.Label105.Location = New System.Drawing.Point(516, 114)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(76, 21)
        Me.Label105.TabIndex = 56
        Me.Label105.Text = "00:00:00:00"
        Me.Label105.UseCompatibleTextRendering = True
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Transparent
        Me.Button27.BackgroundImage = CType(resources.GetObject("Button27.BackgroundImage"), System.Drawing.Image)
        Me.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button27.FlatAppearance.BorderSize = 0
        Me.Button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button27.ForeColor = System.Drawing.Color.LightYellow
        Me.Button27.Location = New System.Drawing.Point(252, 111)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(77, 22)
        Me.Button27.TabIndex = 53
        Me.Button27.Text = "Planted"
        Me.Button27.UseCompatibleTextRendering = True
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.Transparent
        Me.Button28.BackgroundImage = CType(resources.GetObject("Button28.BackgroundImage"), System.Drawing.Image)
        Me.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button28.FlatAppearance.BorderSize = 0
        Me.Button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button28.ForeColor = System.Drawing.Color.LightYellow
        Me.Button28.Location = New System.Drawing.Point(335, 112)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(77, 21)
        Me.Button28.TabIndex = 54
        Me.Button28.Text = "Cancel"
        Me.Button28.UseCompatibleTextRendering = True
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Transparent
        Me.Label106.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label106.ForeColor = System.Drawing.Color.LightYellow
        Me.Label106.Location = New System.Drawing.Point(418, 114)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(95, 21)
        Me.Label106.TabIndex = 55
        Me.Label106.Text = "Time remaining:"
        Me.Label106.UseCompatibleTextRendering = True
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label95.ForeColor = System.Drawing.Color.LightYellow
        Me.Label95.Location = New System.Drawing.Point(516, 88)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(76, 21)
        Me.Label95.TabIndex = 52
        Me.Label95.Text = "00:00:00:00"
        Me.Label95.UseCompatibleTextRendering = True
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button17.ForeColor = System.Drawing.Color.LightYellow
        Me.Button17.Location = New System.Drawing.Point(252, 85)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(77, 22)
        Me.Button17.TabIndex = 49
        Me.Button17.Text = "Planted"
        Me.Button17.UseCompatibleTextRendering = True
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button18.ForeColor = System.Drawing.Color.LightYellow
        Me.Button18.Location = New System.Drawing.Point(335, 86)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(77, 21)
        Me.Button18.TabIndex = 50
        Me.Button18.Text = "Cancel"
        Me.Button18.UseCompatibleTextRendering = True
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label96.ForeColor = System.Drawing.Color.LightYellow
        Me.Label96.Location = New System.Drawing.Point(418, 88)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(95, 21)
        Me.Label96.TabIndex = 51
        Me.Label96.Text = "Time remaining:"
        Me.Label96.UseCompatibleTextRendering = True
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label97.ForeColor = System.Drawing.Color.LightYellow
        Me.Label97.Location = New System.Drawing.Point(516, 61)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(76, 21)
        Me.Label97.TabIndex = 48
        Me.Label97.Text = "00:00:00:00"
        Me.Label97.UseCompatibleTextRendering = True
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button19.ForeColor = System.Drawing.Color.LightYellow
        Me.Button19.Location = New System.Drawing.Point(252, 58)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(77, 22)
        Me.Button19.TabIndex = 45
        Me.Button19.Text = "Planted"
        Me.Button19.UseCompatibleTextRendering = True
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Transparent
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button20.ForeColor = System.Drawing.Color.LightYellow
        Me.Button20.Location = New System.Drawing.Point(335, 59)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(77, 21)
        Me.Button20.TabIndex = 46
        Me.Button20.Text = "Cancel"
        Me.Button20.UseCompatibleTextRendering = True
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label98.ForeColor = System.Drawing.Color.LightYellow
        Me.Label98.Location = New System.Drawing.Point(418, 61)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(95, 21)
        Me.Label98.TabIndex = 47
        Me.Label98.Text = "Time remaining:"
        Me.Label98.UseCompatibleTextRendering = True
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label99.ForeColor = System.Drawing.Color.LightYellow
        Me.Label99.Location = New System.Drawing.Point(516, 35)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(76, 21)
        Me.Label99.TabIndex = 44
        Me.Label99.Text = "00:00:00:00"
        Me.Label99.UseCompatibleTextRendering = True
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Transparent
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button21.ForeColor = System.Drawing.Color.LightYellow
        Me.Button21.Location = New System.Drawing.Point(252, 32)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(77, 22)
        Me.Button21.TabIndex = 41
        Me.Button21.Text = "Planted"
        Me.Button21.UseCompatibleTextRendering = True
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.Transparent
        Me.Button22.BackgroundImage = CType(resources.GetObject("Button22.BackgroundImage"), System.Drawing.Image)
        Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button22.ForeColor = System.Drawing.Color.LightYellow
        Me.Button22.Location = New System.Drawing.Point(335, 33)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(77, 21)
        Me.Button22.TabIndex = 42
        Me.Button22.Text = "Cancel"
        Me.Button22.UseCompatibleTextRendering = True
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label100.ForeColor = System.Drawing.Color.LightYellow
        Me.Label100.Location = New System.Drawing.Point(418, 35)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(95, 21)
        Me.Label100.TabIndex = 43
        Me.Label100.Text = "Time remaining:"
        Me.Label100.UseCompatibleTextRendering = True
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label101.ForeColor = System.Drawing.Color.LightYellow
        Me.Label101.Location = New System.Drawing.Point(516, 8)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(76, 21)
        Me.Label101.TabIndex = 40
        Me.Label101.Text = "00:00:00:00"
        Me.Label101.UseCompatibleTextRendering = True
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.Transparent
        Me.Button23.BackgroundImage = CType(resources.GetObject("Button23.BackgroundImage"), System.Drawing.Image)
        Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button23.ForeColor = System.Drawing.Color.LightYellow
        Me.Button23.Location = New System.Drawing.Point(252, 5)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(77, 22)
        Me.Button23.TabIndex = 37
        Me.Button23.Text = "Planted"
        Me.Button23.UseCompatibleTextRendering = True
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.Transparent
        Me.Button24.BackgroundImage = CType(resources.GetObject("Button24.BackgroundImage"), System.Drawing.Image)
        Me.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button24.FlatAppearance.BorderSize = 0
        Me.Button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button24.ForeColor = System.Drawing.Color.LightYellow
        Me.Button24.Location = New System.Drawing.Point(335, 6)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(77, 21)
        Me.Button24.TabIndex = 38
        Me.Button24.Text = "Cancel"
        Me.Button24.UseCompatibleTextRendering = True
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label102.ForeColor = System.Drawing.Color.LightYellow
        Me.Label102.Location = New System.Drawing.Point(418, 8)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(95, 21)
        Me.Label102.TabIndex = 39
        Me.Label102.Text = "Time remaining:"
        Me.Label102.UseCompatibleTextRendering = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.LightYellow
        Me.Label28.Location = New System.Drawing.Point(3, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 21)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Herb habitat:"
        Me.Label28.UseCompatibleTextRendering = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.LightYellow
        Me.Label26.Location = New System.Drawing.Point(26, 59)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 21)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Catherby:"
        Me.Label26.UseCompatibleTextRendering = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.LightYellow
        Me.Label29.Location = New System.Drawing.Point(45, 114)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 21)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Lieya:"
        Me.Label29.UseCompatibleTextRendering = True
        '
        'Fruit_herb
        '
        Me.Fruit_herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_herb.FormattingEnabled = True
        Me.Fruit_herb.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_herb.Location = New System.Drawing.Point(90, 139)
        Me.Fruit_herb.Name = "Fruit_herb"
        Me.Fruit_herb.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_herb.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.LightYellow
        Me.Label30.Location = New System.Drawing.Point(17, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 21)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Brimhaven:"
        Me.Label30.UseCompatibleTextRendering = True
        '
        'Fruit_lieya
        '
        Me.Fruit_lieya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_lieya.FormattingEnabled = True
        Me.Fruit_lieya.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_lieya.Location = New System.Drawing.Point(90, 112)
        Me.Fruit_lieya.Name = "Fruit_lieya"
        Me.Fruit_lieya.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_lieya.TabIndex = 10
        '
        'Fruit_Brimhaven
        '
        Me.Fruit_Brimhaven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_Brimhaven.FormattingEnabled = True
        Me.Fruit_Brimhaven.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_Brimhaven.Location = New System.Drawing.Point(90, 85)
        Me.Fruit_Brimhaven.Name = "Fruit_Brimhaven"
        Me.Fruit_Brimhaven.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_Brimhaven.TabIndex = 9
        '
        'Fruit_Catherby
        '
        Me.Fruit_Catherby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fruit_Catherby.FormattingEnabled = True
        Me.Fruit_Catherby.Items.AddRange(New Object() {"Apple", "Banana", "Orange", "Curry", "Pineapple", "Papaya", "Palm"})
        Me.Fruit_Catherby.Location = New System.Drawing.Point(90, 58)
        Me.Fruit_Catherby.Name = "Fruit_Catherby"
        Me.Fruit_Catherby.Size = New System.Drawing.Size(156, 21)
        Me.Fruit_Catherby.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.LightYellow
        Me.Label27.Location = New System.Drawing.Point(3, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 21)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Gnome Maze:"
        Me.Label27.UseCompatibleTextRendering = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.LightYellow
        Me.Label25.Location = New System.Drawing.Point(-2, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 21)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Gnome strong:"
        Me.Label25.UseCompatibleTextRendering = True
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Dayly"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel1.Controls.Add(Me.GroupPanel5)
        Me.SuperTabControlPanel1.Controls.Add(Me.GroupPanel3)
        Me.SuperTabControlPanel1.Controls.Add(Me.Bush)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(603, 490)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'GroupPanel5
        '
        Me.GroupPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel5.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.Button49)
        Me.GroupPanel5.Controls.Add(Me.Label55)
        Me.GroupPanel5.Controls.Add(Me.Label127)
        Me.GroupPanel5.Controls.Add(Me.Button50)
        Me.GroupPanel5.Controls.Add(Me.Label128)
        Me.GroupPanel5.Controls.Add(Me.Button47)
        Me.GroupPanel5.Controls.Add(Me.Label125)
        Me.GroupPanel5.Controls.Add(Me.Label14)
        Me.GroupPanel5.Controls.Add(Me.Label20)
        Me.GroupPanel5.Controls.Add(Me.Button48)
        Me.GroupPanel5.Controls.Add(Me.Label126)
        Me.GroupPanel5.Controls.Add(Me.Button45)
        Me.GroupPanel5.Controls.Add(Me.Label8)
        Me.GroupPanel5.Controls.Add(Me.Label123)
        Me.GroupPanel5.Controls.Add(Me.Button46)
        Me.GroupPanel5.Controls.Add(Me.Label124)
        Me.GroupPanel5.Controls.Add(Me.Button43)
        Me.GroupPanel5.Controls.Add(Me.Label121)
        Me.GroupPanel5.Controls.Add(Me.Button44)
        Me.GroupPanel5.Controls.Add(Me.Label122)
        Me.GroupPanel5.Controls.Add(Me.Button41)
        Me.GroupPanel5.Controls.Add(Me.Label119)
        Me.GroupPanel5.Controls.Add(Me.Button42)
        Me.GroupPanel5.Controls.Add(Me.Label120)
        Me.GroupPanel5.Controls.Add(Me.ComboBox5)
        Me.GroupPanel5.Controls.Add(Me.Button39)
        Me.GroupPanel5.Controls.Add(Me.Label117)
        Me.GroupPanel5.Controls.Add(Me.Button40)
        Me.GroupPanel5.Controls.Add(Me.Label118)
        Me.GroupPanel5.Controls.Add(Me.Label21)
        Me.GroupPanel5.Controls.Add(Me.Label13)
        Me.GroupPanel5.Location = New System.Drawing.Point(3, 272)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(600, 192)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel5.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.Class = ""
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.Class = ""
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.Class = ""
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 11
        Me.GroupPanel5.Text = "Other"
        '
        'Button49
        '
        Me.Button49.BackColor = System.Drawing.Color.Transparent
        Me.Button49.BackgroundImage = CType(resources.GetObject("Button49.BackgroundImage"), System.Drawing.Image)
        Me.Button49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button49.FlatAppearance.BorderSize = 0
        Me.Button49.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button49.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button49.ForeColor = System.Drawing.Color.LightYellow
        Me.Button49.Location = New System.Drawing.Point(253, 141)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(77, 22)
        Me.Button49.TabIndex = 63
        Me.Button49.Text = "Planted"
        Me.Button49.UseCompatibleTextRendering = True
        Me.Button49.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label55.ForeColor = System.Drawing.Color.LightYellow
        Me.Label55.Location = New System.Drawing.Point(10, 144)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(67, 21)
        Me.Label55.TabIndex = 9
        Me.Label55.Text = "Mushroom:"
        Me.Label55.UseCompatibleTextRendering = True
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.BackColor = System.Drawing.Color.Transparent
        Me.Label127.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label127.ForeColor = System.Drawing.Color.LightYellow
        Me.Label127.Location = New System.Drawing.Point(419, 144)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(95, 21)
        Me.Label127.TabIndex = 65
        Me.Label127.Text = "Time remaining:"
        Me.Label127.UseCompatibleTextRendering = True
        '
        'Button50
        '
        Me.Button50.BackColor = System.Drawing.Color.Transparent
        Me.Button50.BackgroundImage = CType(resources.GetObject("Button50.BackgroundImage"), System.Drawing.Image)
        Me.Button50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button50.FlatAppearance.BorderSize = 0
        Me.Button50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button50.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button50.ForeColor = System.Drawing.Color.LightYellow
        Me.Button50.Location = New System.Drawing.Point(336, 142)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(77, 21)
        Me.Button50.TabIndex = 64
        Me.Button50.Text = "Cancel"
        Me.Button50.UseCompatibleTextRendering = True
        Me.Button50.UseVisualStyleBackColor = True
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.BackColor = System.Drawing.Color.Transparent
        Me.Label128.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label128.ForeColor = System.Drawing.Color.LightYellow
        Me.Label128.Location = New System.Drawing.Point(517, 144)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(76, 21)
        Me.Label128.TabIndex = 66
        Me.Label128.Text = "00:00:00:00"
        Me.Label128.UseCompatibleTextRendering = True
        '
        'Button47
        '
        Me.Button47.BackColor = System.Drawing.Color.Transparent
        Me.Button47.BackgroundImage = CType(resources.GetObject("Button47.BackgroundImage"), System.Drawing.Image)
        Me.Button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button47.FlatAppearance.BorderSize = 0
        Me.Button47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button47.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button47.ForeColor = System.Drawing.Color.LightYellow
        Me.Button47.Location = New System.Drawing.Point(253, 113)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(77, 22)
        Me.Button47.TabIndex = 59
        Me.Button47.Text = "Planted"
        Me.Button47.UseCompatibleTextRendering = True
        Me.Button47.UseVisualStyleBackColor = True
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.BackColor = System.Drawing.Color.Transparent
        Me.Label125.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label125.ForeColor = System.Drawing.Color.LightYellow
        Me.Label125.Location = New System.Drawing.Point(419, 116)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(95, 21)
        Me.Label125.TabIndex = 61
        Me.Label125.Text = "Time remaining:"
        Me.Label125.UseCompatibleTextRendering = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.LightYellow
        Me.Label14.Location = New System.Drawing.Point(-2, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 21)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Calquat Tree:"
        Me.Label14.UseCompatibleTextRendering = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.LightYellow
        Me.Label20.Location = New System.Drawing.Point(20, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 21)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Beladona:"
        Me.Label20.UseCompatibleTextRendering = True
        '
        'Button48
        '
        Me.Button48.BackColor = System.Drawing.Color.Transparent
        Me.Button48.BackgroundImage = CType(resources.GetObject("Button48.BackgroundImage"), System.Drawing.Image)
        Me.Button48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button48.FlatAppearance.BorderSize = 0
        Me.Button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button48.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button48.ForeColor = System.Drawing.Color.LightYellow
        Me.Button48.Location = New System.Drawing.Point(336, 114)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(77, 21)
        Me.Button48.TabIndex = 60
        Me.Button48.Text = "Cancel"
        Me.Button48.UseCompatibleTextRendering = True
        Me.Button48.UseVisualStyleBackColor = True
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.BackColor = System.Drawing.Color.Transparent
        Me.Label126.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label126.ForeColor = System.Drawing.Color.LightYellow
        Me.Label126.Location = New System.Drawing.Point(517, 116)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(76, 21)
        Me.Label126.TabIndex = 62
        Me.Label126.Text = "00:00:00:00"
        Me.Label126.UseCompatibleTextRendering = True
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.Transparent
        Me.Button45.BackgroundImage = CType(resources.GetObject("Button45.BackgroundImage"), System.Drawing.Image)
        Me.Button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button45.FlatAppearance.BorderSize = 0
        Me.Button45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button45.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button45.ForeColor = System.Drawing.Color.LightYellow
        Me.Button45.Location = New System.Drawing.Point(253, 85)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(77, 22)
        Me.Button45.TabIndex = 55
        Me.Button45.Text = "Planted"
        Me.Button45.UseCompatibleTextRendering = True
        Me.Button45.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.LightYellow
        Me.Label8.Location = New System.Drawing.Point(32, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ternip:"
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.BackColor = System.Drawing.Color.Transparent
        Me.Label123.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label123.ForeColor = System.Drawing.Color.LightYellow
        Me.Label123.Location = New System.Drawing.Point(419, 88)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(95, 21)
        Me.Label123.TabIndex = 57
        Me.Label123.Text = "Time remaining:"
        Me.Label123.UseCompatibleTextRendering = True
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.Transparent
        Me.Button46.BackgroundImage = CType(resources.GetObject("Button46.BackgroundImage"), System.Drawing.Image)
        Me.Button46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button46.FlatAppearance.BorderSize = 0
        Me.Button46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button46.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button46.ForeColor = System.Drawing.Color.LightYellow
        Me.Button46.Location = New System.Drawing.Point(336, 86)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(77, 21)
        Me.Button46.TabIndex = 56
        Me.Button46.Text = "Cancel"
        Me.Button46.UseCompatibleTextRendering = True
        Me.Button46.UseVisualStyleBackColor = True
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.BackColor = System.Drawing.Color.Transparent
        Me.Label124.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label124.ForeColor = System.Drawing.Color.LightYellow
        Me.Label124.Location = New System.Drawing.Point(517, 88)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(76, 21)
        Me.Label124.TabIndex = 58
        Me.Label124.Text = "00:00:00:00"
        Me.Label124.UseCompatibleTextRendering = True
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.Transparent
        Me.Button43.BackgroundImage = CType(resources.GetObject("Button43.BackgroundImage"), System.Drawing.Image)
        Me.Button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button43.FlatAppearance.BorderSize = 0
        Me.Button43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button43.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button43.ForeColor = System.Drawing.Color.LightYellow
        Me.Button43.Location = New System.Drawing.Point(253, 57)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(77, 22)
        Me.Button43.TabIndex = 51
        Me.Button43.Text = "Planted"
        Me.Button43.UseCompatibleTextRendering = True
        Me.Button43.UseVisualStyleBackColor = True
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.BackColor = System.Drawing.Color.Transparent
        Me.Label121.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label121.ForeColor = System.Drawing.Color.LightYellow
        Me.Label121.Location = New System.Drawing.Point(419, 60)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(95, 21)
        Me.Label121.TabIndex = 53
        Me.Label121.Text = "Time remaining:"
        Me.Label121.UseCompatibleTextRendering = True
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.BackgroundImage = CType(resources.GetObject("Button44.BackgroundImage"), System.Drawing.Image)
        Me.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button44.FlatAppearance.BorderSize = 0
        Me.Button44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button44.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button44.ForeColor = System.Drawing.Color.LightYellow
        Me.Button44.Location = New System.Drawing.Point(336, 58)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(77, 21)
        Me.Button44.TabIndex = 52
        Me.Button44.Text = "Cancel"
        Me.Button44.UseCompatibleTextRendering = True
        Me.Button44.UseVisualStyleBackColor = True
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.BackColor = System.Drawing.Color.Transparent
        Me.Label122.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label122.ForeColor = System.Drawing.Color.LightYellow
        Me.Label122.Location = New System.Drawing.Point(517, 60)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(76, 21)
        Me.Label122.TabIndex = 54
        Me.Label122.Text = "00:00:00:00"
        Me.Label122.UseCompatibleTextRendering = True
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.Transparent
        Me.Button41.BackgroundImage = CType(resources.GetObject("Button41.BackgroundImage"), System.Drawing.Image)
        Me.Button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button41.FlatAppearance.BorderSize = 0
        Me.Button41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button41.ForeColor = System.Drawing.Color.LightYellow
        Me.Button41.Location = New System.Drawing.Point(253, 29)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(77, 22)
        Me.Button41.TabIndex = 47
        Me.Button41.Text = "Planted"
        Me.Button41.UseCompatibleTextRendering = True
        Me.Button41.UseVisualStyleBackColor = True
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.BackColor = System.Drawing.Color.Transparent
        Me.Label119.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label119.ForeColor = System.Drawing.Color.LightYellow
        Me.Label119.Location = New System.Drawing.Point(419, 32)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(95, 21)
        Me.Label119.TabIndex = 49
        Me.Label119.Text = "Time remaining:"
        Me.Label119.UseCompatibleTextRendering = True
        '
        'Button42
        '
        Me.Button42.BackColor = System.Drawing.Color.Transparent
        Me.Button42.BackgroundImage = CType(resources.GetObject("Button42.BackgroundImage"), System.Drawing.Image)
        Me.Button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button42.FlatAppearance.BorderSize = 0
        Me.Button42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button42.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button42.ForeColor = System.Drawing.Color.LightYellow
        Me.Button42.Location = New System.Drawing.Point(336, 30)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(77, 21)
        Me.Button42.TabIndex = 48
        Me.Button42.Text = "Cancel"
        Me.Button42.UseCompatibleTextRendering = True
        Me.Button42.UseVisualStyleBackColor = True
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.Color.Transparent
        Me.Label120.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label120.ForeColor = System.Drawing.Color.LightYellow
        Me.Label120.Location = New System.Drawing.Point(517, 32)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(76, 21)
        Me.Label120.TabIndex = 50
        Me.Label120.Text = "00:00:00:00"
        Me.Label120.UseCompatibleTextRendering = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Barley", "Hammerstone", "Asgarnia", "Jute", "Yanillian", "Krandorian", "Wildblood"})
        Me.ComboBox5.Location = New System.Drawing.Point(83, 2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox5.TabIndex = 41
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.Transparent
        Me.Button39.BackgroundImage = CType(resources.GetObject("Button39.BackgroundImage"), System.Drawing.Image)
        Me.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button39.FlatAppearance.BorderSize = 0
        Me.Button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button39.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button39.ForeColor = System.Drawing.Color.LightYellow
        Me.Button39.Location = New System.Drawing.Point(253, 2)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(77, 22)
        Me.Button39.TabIndex = 42
        Me.Button39.Text = "Planted"
        Me.Button39.UseCompatibleTextRendering = True
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.BackColor = System.Drawing.Color.Transparent
        Me.Label117.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label117.ForeColor = System.Drawing.Color.LightYellow
        Me.Label117.Location = New System.Drawing.Point(419, 5)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(95, 21)
        Me.Label117.TabIndex = 44
        Me.Label117.Text = "Time remaining:"
        Me.Label117.UseCompatibleTextRendering = True
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.Transparent
        Me.Button40.BackgroundImage = CType(resources.GetObject("Button40.BackgroundImage"), System.Drawing.Image)
        Me.Button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button40.FlatAppearance.BorderSize = 0
        Me.Button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button40.ForeColor = System.Drawing.Color.LightYellow
        Me.Button40.Location = New System.Drawing.Point(336, 3)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(77, 21)
        Me.Button40.TabIndex = 43
        Me.Button40.Text = "Cancel"
        Me.Button40.UseCompatibleTextRendering = True
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.BackColor = System.Drawing.Color.Transparent
        Me.Label118.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label118.ForeColor = System.Drawing.Color.LightYellow
        Me.Label118.Location = New System.Drawing.Point(517, 5)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(76, 21)
        Me.Label118.TabIndex = 45
        Me.Label118.Text = "00:00:00:00"
        Me.Label118.UseCompatibleTextRendering = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.LightYellow
        Me.Label21.Location = New System.Drawing.Point(32, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 21)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Cactus:"
        Me.Label21.UseCompatibleTextRendering = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.LightYellow
        Me.Label13.Location = New System.Drawing.Point(7, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Spirit Tree:"
        Me.Label13.UseCompatibleTextRendering = True
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Label87)
        Me.GroupPanel3.Controls.Add(Me.ComboBox4)
        Me.GroupPanel3.Controls.Add(Me.Button9)
        Me.GroupPanel3.Controls.Add(Me.ComboBox1)
        Me.GroupPanel3.Controls.Add(Me.Button10)
        Me.GroupPanel3.Controls.Add(Me.Label24)
        Me.GroupPanel3.Controls.Add(Me.Label88)
        Me.GroupPanel3.Controls.Add(Me.Label22)
        Me.GroupPanel3.Controls.Add(Me.Label89)
        Me.GroupPanel3.Controls.Add(Me.ComboBox3)
        Me.GroupPanel3.Controls.Add(Me.Button11)
        Me.GroupPanel3.Controls.Add(Me.Label9)
        Me.GroupPanel3.Controls.Add(Me.Button12)
        Me.GroupPanel3.Controls.Add(Me.ComboBox2)
        Me.GroupPanel3.Controls.Add(Me.Label90)
        Me.GroupPanel3.Controls.Add(Me.Label23)
        Me.GroupPanel3.Controls.Add(Me.Label91)
        Me.GroupPanel3.Controls.Add(Me.Button15)
        Me.GroupPanel3.Controls.Add(Me.Button13)
        Me.GroupPanel3.Controls.Add(Me.Label94)
        Me.GroupPanel3.Controls.Add(Me.Button14)
        Me.GroupPanel3.Controls.Add(Me.Button16)
        Me.GroupPanel3.Controls.Add(Me.Label92)
        Me.GroupPanel3.Controls.Add(Me.Label93)
        Me.GroupPanel3.Location = New System.Drawing.Point(3, 137)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(597, 129)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 10
        Me.GroupPanel3.Text = "Hops"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label87.ForeColor = System.Drawing.Color.LightYellow
        Me.Label87.Location = New System.Drawing.Point(517, 86)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(76, 21)
        Me.Label87.TabIndex = 52
        Me.Label87.Text = "00:00:00:00"
        Me.Label87.UseCompatibleTextRendering = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.LightYellow
        Me.Button9.Location = New System.Drawing.Point(253, 83)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(77, 22)
        Me.Button9.TabIndex = 49
        Me.Button9.Text = "Planted"
        Me.Button9.UseCompatibleTextRendering = True
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button10.ForeColor = System.Drawing.Color.LightYellow
        Me.Button10.Location = New System.Drawing.Point(336, 84)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(77, 21)
        Me.Button10.TabIndex = 50
        Me.Button10.Text = "Cancel"
        Me.Button10.UseCompatibleTextRendering = True
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.LightYellow
        Me.Label24.Location = New System.Drawing.Point(40, 87)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 21)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Entria:"
        Me.Label24.UseCompatibleTextRendering = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label88.ForeColor = System.Drawing.Color.LightYellow
        Me.Label88.Location = New System.Drawing.Point(419, 86)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(95, 21)
        Me.Label88.TabIndex = 51
        Me.Label88.Text = "Time remaining:"
        Me.Label88.UseCompatibleTextRendering = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.LightYellow
        Me.Label22.Location = New System.Drawing.Point(40, 33)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 21)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Seers:"
        Me.Label22.UseCompatibleTextRendering = True
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label89.ForeColor = System.Drawing.Color.LightYellow
        Me.Label89.Location = New System.Drawing.Point(517, 59)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(76, 21)
        Me.Label89.TabIndex = 48
        Me.Label89.Text = "00:00:00:00"
        Me.Label89.UseCompatibleTextRendering = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button11.ForeColor = System.Drawing.Color.LightYellow
        Me.Button11.Location = New System.Drawing.Point(253, 56)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(77, 22)
        Me.Button11.TabIndex = 45
        Me.Button11.Text = "Planted"
        Me.Button11.UseCompatibleTextRendering = True
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.LightYellow
        Me.Label9.Location = New System.Drawing.Point(0, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "North Lumb:"
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button12.ForeColor = System.Drawing.Color.LightYellow
        Me.Button12.Location = New System.Drawing.Point(336, 57)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(77, 21)
        Me.Button12.TabIndex = 46
        Me.Button12.Text = "Cancel"
        Me.Button12.UseCompatibleTextRendering = True
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label90.ForeColor = System.Drawing.Color.LightYellow
        Me.Label90.Location = New System.Drawing.Point(419, 59)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(95, 21)
        Me.Label90.TabIndex = 47
        Me.Label90.Text = "Time remaining:"
        Me.Label90.UseCompatibleTextRendering = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.LightYellow
        Me.Label23.Location = New System.Drawing.Point(34, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 21)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Yanale:"
        Me.Label23.UseCompatibleTextRendering = True
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label91.ForeColor = System.Drawing.Color.LightYellow
        Me.Label91.Location = New System.Drawing.Point(517, 33)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(76, 21)
        Me.Label91.TabIndex = 44
        Me.Label91.Text = "00:00:00:00"
        Me.Label91.UseCompatibleTextRendering = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button15.ForeColor = System.Drawing.Color.LightYellow
        Me.Button15.Location = New System.Drawing.Point(253, 3)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(77, 22)
        Me.Button15.TabIndex = 37
        Me.Button15.Text = "Planted"
        Me.Button15.UseCompatibleTextRendering = True
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button13.ForeColor = System.Drawing.Color.LightYellow
        Me.Button13.Location = New System.Drawing.Point(253, 30)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(77, 22)
        Me.Button13.TabIndex = 41
        Me.Button13.Text = "Planted"
        Me.Button13.UseCompatibleTextRendering = True
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label94.ForeColor = System.Drawing.Color.LightYellow
        Me.Label94.Location = New System.Drawing.Point(419, 6)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(95, 21)
        Me.Label94.TabIndex = 39
        Me.Label94.Text = "Time remaining:"
        Me.Label94.UseCompatibleTextRendering = True
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button14.ForeColor = System.Drawing.Color.LightYellow
        Me.Button14.Location = New System.Drawing.Point(336, 31)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(77, 21)
        Me.Button14.TabIndex = 42
        Me.Button14.Text = "Cancel"
        Me.Button14.UseCompatibleTextRendering = True
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("RuneScape Large", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button16.ForeColor = System.Drawing.Color.LightYellow
        Me.Button16.Location = New System.Drawing.Point(336, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(77, 21)
        Me.Button16.TabIndex = 38
        Me.Button16.Text = "Cancel"
        Me.Button16.UseCompatibleTextRendering = True
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label92.ForeColor = System.Drawing.Color.LightYellow
        Me.Label92.Location = New System.Drawing.Point(419, 33)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(95, 21)
        Me.Label92.TabIndex = 43
        Me.Label92.Text = "Time remaining:"
        Me.Label92.UseCompatibleTextRendering = True
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("RuneScape Large", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label93.ForeColor = System.Drawing.Color.LightYellow
        Me.Label93.Location = New System.Drawing.Point(517, 6)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(76, 21)
        Me.Label93.TabIndex = 40
        Me.Label93.Text = "00:00:00:00"
        Me.Label93.UseCompatibleTextRendering = True
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Other"
        '
        'SuperTabControlPanel6
        '
        Me.SuperTabControlPanel6.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_back
        Me.SuperTabControlPanel6.Controls.Add(Me.Phas)
        Me.SuperTabControlPanel6.Controls.Add(Me.Falador)
        Me.SuperTabControlPanel6.Controls.Add(Me.Catherby)
        Me.SuperTabControlPanel6.Controls.Add(Me.Ardy)
        Me.SuperTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel6.Location = New System.Drawing.Point(0, 23)
        Me.SuperTabControlPanel6.Name = "SuperTabControlPanel6"
        Me.SuperTabControlPanel6.Size = New System.Drawing.Size(603, 467)
        Me.SuperTabControlPanel6.TabIndex = 0
        Me.SuperTabControlPanel6.TabItem = Me.SuperTabItem8
        '
        'SuperTabItem8
        '
        Me.SuperTabItem8.AttachedControl = Me.SuperTabControlPanel6
        Me.SuperTabItem8.BeginGroup = True
        Me.SuperTabItem8.GlobalItem = False
        Me.SuperTabItem8.Name = "SuperTabItem8"
        Me.SuperTabItem8.Text = "Produce"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.Untitled_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 513)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Runescape Timer"
        Me.Phas.ResumeLayout(False)
        Me.Phas.PerformLayout()
        Me.Falador.ResumeLayout(False)
        Me.Falador.PerformLayout()
        Me.Catherby.ResumeLayout(False)
        Me.Catherby.PerformLayout()
        Me.Ardy.ResumeLayout(False)
        Me.Ardy.PerformLayout()
        Me.Bush.ResumeLayout(False)
        Me.Bush.PerformLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        Me.GroupPanel7.PerformLayout()
        Me.GroupPanel6.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.SuperTabControlPanel4.PerformLayout()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.PerformLayout()
        Me.SuperTabControlPanel7.ResumeLayout(False)
        Me.SuperTabControlPanel7.PerformLayout()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.wood.ResumeLayout(False)
        Me.wood.PerformLayout()
        Me.fruit.ResumeLayout(False)
        Me.fruit.PerformLayout()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel5.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.SuperTabControlPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Falador_Flower_Time As rune_label
    Friend WithEvents Falador_Herb_Time As rune_label
    Friend WithEvents Label7 As rune_label
    Friend WithEvents Label6 As rune_label
    Friend WithEvents Label4 As rune_label
    Friend WithEvents Label3 As rune_label
    Friend WithEvents Label2 As rune_label
    Friend WithEvents Label1 As rune_label
    Friend WithEvents Label24 As rune_label
    Friend WithEvents Label23 As rune_label
    Friend WithEvents Label22 As rune_label
    Friend WithEvents Label9 As rune_label
    Friend WithEvents Label19 As rune_label
    Friend WithEvents Label18 As rune_label
    Friend WithEvents Label17 As rune_label
    Friend WithEvents Label5 As rune_label
    Friend WithEvents Bush_Rimmington_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Bush_exe_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Bush_Mons_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Bush_Champ_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Catherby_flower_time As rune_label
    Friend WithEvents Catherby_herb_time As rune_label
    Friend WithEvents Label33 As rune_label
    Friend WithEvents Label34 As rune_label
    Friend WithEvents Catherby_alotment_time As rune_label
    Friend WithEvents Label36 As rune_label
    Friend WithEvents Label37 As rune_label
    Friend WithEvents Label38 As rune_label
    Friend WithEvents Label39 As rune_label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Phas_flower_time As rune_label
    Friend WithEvents Phas_herb_time As rune_label
    Friend WithEvents Label48 As rune_label
    Friend WithEvents Label49 As rune_label
    Friend WithEvents Phas_alotment_time As rune_label
    Friend WithEvents Label51 As rune_label
    Friend WithEvents Label52 As rune_label
    Friend WithEvents Label53 As rune_label
    Friend WithEvents Label54 As rune_label
    Friend WithEvents Ardy_flower_time As rune_label
    Friend WithEvents Ardy_herb_time As rune_label
    Friend WithEvents Label35 As rune_label
    Friend WithEvents Label40 As rune_label
    Friend WithEvents Ardy_Alotment_time As rune_label
    Friend WithEvents Label42 As rune_label
    Friend WithEvents Label43 As rune_label
    Friend WithEvents Label44 As rune_label
    Friend WithEvents Label45 As rune_label
    Friend WithEvents Falador_Alotment As System.Windows.Forms.ComboBox
    Friend WithEvents Falador_Alotment_Time As rune_label
    Friend WithEvents Falador_Flower As System.Windows.Forms.ComboBox
    Friend WithEvents Falador_Herb As System.Windows.Forms.ComboBox
    Friend WithEvents catherby_flower As System.Windows.Forms.ComboBox
    Friend WithEvents catherby_herb As System.Windows.Forms.ComboBox
    Friend WithEvents catherby_alotment As System.Windows.Forms.ComboBox
    Friend WithEvents Ardy_flower As System.Windows.Forms.ComboBox
    Friend WithEvents Ardy_herb As System.Windows.Forms.ComboBox
    Friend WithEvents Ardy_alotment As System.Windows.Forms.ComboBox
    Friend WithEvents Phas_flower As System.Windows.Forms.ComboBox
    Friend WithEvents Phas_herb As System.Windows.Forms.ComboBox
    Friend WithEvents Phas_alotment As System.Windows.Forms.ComboBox
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Falador As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Catherby As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Phas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Ardy As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Bush As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Fruit_Gnomemaze As System.Windows.Forms.ComboBox
    Friend WithEvents Fruit_Gnomestong As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As rune_label
    Friend WithEvents Label16 As rune_label
    Friend WithEvents Label12 As rune_label
    Friend WithEvents Label11 As rune_label
    Friend WithEvents Label10 As rune_label
    Friend WithEvents Label21 As rune_label
    Friend WithEvents Label20 As rune_label
    Friend WithEvents Label8 As rune_label
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem7 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem6 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem8 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents fruit As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Fruit_herb As System.Windows.Forms.ComboBox
    Friend WithEvents Fruit_lieya As System.Windows.Forms.ComboBox
    Friend WithEvents Fruit_Brimhaven As System.Windows.Forms.ComboBox
    Friend WithEvents Fruit_Catherby As System.Windows.Forms.ComboBox
    Friend WithEvents wood As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Wood_lumbridge As System.Windows.Forms.ComboBox
    Friend WithEvents Wood_tree As System.Windows.Forms.ComboBox
    Friend WithEvents Wood_Taverley As System.Windows.Forms.ComboBox
    Friend WithEvents Wood_Falador As System.Windows.Forms.ComboBox
    Friend WithEvents Wood_Varrock As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As rune_label
    Friend WithEvents Label32 As rune_label
    Friend WithEvents Label47 As rune_label
    Friend WithEvents Label41 As rune_label
    Friend WithEvents Label46 As rune_label
    Friend WithEvents Label26 As rune_label
    Friend WithEvents Label29 As rune_label
    Friend WithEvents Label30 As rune_label
    Friend WithEvents Label27 As rune_label
    Friend WithEvents Label25 As rune_label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label50 As rune_label
    Friend WithEvents Label55 As rune_label
    Friend WithEvents Label15 As rune_label
    Friend WithEvents Label14 As rune_label
    Friend WithEvents Label13 As rune_label
    Friend WithEvents Label67 As rune_label
    Friend WithEvents Label66 As rune_label
    Friend WithEvents Label69 As rune_label
    Friend WithEvents Label65 As rune_label
    Friend WithEvents Label68 As rune_label
    Friend WithEvents Label64 As rune_label
    Friend WithEvents Label63 As rune_label
    Friend WithEvents Label62 As rune_label
    Friend WithEvents Label61 As rune_label
    Friend WithEvents Label60 As rune_label
    Friend WithEvents Label59 As rune_label
    Friend WithEvents Label58 As rune_label
    Friend WithEvents Label57 As rune_label
    Friend WithEvents Label56 As rune_label
    Friend WithEvents Label70 As rune_label
    Friend WithEvents SuperTabControlPanel7 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Label78 As rune_label
    Friend WithEvents Label77 As rune_label
    Friend WithEvents Label76 As rune_label
    Friend WithEvents Label75 As rune_label
    Friend WithEvents Label74 As rune_label
    Friend WithEvents Label73 As rune_label
    Friend WithEvents Label72 As rune_label
    Friend WithEvents Label71 As rune_label
    Friend WithEvents Shops As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stylecont As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Black As DevComponents.Editors.ComboItem
    Friend WithEvents Blue As DevComponents.Editors.ComboItem
    Friend WithEvents Silver As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Glass As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Soundswitch As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents AnalogClockControl1 As DevComponents.DotNetBar.Controls.AnalogClockControl
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label79 As rune_label
    Friend WithEvents Label80 As rune_label
    Friend WithEvents Label85 As rune_label
    Friend WithEvents Label86 As rune_label
    Friend WithEvents Label83 As rune_label
    Friend WithEvents Label84 As rune_label
    Friend WithEvents Label81 As rune_label
    Friend WithEvents Label82 As rune_label
    Friend WithEvents Label87 As rune_label
    Friend WithEvents Label88 As rune_label
    Friend WithEvents Label89 As rune_label
    Friend WithEvents Label90 As rune_label
    Friend WithEvents Label91 As rune_label
    Friend WithEvents Label94 As rune_label
    Friend WithEvents Label92 As rune_label
    Friend WithEvents Label93 As rune_label
    Friend WithEvents Label107 As rune_label
    Friend WithEvents Label108 As rune_label
    Friend WithEvents Label109 As rune_label
    Friend WithEvents Label110 As rune_label
    Friend WithEvents Label111 As rune_label
    Friend WithEvents Label112 As rune_label
    Friend WithEvents Label116 As rune_label
    Friend WithEvents Label113 As rune_label
    Friend WithEvents Label115 As rune_label
    Friend WithEvents Label114 As rune_label
    Friend WithEvents Label103 As rune_label
    Friend WithEvents Label104 As rune_label
    Friend WithEvents Label105 As rune_label
    Friend WithEvents Label106 As rune_label
    Friend WithEvents Label95 As rune_label
    Friend WithEvents Label96 As rune_label
    Friend WithEvents Label97 As rune_label
    Friend WithEvents Label98 As rune_label
    Friend WithEvents Label99 As rune_label
    Friend WithEvents Label100 As rune_label
    Friend WithEvents Label101 As rune_label
    Friend WithEvents Label102 As rune_label
    Friend WithEvents Label127 As rune_label
    Friend WithEvents Label128 As rune_label
    Friend WithEvents Label125 As rune_label
    Friend WithEvents Label126 As rune_label
    Friend WithEvents Label123 As rune_label
    Friend WithEvents Label124 As rune_label
    Friend WithEvents Label121 As rune_label
    Friend WithEvents Label122 As rune_label
    Friend WithEvents Label119 As rune_label
    Friend WithEvents Label120 As rune_label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label117 As rune_label
    Friend WithEvents Label118 As rune_label
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label129 As rune_label
    Friend WithEvents Label130 As rune_label
    Friend WithEvents Label143 As rune_label
    Friend WithEvents Label144 As rune_label
    Friend WithEvents Label141 As rune_label
    Friend WithEvents Label142 As rune_label
    Friend WithEvents Label139 As rune_label
    Friend WithEvents Label140 As rune_label
    Friend WithEvents Label137 As rune_label
    Friend WithEvents Label138 As rune_label
    Friend WithEvents Label135 As rune_label
    Friend WithEvents Label136 As rune_label
    Friend WithEvents Label133 As rune_label
    Friend WithEvents Label134 As rune_label
    Friend WithEvents Label131 As rune_label
    Friend WithEvents Label132 As rune_label
    Friend WithEvents Label145 As rune_label
    Friend WithEvents Phas_alotment_plant As Runescapeclock.rune_button
    Friend WithEvents Falador_Alotment_Cancel As Runescapeclock.rune_button
    Friend WithEvents Falador_Herb_Cancel As Runescapeclock.rune_button
    Friend WithEvents Falador_Flower_Cancel As Runescapeclock.rune_button
    Friend WithEvents Falador_Flower_Plant As Runescapeclock.rune_button
    Friend WithEvents Falador_Herb_Plant As Runescapeclock.rune_button
    Friend WithEvents Falador_Alotment_Plant As Runescapeclock.rune_button
    Friend WithEvents Catherby_alotment_cancel As Runescapeclock.rune_button
    Friend WithEvents Catherby_herb_cancel As Runescapeclock.rune_button
    Friend WithEvents Catherby_flower_cancel As Runescapeclock.rune_button
    Friend WithEvents Catherby_flower_plant As Runescapeclock.rune_button
    Friend WithEvents Catherby_herb_plant As Runescapeclock.rune_button
    Friend WithEvents Catherby_alotment_plant As Runescapeclock.rune_button
    Friend WithEvents Phas_alotment_cancel As Runescapeclock.rune_button
    Friend WithEvents Phas_herb_cancel As Runescapeclock.rune_button
    Friend WithEvents Phas_flower_cancel As Runescapeclock.rune_button
    Friend WithEvents Phas_flower_plant As Runescapeclock.rune_button
    Friend WithEvents Phas_herb_plant As Runescapeclock.rune_button
    Friend WithEvents Ardy_Alotment_cancel As Runescapeclock.rune_button
    Friend WithEvents Ardy_herb_cancel As Runescapeclock.rune_button
    Friend WithEvents Ardy_flower_cancel As Runescapeclock.rune_button
    Friend WithEvents Ardy_flower_plant As Runescapeclock.rune_button
    Friend WithEvents Ardy_herb_plant As Runescapeclock.rune_button
    Friend WithEvents Ardy_Alotment_plant As Runescapeclock.rune_button
    Friend WithEvents Button1 As Runescapeclock.rune_button
    Friend WithEvents Button2 As Runescapeclock.rune_button
    Friend WithEvents Button7 As Runescapeclock.rune_button
    Friend WithEvents Button8 As Runescapeclock.rune_button
    Friend WithEvents Button5 As Runescapeclock.rune_button
    Friend WithEvents Button6 As Runescapeclock.rune_button
    Friend WithEvents Button3 As Runescapeclock.rune_button
    Friend WithEvents Button4 As Runescapeclock.rune_button
    Friend WithEvents Button9 As Runescapeclock.rune_button
    Friend WithEvents Button10 As Runescapeclock.rune_button
    Friend WithEvents Button11 As Runescapeclock.rune_button
    Friend WithEvents Button12 As Runescapeclock.rune_button
    Friend WithEvents Button15 As Runescapeclock.rune_button
    Friend WithEvents Button13 As Runescapeclock.rune_button
    Friend WithEvents Button14 As Runescapeclock.rune_button
    Friend WithEvents Button16 As Runescapeclock.rune_button
    Friend WithEvents Button29 As Runescapeclock.rune_button
    Friend WithEvents Button30 As Runescapeclock.rune_button
    Friend WithEvents Button31 As Runescapeclock.rune_button
    Friend WithEvents Button32 As Runescapeclock.rune_button
    Friend WithEvents Button33 As Runescapeclock.rune_button
    Friend WithEvents Button34 As Runescapeclock.rune_button
    Friend WithEvents Button37 As Runescapeclock.rune_button
    Friend WithEvents Button38 As Runescapeclock.rune_button
    Friend WithEvents Button35 As Runescapeclock.rune_button
    Friend WithEvents Button36 As Runescapeclock.rune_button
    Friend WithEvents Button25 As Runescapeclock.rune_button
    Friend WithEvents Button26 As Runescapeclock.rune_button
    Friend WithEvents Button27 As Runescapeclock.rune_button
    Friend WithEvents Button28 As Runescapeclock.rune_button
    Friend WithEvents Button17 As Runescapeclock.rune_button
    Friend WithEvents Button18 As Runescapeclock.rune_button
    Friend WithEvents Button19 As Runescapeclock.rune_button
    Friend WithEvents Button20 As Runescapeclock.rune_button
    Friend WithEvents Button21 As Runescapeclock.rune_button
    Friend WithEvents Button22 As Runescapeclock.rune_button
    Friend WithEvents Button23 As Runescapeclock.rune_button
    Friend WithEvents Button24 As Runescapeclock.rune_button
    Friend WithEvents Button49 As Runescapeclock.rune_button
    Friend WithEvents Button50 As Runescapeclock.rune_button
    Friend WithEvents Button47 As Runescapeclock.rune_button
    Friend WithEvents Button48 As Runescapeclock.rune_button
    Friend WithEvents Button45 As Runescapeclock.rune_button
    Friend WithEvents Button46 As Runescapeclock.rune_button
    Friend WithEvents Button43 As Runescapeclock.rune_button
    Friend WithEvents Button44 As Runescapeclock.rune_button
    Friend WithEvents Button41 As Runescapeclock.rune_button
    Friend WithEvents Button42 As Runescapeclock.rune_button
    Friend WithEvents Button39 As Runescapeclock.rune_button
    Friend WithEvents Button40 As Runescapeclock.rune_button
    Friend WithEvents Button51 As Runescapeclock.rune_button
    Friend WithEvents Button58 As Runescapeclock.rune_button
    Friend WithEvents Button57 As Runescapeclock.rune_button
    Friend WithEvents Button56 As Runescapeclock.rune_button
    Friend WithEvents Button55 As Runescapeclock.rune_button
    Friend WithEvents Button54 As Runescapeclock.rune_button
    Friend WithEvents Button53 As Runescapeclock.rune_button
    Friend WithEvents Button52 As Runescapeclock.rune_button
    Friend WithEvents Button59 As Runescapeclock.rune_button
    Friend WithEvents Button60 As Runescapeclock.rune_button

End Class
