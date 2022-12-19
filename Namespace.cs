Namespace ProgramacaoOnline.Models
    Partial Public Class Cliente
        Private _nCodCliente As Integer
        Private _sNomeCliente As String
        Private _sEndereco As String
        Private _sDDD As String
        Private _sTelefone As String
        Private _sEmail As String

        Public Property nCodCliente() As Integer
            Get
                Return _nCodCliente
            End Get

            Set(ByVal value As Integer)
                If (_nCodCliente <> value) Then
                    _nCodCliente = value
                End If
            End Set
        End Property

        Public Property sNomeCliente() As String
            Get
                Return _sNomeCliente
            End Get

            Set(ByVal value As String)
                If (_sNomeCliente <> value) Then
                    _sNomeCliente = value
                End If
            End Set
        End Property

        Public Property sEndereco() As String
            Get
                Return _sEndereco
            End Get

            Set(ByVal value As String)
                If (_sEndereco <> value) Then
                    _sEndereco = value
                End If
            End Set
        End Property

        Public Property sDDD() As String
            Get
                Return _sDDD
            End Get

            Set(ByVal value As String)
                If (_sDDD <> value) Then
                    _sDDD = value
                End If
            End Set
         End Property

        Public Property sTelefone() As String
            Get
                Return _sTelefone
            End Get

            Set(ByVal value As String)
                If (_sTelefone <> value) Then
                    _sTelefone = value
                End If
            End Set
        End Property

        Public Property sEmail() As String
            Get
                Return _sEmail
            End Get

            Set(ByVal value As String)
                If (_sEmail <> value) Then
                    _sEmail = value
                End If
            End Set
        End Property
     End Class
End Namespace
