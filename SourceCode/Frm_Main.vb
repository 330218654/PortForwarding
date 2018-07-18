Imports System.Net.Sockets
Imports Sy.Threading

Public Class Frm_Main
    Private MainThread As Thread
    Private MainSocket As Socket
    Private SrcPort As Integer
    Private DstPort As Integer

    Private Const DefRevBufferSize As Integer = 1024
    Private Const DefSndBufferSize As Integer = 8192

    Private StrStart As String = My.Resources.Btn_Start_Text_Start
    Private StrStop As String = My.Resources.Btn_Start_Text_Stop

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NUD_RevBufferSize.Value = DefRevBufferSize
        NUD_SndBufferSize.Value = DefSndBufferSize
        Btn_Start.Text = StrStart

        For i As UIFilter = UIFilter.Min + 1 To UIFilter.Max - 1
            Cmb_UIFilter.Items.Add(i.ToString)
        Next
        Cmb_UIFilter.SelectedIndex = 0

        I18N()

        Text += $" [V{Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString} By:admin@sml2.com]"
    End Sub

    Private Sub I18N()
        Btn_Access.Text = My.Resources.Btn_Access_Text
        Btn_Clear.Text = My.Resources.Btn_Clear_Text
        Btn_Defense.Text = My.Resources.Btn_Defense_Text
        Btn_Export.Text = My.Resources.Btn_Export_Text
        Btn_Import.Text = My.Resources.Btn_Import_Text
        Btn_Manager.Text = My.Resources.Btn_Manager_Text
        Btn_ReLoad.Text = My.Resources.Btn_ReLoad_Text
        Btn_Remove.Text = My.Resources.Btn_Remove_Text
        Btn_ReSet.Text = My.Resources.Btn_ReSet_Text
        Btn_RmCountlt.Text = My.Resources.Btn_RmCountlt_Text
        Btn_RmHourAgo.Text = My.Resources.Btn_RmHourAgo_Text
        Btn_Start.Text = My.Resources.Btn_Start_Text_Start
        Chk_LogAccept.Text = My.Resources.Chk_LogAccept_Text
        Chk_LogClose.Text = My.Resources.Chk_LogClose_Text
        Chk_LogRevSize.Text = My.Resources.Chk_LogRevSize_Text
        Chk_LogSndSize.Text = My.Resources.Chk_LogSndSize_Text
        CMH_Count.Text = My.Resources.CMH_Count_Text
        CMH_DefenseTime.Text = My.Resources.CMH_DefenseTime_Text
        CMH_IP.Text = My.Resources.CMH_IP_Text
        CMH_IsDefensed.Text = My.Resources.CMH_IsDefensed_Text
        CMH_LastTime.Text = My.Resources.CMH_LastTime_Text
        CMH_RevCount.Text = My.Resources.CMH_RevCount_Text
        CMH_Serial.Text = My.Resources.CMH_Serial_Text
        CMH_SndCount.Text = My.Resources.CMH_SndCount_Text
        Text = My.Resources.Frm_Main_Text
        GPB_ManagerClient.Text = My.Resources.GPB_ManagerClient_Text
        Lab_Dst.Text = My.Resources.Lab_Dst_Text
        Lab_RevBufSize.Text = My.Resources.Lab_RevBufSize_Text
        Lab_SndBufSize.Text = My.Resources.Lab_SndBufSize_Text
        Lab_Src.Text = My.Resources.Lab_Src_Text
    End Sub
    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Dim Button As Button = sender
        Button.Enabled = False
        If Button.Text.Equals(StrStart) Then
            UIAdt(True)
            MainThread = New Thread(AddressOf MainSub)
            MainThread.Start()
        Else
            If MainThread IsNot Nothing Then MainThread.Abort()
            If MainSocket IsNot Nothing Then MainSocket.Close()
        End If
            Button.Enabled = True
    End Sub
    Private Sub UIAdt(isStart As Boolean)
        If isStart Then
            SrcPort = NUD_Src.Value
            NUD_Src.Enabled = False
            DstPort = NUD_Dst.Value
            NUD_Dst.Enabled = False
            Btn_Start.Text = StrStop
        Else
            NUD_Src.Enabled = True
            NUD_Dst.Enabled = True
            Btn_Start.Text = StrStart
        End If
    End Sub
    Public Sub MainSub()
        MainSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Try
            MainSocket.Bind(New Net.IPEndPoint(Net.IPAddress.Parse("0.0.0.0"), SrcPort))
            MainSocket.Listen(32) '允许N个排队,多余的拒绝服务
            Log.AppendLogOnThreadAsync($"Bind Success   Port:{SrcPort}")
        Catch ex As Exception
            Log.AppendLogOnThreadAsync($"Bind Fail:{ex.Message}")
            Invoke(Sub() UIAdt(False))
            Exit Sub
        End Try
        Try
            Do
                Dim NewSocket As Socket = MainSocket.Accept
                If LogNormal Then Log.AppendLogOnThreadAsync($"Accpet:{NewSocket.RemoteEndPoint.ToString}")
                ForwardSub(NewSocket)
            Loop
        Catch ex As Exception
            If MainSocket IsNot Nothing Then MainSocket.Close()
            Invoke(Sub() UIAdt(False))
        End Try
    End Sub
    Public Sub ForwardSub(Socket As Socket)
        Dim Task = Sub()
                       Dim Client As Client = Client.Find(Socket.RemoteEndPoint)
                       If Client.CheckDefense Then
                           If LogNormal Then Log.AppendLogOnThread($"Defense:{Client.IP} , Times:{Client.DefenseTimes}")
                       Else
                           If LogNormal Then Log.AppendLogOnThread($"Access:{Client.ToString}  Count:{Client.Dic.Count}")
                           Dim MRES As New Threading.ManualResetEventSlim(False)
                           Dim DstSocket As Socket = Nothing
                           Dim RevTask As New Threading.Tasks.Task(
                           Sub()
                               Dim buffer As Byte() = New Byte(RevBufferSize) {}
                               Do While (Socket.Connected)
                                   Try
                                       Dim l = Socket.Receive(buffer, 0, buffer.Length, SocketFlags.None)
                                       If LogRevSize Then Log.AppendLogOnThread($"Rev:{l}  From:{Client.IP}")
                                       If l = 0 Then Throw New SocketException("Empty Data")
                                       Client.AddDateRev(l)
                                       If DstSocket Is Nothing Then
                                           DstSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                                           DstSocket.Connect(Net.IPAddress.Parse("127.0.0.1"), DstPort)
                                       End If
                                       MRES.Set()
                                       DstSocket.Send(buffer, l, SocketFlags.None)
                                   Catch ex As Exception
                                       Socket.Close()
                                       DstSocket.Close()
                                   End Try
                               Loop
                           End Sub)
                           Dim SndTask As New Threading.Tasks.Task(
                           Sub()
                               MRES.Wait()
                               Dim buffer As Byte() = New Byte(SndBufferSize) {}
                               Do While (DstSocket.Connected)
                                   Try
                                       Dim l = DstSocket.Receive(buffer, 0, buffer.Length, SocketFlags.None)
                                       If l = 0 Then Throw New SocketException("Empty Data")
                                       Client.AddDateSnd(l)
                                       Socket.Send(buffer, l, SocketFlags.None)
                                       If LogSndSize Then Log.AppendLogOnThread($"Snd:{l}  To:{Client.IP}")
                                   Catch ex As Exception
                                       Socket.Close()
                                       DstSocket.Close()
                                   End Try
                               Loop
                           End Sub)
                           RevTask.Start()
                           SndTask.Start()
                           Threading.Tasks.Task.WaitAll({RevTask, SndTask})
                           Socket.Close()
                           Socket.Dispose()
                           If DstSocket IsNot Nothing Then
                               DstSocket.Close()
                               DstSocket.Dispose()
                           End If
                           MRES.Dispose()
                           If LogClose Then Log.AppendLogOnThread($"Closed: {Client.ToString} ")
                       End If
                   End Sub
        Task.BeginInvoke(Nothing, Nothing)
    End Sub

    Private LogNormal As Boolean = True
    Private LogClose As Boolean = True
    Private LogRevSize As Boolean = True
    Private LogSndSize As Boolean = True
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_LogRevSize.CheckedChanged
        Dim CheckBox As CheckBox = sender
        LogRevSize = CheckBox.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_LogSndSize.CheckedChanged
        Dim CheckBox As CheckBox = sender
        LogSndSize = CheckBox.Checked
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_LogClose.CheckedChanged
        Dim CheckBox As CheckBox = sender
        LogClose = CheckBox.Checked
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_LogAccept.CheckedChanged
        Dim CheckBox As CheckBox = sender
        LogNormal = CheckBox.Checked
    End Sub

    Private RevBufferSize As Integer
    Private SndBufferSize As Integer
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NUD_SndBufferSize.ValueChanged
        Dim NumericUpDown As NumericUpDown = sender
        SndBufferSize = NumericUpDown.Value - 1
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NUD_RevBufferSize.ValueChanged
        Dim NumericUpDown As NumericUpDown = sender
        RevBufferSize = NumericUpDown.Value - 1
    End Sub



    Enum UIFilter
        Min = -1
        All
        Access
        Defense
        Max
    End Enum

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Manager.Click
        LoadClient()
        GPB_ManagerClient.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        GPB_ManagerClient.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_ReLoad.Click
        LoadClient()
    End Sub
    Private Sub LoadClient()
        Ltv_Client.SuspendLayout()
        Dim Filter As UIFilter = Cmb_UIFilter.SelectedIndex
        Ltv_Client.Items.Clear()
        Dim i As Integer
        Dim AddUI = Sub(c As Client, Func As Func(Of Client, Boolean))
                        If Func(c) Then
                            i += 1
                            Dim ltvi = Ltv_Client.Items.Add(i)
                            ltvi.SubItems.AddRange({c.IP,
                                                   c.DateRev,
                                                   c.DateSnd,
                                                   If(c.IsDefense, My.Resources.IsTrue, My.Resources.IsFalse),
                                                   c.DefenseTimes,
                                                   c.Count,
                                                   c.LastTime})
                            ltvi.Tag = c
                        End If
                    End Sub
        Dim FunCheck As Func(Of Client, Boolean) = Nothing
        Select Case Filter
            Case UIFilter.Access
                FunCheck = Function(c As Client) Not c.IsDefense()
            Case UIFilter.Defense
                FunCheck = Function(c As Client) c.IsDefense()
            Case UIFilter.All
                FunCheck = Function(c As Client) True
        End Select
        For Each KeyValuePair As KeyValuePair(Of String, Client) In Client.Dic
            AddUI(KeyValuePair.Value, FunCheck)
        Next
        Ltv_Client.ResumeLayout()
    End Sub
    Private Sub ReLoadClient()
        Ltv_Client.SuspendLayout()
        For Each ltvi As ListViewItem In Ltv_Client.Items
            Dim c As Client = ltvi.Tag
            ltvi.SubItems(1).Text = c.IP
            ltvi.SubItems(2).Text = c.DateRev
            ltvi.SubItems(3).Text = c.DateSnd
            ltvi.SubItems(4).Text = If(c.IsDefense, My.Resources.IsTrue, My.Resources.IsFalse)
            ltvi.SubItems(5).Text = c.DefenseTimes
            ltvi.SubItems(6).Text = c.Count
            ltvi.SubItems(7).Text = c.LastTime
        Next
        Ltv_Client.ResumeLayout()
    End Sub
    Private Sub Cmb_UIFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_UIFilter.SelectedIndexChanged
        LoadClient()
    End Sub
    Private Sub DealCheckItem(Fun As Action(Of Client), Optional IsChangeElement As Boolean = False)
        For Each ltvi As ListViewItem In Ltv_Client.CheckedItems
            Fun(ltvi.Tag)
        Next
        If IsChangeElement Then
            LoadClient()
        Else
            ReLoadClient()
        End If
    End Sub
    Private Sub DealAllItem(Fun As Action(Of Client), Optional IsChangeElement As Boolean = False)
        For Each ltvi As ListViewItem In Ltv_Client.Items
            Fun(ltvi.Tag)
        Next
        If IsChangeElement Then
            LoadClient()
        Else
            ReLoadClient()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_ReSet.Click
        DealCheckItem(Sub(c As Client)
                          c.DateSnd = 0
                          c.DateRev = 0
                          c.Count = 0
                          c.IsDefense = False
                      End Sub)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Defense.Click
        DealCheckItem(Sub(c As Client)
                          c.IsDefense = True
                      End Sub)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Access.Click
        DealCheckItem(Sub(c As Client)
                          c.IsDefense = False
                      End Sub)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        DealCheckItem(Sub(c As Client)
                          Client.Dic.Remove(c.IP)
                      End Sub, True)
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Client.Dic.Clear()
        LoadClient()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Btn_RmCountlt.Click
        Dim Count = Num_Count.Value
        DealAllItem(Sub(c As Client)
                        If c.Count <= Count Then Client.Dic.Remove(c.IP)
                    End Sub, True)
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Btn_RmHourAgo.Click
        Dim Hour = NUD_Hour.Value
        Dim Dt As Date = Now.AddHours(-Hour)
        DealAllItem(Sub(c As Client)
                        If c.LastTime <= Dt Then Client.Dic.Remove(c.IP)
                    End Sub, True)
    End Sub

    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click
        Dim sfd As New SaveFileDialog With {
            .Filter = "Bin(Binary)|*.Bin",
            .FileName = $"IPList_{Sy.NowFormat.yyyyMMddHHmmss}",
            .AddExtension = True,
            .InitialDirectory = Application.StartupPath,
            .SupportMultiDottedExtensions = False
        }
        If sfd.ShowDialog = DialogResult.OK Then
            Dim FileName = sfd.FileName
            Dim Bin = Sy.Data.BinObject.Serialize(Client.Dic)
            IO.File.WriteAllBytes(FileName, Bin)
        End If
    End Sub

    Private Sub Btn_Import_Click(sender As Object, e As EventArgs) Handles Btn_Import.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Bin(Binary)|*.Bin",
            .FileName = "IPList",
            .AddExtension = True,
            .InitialDirectory = Application.StartupPath,
            .SupportMultiDottedExtensions = False
        }
        If ofd.ShowDialog = DialogResult.OK Then
            Dim FileName = ofd.FileName
            Dim Bin = IO.File.ReadAllBytes(FileName)
            Dim Dic = Sy.Data.BinObject.Deserialize(Of Dictionary(Of String, Client))(Bin)
            For Each kp In Dic
                If Client.Dic.ContainsKey(kp.Key) Then
                    Dim c = Client.Dic(kp.Key)
                    Dim Imc = kp.Value
                    c.AddDateRev(Imc.DateRev)
                    c.AddDateSnd(Imc.DateSnd)
                    c.Count += (Imc.Count)
                    c.IsDefense = c.IsDefense Or Imc.IsDefense
                    c.DefenseTimes += Imc.DefenseTimes
                Else
                    Try
                        Client.Dic.Add(kp.Key, kp.Value)
                    Catch ex As ArgumentException
                    End Try
                End If
            Next
        End If
        LoadClient()
    End Sub



    Private Sub Ltv_Client_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Ltv_Client.ColumnClick
        Sy.UI.Common.ListViewHelper.ListView_ColumnClick(sender, e)
    End Sub
End Class
