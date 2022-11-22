Public Class Form1


    Dim paiedebase As Double = 250
    'Dim montantvendu As Integer = TextBox2.Text

    Dim quota As Integer = 1000
    Dim commission As Double = (15 / 100)

    Function gestion_commission() As String
        Dim montantvendu As Integer = CInt(TextBox2.Text)
        If (montantvendu >= quota) Then

            Dim commission_a_rendre As Double = (montantvendu * commission)
            Dim paie_total = commission_a_rendre + paiedebase
            Label4.Text = "La commission du vendeur " & FormatCurrency(commission_a_rendre) & " du coup   paie total est  " & FormatCurrency(paie_total)
        Else
            '  commission_a_rendre = 0
            Label4.Text = "Le paie  " & paiedebase

        End If

        Return Label4.Text
    End Function


    Private Sub PaieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaieToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Fichier_Click(sender As Object, e As EventArgs) Handles Fichier.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PaieToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaieToolStripMenuItem1.Click
        gestion_commission()

    End Sub

    Private Sub NettoyerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NettoyerToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub CouleurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouleurToolStripMenuItem.Click
        Label4.ForeColor = Color.Red

    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        MsgBox("Nom du projet : PaieVnedeur 
                Langage utilisé est Vba
                Programmé par Hamet Diop
")
    End Sub

    Private Sub PoliceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliceToolStripMenuItem.Click
        Label4.Font = New Font("Comic Sans MS", 15,
                    FontStyle.Bold Or FontStyle.Underline)

    End Sub
End Class
