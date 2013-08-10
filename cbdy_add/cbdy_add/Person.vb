Public Class Person

    Private _id As Integer
    Private _forename As String
    Private _surname As String
    Private _birthYear As String
    Private _deathYear As Integer
    Private _description As String
    Private _birthMonth As Integer
    Private _birthDay As Integer
    Private _imagename As String
    Private _imagetype As String
    Private _ShortDesc As String
    Private _sortSeq As Integer
    Private _unsavedChanges As Boolean

    Public Property unsavedChanges() As Boolean
        Get
            Return _unsavedChanges
        End Get
        Set(ByVal value As Boolean)
            _unsavedChanges = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Sortseq() As Integer
        Get
            Return _sortSeq
        End Get
        Set(ByVal value As Integer)
            _sortSeq = value
        End Set
    End Property

    Public Property ShortDesc() As String
        Get
            Return _ShortDesc
        End Get
        Set(ByVal value As String)
            _ShortDesc = value
        End Set
    End Property


    Public Property ImageType() As String
        Get
            Return _imagetype
        End Get
        Set(ByVal value As String)
            _imagetype = value
        End Set
    End Property

    Public Property ImageName() As String
        Get
            Return _imagename
        End Get
        Set(ByVal value As String)
            _imagename = value
        End Set
    End Property



    Public Property BirthDay() As Integer
        Get
            Return _birthDay
        End Get
        Set(ByVal value As Integer)
            _birthDay = value
        End Set
    End Property

    Public Property BirthMonth() As Integer
        Get
            Return _birthMonth
        End Get
        Set(ByVal value As Integer)
            _birthMonth = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Property DeathYear() As Integer
        Get
            Return _deathYear
        End Get
        Set(ByVal value As Integer)
            _deathYear = value
        End Set
    End Property

    Public Property BirthYear() As String
        Get
            Return _birthYear
        End Get
        Set(ByVal value As String)
            _birthYear = value
        End Set
    End Property
    Public Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = value
        End Set
    End Property


    Public Property ForeName() As String
        Get
            Return _forename
        End Get
        Set(ByVal value As String)
            _forename = value
        End Set
    End Property
    Public Sub New()
        _id = -1
        _forename = ""
        _surname = ""
        _ShortDesc = ""
        _sortSeq = 0
        _description = ""
        _birthDay = 0
        _birthMonth = 0
        _birthYear = ""
        _deathYear = 0
        _imagename = ""
        _imagetype = ""
        _unsavedChanges = False
    End Sub

    Public Sub New(ByVal pForename As String, ByVal pSurname As String, ByVal pDesc As String, ByVal pShortDesc As String, ByVal pDay As Integer, ByVal pMonth As Integer, ByVal pYear As String, ByVal pDeathYr As Integer, ByVal pImgName As String, ByVal pImgType As String)
        _id = -1
        _forename = pForename
        _surname = pSurname
        _ShortDesc = pShortDesc
        _sortSeq = 0
        _surname = pSurname
        _description = pDesc
        _birthDay = pDay
        _birthMonth = pMonth
        _birthYear = pYear
        _deathYear = pDeathYr
        _imagename = pImgName
        _imagetype = pImgType
        _unsavedChanges = False
    End Sub
    Public Sub New(ByVal pPerson As Person)
        _id = pPerson.Id
        _forename = pPerson.ForeName
        _surname = pPerson.Surname
        _ShortDesc = pPerson.ShortDesc
        _sortSeq = pPerson.Sortseq
        _description = pPerson.Description
        _birthDay = pPerson.BirthDay
        _birthMonth = pPerson.BirthMonth
        _birthYear = pPerson.BirthYear
        _deathYear = pPerson.DeathYear
        _imagename = pPerson.ImageName
        _imagetype = pPerson.ImageType
        _unsavedChanges = False
    End Sub
    Public ReadOnly Property iBirthYear() As Integer
        Get
            Dim iYr As Integer = 0
            Dim isBC As Boolean = _birthYear.ToLower.IndexOf("bc") >= 0
            Try
                iYr = Integer.Parse(_birthYear.ToLower.Replace("bc", "").Trim)
                If isBC Then
                    iYr = iYr * -1
                End If
            Catch ex As Exception
            End Try

            Return iYr
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return _forename & " " & _surname
        End Get
    End Property
End Class
