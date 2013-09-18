<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instituicao.aspx.cs" Inherits="comunidadeViva.instituicao.instituicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">

    <title>Instituições</title>

    <script src="../Scripts/jquery-1.7.1.js"></script>
    <script src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <script src="../Scripts/jZipCode_1.1.js"></script>
    <link href="../css/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="../css/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../css/bootstrap/js/bootstrap.min.js"></script>


    <script type="text/javascript">

        /*        $(document).ready(function () {
                    $('#tbxCep').jZipCode({
                        streetTarget: '#tbxLogradouro',
                        districtTarget: '#tbxBairro',
                        cityTarget: '#tbxCidade',
                        stateTarget: '#tbxEstado',
                        multipleReturns: '#returns',
                        keyUpDelay: 1500,
                        showMap: 'map'
                    });
                });
        */
    </script>


</head>
<body>

    <form id="form_Instituicao" runat="server" action="#" method="post" class="form-horizontal">
        <p>
            <asp:Label ID="lblRetorno" runat="server" Text=""></asp:Label>
        </p>

        <div>

            <table align="center">
                <tr>
                    <th colspan="2" style="background-color: #202F56; color: white; height: 30px;">Dados da Instituição
                    </th>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: left">Identificador:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxIdInstituicao" runat="server" class="span1" ReadOnly="true" ToolTip="Identificador automático"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left">Cnpj:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="txtCnpj" Text="" runat="server" class="span2"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: left">Instituição:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="txbInstituicao" Text="" runat="server" class="span6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left">Nome Fantasia:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="txtFantasia" Text="" runat="server" class="span6"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: left">Descrição:</td>
                    <td style="text-align: left">
                        <textarea id="txbDescricao" style="width: 445px;" rows="5" runat="server"></textarea>
                    </td>
                </tr>

                <!--tr>
                    <td>
                        <h3>Endereço</h3>
                    </td>
                    <td></td>
                    <td rowspan="7">
                        <div id="returns"></div>
                        <div id="map" style="width: 300px; height: 300px;"></div>
                    </td>
                </tr-->
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                <tr>
                    <th colspan="2" style="background-color: #202F56; color: white; height: 30px;">Endereço
                    </th>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                <tr>
                    <td style="text-align: left">Cep:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxCep" Text="" runat="server" class="span2"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: left">Logradouro:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxLogradouro" Text="" runat="server" class="span4"></asp:TextBox>
                        &nbsp;Nº&nbsp;<asp:TextBox ID="tbxNumero" runat="server" class="span1"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: left">Complemento:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbcComplemento" runat="server" class="span2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left">Bairro:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxBairro" Text="" runat="server" class="span4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left">Cidade:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxCidade" Text="" runat="server" class="span4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left">Estado:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxEstado" Text="" runat="server" class="span4"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: left">Referência:</td>
                    <td style="text-align: left">
                        <textarea id="tbxReferencia" style="width: 445px;" rows="5" runat="server"></textarea></td>
                </tr>

                <tr>
                    <td style="text-align: left">Link Mapa:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="LinkMapa" Text="" runat="server" Width="80%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <th colspan="2" style="background-color: #202F56; color: white; height: 30px;">Contato Principal
                    </th>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td style="text-align: left">Nome:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxNome" Text="" runat="server" class="span5"></asp:TextBox></td>
                </tr>

                <tr>
                    <td style="text-align: left">Telefone:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxTelefone" Text="" runat="server" class="span2"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: left">Celular:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxCelular" Text="" runat="server" class="span2"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: left">Email:</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="tbxEmail" Text="" runat="server" class="span4"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                
                <tr>
                    <td colspan="2">
                        <hr style="height:2px; background-color:#202F56;">
                    </td>
                </tr>
                    <td colspan="2" align="center">

                        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="100px" OnClick="AlterarInstituicao" />
                        <asp:Button ID="btnCadastrar" runat="server" Text="Gravar" OnClick="CadastrarInstituicao" Width="100px" />
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Width="100px" OnClick="btnVoltar_Click"/>

                    </td>



            </table>
        </div>

        <br />

        <br />
        <br />
    </form>

</body>
</html>







