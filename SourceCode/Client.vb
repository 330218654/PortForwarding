Imports System.Net
<Serializable>
Public Class Client
    Inherits Sy.Data.BinObject
    Private Sub New()
    End Sub
    Public Shared ReadOnly Dic As New Dictionary(Of String, Client)
    Public Shared Function Find(iP As IPEndPoint) As Client
        Dim StrIP = iP.Address.ToString
        Dim c As Client
        If Dic.ContainsKey(StrIP) Then
            c = Dic(StrIP)
            c.AddVisit()
        Else
            c = New Client(StrIP)
            Dic.Add(c.IP, c)
        End If
        Return c
    End Function
    Private Sub AddVisit()
        Count += 1
        Dim CurTime = Now
        If Not IsDefense Then
            '软防CC 只要规则写的骚 怎么都没事
            If CurTime.Ticks - LastTime.Ticks < 10000000 Then 'Tick单位是1/10微秒? 
                DefenseCount += 1
                If DefenseCount > 100 Then IsDefense = True '访问间隔小于1秒 持续100次 开启防御
            Else
                DefenseCount = 0 '清空准备防御计数
            End If
            '软防D 对方带宽大的话只能硬防  这个就拼成本  没办法的
            If Count Mod 10 = 0 Then '每N次检测下平均数据量
                If LastDateCount / 10 < 1024 Then IsDefense = True '访问10次数据量平均小于1k 开启防御
                LastDateRev = 0 '清空最后访问接受字节计数
                LastDateSnd = 0 '清空最后访问发送字节计数
            End If
        End If
        LastTime = CurTime
    End Sub
    Public Sub AddDateRev(Len As Integer)
        LastDateRev += Len
        DateRev += Len
    End Sub
    Public Sub AddDateSnd(Len As Integer)
        LastDateSnd += Len
        DateSnd += Len
    End Sub

    Public IP As String
    Public FirstTime As Date
    Public Count As String = 1
    Public ReadOnly Property LastDateCount As Integer
        Get
            Return DateRev + DateSnd
        End Get
    End Property
    Public DateRev As Integer = 0
    Public DateSnd As Integer = 0
    Public ReadOnly Property DateCount As Integer
        Get
            Return LastDateRev + LastDateSnd
        End Get
    End Property
    Public LastDateRev As Integer = 0
    Public LastDateSnd As Integer = 0
    Public LastTime As Date

    Public Sub New(iP As String)
        Me.IP = iP
        FirstTime = Now
        LastTime = FirstTime
    End Sub
    Public Overrides Function ToString() As String
        Return $"IP[{IP}] Count[{Count}] Data[{DateCount}] {FirstTime.ToString}-{LastTime.ToString}"
    End Function

    Private DefenseCount As Integer = 0
    Public DefenseTimes As Integer = 0
    Public Property IsDefense As Boolean = False
    Friend Function CheckDefense() As Boolean
        If IsDefense Then DefenseTimes += 1
        Return IsDefense
    End Function
End Class
