<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guid.aspx.cs" Inherits="GUID.guid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function SayiKontrol(e) {
            olay = document.all ? window.event : e;
            tus = document.all ? olay.keyCode : olay.which;
            if (tus < 48 || tus > 57) {
                if (document.all) { olay.returnValue = false; } else { olay.preventDefault(); }
            }
        }



        
function Blank_TextField_Validator()
{
 
    if (document.getElementById('TextBox1').value == "" || document.getElementById('TextBox2').value == "")
{
 
   alert("Lütfen rakam giriniz!");


   return (false);
}

return (true);
}



        
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>

        Static GUID
        <asp:Label ID="Label1" runat="server" Text="Label">        </asp:Label>

        <br />
        Dynamic GUID

        <br />


        Rakam giriniz!
        <br />
        <asp:TextBox ID="TextBox1" runat="server" onkeypress="SayiKontrol(event)" ></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" onkeypress ="SayiKontrol(event)"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" onclientClick="Blank_TextField_Validator()"/>
        <br />
        <br />
      
     

       <asp:Label ID="Label2" runat="server" Text="">
       </asp:Label>


    </div>
    </form>
</body>
</html>
