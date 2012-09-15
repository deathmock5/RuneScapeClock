Option Explicit On

Public Class Form1
    Public Sub time() Handles Me.Load
        Timer1.Start()
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
        stylecont.SelectedItem = My.Settings.Thetheme
        Soundswitch.Value = My.Settings.Soundon
        Select Case Now.Month
            Case 1 Or 2 Or 10 Or 11 Or 12
                AnalogClockControl1.TimeZone = "W. Central Africa Standard Time"
            Case 3
                If Now.Day < 25 Then
                    AnalogClockControl1.TimeZone = "W. Central Africa Standard Time"
                Else
                    AnalogClockControl1.TimeZone = "W. Europe Standard Time"
                End If
            Case 4 Or 5 Or 6 Or 7 Or 8
                AnalogClockControl1.TimeZone = "W. Europe Standard Time"
            Case 9
                If Now.Day > 28 Then
                    AnalogClockControl1.TimeZone = "W. Central Africa Standard Time"
                Else
                    AnalogClockControl1.TimeZone = "W. Europe Standard Time"
                End If
        End Select
        AnalogClockControl1.TimeZone = "W. Central Africa Standard Time"
    End Sub  'starts the timer
    Dim nameofitem As String
    Public buttonoutimg As Image = My.Resources.button_out
    Public buttoninimg As Image = My.Resources.button_over
    Public messager As New POPUP()
#Region "constant times in seconds"
    'aluments
    Const Potato As Integer = 2400
    Const Onion As Integer = 2400
    Const Cabbage As Integer = 2400
    Const Tomato As Integer = 2400
    Const Sweetcorn As Integer = 3000
    Const Strawberry As Integer = 6000
    Const watermellon As Integer = 4200
    'herbs
    Const Guam As Integer = 4800
    Const Marintile As Integer = 4800
    Const Tarrowmin As Integer = 4800
    Const Haralander As Integer = 4800
    Const Gout As Integer = 4800
    Const Ranarr As Integer = 4800
    Const Spirit As Integer = 4800
    Const Toadflax As Integer = 4800
    Const Irit As Integer = 4800
    Const Wergali As Integer = 4800
    Const Avantoe As Integer = 4800
    Const Kwuarm As Integer = 4800
    Const Snapdragon As Integer = 4800
    Const Chantidine As Integer = 4800
    Const Lantadyme As Integer = 4800
    Const Dwarfweed As Integer = 4800
    Const Torstole As Integer = 4800
    Const Fellstalk As Integer = 4800
    'flowers
    Const Maragold As Integer = 1200
    Const Rosemerry As Integer = 1200
    Const Nastrium As Integer = 1200
    Const Woad As Integer = 1200
    Const Limpwort As Integer = 1200
    Const lilly As Integer = 4800
    'hops
    Const Barley As Integer = 2400
    Const Hammerstone As Integer = 2400
    Const Asgarnian As Integer = 3000
    Const Jute As Integer = 3000
    Const Yanillian As Integer = 3600
    Const Krandorian As Integer = 4200
    Const Wildblood As Integer = 4800
    'Bushes
    Const Redberry As Integer = 6000
    Const Cadavaberry As Integer = 7200
    Const Dwellberry As Integer = 8400
    Const Jangerberry As Integer = 9600
    Const Whiteberry As Integer = 9600
    Const Poisonivy As Integer = 9600
    'wood
    Const Oak As Integer = 9600
    Const Willow As Integer = 14400
    Const Maple As Integer = 19200
    Const Yew As Integer = 24000
    Const Magic As Integer = 28800
    'fruit
    Const Apple As Integer = 57600
    Const Banana As Integer = 57600
    Const Orange As Integer = 57600
    Const Curry As Integer = 57600
    Const Pinapple As Integer = 57600
    Const Papaya As Integer = 57600
    Const Palm As Integer = 57600
    'Special
    Const Evil As Integer = 300
    Const Bittercap As Integer = 14400
    Const Jade As Integer = 57600
    Const Cactus As Integer = 33600
    Const Belladonna As Integer = 19200
    Const Calquat As Integer = 76800
    Const Morchella As Integer = 14400
    Const Spirittre As Integer = 211200
