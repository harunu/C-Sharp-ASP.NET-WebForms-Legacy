<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HFWeb._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2>HAYATIMIZ FILM TEST VERSION</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MOVIEID" DataSourceID="dtsMovies">
            <Columns>
                <asp:TemplateField HeaderText="POSTERIMAGE" SortExpression="POSTERIMAGE">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("POSTERIMAGE") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="190px" 
                            ImageUrl='<%# Eval("POSTERIMAGE", "poster/{0}") %>' Width="128px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="MOVIEID" 
                    DataNavigateUrlFormatString="product.aspx?movieid={0}" DataTextField="NAME" />
                <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                <asp:BoundField DataField="TYPE" HeaderText="TYPE" SortExpression="TYPE" />
                <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" 
                    SortExpression="DESCRIPTION" />
                <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dtsMovies" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HAYATIMIZFILMConnectionString %>" 
            SelectCommand="SELECT * FROM [TBMOVIES] WHERE (([CATID] = @CATID OR @CATID=0) AND ([NAME] LIKE '%' + @NAME + '%' OR @NAME='0'))">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="CATID" 
                    QueryStringField="catid" Type="Int32" />
                <asp:QueryStringParameter DefaultValue="0" Name="NAME" 
                    QueryStringField="search" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>


</asp:Content>
