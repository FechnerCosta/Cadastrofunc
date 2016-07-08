<%@ Page Language="C#"  MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WEB.WebForm1" %>

<asp:Content ID="oi" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




<!DOCTYPE html>

<html>
<head>
<style>
#header {
    background-color:orange;
    color:black;
    text-align:center;
    padding:5px;
}
#nav {
    line-height:30px;
    background-color:#eeeeee;
    height:490px;
    width:150px;
    float:left;
    padding:5px;


}
#section {
    width:1316px;
    text-align:center;
    padding:10px;
    height: 481px;
    
        
    }
#footer {
    background-color:orange;
    color:black;
    clear:both;
    text-align:center;
    padding:5px;
    }
</style>
</head>
<body>

<div id="header">
<h1>bem vindo ! </h1>
</div>

<div id="nav">
    <p>
<a href="http://localhost:49937/CadastrarFunc.aspx" target="_top">Cadastrar funcionario</a><br><p>
 <a href="http://localhost:49937/listafuncionario.aspx" target="_top">Listar funcionarios</a><br>

</div>
    
<div id="section">
        <h2>Cadastrar funcionario</h2>
<p>
    Para Cadastrar um funcionario, clique no link "Cadastrar funcionario"
<p>
    Para Vizualizar os funcionarios cadastrados, clique no link "Listar funcionarios"

</div>

<div id="footer">
Copyright @Fechner Costa
</div>
    
</html>







</asp:Content>