#End Region
#Region "times"
    Dim fal_ala, fal_Herb, fal_flower As Integer
    Dim cat_ala, cat_herb, cat_flower As Integer
    Dim ard_ala, ard_herb, ard_flower As Integer
    Dim port_ala, port_herb, port_flower As Integer
#End Region
#Region "conversions"
    Function time_when_ready(ByVal time_it_takes As Integer) As Date
        Dim month As Byte
        Dim day As Byte
        Dim week As Byte
        Dim hour As Byte
        Dim minute As Byte
        Dim second As Byte
        Dim ampm As String

        Return "1"
    End Function
    Function get_seconds(ByVal time As Integer) As Byte
        Dim timestring As String = time.ToString
        Try
            timestring = timestring.Substring(timestring.Length - 2)
        Catch ex As Exception
            timestring = "0"
        End Try
        If Convert.ToByte(timestring) >= 60 Then
            timestring = Convert.ToByte(timestring) - 60
        End If
        Return CType(timestring, Byte)
    End Function
    Function get_minutes(ByVal time As Integer) As Byte
        time = time - get_seconds(time)
        Try
            time /= 60
        Catch ex As Exception
            time = 0
        End Try
        Dim timestring As String = time.ToString


        Return CType(timestring, Byte)
    End Function
    Function convert_to_time_string(ByVal time As Integer) As String
        Dim days As String = CInt(time \ 86400)
        If days < 0 Then
            days = 0
        End If
        Dim hours As String = CInt((time - (days * 86400)) \ 3600)
        If hours < 0 Then
            hours = 0
        End If
        Dim minutes As String = CInt((time - (hours * 3600) - (days * 86400)) \ 60)
        If minutes < 0 Then
            minutes = 0
        End If
        Dim seconds As String = CInt(time - (hours * 3600) - (days * 86400) - (minutes * 60))
        If seconds < 0 Then
            seconds = 0
        End If
        If days < 10 Then
            days = "0" & days
        End If
        If hours < 10 Then
            hours = "0" & hours
        End If
        If minutes < 10 Then
            minutes = "0" & minutes
        End If
        If seconds < 10 Then
            seconds = "0" & seconds
        End If
        Return days & ":" & hours & ":" & minutes & ":" & seconds
    End Function 'outputs strings
