<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="members.aspx.cs" Inherits="HFWeb.members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 173px;
        }
        .style3
        {
            width: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>
        Üye Kaydı</h3>
    <p>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="CUSTID" 
            DataSourceID="dtsUyeKayit" DefaultMode="Insert">
            
            <InsertItemTemplate>
                <table class="style1">
                    <tr>
                        <td class="style3">
                            Adınız</td>
                        <td class="style2">
                            <asp:TextBox ID="NAMETextBox" runat="server" Text='<%# Bind("NAME") %>' />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ErrorMessage="Bu Alan boş bırakılamaz" ControlToValidate="NAMETextBox"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Soyadınız</td>
                        <td class="style2">
                            <asp:TextBox ID="SURNAMETextBox" runat="server" Text='<%# Bind("SURNAME") %>' />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ErrorMessage="Bu Alan boş bırakılamaz" ControlToValidate="SURNAMETextBox"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            E-posta</td>
                        <td class="style2">
                            <asp:TextBox ID="EMAILTextBox" runat="server" Text='<%# Bind("EMAIL") %>' />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Parola</td>
                        <td class="style2">
                            <asp:TextBox ID="PASSWORDTextBox" runat="server" 
                                Text='<%# Bind("PASSWORD") %>' />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ErrorMessage="Bu Alan boş bırakılamaz" ControlToValidate="PASSWORDTextBox"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Parola Tekrar</td>
                        <td class="style2">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ErrorMessage="Parolanız uyuşmuyor" ControlToCompare="TextBox1" 
                                ControlToValidate="PASSWORDTextBox"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Telefon</td>
                        <td class="style2">
                            <asp:TextBox ID="PHONETextBox" runat="server" Text='<%# Bind("PHONE") %>' />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <!--<tr>
                        <td class="style3">
                            Resimi Girin</td>
                        <td class="style2">
                            <img src="GIOAPPgetimage.aspx" />
                            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
                            </td>
                        <td>
                            &nbsp;</td>
                    </tr>-->
                </table>
                <br />
                <asp:Button ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Kaydet" />
              
            </InsertItemTemplate>
           
        </asp:FormView>
        <asp:SqlDataSource ID="dtsUyeKayit" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>" 
            DeleteCommand="DELETE FROM [TBCUSTOMER] WHERE [CUSTID] = @CUSTID" 
            InsertCommand="INSERT INTO [TBCUSTOMER] ([NAME], [SURNAME], [EMAIL], [PASSWORD], [PHONE]) VALUES (@NAME, @SURNAME, @EMAIL, @PASSWORD, @PHONE)" 
            SelectCommand="SELECT * FROM [TBCUSTOMER]" 
            UpdateCommand="UPDATE [TBCUSTOMER] SET [NAME] = @NAME, [SURNAME] = @SURNAME, [EMAIL] = @EMAIL, [PASSWORD] = @PASSWORD, [PHONE] = @PHONE WHERE [CUSTID] = @CUSTID">
            <DeleteParameters>
                <asp:Parameter Name="CUSTID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="NAME" Type="String" />
                <asp:Parameter Name="SURNAME" Type="String" />
                <asp:Parameter Name="EMAIL" Type="String" />
                <asp:Parameter Name="PASSWORD" Type="String" />
                <asp:Parameter Name="PHONE" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="NAME" Type="String" />
                <asp:Parameter Name="SURNAME" Type="String" />
                <asp:Parameter Name="EMAIL" Type="String" />
                <asp:Parameter Name="PASSWORD" Type="String" />
                <asp:Parameter Name="PHONE" Type="String" />
                <asp:Parameter Name="CUSTID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
<p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="login.aspx">Ben Zaten Üyeyim. Giriş Yapmak İstiyorum.</asp:HyperLink>
    </p>

</asp:Content>
