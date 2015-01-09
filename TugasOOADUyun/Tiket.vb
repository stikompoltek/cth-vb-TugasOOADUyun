Public Class Tiket
    Private strIDStudio As String
    Private strIDKursi As String

    Public Property IDStudio() As String
        Get
            Return strIDStudio
        End Get
        Set(ByVal value As String)
            strIDStudio = value
        End Set
    End Property

    Public Property IDKursi() As String
        Get
            Return strIDKursi
        End Get
        Set(ByVal value As String)
            strIDKursi = value
        End Set
    End Property

End Class
