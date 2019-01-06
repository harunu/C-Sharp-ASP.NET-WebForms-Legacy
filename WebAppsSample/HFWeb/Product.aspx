<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Product.aspx.cs" Inherits="HFWeb.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
    <script type="text/javascript">
        function RequestAdd2Cart(ProductId, Price) {
            PageMethods.Add2CartServer(ProductId, Price, Add2CartComplate);
        }

        function Add2CartComplate(sonuc) {
            if (sonuc == "mustlogin") {
                alert("Kullanıcı Girişi Yapmanız Gerekiyor");
                window.location = "/login.aspx";
            }
            else if (sonuc == "Ok") {
                $('#Basari').fadeIn(1000).delay(2000).fadeOut(1000);
                
            }
            else {
               alert(sonuc);

            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="frmMovie" runat="server" DataKeyNames="MOVIEID" DataSourceID="dtsMovies"
        Width="528px">
        <ItemTemplate>
            <table class="style1">
                <tr>
                    <td rowspan="2">
                        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl='<%# Eval("POSTERIMAGE", "poster/{0}") %>'
                            Width="128px" />
                    </td>
                    <td>
                        <asp:Label ID="NAMELabel" runat="server" Font-Size="20pt" Text='<%# Bind("NAME") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Kategori : </b>
                        <asp:HyperLink runat="server" ID="kat" NavigateUrl='<%# Eval("CATID", "default.aspx?catid={0}") %>'><%# Eval("CATEGORYNAME") %></asp:HyperLink>
                        &nbsp;&nbsp;&nbsp;&nbsp; |&nbsp; <b>Yıl : </b>
                        <asp:Label ID="YEARLabel" runat="server" Font-Size="16px" Text='<%# Bind("YEAR") %>' />
                        &nbsp;&nbsp;&nbsp; |<br />
                        <b>Tip : </b>
                        <asp:Label ID="TYPELabel" runat="server" Font-Size="16px" Text='<%# Bind("TYPE") %>' />
                        &nbsp;|&nbsp;&nbsp; <b>Fiyat: </b>
                        <asp:Label ID="PRICELabel" runat="server" Font-Size="16px" Text='<%# Bind("PRICE") %>' />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("DESCRIPTION") %>'></asp:Label>
                        <p>
                            <input id="btnSepet" type="button" value="Sepete Ekle" onclick='return RequestAdd2Cart(<%# Eval("MOVIEID")%>,<%# Eval("PRICE") %>);' />
                        </p>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
            <br />
        </ItemTemplate>
    </asp:FormView>


    <div class="SepeteEkleBasarili" id="Basari">
        Ürün başarı ile sepete eklendi.
    </div>

    <asp:SqlDataSource ID="dtsMovies" runat="server" ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>"
        SelectCommand="SELECT * FROM [SRGMOVIES] WHERE ([MOVIEID] = @MOVIEID)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="MOVIEID" QueryStringField="movieid"
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="dtsCart" runat="server" ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>"
        InsertCommand="PRCAdd2Cart" InsertCommandType="StoredProcedure" SelectCommand="PRCAdd2Cart"
        SelectCommandType="StoredProcedure">
        <InsertParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="CustID" Type="Int32" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="Price" Type="Decimal" />
        </InsertParameters>
        <SelectParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="CustID" Type="Int32" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="Price" Type="Decimal" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
