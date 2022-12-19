<WebMethod(Description:="Web método para cadastro de clientes.")> _

    Public Function IncluirCliente(ByVal nome As String, ByVal endereco As String, _

                                   ByVal ddd As String, ByVal telefone As String, _

                                   ByVal email As String) As Data.DataSet

        Dim resultado As Data.DataSet = New Data.DataSet()

 

        Try

            If (Not nome.Equals("")) Then

                If (Not endereco.Equals("")) Then

                    If (Not email.Equals("")) Then

                        Dim cliente As New ProgramacaoOnline.Models.Cliente()

 

                        With cliente

                            .sNomeCliente = nome

                            .sEndereco = endereco

                            .sDDD = ddd

                            .sTelefone = telefone

                            .sEmail = email

                        End With

 

                        resultado.Tables.Add( _

                            New ProgramacaoOnline.Persistence.ClienteDataModel().IncluirCliente(cliente))

                    Else

                        resultado.Tables.Add( _

                            ProgramacaoOnline.Utils.Convert.ToDataTable(1, "Informe o email do cliente."))

                    End If

                Else

                    resultado.Tables.Add( _

                        ProgramacaoOnline.Utils.Convert.ToDataTable(1, "Informe o endereço do cliente."))

                End If

            Else

                resultado.Tables.Add( _

                    ProgramacaoOnline.Utils.Convert.ToDataTable(1, "Informe o nome do cliente."))

            End If

 

            Return resultado

 

        Catch ex As Exception

            resultado.Tables.Add( _

                ProgramacaoOnline.Utils.Convert.ToDataTable(1, ex.Message.ToString()))

        End Try

 

    End Function
