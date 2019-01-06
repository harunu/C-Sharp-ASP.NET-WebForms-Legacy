<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewcart.aspx.cs" Inherits="HFWeb.viewcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 222px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 style="font-size:20px;background-color:LightSkyBlue">Alışveriş Sepeti</h1>
    <asp:GridView ID="grdSepet" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="CARTID" DataSourceID="dtsSepet" 
        ForeColor="#333333" GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField SortExpression="POSTERIMAGE">
               
                <ItemTemplate>
                     <asp:Image ID="Image1" runat="server" Height="100px" 
                            ImageUrl='<%# Eval("POSTERIMAGE", "poster/{0}") %>' Width="60px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="NAME" HeaderText="Film" SortExpression="NAME" />
            <asp:BoundField DataField="QUANTITY" HeaderText="Adet" 
                SortExpression="QUANTITY" />
            <asp:BoundField DataField="PRICE" HeaderText="Fiyat" SortExpression="PRICE" />
            <asp:BoundField DataField="TOTAL" HeaderText="Toplam" />
            <asp:CommandField ButtonType="Button" DeleteText="Sepetten Çıkar" 
                ShowDeleteButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <asp:SqlDataSource ID="dtsSepet" runat="server" 
        ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>" 
        DeleteCommand="DELETE FROM [TBCART] WHERE [CARTID] = @CARTID" 
        InsertCommand="INSERT INTO [TBCART] ([CUSTID], [MOVIEID], [ORDERID], [QUANTITY], [PRICE]) VALUES (@CUSTID, @MOVIEID, @ORDERID, @QUANTITY, @PRICE)" 
        SelectCommand="SELECT TBCART.CARTID, TBCART.CUSTID, TBCART.MOVIEID, TBCART.ORDERID, TBCART.QUANTITY, TBCART.PRICE, TBCART.QUANTITY * TBCART.PRICE AS TOTAL, TBMOVIES.NAME, TBMOVIES.POSTERIMAGE FROM TBCART INNER JOIN TBMOVIES ON TBCART.MOVIEID = TBMOVIES.MOVIEID WHERE (TBCART.ORDERID = 0) AND (TBCART.CUSTID = @CUSTID)" 
        UpdateCommand="UPDATE [TBCART] SET [CUSTID] = @CUSTID, [MOVIEID] = @MOVIEID, [ORDERID] = @ORDERID, [QUANTITY] = @QUANTITY, [PRICE] = @PRICE WHERE [CARTID] = @CARTID">
        <DeleteParameters>
            <asp:Parameter Name="CARTID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CUSTID" Type="Int32" />
            <asp:Parameter Name="MOVIEID" Type="Int32" />
            <asp:Parameter Name="ORDERID" Type="Int32" />
            <asp:Parameter Name="QUANTITY" Type="Int32" />
            <asp:Parameter Name="PRICE" Type="Decimal" />
        </InsertParameters>
        <SelectParameters>
            <asp:SessionParameter DefaultValue="0" Name="CUSTID" SessionField="custid" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="CUSTID" Type="Int32" />
            <asp:Parameter Name="MOVIEID" Type="Int32" />
            <asp:Parameter Name="ORDERID" Type="Int32" />
            <asp:Parameter Name="QUANTITY" Type="Int32" />
            <asp:Parameter Name="PRICE" Type="Decimal" />
            <asp:Parameter Name="CARTID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <br />
    <table class="style1">
        <tr>
            <td bgcolor="#99CCFF" class="style2" colspan="3">
                Sipariş Formu</td>
        </tr>
        <tr>
            <td class="style2">
                Gönderilecek Adres</td>
            <td class="style3">
                <asp:TextBox ID="txtAdres" runat="server" Height="75px" TextMode="MultiLine" 
                    Width="218px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtAdres" ErrorMessage="Adres giriniz"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Notlar</td>
            <td class="style3">
                <asp:TextBox ID="txtNotlar" runat="server" Height="75px" TextMode="MultiLine" 
                    Width="218px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnSiparisVer" runat="server" onclick="btnSiparisVer_Click" 
                    Text="Sipariş Ver" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                <asp:Label ID="lblMesaj" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
