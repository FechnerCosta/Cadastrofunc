<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadastrarFunc.aspx.cs" Inherits="WEB.WebForm2" %>

<asp:Content ID="oi" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <div>


    </div>
    <div>
        <table>

        <tr>
            <td style="width: 649px; height: 37px">

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nome</td>
            <td style="width: 649px; height: 37px">
                    
                <asp:TextBox ID="txtNome" runat="server" Height="27px" Width="495px" ></asp:TextBox>
                    
            </td>

        </tr>
        <tr>
            <td style="width: 649px; height: 39px">

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;CPF</td>
            <td style="width: 649px; height: 37px">
                    
                <asp:TextBox ID="txtCPF" runat="server" Height="27px" Width="495px" ></asp:TextBox>
                    
            </td>
        </tr>
         <tr>
            <td style="width: 649px; height: 39px">

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cargo</td>
             <td style="width: 649px; height: 37px">
                    
                 <asp:TextBox ID="txtCargo" runat="server" Height="27px" Width="495px" ></asp:TextBox>
                    
            </td>
        </tr>
         <tr>
            <td style="width: 649px; height: 39px">

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Salario</td>
             <td style="width: 649px; height: 37px">
                    
                 <asp:TextBox ID="txtsalario" runat="server" Height="27px" Width="495px" ></asp:TextBox>
                    
            </td>
        </tr>
         <tr>
            <td style="width: 649px; height: 39px">

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Data Admissao</td>
             <td style="width: 649px; height: 37px">
                    
                 <asp:TextBox ID="txtdtadmin" runat="server" Height="27px" Width="495px" ></asp:TextBox>
                    
            </td>
        </tr>
    </table>
        <p>
            &nbsp;</div>


</body>
</html>
        <tr>
            <td>
       <asp:Button ID="Button1" runat="server" Text="Cadastrar" Width="139px" OnClick="btn_enviar" Height="36px" />
            </td>
            <td>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp <asp:button runat="server" text="Home" Height="36px" Width="169px" OnClick="btn_home" />
            </td>

        </tr>
    </form>

</asp:Content>