#End Region
    Private Sub tick_Check(ByRef place As DevComponents.DotNetBar.Controls.GroupPanel _
                          , ByRef place_thing As System.Windows.Forms.ComboBox _
                          , ByRef place_thing_plant As System.Windows.Forms.Button _
                          , ByRef place_thing_time As System.Windows.Forms.Label _
                          , ByRef place_time As Integer)
        If place_thing.Enabled = False Then
            place_time -= 1
            If place_time < 0 Then
                'POPUP.Message("Your " & place.Text & " " & place_thing.Text & " is ready!")
                place_thing.Enabled = True
                place_thing_plant.Enabled = True
            Else
                place_thing_time.Text = convert_to_time_string(place_time)
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Soundswitch.Value Then
            My.Settings.Soundon = True
        Else
            My.Settings.Soundon = False
        End If
        'falador===================================================================================================================
        tick_Check(Falador, Falador_Alotment, Falador_Alotment_Plant, Falador_Alotment_Time, fal_ala)
        tick_Check(Falador, Falador_Herb, Falador_Herb_Plant, Falador_Herb_Time, fal_Herb)
        tick_Check(Falador, Falador_Flower, Falador_Flower_Plant, Falador_Flower_Time, fal_flower)
        'catherby===================================================================================================================
        tick_Check(Catherby, catherby_alotment, Catherby_alotment_plant, Catherby_alotment_time, cat_ala)
        tick_Check(Catherby, catherby_herb, Catherby_herb_plant, Catherby_herb_time, cat_herb)
        tick_Check(Catherby, catherby_flower, Catherby_flower_plant, Catherby_flower_time, cat_flower)
        'ardy===================================================================================================================
        tick_Check(Ardy, Ardy_alotment, Ardy_Alotment_plant, Ardy_Alotment_time, ard_ala)
        tick_Check(Ardy, Ardy_herb, Ardy_herb_plant, Ardy_herb_time, ard_herb)
        tick_Check(Ardy, Ardy_flower, Ardy_flower_plant, Ardy_flower_time, ard_flower)
        'phast===================================================================================================================
        tick_Check(Phas, Phas_alotment, Phas_alotment_plant, Phas_alotment_time, port_ala)
        tick_Check(Phas, Phas_herb, Phas_herb_plant, Phas_herb_time, port_herb)
        tick_Check(Phas, Phas_flower, Phas_flower_plant, Phas_flower_time, port_flower)
    End Sub
    'thing
    Private Sub click_check(ByRef place_thing As System.Windows.Forms.ComboBox _
                            , ByRef place_thing_time As System.Windows.Forms.Label _
                            , ByRef place_thing_plant As System.Windows.Forms.Button _
                            , ByRef place_time As Integer _
                            , ByVal thing As String)
        Dim gotanerror As Boolean = False
        Dim error_message As String
        Select Case thing
            Case "ala"
                Select Case place_thing.Text
                    Case "Potato"
                        place_thing_time.Text = convert_to_time_string(Potato)
                        place_time = Potato
                    Case "Onion"
                        place_thing_time.Text = convert_to_time_string(Onion)
                        place_time = Onion
                    Case "Cabbage"
                        place_thing_time.Text = convert_to_time_string(Cabbage)
                        place_time = Cabbage
                    Case "Tomato"
                        place_thing_time.Text = convert_to_time_string(Tomato)
                        place_time = Tomato
                    Case "Sweetcorn"
                        place_thing_time.Text = convert_to_time_string(Sweetcorn)
                        place_time = Sweetcorn
                    Case "Strawberry"
                        place_thing_time.Text = convert_to_time_string(Strawberry)
                        place_time = Strawberry
                    Case "Watermellon"
                        place_thing_time.Text = convert_to_time_string(watermellon)
                        place_time = watermellon
                    Case Else
                        error_message = "No value selected"
                        gotanerror = True
                End Select
            Case "herb"
                Select Case place_thing.Text
                    Case "Guam"
                        place_thing_time.Text = convert_to_time_string(Guam)
                        place_time = Guam
                    Case "Marintile"
                        place_thing_time.Text = convert_to_time_string(Marintile)
                        place_time = Marintile
                    Case "Tarrowmin"
                        place_thing_time.Text = convert_to_time_string(Tarrowmin)
                        place_time = Tarrowmin
                    Case "Haralander"
                        place_thing_time.Text = convert_to_time_string(Haralander)
                        place_time = Haralander
                    Case "Gout"
                        place_thing_time.Text = convert_to_time_string(Gout)
                        place_time = Gout
                    Case "Ranarr"
                        place_thing_time.Text = convert_to_time_string(Ranarr)
                        place_time = Ranarr
                    Case "Spirit"
                        place_thing_time.Text = convert_to_time_string(Spirit)
                        place_time = Spirit
                    Case "Toadflax"
                        place_thing_time.Text = convert_to_time_string(Toadflax)
                        place_time = Toadflax
                    Case "Irit"
                        place_thing_time.Text = convert_to_time_string(Irit)
                        place_time = Irit
                    Case "Wergali"
                        place_thing_time.Text = convert_to_time_string(Wergali)
                        place_time = Wergali
                    Case "Avantoe"
                        place_thing_time.Text = convert_to_time_string(Avantoe)
                        place_time = Avantoe
                    Case "Kwuarm"
                        place_thing_time.Text = convert_to_time_string(Kwuarm)
                        place_time = Kwuarm
                    Case "Snapdragon"
                        place_thing_time.Text = convert_to_time_string(Snapdragon)
                        place_time = Snapdragon
                    Case "Chantidine"
                        place_thing_time.Text = convert_to_time_string(Chantidine)
                        place_time = Chantidine
                    Case "Lantadyme"
                        place_thing_time.Text = convert_to_time_string(Lantadyme)
                        place_time = Lantadyme
                    Case "Dwarfweed"
                        place_thing_time.Text = convert_to_time_string(Dwarfweed)
                        place_time = Dwarfweed
                    Case "Torstole"
                        place_thing_time.Text = convert_to_time_string(Torstole)
                        place_time = Torstole
                    Case "Fellstalk"
                        place_thing_time.Text = convert_to_time_string(Fellstalk)
                        place_time = Fellstalk
                    Case Else
                        error_message = "No value selected"
                        gotanerror = True
                End Select
            Case "flower"
                Select Case place_thing.Text
                    Case "Maragold"
                        place_thing_time.Text = convert_to_time_string(Maragold)
                        place_time = Maragold
                    Case "Rosemerry"
                        place_thing_time.Text = convert_to_time_string(Rosemerry)
                        place_time = Rosemerry
                    Case "Nastrium"
                        place_thing_time.Text = convert_to_time_string(Nastrium)
                        place_time = Nastrium
                    Case "Woad"
                        place_thing_time.Text = convert_to_time_string(Woad)
                        place_time = Woad
                    Case "Limpwort"
                        place_thing_time.Text = convert_to_time_string(Limpwort)
                        place_time = Limpwort
                    Case "lilly"
                        place_thing_time.Text = convert_to_time_string(lilly)
                        place_time = lilly
                    Case Else
                        error_message = "No value selected"
                        gotanerror = True
                End Select
        End Select
        If Not gotanerror Then
            place_thing_plant.Enabled = False
            place_thing.Enabled = False
        End If
    End Sub

