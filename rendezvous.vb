Imports System.Data.SqlClient
Module rendezvous
    Structure d_rdv
        Dim code As Integer
        Dim datee As Date
        Dim heure As Date
    End Structure


    Dim chaineconnexion As String = "Data Source=DESKTOP-N0R06JD\SQLEXPRESS;Initial Catalog=HOPITAL;Integrated Security=True"

    Public Sub ajoutRDV(r As d_rdv)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "INSERT INTO RRDV (CODE , DATE , HEURE) VALUES (@CODE , @DATE , @HEURE);"
            Using cmd As New SqlCommand(requete, con)
                cmd.Parameters.AddWithValue("@CODE", r.code)
                cmd.Parameters.AddWithValue("@DATE", r.datee)
                cmd.Parameters.AddWithValue("@HEURE", r.heure)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Affrdv(dgv As DataGridView)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "SELECT * FROM RRDV"
            Dim cmd As New SqlCommand(requete, con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub suppprdv(code As Integer)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim req As String = "DELETE FROM RRDV WHERE CODE = @code;"
            Using cmd As New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("CODE", code)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
