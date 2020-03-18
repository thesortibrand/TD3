Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form1
    'Declaration de variables globales 
    Dim Tab() As Integer
    Dim ordre As Integer
    Dim Nb_aleatoire As Integer
    Dim limite As Integer
    Dim reset As Integer

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click


        If ordre < limite Then
Line13:
            Randomize() 'ça sert pour avoir un début aléatoire
            Nb_aleatoire = Int((txtLimite.Text * Rnd()) + 1)

            For a As Integer = 0 To limite - 1
                If Tab(a) = Nb_aleatoire Then
                    GoTo Line13
                End If
            Next a
            Tab(ordre) = Nb_aleatoire
            ordre = ordre + 1
            lsTires.Items.Add(Nb_aleatoire)
        Else
            MsgBox("Tous les nombres ont été tirés au sort")
            reset = 2
        End If

    End Sub

    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged
        If txtLimite.Text <> "" And reset = 0 Then
            limite = txtLimite.Text
            ReDim Tab(txtLimite.Text - 1)
            For b As Integer = 0 To limite - 1
                Tab(b) = 0
            Next b
            ordre = 0
        End If
        reset = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lsTires.Items.Clear()
        txtLimite.Text = ""
        reset = 0
        ChartTirage.Series.Clear()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        MsgBox("Creé par Daniel GARCIA")
        Me.Close()
    End Sub

    Private Sub btnTracer_Click(sender As Object, e As EventArgs) Handles btnTracer.Click
        Dim ma_serie_tracer As New Series
        Dim x As Integer
        Dim y As Integer



        If reset = 2 Then
            For i As Integer = 0 To limite - 1
                x = i + 1
                y = Tab(i)
                ma_serie_tracer.Points.AddXY(x, y)
            Next i

            ma_serie_tracer.ChartType = ma_serie_tracer.ChartType.Area
            ChartTirage.Series.Add(ma_serie_tracer)

            reset = 1

        End If


    End Sub
End Class