#Region "buttons"
    'falador
    Private Sub Falador_Alotment_Plant_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Alotment_Plant.Click
        click_check(Falador_Alotment, Falador_Alotment_Time, Falador_Alotment_Plant, fal_ala, "ala")
    End Sub
    Private Sub Falador_Alotment_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Alotment_Cancel.Click
        Falador_Alotment_Plant.Enabled = True
        Falador_Alotment.Enabled = True
    End Sub
    Private Sub Falador_Herb_Plant_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Herb_Plant.Click
        click_check(Falador_Herb, Falador_Herb_Time, Falador_Herb_Plant, fal_Herb, "herb")
    End Sub
    Private Sub Falador_Herb_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Herb_Cancel.Click
        Falador_Herb_Plant.Enabled = True
        Falador_Herb.Enabled = True
    End Sub
    Private Sub Falador_Flower_Plant_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Flower_Plant.Click
        click_check(Falador_Flower, Falador_Flower_Time, Falador_Flower_Plant, fal_flower, "flower")
    End Sub
    Private Sub Falador_Flower_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Falador_Flower_Cancel.Click
        Falador_Flower_Plant.Enabled = True
        Falador_Flower.Enabled = True
    End Sub
    'Catherby
    Private Sub Catherby_alotment_plant_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_alotment_plant.Click
        click_check(catherby_alotment, Catherby_alotment_time, Catherby_alotment_plant, cat_ala, "ala")
    End Sub
    Private Sub Catherby_herb_plant_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_herb_plant.Click
        click_check(catherby_herb, Catherby_herb_time, Catherby_herb_plant, cat_herb, "herb")
    End Sub
    Private Sub Catherby_flower_plant_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_flower_plant.Click
        click_check(catherby_flower, Catherby_flower_time, Catherby_flower_plant, cat_flower, "flower")
    End Sub
    Private Sub Catherby_alotment_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_alotment_cancel.Click
        Catherby_alotment_plant.Enabled = True
        catherby_alotment.Enabled = True
    End Sub
    Private Sub Catherby_herb_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_herb_cancel.Click
        Catherby_herb_plant.Enabled = True
        catherby_herb.Enabled = True
    End Sub
    Private Sub Catherby_flower_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Catherby_flower_cancel.Click
        Catherby_flower_plant.Enabled = True
        catherby_flower.Enabled = True
    End Sub
    'Ardy
    Private Sub Ardy_Alotment_plant_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_Alotment_plant.Click
        click_check(Ardy_alotment, Ardy_Alotment_time, Ardy_Alotment_plant, ard_ala, "ala")
    End Sub
    Private Sub Ardy_herb_plant_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_herb_plant.Click
        click_check(Ardy_herb, Ardy_herb_time, Ardy_herb_plant, ard_herb, "herb")
    End Sub
    Private Sub Ardy_flower_plant_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_flower_plant.Click
        click_check(Ardy_flower, Ardy_flower_time, Ardy_flower_plant, ard_flower, "flower")
    End Sub
    Private Sub Ardy_Alotment_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_Alotment_cancel.Click
        Ardy_Alotment_plant.Enabled = True
        Ardy_alotment.Enabled = True
    End Sub
    Private Sub Ardy_herb_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_herb_cancel.Click
        Ardy_herb_plant.Enabled = True
        Ardy_herb.Enabled = True
    End Sub
    Private Sub Ardy_flower_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Ardy_flower_cancel.Click
        Ardy_flower_plant.Enabled = True
        Ardy_flower.Enabled = True
    End Sub
    'Phas
    Private Sub Phas_alotment_plant_Click(sender As System.Object, e As System.EventArgs) Handles Phas_alotment_plant.Click
        Dim gotanerror As Boolean = False
        Select Case Phas_alotment.Text
            Case "Potato"
                Phas_alotment_time.Text = convert_to_time_string(Potato)
                port_ala = Potato
            Case "Onion"
                Phas_alotment_time.Text = convert_to_time_string(Onion)
                port_ala = Onion
            Case "Cabbage"
                Phas_alotment_time.Text = convert_to_time_string(Cabbage)
                port_ala = Cabbage
            Case "Tomato"
                Phas_alotment_time.Text = convert_to_time_string(Tomato)
                port_ala = Tomato
            Case "Sweetcorn"
                Phas_alotment_time.Text = convert_to_time_string(Sweetcorn)
                port_ala = Sweetcorn
            Case "Strawberry"
                Phas_alotment_time.Text = convert_to_time_string(Strawberry)
                port_ala = Strawberry
            Case "Watermellon"
                Phas_alotment_time.Text = convert_to_time_string(watermellon)
                port_ala = watermellon
            Case Else
                MsgBox("error!", MsgBoxStyle.OkOnly)
                gotanerror = True
        End Select
        If Not gotanerror Then
            Phas_alotment_plant.Enabled = False
            Phas_alotment.Enabled = False
        End If
    End Sub
    Private Sub Phas_herb_plant_Click(sender As System.Object, e As System.EventArgs) Handles Phas_herb_plant.Click
        Dim gotanerror As Boolean = False
        Select Case Phas_herb.Text
            Case "Guam"
                Phas_herb_time.Text = convert_to_time_string(Guam)
                port_herb = Guam
            Case "Marintile"
                Phas_herb_time.Text = convert_to_time_string(Marintile)
                port_herb = Marintile
            Case "Tarrowmin"
                Phas_herb_time.Text = convert_to_time_string(Tarrowmin)
                port_herb = Tarrowmin
            Case "Haralander"
                Phas_herb_time.Text = convert_to_time_string(Haralander)
                port_herb = Haralander
            Case "Gout"
                Phas_herb_time.Text = convert_to_time_string(Gout)
                port_herb = Gout
            Case "Ranarr"
                Phas_herb_time.Text = convert_to_time_string(Ranarr)
                port_herb = Ranarr
            Case "Spirit"
                Phas_herb_time.Text = convert_to_time_string(Spirit)
                port_herb = Spirit
            Case "Toadflax"
                Phas_herb_time.Text = convert_to_time_string(Toadflax)
                port_herb = Toadflax
            Case "Irit"
                Phas_herb_time.Text = convert_to_time_string(Irit)
                port_herb = Irit
            Case "Wergali"
                Phas_herb_time.Text = convert_to_time_string(Wergali)
                port_herb = Wergali
            Case "Avantoe"
                Phas_herb_time.Text = convert_to_time_string(Avantoe)
                port_herb = Avantoe
            Case "Kwuarm"
                Phas_herb_time.Text = convert_to_time_string(Kwuarm)
                port_herb = Kwuarm
            Case "Snapdragon"
                Phas_herb_time.Text = convert_to_time_string(Snapdragon)
                port_herb = Snapdragon
            Case "Chantidine"
                Phas_herb_time.Text = convert_to_time_string(Chantidine)
                port_herb = Chantidine
            Case "Lantadyme"
                Phas_herb_time.Text = convert_to_time_string(Lantadyme)
                port_herb = Lantadyme
            Case "Dwarfweed"
                Phas_herb_time.Text = convert_to_time_string(Dwarfweed)
                port_herb = Dwarfweed
            Case "Torstole"
                Phas_herb_time.Text = convert_to_time_string(Torstole)
                port_herb = Torstole
            Case "Fellstalk"
                Phas_herb_time.Text = convert_to_time_string(Fellstalk)
                port_herb = Fellstalk
            Case Else
                MsgBox("error!", MsgBoxStyle.OkOnly)
                gotanerror = True
        End Select
        If Not gotanerror Then
            Phas_herb_plant.Enabled = False
            Phas_herb.Enabled = False
        End If
    End Sub
    Private Sub Phas_flower_plant_Click(sender As System.Object, e As System.EventArgs) Handles Phas_flower_plant.Click
        Dim gotanerror As Boolean = False
        Select Case Phas_flower.Text
            Case "Maragold"
                Phas_flower_time.Text = convert_to_time_string(Maragold)
                port_flower = Maragold
            Case "Rosemerry"
                Phas_flower_time.Text = convert_to_time_string(Rosemerry)
                port_flower = Rosemerry
            Case "Nastrium"
                Phas_flower_time.Text = convert_to_time_string(Nastrium)
                port_flower = Nastrium
            Case "Woad"
                Phas_flower_time.Text = convert_to_time_string(Woad)
                port_flower = Woad
            Case "Limpwort"
                Phas_flower_time.Text = convert_to_time_string(Limpwort)
                port_flower = Limpwort
            Case "lilly"
                Phas_flower_time.Text = convert_to_time_string(lilly)
                port_flower = lilly
            Case Else
                MsgBox("error!", MsgBoxStyle.OkOnly)
                gotanerror = True
        End Select
        If Not gotanerror Then
            Phas_flower_plant.Enabled = False
            Phas_flower.Enabled = False
        End If
    End Sub
    Private Sub Phas_alotment_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Phas_alotment_cancel.Click
        Phas_alotment_plant.Enabled = True
        Phas_alotment.Enabled = True
    End Sub
    Private Sub Phas_herb_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Phas_herb_cancel.Click
        Phas_herb_plant.Enabled = True
        Phas_herb.Enabled = True
    End Sub
    Private Sub Phas_flower_cancel_Click(sender As System.Object, e As System.EventArgs) Handles Phas_flower_cancel.Click
        Phas_flower_plant.Enabled = True
        Phas_flower.Enabled = True
    End Sub
#End Region
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Select Case stylecont.SelectedItem.ToString
                Case "Black"
                    StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
                Case "Blue"
                    StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
                Case "Silver"
                    StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
                Case "Glass"
                    StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
                Case Else
                    MsgBox("No property of '" & stylecont.SelectedItem.ToString & "'", MsgBoxStyle.OkOnly)
            End Select
            If stylecont.SelectedItem.ToString <> "" Then
                My.Settings.Thetheme = stylecont.SelectedItem.ToString
            End If
        Catch Exception As NullReferenceException
            MsgBox("You dident select anything =/", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=25P2UDX7UF344")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("Http://deathmock.zxq.net")
    End Sub
    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Timeconv.Show()
    End Sub
    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        messager.addmessage("Your " & Falador.Text & " " & Falador_Herb.Text & " patch is ready!")
    End Sub
    Private Sub AnalogClockControl1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles AnalogClockControl1.Click
        MsgBox(AnalogClockControl1.Value)
    End Sub
End Class
