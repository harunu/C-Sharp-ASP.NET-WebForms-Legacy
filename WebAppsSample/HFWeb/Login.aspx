<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HFWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Kullanıcı Girişi</p>
<table class="style1">
    <tr>
        <td>
            E-
            Adresi</td>
        <td>
            <asp:TextBox ID="txtEposta" runat="server">harun@hotmail.com</asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Parola</td>
        <td>
            <asp:TextBox ID="txtParola" runat="server" TextMode="Password">1</asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="btnGiris" runat="server" onclick="btnGiris_Click" Text="Giriş" 
                Width="77px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:SqlDataSource ID="dtsGiris" runat="server" 
                ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>" 
                SelectCommand="SPGiris" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtEposta" Name="EPOSTA" PropertyName="Text" 
                        Type="String" />
                    <asp:ControlParameter ControlID="txtParola" Name="PAROLA" PropertyName="Text" 
                        Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
        <td>
            <asp:Label ID="lblMesaj" runat="server" Text="Kullanıcı adı veya Parola Hatalı" 
                ViewStateMode="Enabled" Visible="False"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
