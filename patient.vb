Imports System.Data.SqlClient
Module patient
    Structure d_patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
    End Structure
    Dim chaineconnexion As String = "Data Source=DESKTOP-N0R06JD\SQLEXPRESS;Initial Catalog=HOPITAL;Integrated Security=True"
    Public Sub ajoutpatient(l As d_patient)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "INSERT INTO  PPATIENT (CODE , NOM , PRENOM) VALUES (@CODE , @NOM , @PRENOM);"
            Using cmd As New SqlCommand(requete, con)
                cmd.Parameters.AddWithValue("@CODE", l.code)
                cmd.Parameters.AddWithValue("@NOM", l.nom)
                cmd.Parameters.AddWithValue("@PRENOM", l.prenom)
                cmd.ExecuteNonQuery()
                MsgBox("ajouter avec succes")
            End Using
        End Using
    End Sub
    Public Sub Affpatient(dgv As DataGridView)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "SELECT * FROM PPATIENT"
            Dim cmd As New SqlCommand(requete, con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Function CODE() As Integer
        Dim l As Integer = 0
        Dim c As Integer = 0
        Using conn As New SqlConnection(chaineconnexion)
            conn.Open()
            Dim requete As String = "SELECT COUNT(*) FROM PPATIENT;"
            Using cmd As New SqlCommand(requete, conn)
                l = Convert.ToInt16(cmd.ExecuteScalar())
            End Using
            c = l + 1
        End Using
        Return c
    End Function

    Public Sub supppatient(code As Integer)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim req As String = "DELETE FROM PPATIENT WHERE CODE = @code;"
            Using cmd As New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("CODE", code)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        suppprdv(code)
    End Sub
    Public Sub AffRT(dgv As DataGridView, nom As String)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "SELECT * FROM RESULTAT WHERE NOM = @nom"
            Dim cmd As New SqlCommand(requete, con)
            cmd.Parameters.AddWithValue("@nom", nom)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub majrt()
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim req As String = "DELETE FROM resultat;"
            Using cmd As New SqlCommand(req, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ajoutRT()
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "INSERT INTO resultat (code, nom, prenom, date, heure) SELECT p.code AS code, p.nom AS nom, p.prenom AS prenom, FORMAT(r.date, 'yyyy-MM-dd') AS date, r.heure AS heure FROM  PPATIENT p LEFT JOIN RRDV r ON p.code = r.code;"
            Dim cmd As New SqlCommand(requete, con)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub AffTtRT(dgv As DataGridView)
        Using con As New SqlConnection(chaineconnexion)
            con.Open()
            Dim requete As String = "SELECT * FROM RESULTAT;"
            Dim cmd As New SqlCommand(requete, con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
End Module