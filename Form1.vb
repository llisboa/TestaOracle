Imports Icraft.IcftBase
Imports System.Windows.Forms
Public Class frmTestaOracle
    Private Sub BtnSTART_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        Dim nomeArq As String = ""
        Dim rodada As Integer = 0
        Dim Retorno As String = ""
        Dim SFD As New SaveFileDialog()
        SFD.DefaultExt = "txt"
        SFD.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SFD.FileName = "log"
        SFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If SFD.ShowDialog() = DialogResult.OK Then
            'pega o nome do arquivo
            nomeArq = SFD.FileName
        Else
            Exit Sub
        End If
        System.IO.File.WriteAllText(nomeArq, "")
        Dim escreveArq As System.IO.StreamWriter = System.IO.File.AppendText(nomeArq)
        Try
            While True
                Application.DoEvents()
                rodada += 1
                'AtualizaStatus("Tentativa de recuperar valor do Oracle")
                Try
                    Retorno = DSValor("count(*)", "sbdb.sócio", "strConn", "")
                Catch ex As Exception
                    'AtualizaStatus("Falha ao tentar recuperar valor do Oracle")
                    Retorno = "ERRO:" & ex.Message.ToString.ToUpper
                End Try

                Retorno = rodada & " | " & Retorno & " - " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                escreveArq.WriteLine(Replace(Retorno, System.Environment.NewLine, " "))
                txtRESULT.AppendText(System.Environment.NewLine & Retorno)
                System.Threading.Thread.Sleep(5000) ' 5 segundos
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString.ToUpper)
        End Try
        escreveArq.Close()
    End Sub
End Class
