Imports System.Management

Public Class Form1
    ' As a global variable, this can be used by another process 
    ' to end current processing.
    Dim blContinue As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Init()
    End Sub

    Private Sub Init()
        Dim myProcesses() As Process
        Dim intCount As Integer
        myProcesses = Process.GetProcesses()
        intCount = myProcesses.Length
        lblCount.Text = intCount.ToString()

        lblCount.AutoSize = True
        txtProcessName.Text = ""

        cmdCancel.Visible = False
        cmdRun.Enabled = True
        blContinue = True
    End Sub

    ''' <summary>
    ''' https://www.c-sharpcorner.com/UploadFile/scottlysle/listing-and-killing-processes-with-visual-basic2/
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        On Error GoTo Err

        cmdCancel.Visible = True
        cmdRun.Enabled = False
        blContinue = True

        Dim myProcesses() As Process
        Dim myProcess As Process
        Dim intCount As Integer
        Dim intExpPid As Integer

        myProcesses = Process.GetProcesses()
        intCount = myProcesses.Count

        lblCount.Text = intCount.ToString()

        If intCount > 0 Then
            For Each myProcess In myProcesses
                Application.DoEvents()
                If Not blContinue Then GoTo ErrCanceled
                If myProcess IsNot Nothing Then
                    intCount -= 1 : lblCount.Text = intCount.ToString()
                    txtProcessName.Text = myProcess.ProcessName

                    Select Case myProcess.ProcessName
                        Case "explorer"
                            intExpPid = myProcess.Id
                            Continue For
                        Case "dllhost", "svchost.exe", "svchost", "Idle", "System"
                            Continue For
                    End Select

                    If chkVerify.Checked Then
                        Select Case GetProcessOwner(myProcess.Id).ToString()
                            Case "NO OWNER"
                            Case Else
                                'myProcess.Kill()
                                myProcess.CloseMainWindow()

                        End Select
                    Else
                        myProcess.CloseMainWindow()
                    End If
                End If
            Next
        End If

        If chkReboot.Checked Then
            myProcess = Process.GetProcessById(intExpPid)
            myProcess.CloseMainWindow()
        End If

        cmdCancel.Visible = False
        cmdRun.Enabled = True

        Exit Sub
Err:
        Resume Next
ErrCanceled:
        Call Init()
    End Sub

    ''' <summary>
    ''' https://stackoverflow.com/questions/16923332/how-to-kill-process-by-user
    ''' </summary>
    ''' <param name="processId"></param>
    ''' <returns></returns>
    Public Function GetProcessOwner(processId As Integer) As String
        Dim query As String = "Select * From Win32_Process Where ProcessID = " + processId.ToString()
        Dim searcher As New ManagementObjectSearcher(query)
        Dim processList As ManagementObjectCollection = searcher.[Get]()

        For Each obj As ManagementObject In processList
            Dim argList As String() = New String() {String.Empty, String.Empty}
            Dim returnVal As Integer = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList))
            If returnVal = 0 Then
                ' argList(0) == User
                ' argList(1) == DOMAIN
                Return argList(0)
            End If
        Next

        Return "NO OWNER"
    End Function

    Private Function GetOwnersProcessCount() As Integer
        Dim myProcesses() As Process
        Dim intCount As Integer, intRetCount As Integer
        Dim strOwner As String

        myProcesses = Process.GetProcesses()
        intCount = myProcesses.Count
        If intCount > 0 Then
            For Each p In myProcesses
                strOwner = GetProcessOwner(p.Id)
                Select Case strOwner
                    Case "NO OWNER"
                    Case Else
                        intRetCount += 1
                End Select
            Next
        End If
        Return intRetCount
    End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        blContinue = False
    End Sub
End Class
